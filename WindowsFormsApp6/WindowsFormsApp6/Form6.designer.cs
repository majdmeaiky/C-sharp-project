namespace WindowsFormsApp6
{
    partial class Form6
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
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.picGame = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblWriteHere = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(263, 381);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(237, 45);
            this.txtAnswer.TabIndex = 1;
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnswer.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 363);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(218, 63);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picGame
            // 
            this.picGame.Location = new System.Drawing.Point(157, 26);
            this.picGame.Name = "picGame";
            this.picGame.Size = new System.Drawing.Size(469, 313);
            this.picGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGame.TabIndex = 0;
            this.picGame.TabStop = false;
            this.picGame.Visible = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(57, 26);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(696, 37);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome to the writing game, we wish you luck!";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(589, 363);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(199, 63);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblWriteHere
            // 
            this.lblWriteHere.AutoSize = true;
            this.lblWriteHere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblWriteHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriteHere.Location = new System.Drawing.Point(86, 387);
            this.lblWriteHere.Name = "lblWriteHere";
            this.lblWriteHere.Size = new System.Drawing.Size(130, 29);
            this.lblWriteHere.TabIndex = 5;
            this.lblWriteHere.Text = "Write here:";
            this.lblWriteHere.Visible = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.images__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWriteHere);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.picGame);
            this.Name = "Form6";
            this.Text = "Game 2";
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGame;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblWriteHere;
    }
}