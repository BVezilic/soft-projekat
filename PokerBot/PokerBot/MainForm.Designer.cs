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
            this.gbPlayer = new System.Windows.Forms.GroupBox();
            this.btnPlayerFold = new System.Windows.Forms.Button();
            this.btnPlayerRaise = new System.Windows.Forms.Button();
            this.btnPlayerCall = new System.Windows.Forms.Button();
            this.tbPlayerHand = new System.Windows.Forms.TextBox();
            this.tbPlayerMoney = new System.Windows.Forms.TextBox();
            this.lblPlayerHandValue = new System.Windows.Forms.Label();
            this.lblPlayerHand = new System.Windows.Forms.Label();
            this.lblPlayerMoney = new System.Windows.Forms.Label();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.gbBot = new System.Windows.Forms.GroupBox();
            this.btnBotFold = new System.Windows.Forms.Button();
            this.btnBotRaise = new System.Windows.Forms.Button();
            this.btnBotCall = new System.Windows.Forms.Button();
            this.tbBotHandNum = new System.Windows.Forms.TextBox();
            this.tbBotMoney = new System.Windows.Forms.TextBox();
            this.lblBotHandValue = new System.Windows.Forms.Label();
            this.lblBotHand = new System.Windows.Forms.Label();
            this.lblBotMoney = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.gbMood = new System.Windows.Forms.GroupBox();
            this.pbMood = new System.Windows.Forms.PictureBox();
            this.tbBotHandSuite = new System.Windows.Forms.TextBox();
            this.checkHandBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.gbPlayer.SuspendLayout();
            this.gbOutput.SuspendLayout();
            this.gbBot.SuspendLayout();
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
            // gbPlayer
            // 
            this.gbPlayer.Controls.Add(this.btnPlayerFold);
            this.gbPlayer.Controls.Add(this.btnPlayerRaise);
            this.gbPlayer.Controls.Add(this.btnPlayerCall);
            this.gbPlayer.Controls.Add(this.tbPlayerHand);
            this.gbPlayer.Controls.Add(this.tbPlayerMoney);
            this.gbPlayer.Controls.Add(this.lblPlayerHandValue);
            this.gbPlayer.Controls.Add(this.lblPlayerHand);
            this.gbPlayer.Controls.Add(this.lblPlayerMoney);
            this.gbPlayer.Location = new System.Drawing.Point(13, 345);
            this.gbPlayer.Name = "gbPlayer";
            this.gbPlayer.Size = new System.Drawing.Size(374, 119);
            this.gbPlayer.TabIndex = 11;
            this.gbPlayer.TabStop = false;
            this.gbPlayer.Text = "Player";
            // 
            // btnPlayerFold
            // 
            this.btnPlayerFold.Location = new System.Drawing.Point(281, 16);
            this.btnPlayerFold.Name = "btnPlayerFold";
            this.btnPlayerFold.Size = new System.Drawing.Size(75, 23);
            this.btnPlayerFold.TabIndex = 10;
            this.btnPlayerFold.Text = "Fold";
            this.btnPlayerFold.UseVisualStyleBackColor = true;
            // 
            // btnPlayerRaise
            // 
            this.btnPlayerRaise.Location = new System.Drawing.Point(200, 16);
            this.btnPlayerRaise.Name = "btnPlayerRaise";
            this.btnPlayerRaise.Size = new System.Drawing.Size(75, 23);
            this.btnPlayerRaise.TabIndex = 9;
            this.btnPlayerRaise.Text = "Raise 20$";
            this.btnPlayerRaise.UseVisualStyleBackColor = true;
            // 
            // btnPlayerCall
            // 
            this.btnPlayerCall.Location = new System.Drawing.Point(119, 16);
            this.btnPlayerCall.Name = "btnPlayerCall";
            this.btnPlayerCall.Size = new System.Drawing.Size(75, 23);
            this.btnPlayerCall.TabIndex = 8;
            this.btnPlayerCall.Text = "Call";
            this.btnPlayerCall.UseVisualStyleBackColor = true;
            // 
            // tbPlayerHand
            // 
            this.tbPlayerHand.Location = new System.Drawing.Point(56, 47);
            this.tbPlayerHand.Name = "tbPlayerHand";
            this.tbPlayerHand.Size = new System.Drawing.Size(138, 20);
            this.tbPlayerHand.TabIndex = 7;
            // 
            // tbPlayerMoney
            // 
            this.tbPlayerMoney.Location = new System.Drawing.Point(56, 17);
            this.tbPlayerMoney.Name = "tbPlayerMoney";
            this.tbPlayerMoney.Size = new System.Drawing.Size(57, 20);
            this.tbPlayerMoney.TabIndex = 5;
            // 
            // lblPlayerHandValue
            // 
            this.lblPlayerHandValue.AutoSize = true;
            this.lblPlayerHandValue.Location = new System.Drawing.Point(200, 50);
            this.lblPlayerHandValue.Name = "lblPlayerHandValue";
            this.lblPlayerHandValue.Size = new System.Drawing.Size(47, 13);
            this.lblPlayerHandValue.TabIndex = 4;
            this.lblPlayerHandValue.Text = "One pair";
            // 
            // lblPlayerHand
            // 
            this.lblPlayerHand.AutoSize = true;
            this.lblPlayerHand.Location = new System.Drawing.Point(7, 50);
            this.lblPlayerHand.Name = "lblPlayerHand";
            this.lblPlayerHand.Size = new System.Drawing.Size(36, 13);
            this.lblPlayerHand.TabIndex = 1;
            this.lblPlayerHand.Text = "Hand:";
            // 
            // lblPlayerMoney
            // 
            this.lblPlayerMoney.AutoSize = true;
            this.lblPlayerMoney.Location = new System.Drawing.Point(7, 20);
            this.lblPlayerMoney.Name = "lblPlayerMoney";
            this.lblPlayerMoney.Size = new System.Drawing.Size(42, 13);
            this.lblPlayerMoney.TabIndex = 0;
            this.lblPlayerMoney.Text = "Money:";
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
            // gbBot
            // 
            this.gbBot.Controls.Add(this.checkHandBtn);
            this.gbBot.Controls.Add(this.btnBotFold);
            this.gbBot.Controls.Add(this.btnBotRaise);
            this.gbBot.Controls.Add(this.tbBotHandSuite);
            this.gbBot.Controls.Add(this.btnBotCall);
            this.gbBot.Controls.Add(this.tbBotHandNum);
            this.gbBot.Controls.Add(this.tbBotMoney);
            this.gbBot.Controls.Add(this.lblBotHandValue);
            this.gbBot.Controls.Add(this.lblBotHand);
            this.gbBot.Controls.Add(this.lblBotMoney);
            this.gbBot.Location = new System.Drawing.Point(397, 345);
            this.gbBot.Name = "gbBot";
            this.gbBot.Size = new System.Drawing.Size(375, 119);
            this.gbBot.TabIndex = 12;
            this.gbBot.TabStop = false;
            this.gbBot.Text = "Bot";
            // 
            // btnBotFold
            // 
            this.btnBotFold.Location = new System.Drawing.Point(288, 17);
            this.btnBotFold.Name = "btnBotFold";
            this.btnBotFold.Size = new System.Drawing.Size(75, 23);
            this.btnBotFold.TabIndex = 13;
            this.btnBotFold.Text = "Fold";
            this.btnBotFold.UseVisualStyleBackColor = true;
            // 
            // btnBotRaise
            // 
            this.btnBotRaise.Location = new System.Drawing.Point(207, 17);
            this.btnBotRaise.Name = "btnBotRaise";
            this.btnBotRaise.Size = new System.Drawing.Size(75, 23);
            this.btnBotRaise.TabIndex = 12;
            this.btnBotRaise.Text = "Raise 20$";
            this.btnBotRaise.UseVisualStyleBackColor = true;
            // 
            // btnBotCall
            // 
            this.btnBotCall.Location = new System.Drawing.Point(126, 17);
            this.btnBotCall.Name = "btnBotCall";
            this.btnBotCall.Size = new System.Drawing.Size(75, 23);
            this.btnBotCall.TabIndex = 11;
            this.btnBotCall.Text = "Call";
            this.btnBotCall.UseVisualStyleBackColor = true;
            // 
            // tbBotHandNum
            // 
            this.tbBotHandNum.Location = new System.Drawing.Point(66, 47);
            this.tbBotHandNum.Name = "tbBotHandNum";
            this.tbBotHandNum.Size = new System.Drawing.Size(135, 20);
            this.tbBotHandNum.TabIndex = 8;
            // 
            // tbBotMoney
            // 
            this.tbBotMoney.Location = new System.Drawing.Point(66, 19);
            this.tbBotMoney.Name = "tbBotMoney";
            this.tbBotMoney.Size = new System.Drawing.Size(54, 20);
            this.tbBotMoney.TabIndex = 6;
            // 
            // lblBotHandValue
            // 
            this.lblBotHandValue.AutoSize = true;
            this.lblBotHandValue.Location = new System.Drawing.Point(207, 50);
            this.lblBotHandValue.Name = "lblBotHandValue";
            this.lblBotHandValue.Size = new System.Drawing.Size(43, 13);
            this.lblBotHandValue.TabIndex = 5;
            this.lblBotHandValue.Text = "Straight";
            // 
            // lblBotHand
            // 
            this.lblBotHand.AutoSize = true;
            this.lblBotHand.Location = new System.Drawing.Point(18, 50);
            this.lblBotHand.Name = "lblBotHand";
            this.lblBotHand.Size = new System.Drawing.Size(36, 13);
            this.lblBotHand.TabIndex = 3;
            this.lblBotHand.Text = "Hand:";
            // 
            // lblBotMoney
            // 
            this.lblBotMoney.AutoSize = true;
            this.lblBotMoney.Location = new System.Drawing.Point(18, 20);
            this.lblBotMoney.Name = "lblBotMoney";
            this.lblBotMoney.Size = new System.Drawing.Size(42, 13);
            this.lblBotMoney.TabIndex = 2;
            this.lblBotMoney.Text = "Money:";
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
            // tbBotHandSuite
            // 
            this.tbBotHandSuite.Location = new System.Drawing.Point(66, 73);
            this.tbBotHandSuite.Name = "tbBotHandSuite";
            this.tbBotHandSuite.Size = new System.Drawing.Size(135, 20);
            this.tbBotHandSuite.TabIndex = 14;
            // 
            // checkHandBtn
            // 
            this.checkHandBtn.Location = new System.Drawing.Point(203, 73);
            this.checkHandBtn.Name = "checkHandBtn";
            this.checkHandBtn.Size = new System.Drawing.Size(93, 20);
            this.checkHandBtn.TabIndex = 15;
            this.checkHandBtn.Text = "CHECK";
            this.checkHandBtn.UseVisualStyleBackColor = true;
            this.checkHandBtn.Click += new System.EventHandler(this.checkHandBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gbMood);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbBot);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.gbPlayer);
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
            this.gbPlayer.ResumeLayout(false);
            this.gbPlayer.PerformLayout();
            this.gbOutput.ResumeLayout(false);
            this.gbBot.ResumeLayout(false);
            this.gbBot.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbPlayer;
        private System.Windows.Forms.Label lblPlayerHandValue;
        private System.Windows.Forms.Label lblPlayerHand;
        private System.Windows.Forms.Label lblPlayerMoney;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.GroupBox gbBot;
        private System.Windows.Forms.Label lblBotHandValue;
        private System.Windows.Forms.Label lblBotHand;
        private System.Windows.Forms.Label lblBotMoney;
        private System.Windows.Forms.Button btnPlayerFold;
        private System.Windows.Forms.Button btnPlayerRaise;
        private System.Windows.Forms.Button btnPlayerCall;
        private System.Windows.Forms.TextBox tbPlayerHand;
        private System.Windows.Forms.TextBox tbPlayerMoney;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnBotFold;
        private System.Windows.Forms.Button btnBotRaise;
        private System.Windows.Forms.Button btnBotCall;
        private System.Windows.Forms.TextBox tbBotHandNum;
        private System.Windows.Forms.TextBox tbBotMoney;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox gbMood;
        private System.Windows.Forms.PictureBox pbMood;
        private System.Windows.Forms.Button checkHandBtn;
        private System.Windows.Forms.TextBox tbBotHandSuite;
    }
}

