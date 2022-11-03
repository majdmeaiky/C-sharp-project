namespace WindowsFormsApp6
{
    partial class Form1
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.lbliNstructions = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnData = new System.Windows.Forms.Button();
            this.btnGames = new System.Windows.Forms.Button();
            this.btnLearning = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(29, 21);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(713, 37);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Please enter your mail/user name and the submit";
            // 
            // lbliNstructions
            // 
            this.lbliNstructions.AutoSize = true;
            this.lbliNstructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbliNstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliNstructions.Location = new System.Drawing.Point(206, 71);
            this.lbliNstructions.Name = "lbliNstructions";
            this.lbliNstructions.Size = new System.Drawing.Size(358, 32);
            this.lbliNstructions.TabIndex = 2;
            this.lbliNstructions.Text = "Please choose one option: ";
            this.lbliNstructions.Visible = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(28, 172);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(131, 46);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Email:";
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnData.Location = new System.Drawing.Point(6, 252);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(153, 63);
            this.btnData.TabIndex = 4;
            this.btnData.Text = "Update Data";
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Visible = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click_1);
            // 
            // btnGames
            // 
            this.btnGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGames.Location = new System.Drawing.Point(314, 252);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(137, 63);
            this.btnGames.TabIndex = 5;
            this.btnGames.Text = "Games";
            this.btnGames.UseVisualStyleBackColor = false;
            this.btnGames.Visible = false;
            this.btnGames.Click += new System.EventHandler(this.btnGames_Click_1);
            // 
            // btnLearning
            // 
            this.btnLearning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLearning.Location = new System.Drawing.Point(627, 252);
            this.btnLearning.Name = "btnLearning";
            this.btnLearning.Size = new System.Drawing.Size(147, 66);
            this.btnLearning.TabIndex = 6;
            this.btnLearning.Text = "Lessons";
            this.btnLearning.UseVisualStyleBackColor = false;
            this.btnLearning.Visible = false;
            this.btnLearning.Click += new System.EventHandler(this.btnLearning_Click_1);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSubmit.Location = new System.Drawing.Point(12, 392);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(147, 54);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Location = new System.Drawing.Point(627, 392);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 54);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(193, 166);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(417, 52);
            this.txtUserName.TabIndex = 9;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.Capture1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnLearning);
            this.Controls.Add(this.btnGames);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lbliNstructions);
            this.Controls.Add(this.lblInfo);
            this.Name = "Form1";
            this.Text = "Majd and Matan learning app";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lbliNstructions;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnGames;
        private System.Windows.Forms.Button btnLearning;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtUserName;
    }
}

