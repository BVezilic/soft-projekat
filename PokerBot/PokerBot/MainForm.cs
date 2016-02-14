using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;


namespace PokerBot
{
    public partial class MainForm : Form
    {
        private int pot = 0;
        private int aiBet = 0;
        private bool isFirstPhase = true;
        private Player player = new Player(20000, Mood.neutral);
        private PlayerController pc = new PlayerController();
        private Player oponent = new Player(20000, Mood.neutral);
        private FilterInfoCollection VideoCaptureDevices;
        private VideoCaptureDevice FinalVideo;
        
        public MainForm()
        {
            InitializeComponent();
        }

        #region Kamera
        private void MainForm_Load(object sender, EventArgs e)
        {
            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo VideoCaptureDevice in VideoCaptureDevices)
            {
                cbCameras.Items.Add(VideoCaptureDevice.Name);
            }

            FinalVideo = new VideoCaptureDevice();    
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                FinalVideo = new VideoCaptureDevice(VideoCaptureDevices[cbCameras.SelectedIndex].MonikerString);
                FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
                FinalVideo.Start();
                connectControls();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Izaberite kameru!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FinalVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap video = (Bitmap)eventArgs.Frame.Clone();
            pbCamera.Image = video;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FinalVideo.SignalToStop();
            FinalVideo.WaitForStop();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            pbPicture.Image = (Image)pbCamera.Image.Clone();
            pbPicture.Image.Save(@"..\..\OCR\hand.jpg", ImageFormat.Jpeg);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            FinalVideo.SignalToStop();
            disconnectControls();
            pbCamera.Image = null;
        }

        private void connectControls()
        {
            btnConnect.Enabled = false;
            cbCameras.Enabled = false;

            btnDisconnect.Enabled = true;
            btnCapture.Enabled = true;
        }

        private void disconnectControls()
        {
            btnConnect.Enabled = true;
            cbCameras.Enabled = true;

            btnDisconnect.Enabled = false;
            btnCapture.Enabled = false;
        }
        
        private void btnRecognize_Click(object sender, EventArgs e)
        {            
            String hand = System.IO.File.ReadAllText(@"..\..\OCR\hand.txt");
            tbHand.Tag = hand;

            String text = "";
            foreach (char c in hand)
            {
                if (c == 'S')
                    text += '\u2660';
                else if (c == 'H')
                    text += '\u2661';
                else if (c == 'D')
                    text += '\u2662';
                else if (c == 'C')
                    text += '\u2663';
                else
                    text += c;
            }
            tbHand.Text = text;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
            tbHand.Text = null;
        }
        #endregion

        private void checkHandBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hand hand = new Hand(tbNewHand.Text);
            Random rnd = new Random();

            player.Mood = (Mood)(int)(rnd.Next(0,3));

            pc = new PlayerController(hand, player);
            int forSwithc = hand.EvaluateHand();
            lHandVal.Text = forSwithc.ToString();

            forSwithc = forSwithc / 1000000;
            string handName = "";
            switch (forSwithc)
            {
                case 9:
                    handName = "Royal Flush";
                    break;
                case 8:
                    handName = "Straight Flush";
                    break;
                case 7:
                    handName = "Four Of A Kind";
                    break;
                case 6:
                    handName = "Full House";
                    break;
                case 5:
                    handName = "Flush";
                    break;
                case 4:
                    handName = "Straight";
                    break;
                case 3:
                    handName = "Three Of A Kind";
                    break;
                case 2:
                    handName = "Two Pairs";
                    break;
                case 1:
                    handName = "One Pair";
                    break;
                case 0:
                    handName = "High Card";
                    break;
            }

            lHandName.Text = handName;

            lHand.Text = hand.ToString();

            List<Card> change = new List<Card>();
            

            change = pc.TradeCards();

            handName = "";
            foreach (Card card in change)
            {
                handName += card.ToString() + " ";
            }

            lChangeCards.Text = handName;
            lAiMoney.Text = pc.Player.Money.ToString();
            lAiMaxBet.Text = pc.EvaluateMaxBet().ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btRes_Click(object sender, EventArgs e)
        {
            lAiMoney.Text = player.Money.ToString();
            lOpMoney.Text = oponent.Money.ToString();
            isFirstPhase = true;
            lPhase.Text = isFirstPhase.ToString();
            
        }

        private void btnRaise_Click(object sender, EventArgs e)
        {
            int opBet = this.aiBet + int.Parse(tbRaise.Text);

            oponent.Money -= opBet;
            pot += opBet;
            int aiBet = pc.makeBet(0, oponent.Money, opBet, isFirstPhase);

            if (aiBet == opBet)
            {
                lAiMove.Text = "Call";
                isFirstPhase = false;
                lPhase.Text = isFirstPhase.ToString();
                pot = aiBet;
                lPot.Text = pot.ToString();
                return;
            }
            if (aiBet == 0)
            {
                oponent.Money += pot;
                pot = 0;
                lAiMove.Text = "Fold";
                isFirstPhase = true;
                lPhase.Text = isFirstPhase.ToString();
                lAiMoney.Text = player.Money.ToString();
                lOpMoney.Text = oponent.Money.ToString();
                
                lPot.Text = pot.ToString();
                return;
            }
            pot += aiBet;
            lPot.Text = pot.ToString();
            lAiMove.Text = "Raise " + aiBet.ToString();
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            oponent.Money -= aiBet;
            pot += aiBet;
            isFirstPhase = false;
            lPhase.Text = isFirstPhase.ToString();
            lPot.Text = pot.ToString();
        }

        private void btnFold_Click(object sender, EventArgs e)
        {
            
            player.Money += pot;
            pot = 0;
            lPot.Text = pot.ToString();
            isFirstPhase = true;
            lPhase.Text = isFirstPhase.ToString();
            lAiMoney.Text = player.Money.ToString();
            lOpMoney.Text = oponent.Money.ToString();
        }

        private void lOpMoney_Click(object sender, EventArgs e)
        {

        }

        private void btnWin_Click(object sender, EventArgs e)
        {
            oponent.Money += pot;
            pot = 0;
            isFirstPhase = true;
            lPhase.Text = isFirstPhase.ToString();
            lAiMoney.Text = player.Money.ToString();
            lOpMoney.Text = oponent.Money.ToString();

            lPot.Text = pot.ToString();
        }
    }
}
//h,10 c,a c,4 d,3 s,5
//c,a s,4 d,9 d,4 s,3