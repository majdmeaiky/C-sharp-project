namespace WindowsFormsApp6
{
    partial class Form5
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
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.lblChoise1 = new System.Windows.Forms.Label();
            this.lblChoise2 = new System.Windows.Forms.Label();
            this.lblChoise3 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.cmbPic = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(62, 209);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(175, 145);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(333, 209);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(191, 145);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Location = new System.Drawing.Point(606, 209);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(171, 145);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 2;
            this.pic3.TabStop = false;
            // 
            // lblChoise1
            // 
            this.lblChoise1.AutoSize = true;
            this.lblChoise1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblChoise1.Location = new System.Drawing.Point(107, 154);
            this.lblChoise1.Name = "lblChoise1";
            this.lblChoise1.Size = new System.Drawing.Size(71, 20);
            this.lblChoise1.TabIndex = 3;
            this.lblChoise1.Text = "Picture 1";
            // 
            // lblChoise2
            // 
            this.lblChoise2.AutoSize = true;
            this.lblChoise2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblChoise2.Location = new System.Drawing.Point(393, 154);
            this.lblChoise2.Name = "lblChoise2";
            this.lblChoise2.Size = new System.Drawing.Size(71, 20);
            this.lblChoise2.TabIndex = 4;
            this.lblChoise2.Text = "Picture 2";
            // 
            // lblChoise3
            // 
            this.lblChoise3.AutoSize = true;
            this.lblChoise3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblChoise3.Location = new System.Drawing.Point(660, 154);
            this.lblChoise3.Name = "lblChoise3";
            this.lblChoise3.Size = new System.Drawing.Size(71, 20);
            this.lblChoise3.TabIndex = 5;
            this.lblChoise3.Text = "Picture 3";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(39, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(711, 37);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "Welcome to the choises game, we wish you luck!";
            // 
            // cmbPic
            // 
            this.cmbPic.FormattingEnabled = true;
            this.cmbPic.Items.AddRange(new object[] {
            "picture 1",
            "pucture 2",
            "picture 3"});
            this.cmbPic.Location = new System.Drawing.Point(353, 59);
            this.cmbPic.Name = "cmbPic";
            this.cmbPic.Size = new System.Drawing.Size(121, 28);
            this.cmbPic.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(675, 375);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(102, 48);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 375);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(237, 48);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(105, 67);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(93, 32);
            this.lblWord.TabIndex = 10;
            this.lblWord.Text = "label1";
            this.lblWord.Visible = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.images__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbPic);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblChoise3);
            this.Controls.Add(this.lblChoise2);
            this.Controls.Add(this.lblChoise1);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Name = "Form5";
            this.Text = "Game 1";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.Label lblChoise1;
        private System.Windows.Forms.Label lblChoise2;
        private System.Windows.Forms.Label lblChoise3;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ComboBox cmbPic;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblWord;
    }
}