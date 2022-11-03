namespace WindowsFormsApp6
{
    partial class Form8
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblWord3 = new System.Windows.Forms.Label();
            this.lblWord2 = new System.Windows.Forms.Label();
            this.lblWord1 = new System.Windows.Forms.Label();
            this.cmbAnswer = new System.Windows.Forms.ComboBox();
            this.lblChoise1 = new System.Windows.Forms.Label();
            this.lblChoise2 = new System.Windows.Forms.Label();
            this.lblChoise3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(73, 29);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(575, 46);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the lisitening game";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(22, 251);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(237, 61);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblWord3
            // 
            this.lblWord3.AutoSize = true;
            this.lblWord3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblWord3.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord3.Location = new System.Drawing.Point(625, 139);
            this.lblWord3.Name = "lblWord3";
            this.lblWord3.Size = new System.Drawing.Size(147, 53);
            this.lblWord3.TabIndex = 5;
            this.lblWord3.Text = "label1";
            this.lblWord3.Visible = false;
            // 
            // lblWord2
            // 
            this.lblWord2.AutoSize = true;
            this.lblWord2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblWord2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord2.Location = new System.Drawing.Point(301, 251);
            this.lblWord2.Name = "lblWord2";
            this.lblWord2.Size = new System.Drawing.Size(147, 53);
            this.lblWord2.TabIndex = 6;
            this.lblWord2.Text = "label2";
            this.lblWord2.Visible = false;
            // 
            // lblWord1
            // 
            this.lblWord1.AutoSize = true;
            this.lblWord1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblWord1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord1.Location = new System.Drawing.Point(13, 385);
            this.lblWord1.Name = "lblWord1";
            this.lblWord1.Size = new System.Drawing.Size(147, 53);
            this.lblWord1.TabIndex = 7;
            this.lblWord1.Text = "label3";
            this.lblWord1.Visible = false;
            // 
            // cmbAnswer
            // 
            this.cmbAnswer.FormattingEnabled = true;
            this.cmbAnswer.Items.AddRange(new object[] {
            "Word 1",
            "Word 2",
            "Word 3"});
            this.cmbAnswer.Location = new System.Drawing.Point(213, 89);
            this.cmbAnswer.Name = "cmbAnswer";
            this.cmbAnswer.Size = new System.Drawing.Size(307, 28);
            this.cmbAnswer.TabIndex = 8;
            this.cmbAnswer.Visible = false;
            // 
            // lblChoise1
            // 
            this.lblChoise1.AutoSize = true;
            this.lblChoise1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblChoise1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoise1.Location = new System.Drawing.Point(27, 355);
            this.lblChoise1.Name = "lblChoise1";
            this.lblChoise1.Size = new System.Drawing.Size(96, 30);
            this.lblChoise1.TabIndex = 9;
            this.lblChoise1.Text = "Word 1";
            this.lblChoise1.Visible = false;
            // 
            // lblChoise2
            // 
            this.lblChoise2.AutoSize = true;
            this.lblChoise2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblChoise2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoise2.Location = new System.Drawing.Point(322, 225);
            this.lblChoise2.Name = "lblChoise2";
            this.lblChoise2.Size = new System.Drawing.Size(96, 30);
            this.lblChoise2.TabIndex = 10;
            this.lblChoise2.Text = "Word 2";
            this.lblChoise2.Visible = false;
            // 
            // lblChoise3
            // 
            this.lblChoise3.AutoSize = true;
            this.lblChoise3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblChoise3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoise3.Location = new System.Drawing.Point(657, 109);
            this.lblChoise3.Name = "lblChoise3";
            this.lblChoise3.Size = new System.Drawing.Size(96, 30);
            this.lblChoise3.TabIndex = 11;
            this.lblChoise3.Text = "Word 3";
            this.lblChoise3.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(598, 255);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(190, 57);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.unnamed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblChoise3);
            this.Controls.Add(this.lblChoise2);
            this.Controls.Add(this.lblChoise1);
            this.Controls.Add(this.cmbAnswer);
            this.Controls.Add(this.lblWord1);
            this.Controls.Add(this.lblWord2);
            this.Controls.Add(this.lblWord3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Form8";
            this.Text = "Game 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblWord3;
        private System.Windows.Forms.Label lblWord2;
        private System.Windows.Forms.Label lblWord1;
        private System.Windows.Forms.ComboBox cmbAnswer;
        private System.Windows.Forms.Label lblChoise1;
        private System.Windows.Forms.Label lblChoise2;
        private System.Windows.Forms.Label lblChoise3;
        private System.Windows.Forms.Button btnSubmit;
    }
}