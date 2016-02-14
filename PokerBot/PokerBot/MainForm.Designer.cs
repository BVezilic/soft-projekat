namespace PokerBot
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.cbCameras = new System.Windows.Forms.ComboBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnRecognize = new System.Windows.Forms.Button();
            this.tbHand = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDeal = new System.Windows.Forms.Button();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.gbMood = new System.Windows.Forms.GroupBox();
            this.pbMood = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lHand = new System.Windows.Forms.Label();
            this.tbNewHand = new System.Windows.Forms.TextBox();
            this.lHandVal = new System.Windows.Forms.Label();
            this.lHandName = new System.Windows.Forms.Label();
            this.lChangeCards = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lAiMoney = new System.Windows.Forms.Label();
            this.lAiMaxBet = new System.Windows.Forms.Label();
            this.btnRaise = new System.Windows.Forms.Button();
            this.tbRaise = new System.Windows.Forms.TextBox();
            this.lPot = new System.Windows.Forms.Label();
            this.btRes = new System.Windows.Forms.Button();
            this.btnCall = new System.Windows.Forms.Button();
            this.btnFold = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lOpMoney = new System.Windows.Forms.Label();
            this.lAiMove = new System.Windows.Forms.Label();
            this.lPhase = new System.Windows.Forms.Label();
            this.btnWin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.gbOutput.SuspendLayout();
            this.gbMood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMood)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCamera
            // 
            this.pbCamera.BackColor = System.Drawing.Color.Black;
            this.pbCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbCamera.Location = new System.Drawing.Point(12, 12);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(375, 250);
            this.pbCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCamera.TabIndex = 0;
            this.pbCamera.TabStop = false;
            // 
            // pbPicture
            // 
            this.pbPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPicture.BackColor = System.Drawing.Color.Black;
            this.pbPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPicture.Location = new System.Drawing.Point(397, 12);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(375, 250);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 1;
            this.pbPicture.TabStop = false;
            // 
            // cbCameras
            // 
            this.cbCameras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCameras.FormattingEnabled = true;
            this.cbCameras.Location = new System.Drawing.Point(12, 271);
            this.cbCameras.Name = "cbCameras";
            this.cbCameras.Size = new System.Drawing.Size(132, 28);
            this.cbCameras.TabIndex = 2;
            // 
            // btnCapture
            // 
            this.btnCapture.Enabled = false;
            this.btnCapture.Location = new System.Drawing.Point(312, 271);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(75, 28);
            this.btnCapture.TabIndex = 4;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(150, 271);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 28);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(231, 271);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 28);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnRecognize
            // 
            this.btnRecognize.Location = new System.Drawing.Point(548, 272);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(75, 28);
            this.btnRecognize.TabIndex = 7;
            this.btnRecognize.Text = "Recognize";
            this.btnRecognize.UseVisualStyleBackColor = true;
            this.btnRecognize.Click += new System.EventHandler(this.btnRecognize_Click);
            // 
            // tbHand
            // 
            this.tbHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHand.Location = new System.Drawing.Point(397, 272);
            this.tbHand.Name = "tbHand";
            this.tbHand.Size = new System.Drawing.Size(145, 26);
            this.tbHand.TabIndex = 8;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(699, 272);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(73, 27);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDeal
            // 
            this.btnDeal.Location = new System.Drawing.Point(13, 316);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(75, 23);
            this.btnDeal.TabIndex = 10;
            this.btnDeal.Text = "Deal cards";
            this.btnDeal.UseVisualStyleBackColor = true;
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.rtbOutput);
            this.gbOutput.Location = new System.Drawing.Point(13, 470);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(610, 82);
            this.gbOutput.TabIndex = 12;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOutput.Location = new System.Drawing.Point(3, 16);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(604, 63);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(629, 272);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(64, 27);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // gbMood
            // 
            this.gbMood.Controls.Add(this.pbMood);
            this.gbMood.Location = new System.Drawing.Point(629, 470);
            this.gbMood.Name = "gbMood";
            this.gbMood.Size = new System.Drawing.Size(143, 82);
            this.gbMood.TabIndex = 13;
            this.gbMood.TabStop = false;
            this.gbMood.Text = "Mood";
            // 
            // pbMood
            // 
            this.pbMood.BackColor = System.Drawing.Color.Black;
            this.pbMood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMood.Location = new System.Drawing.Point(3, 16);
            this.pbMood.Name = "pbMood";
            this.pbMood.Size = new System.Drawing.Size(137, 63);
            this.pbMood.TabIndex = 0;
            this.pbMood.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lHand
            // 
            this.lHand.AutoSize = true;
            this.lHand.Location = new System.Drawing.Point(203, 350);
            this.lHand.Name = "lHand";
            this.lHand.Size = new System.Drawing.Size(35, 13);
            this.lHand.TabIndex = 15;
            this.lHand.Text = "label1";
            // 
            // tbNewHand
            // 
            this.tbNewHand.Location = new System.Drawing.Point(97, 347);
            this.tbNewHand.Name = "tbNewHand";
            this.tbNewHand.Size = new System.Drawing.Size(100, 20);
            this.tbNewHand.TabIndex = 16;
            // 
            // lHandVal
            // 
            this.lHandVal.AutoSize = true;
            this.lHandVal.Location = new System.Drawing.Point(203, 381);
            this.lHandVal.Name = "lHandVal";
            this.lHandVal.Size = new System.Drawing.Size(35, 13);
            this.lHandVal.TabIndex = 17;
            this.lHandVal.Text = "label1";
            // 
            // lHandName
            // 
            this.lHandName.AutoSize = true;
            this.lHandName.Location = new System.Drawing.Point(203, 409);
            this.lHandName.Name = "lHandName";
            this.lHandName.Size = new System.Drawing.Size(35, 13);
            this.lHandName.TabIndex = 18;
            this.lHandName.Text = "label1";
            // 
            // lChangeCards
            // 
            this.lChangeCards.AutoSize = true;
            this.lChangeCards.Location = new System.Drawing.Point(203, 433);
            this.lChangeCards.Name = "lChangeCards";
            this.lChangeCards.Size = new System.Drawing.Size(35, 13);
            this.lChangeCards.TabIndex = 19;
            this.lChangeCards.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "bad",
            "neutral",
            "good"});
            this.comboBox1.Location = new System.Drawing.Point(16, 374);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lAiMoney
            // 
            this.lAiMoney.AutoSize = true;
            this.lAiMoney.Location = new System.Drawing.Point(13, 409);
            this.lAiMoney.Name = "lAiMoney";
            this.lAiMoney.Size = new System.Drawing.Size(35, 13);
            this.lAiMoney.TabIndex = 21;
            this.lAiMoney.Text = "label1";
            this.lAiMoney.Click += new System.EventHandler(this.label1_Click);
            // 
            // lAiMaxBet
            // 
            this.lAiMaxBet.AutoSize = true;
            this.lAiMaxBet.Location = new System.Drawing.Point(13, 433);
            this.lAiMaxBet.Name = "lAiMaxBet";
            this.lAiMaxBet.Size = new System.Drawing.Size(35, 13);
            this.lAiMaxBet.TabIndex = 22;
            this.lAiMaxBet.Text = "label1";
            // 
            // btnRaise
            // 
            this.btnRaise.Location = new System.Drawing.Point(312, 345);
            this.btnRaise.Name = "btnRaise";
            this.btnRaise.Size = new System.Drawing.Size(75, 23);
            this.btnRaise.TabIndex = 23;
            this.btnRaise.Text = "Raise";
            this.btnRaise.UseVisualStyleBackColor = true;
            this.btnRaise.Click += new System.EventHandler(this.btnRaise_Click);
            // 
            // tbRaise
            // 
            this.tbRaise.Location = new System.Drawing.Point(393, 347);
            this.tbRaise.Name = "tbRaise";
            this.tbRaise.Size = new System.Drawing.Size(100, 20);
            this.tbRaise.TabIndex = 24;
            // 
            // lPot
            // 
            this.lPot.AutoSize = true;
            this.lPot.Location = new System.Drawing.Point(499, 350);
            this.lPot.Name = "lPot";
            this.lPot.Size = new System.Drawing.Size(35, 13);
            this.lPot.TabIndex = 25;
            this.lPot.Text = "label1";
            this.lPot.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btRes
            // 
            this.btRes.Location = new System.Drawing.Point(312, 316);
            this.btRes.Name = "btRes";
            this.btRes.Size = new System.Drawing.Size(75, 23);
            this.btRes.TabIndex = 26;
            this.btRes.Text = "Reset";
            this.btRes.UseVisualStyleBackColor = true;
            this.btRes.Click += new System.EventHandler(this.btRes_Click);
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(312, 372);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(75, 23);
            this.btnCall.TabIndex = 27;
            this.btnCall.Text = "Call";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // btnFold
            // 
            this.btnFold.Location = new System.Drawing.Point(312, 399);
            this.btnFold.Name = "btnFold";
            this.btnFold.Size = new System.Drawing.Size(75, 23);
            this.btnFold.TabIndex = 28;
            this.btnFold.Text = "Fold";
            this.btnFold.UseVisualStyleBackColor = true;
            this.btnFold.Click += new System.EventHandler(this.btnFold_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "lAiMoney";
            // 
            // lOpMoney
            // 
            this.lOpMoney.AutoSize = true;
            this.lOpMoney.Location = new System.Drawing.Point(499, 321);
            this.lOpMoney.Name = "lOpMoney";
            this.lOpMoney.Size = new System.Drawing.Size(55, 13);
            this.lOpMoney.TabIndex = 31;
            this.lOpMoney.Text = "lOpMoney";
            this.lOpMoney.Click += new System.EventHandler(this.lOpMoney_Click);
            // 
            // lAiMove
            // 
            this.lAiMove.AutoSize = true;
            this.lAiMove.Location = new System.Drawing.Point(499, 409);
            this.lAiMove.Name = "lAiMove";
            this.lAiMove.Size = new System.Drawing.Size(35, 13);
            this.lAiMove.TabIndex = 32;
            this.lAiMove.Text = "label1";
            // 
            // lPhase
            // 
            this.lPhase.AutoSize = true;
            this.lPhase.Location = new System.Drawing.Point(499, 433);
            this.lPhase.Name = "lPhase";
            this.lPhase.Size = new System.Drawing.Size(35, 13);
            this.lPhase.TabIndex = 33;
            this.lPhase.Text = "label1";
            // 
            // btnWin
            // 
            this.btnWin.Location = new System.Drawing.Point(312, 428);
            this.btnWin.Name = "btnWin";
            this.btnWin.Size = new System.Drawing.Size(75, 23);
            this.btnWin.TabIndex = 34;
            this.btnWin.Text = "Win";
            this.btnWin.UseVisualStyleBackColor = true;
            this.btnWin.Click += new System.EventHandler(this.btnWin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnWin);
            this.Controls.Add(this.lPhase);
            this.Controls.Add(this.lAiMove);
            this.Controls.Add(this.lOpMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFold);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.btRes);
            this.Controls.Add(this.lPot);
            this.Controls.Add(this.tbRaise);
            this.Controls.Add(this.btnRaise);
            this.Controls.Add(this.lAiMaxBet);
            this.Controls.Add(this.lAiMoney);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lChangeCards);
            this.Controls.Add(this.lHandName);
            this.Controls.Add(this.lHandVal);
            this.Controls.Add(this.tbNewHand);
            this.Controls.Add(this.lHand);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbMood);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbHand);
            this.Controls.Add(this.btnRecognize);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.cbCameras);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.pbCamera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PokerBot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.gbOutput.ResumeLayout(false);
            this.gbMood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCamera;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.ComboBox cbCameras;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnRecognize;
        private System.Windows.Forms.TextBox tbHand;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox gbMood;
        private System.Windows.Forms.PictureBox pbMood;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lHand;
        private System.Windows.Forms.TextBox tbNewHand;
        private System.Windows.Forms.Label lHandVal;
        private System.Windows.Forms.Label lHandName;
        private System.Windows.Forms.Label lChangeCards;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lAiMoney;
        private System.Windows.Forms.Label lAiMaxBet;
        private System.Windows.Forms.Button btnRaise;
        private System.Windows.Forms.TextBox tbRaise;
        private System.Windows.Forms.Label lPot;
        private System.Windows.Forms.Button btRes;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.Button btnFold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lOpMoney;
        private System.Windows.Forms.Label lAiMove;
        private System.Windows.Forms.Label lPhase;
        private System.Windows.Forms.Button btnWin;
    }
}

