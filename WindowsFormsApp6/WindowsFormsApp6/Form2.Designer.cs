namespace WindowsFormsApp6
{
    partial class Form2
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
            this.cmbLetter = new System.Windows.Forms.ComboBox();
            this.cmbChoice = new System.Windows.Forms.ComboBox();
            this.lblChoice = new System.Windows.Forms.Label();
            this.lblChoose = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.picWord = new System.Windows.Forms.PictureBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTime1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWord)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLetter
            // 
            this.cmbLetter.FormattingEnabled = true;
            this.cmbLetter.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cmbLetter.Location = new System.Drawing.Point(3, 186);
            this.cmbLetter.Name = "cmbLetter";
            this.cmbLetter.Size = new System.Drawing.Size(149, 28);
            this.cmbLetter.TabIndex = 0;
            // 
            // cmbChoice
            // 
            this.cmbChoice.FormattingEnabled = true;
            this.cmbChoice.Items.AddRange(new object[] {
            "Manually",
            "Autumatic"});
            this.cmbChoice.Location = new System.Drawing.Point(12, 66);
            this.cmbChoice.Name = "cmbChoice";
            this.cmbChoice.Size = new System.Drawing.Size(140, 28);
            this.cmbChoice.TabIndex = 1;
            // 
            // lblChoice
            // 
            this.lblChoice.AutoSize = true;
            this.lblChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoice.Location = new System.Drawing.Point(12, 9);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(483, 30);
            this.lblChoice.TabIndex = 2;
            this.lblChoice.Text = "Please choose the way you want to learn:";
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.Location = new System.Drawing.Point(7, 122);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(251, 30);
            this.lblChoose.TabIndex = 3;
            this.lblChoose.Text = "Please choose letter:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 391);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 47);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(600, 169);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(169, 52);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // picWord
            // 
            this.picWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWord.Location = new System.Drawing.Point(264, 100);
            this.picWord.Name = "picWord";
            this.picWord.Size = new System.Drawing.Size(306, 294);
            this.picWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWord.TabIndex = 6;
            this.picWord.TabStop = false;
            this.picWord.Visible = false;
            // 
            // txtWord
            // 
            this.txtWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord.Location = new System.Drawing.Point(576, 251);
            this.txtWord.Multiline = true;
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(223, 57);
            this.txtWord.TabIndex = 7;
            this.txtWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWord.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(600, 391);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(178, 47);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime1.Location = new System.Drawing.Point(620, 26);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(0, 29);
            this.lblTime1.TabIndex = 9;
            this.lblTime1.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp6.Properties.Resources._10_Tips_1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTime1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.picWord);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.lblChoice);
            this.Controls.Add(this.cmbChoice);
            this.Controls.Add(this.cmbLetter);
            this.Name = "Form2";
            this.Text = "Lessons";
            ((System.ComponentModel.ISupportInitialize)(this.picWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLetter;
        private System.Windows.Forms.ComboBox cmbChoice;
        private System.Windows.Forms.Label lblChoice;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox picWord;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTime1;
    }
}