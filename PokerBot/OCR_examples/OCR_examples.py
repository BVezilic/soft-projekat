# -*- coding: utf-8 -*-
"""
Created on Mon Feb 15 17:55:30 2016

@author: Branislav Vezilic
"""

#import potrebnih biblioteka
import cv2
import numpy as np

# keras
from keras.models import Sequential
from keras.layers.core import Dense,Activation,Dropout
from keras.optimizers import SGD

def load_image(path):
    return cv2.cvtColor(cv2.imread(path), cv2.COLOR_BGR2RGB)

def image_gray(image):
    return cv2.cvtColor(image, cv2.COLOR_RGB2GRAY)

def image_bin(image_gs):
    height, width = image_gs.shape[0:2]
    ret,image_bin = cv2.threshold(image_gs, 0, 255, cv2.THRESH_BINARY)
    return image_bin
    
def edge_detect(image):
    return cv2.Canny(image,100,200)
    
def resize_region(region):
    return cv2.resize(region,(28,28), interpolation = cv2.INTER_NEAREST)

def scale_to_range(image):
    return image/255

def matrix_to_vector(image):
    return image.flatten()

def prepare_for_ann(regions):
    ready_for_ann = []
    for region in regions:
        scale = scale_to_range(region)
        ready_for_ann.append(matrix_to_vector(scale))       
    return ready_for_ann
    
def create_ann_suit():
    model = Sequential()
    model.add(Dense(128, input_dim=784, init='glorot_uniform'))
    model.add(Activation('relu'))
    model.add(Dropout(0.5))
    model.add(Dense(128, init='glorot_uniform'))
    model.add(Activation('relu'))
    model.add(Dropout(0.5))
    model.add(Dense(4, init='glorot_uniform'))
    model.add(Activation('relu'))
    return model
    
def create_ann_value():
    model = Sequential()
    model.add(Dense(128, input_dim=784, init='glorot_uniform'))
    model.add(Activation('relu'))
    model.add(Dropout(0.5))
    model.add(Dense(128, init='glorot_uniform'))
    model.add(Activation('relu'))
    model.add(Dropout(0.5))
    model.add(Dense(13, init='glorot_uniform'))
    model.add(Activation('relu'))
    return model
    
def winner(output): # output je vektor sa izlaza neuronske mreze
    return max(enumerate(output), key=lambda x: x[1])[0]

def display_result(outputs, alphabet):
    result = []
    for output in outputs:
        result.append(alphabet[winner(output)])
    return result

def find_error(inputs):
    error = []
    for i in inputs:
        if sum(i) == 0:
            error.append(True)
        else:
            error.append(False)
    return error
    
def clear_file():
    file = open('hand.txt','w')
    file.write('')
    file.close()

def write_hand(result,error):
    hand = ''
    for j in range(0,len(result[0])):
        for i in range(0,len(result)):
            if error[i][j] == True:
                hand += '?'
            else:
                hand += result[i][j]
            if i == 0:
                hand += ','
        if j < len(result[0])-1:
            hand += ' '
        
    file = open('hand.txt','a')
    file.write(hand)
    file.write('\n\n')
    file.close()
    
def rectify(h):
    h = h.reshape((4,2))
    hnew = np.zeros((4,2),dtype = np.float32)

    add = h.sum(1)
    hnew[0] = h[np.argmin(add)]
    hnew[2] = h[np.argmax(add)]

    diff = np.diff(h,axis = 1)
    hnew[1] = h[np.argmin(diff)]
    hnew[3] = h[np.argmax(diff)]

    return hnew

def distance(cnt):
    x,y,w,h = cv2.boundingRect(cnt)
    return y*100 + x*10
  
def select_suit(card, size, cardtype):
    img, contour_borders, hierarchy = cv2.findContours(card.copy(), cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)
    contours = []
    for contour in contour_borders: 
        x,y,w,h = cv2.boundingRect(contour) #koordinate i velicina granicnog pravougaonika
        if size/6.4 > h > size/42.6 and size/6.4 > w > size/42.6 and x < size/3.2:
            region = card[y:y+h+1,x:x+w+1]
            contours.append(image_bin(resize_region(region)))
         
    if len(contours) < 2:
        #print 'NISAM USPEO DA NADJEM DVE KONTURE!'
        return np.zeros((28,28))
    
    return contours[cardtype]
    
def select_roi(image_orig, img_bin, cardtype, numcards=5):
    img, contour_borders, hierarchy = cv2.findContours(img_bin.copy(), cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)
    contours = []
    contour_borders = sorted(contour_borders, key=cv2.contourArea, reverse=True)[:numcards]
    contour_borders = sorted(contour_borders, key=distance, reverse=False)
    img = cv2.drawContours(image_orig, contour_borders, -1, (0,255,0), 2)
    
    for contour in contour_borders: 
        epsilon = 0.1*cv2.arcLength(contour,True)
        approx = cv2.approxPolyDP(contour,epsilon,True)
        if len(approx) != 4: # ukoliko nije 4, znaci da nije karta u pitanju
            continue
        card = rectify(approx)
        size = 640
        new = np.array([ [0,0],[size,0],[size,size],[0,size] ],np.float32)
        transform = cv2.getPerspectiveTransform(card,new)
        warp = cv2.warpPerspective(img_bin,transform,(size,size))
        suit = select_suit(warp,size,cardtype)
        contours.append(suit) 
        
    return img, contours
    
alphabet_suit = ['D','H','S','C']
alphabet_value = ['A','2','3','4','5','6','7','8','9','10','J','Q','K']
sgd = SGD(lr=0.01, decay=1e-6, momentum=0.9, nesterov=True)

ann_suit = create_ann_suit()
ann_suit.load_weights('suit_weights')
ann_suit.compile(loss='mean_squared_error', optimizer=sgd)

ann_value = create_ann_value()
ann_value.load_weights('value_weights')
ann_value.compile(loss='mean_squared_error', optimizer=sgd)

clear_file()
files = ['test1.jpg','test2.jpg','test3.jpg','test4.jpg',
'test5.jpg','test6.jpg','test8.jpg','test9.jpg', 'test11.jpg','test12.jpg']
for file in files:
    image_color = load_image('test/'+file)
    img = edge_detect(image_gray(image_color))  
  
    final_result = []  
    errors = []    
    
    image, values = select_roi(image_color, img, 1, 5)
    inputs = prepare_for_ann(values)
    errors.append(find_error(inputs))
    result = ann_value.predict(np.array(inputs, np.float32))
    final_result.append(display_result(result, alphabet_value))
    
    image, suits = select_roi(image_color, img, 0, 5)
    inputs = prepare_for_ann(suits)
    errors.append(find_error(inputs))
    result = ann_suit.predict(np.array(inputs, np.float32))
    final_result.append(display_result(result, alphabet_suit))


    write_hand(final_result, errors)
