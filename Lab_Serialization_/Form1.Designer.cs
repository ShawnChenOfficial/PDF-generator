using System;

namespace Lab_Serialization_
{
    partial class CardsDealer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardsDealer));
            this.buttonDealCards = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button1stHand = new System.Windows.Forms.Button();
            this.button4thHand = new System.Windows.Forms.Button();
            this.button3rdHand = new System.Windows.Forms.Button();
            this.button2ndHand = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.labelNumOfHands = new System.Windows.Forms.Label();
            this.Save_PDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDealCards
            // 
            this.buttonDealCards.Location = new System.Drawing.Point(176, 348);
            this.buttonDealCards.Name = "buttonDealCards";
            this.buttonDealCards.Size = new System.Drawing.Size(75, 23);
            this.buttonDealCards.TabIndex = 0;
            this.buttonDealCards.Text = "Deal Cards";
            this.buttonDealCards.UseVisualStyleBackColor = true;
            this.buttonDealCards.Click += new System.EventHandler(this.buttonDealCards_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(365, 348);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "back-red-75-3.png");
            this.imageList.Images.SetKeyName(1, "clubs-a-75.png");
            this.imageList.Images.SetKeyName(2, "clubs-2-75.png");
            this.imageList.Images.SetKeyName(3, "clubs-3-75.png");
            this.imageList.Images.SetKeyName(4, "clubs-4-75.png");
            this.imageList.Images.SetKeyName(5, "clubs-5-75.png");
            this.imageList.Images.SetKeyName(6, "clubs-6-75.png");
            this.imageList.Images.SetKeyName(7, "clubs-7-75.png");
            this.imageList.Images.SetKeyName(8, "clubs-8-75.png");
            this.imageList.Images.SetKeyName(9, "clubs-9-75.png");
            this.imageList.Images.SetKeyName(10, "clubs-10-75.png");
            this.imageList.Images.SetKeyName(11, "clubs-j-75.png");
            this.imageList.Images.SetKeyName(12, "clubs-q-75.png");
            this.imageList.Images.SetKeyName(13, "clubs-k-75.png");
            this.imageList.Images.SetKeyName(14, "diamonds-a-75.png");
            this.imageList.Images.SetKeyName(15, "diamonds-2-75.png");
            this.imageList.Images.SetKeyName(16, "diamonds-3-75.png");
            this.imageList.Images.SetKeyName(17, "diamonds-4-75.png");
            this.imageList.Images.SetKeyName(18, "diamonds-5-75.png");
            this.imageList.Images.SetKeyName(19, "diamonds-6-75.png");
            this.imageList.Images.SetKeyName(20, "diamonds-7-75.png");
            this.imageList.Images.SetKeyName(21, "diamonds-8-75.png");
            this.imageList.Images.SetKeyName(22, "diamonds-9-75.png");
            this.imageList.Images.SetKeyName(23, "diamonds-10-75.png");
            this.imageList.Images.SetKeyName(24, "diamonds-j-75.png");
            this.imageList.Images.SetKeyName(25, "diamonds-q-75.png");
            this.imageList.Images.SetKeyName(26, "diamonds-k-75.png");
            this.imageList.Images.SetKeyName(27, "hearts-a-75.png");
            this.imageList.Images.SetKeyName(28, "hearts-2-75.png");
            this.imageList.Images.SetKeyName(29, "hearts-3-75.png");
            this.imageList.Images.SetKeyName(30, "hearts-4-75.png");
            this.imageList.Images.SetKeyName(31, "hearts-5-75.png");
            this.imageList.Images.SetKeyName(32, "hearts-6-75.png");
            this.imageList.Images.SetKeyName(33, "hearts-7-75.png");
            this.imageList.Images.SetKeyName(34, "hearts-8-75.png");
            this.imageList.Images.SetKeyName(35, "hearts-9-75.png");
            this.imageList.Images.SetKeyName(36, "hearts-10-75.png");
            this.imageList.Images.SetKeyName(37, "hearts-j-75.png");
            this.imageList.Images.SetKeyName(38, "hearts-q-75.png");
            this.imageList.Images.SetKeyName(39, "hearts-k-75.png");
            this.imageList.Images.SetKeyName(40, "spades-a-75.png");
            this.imageList.Images.SetKeyName(41, "spades-2-75.png");
            this.imageList.Images.SetKeyName(42, "spades-3-75.png");
            this.imageList.Images.SetKeyName(43, "spades-4-75.png");
            this.imageList.Images.SetKeyName(44, "spades-5-75.png");
            this.imageList.Images.SetKeyName(45, "spades-6-75.png");
            this.imageList.Images.SetKeyName(46, "spades-7-75.png");
            this.imageList.Images.SetKeyName(47, "spades-8-75.png");
            this.imageList.Images.SetKeyName(48, "spades-9-75.png");
            this.imageList.Images.SetKeyName(49, "spades-10-75.png");
            this.imageList.Images.SetKeyName(50, "spades-j-75.png");
            this.imageList.Images.SetKeyName(51, "spades-q-75.png");
            this.imageList.Images.SetKeyName(52, "spades-k-75.png");
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Bit Code|*.bc";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "5-03-2019_11-30-33_AM";
            // 
            // button1stHand
            // 
            this.button1stHand.Location = new System.Drawing.Point(151, 47);
            this.button1stHand.Name = "button1stHand";
            this.button1stHand.Size = new System.Drawing.Size(75, 23);
            this.button1stHand.TabIndex = 3;
            this.button1stHand.Tag = 0;
            this.button1stHand.Text = "1st Hand";
            this.button1stHand.UseVisualStyleBackColor = true;
            this.button1stHand.Click += new System.EventHandler(this.buttonHand_Click);
            // 
            // button4thHand
            // 
            this.button4thHand.Location = new System.Drawing.Point(574, 47);
            this.button4thHand.Name = "button4thHand";
            this.button4thHand.Size = new System.Drawing.Size(75, 23);
            this.button4thHand.TabIndex = 4;
            this.button4thHand.Tag = 3;
            this.button4thHand.Text = "4th Hand";
            this.button4thHand.UseVisualStyleBackColor = true;
            this.button4thHand.Click += new System.EventHandler(this.buttonHand_Click);
            // 
            // button3rdHand
            // 
            this.button3rdHand.Location = new System.Drawing.Point(430, 47);
            this.button3rdHand.Name = "button3rdHand";
            this.button3rdHand.Size = new System.Drawing.Size(75, 23);
            this.button3rdHand.TabIndex = 5;
            this.button3rdHand.Tag = 2;
            this.button3rdHand.Text = "3rd Hand";
            this.button3rdHand.UseVisualStyleBackColor = true;
            this.button3rdHand.Click += new System.EventHandler(this.buttonHand_Click);
            // 
            // button2ndHand
            // 
            this.button2ndHand.Location = new System.Drawing.Point(294, 47);
            this.button2ndHand.Name = "button2ndHand";
            this.button2ndHand.Size = new System.Drawing.Size(75, 23);
            this.button2ndHand.TabIndex = 6;
            this.button2ndHand.Tag = 1;
            this.button2ndHand.Text = "2nd Hand";
            this.button2ndHand.UseVisualStyleBackColor = true;
            this.button2ndHand.Click += new System.EventHandler(this.buttonHand_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(539, 348);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(25, 21);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(102, 13);
            this.label.TabIndex = 8;
            this.label.Text = "You Are On Hands :";
            // 
            // labelNumOfHands
            // 
            this.labelNumOfHands.AutoSize = true;
            this.labelNumOfHands.Location = new System.Drawing.Point(134, 21);
            this.labelNumOfHands.Name = "labelNumOfHands";
            this.labelNumOfHands.Size = new System.Drawing.Size(0, 13);
            this.labelNumOfHands.TabIndex = 9;
            // 
            // Save_PDF
            // 
            this.Save_PDF.Location = new System.Drawing.Point(365, 378);
            this.Save_PDF.Name = "Save_PDF";
            this.Save_PDF.Size = new System.Drawing.Size(75, 40);
            this.Save_PDF.TabIndex = 10;
            this.Save_PDF.Text = "Save As PDF";
            this.Save_PDF.UseVisualStyleBackColor = true;
            this.Save_PDF.Click += new System.EventHandler(this.Save_PDF_Click);
            // 
            // CardsDealer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save_PDF);
            this.Controls.Add(this.labelNumOfHands);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.button2ndHand);
            this.Controls.Add(this.button3rdHand);
            this.Controls.Add(this.button4thHand);
            this.Controls.Add(this.button1stHand);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDealCards);
            this.MaximizeBox = false;
            this.Name = "CardsDealer";
            this.Text = "Cards Dealer App";
            this.Load += new System.EventHandler(this.CardsDealer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDealCards;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button1stHand;
        private System.Windows.Forms.Button button4thHand;
        private System.Windows.Forms.Button button3rdHand;
        private System.Windows.Forms.Button button2ndHand;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelNumOfHands;
        private System.Windows.Forms.Button Save_PDF;
    }
}

