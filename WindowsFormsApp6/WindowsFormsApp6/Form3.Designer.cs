namespace WindowsFormsApp6
{
    partial class Form3
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
            this.lblInsert = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblVoice = new System.Windows.Forms.Label();
            this.txtNewWord = new System.Windows.Forms.TextBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.txtVoice = new System.Windows.Forms.TextBox();
            this.btnUploadVoice = new System.Windows.Forms.Button();
            this.btnNewSubmit = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInsert
            // 
            this.lblInsert.AutoSize = true;
            this.lblInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsert.Location = new System.Drawing.Point(79, 33);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(667, 37);
            this.lblInsert.TabIndex = 0;
            this.lblInsert.Text = "Please insert the information you want to add:";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(49, 122);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(90, 32);
            this.lblWord.TabIndex = 1;
            this.lblWord.Text = "Word:";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.Location = new System.Drawing.Point(12, 207);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(164, 32);
            this.lblImage.TabIndex = 2;
            this.lblImage.Text = "Image URL:";
            // 
            // lblVoice
            // 
            this.lblVoice.AutoSize = true;
            this.lblVoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblVoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoice.Location = new System.Drawing.Point(18, 314);
            this.lblVoice.Name = "lblVoice";
            this.lblVoice.Size = new System.Drawing.Size(158, 32);
            this.lblVoice.TabIndex = 3;
            this.lblVoice.Text = "Voice URL:";
            // 
            // txtNewWord
            // 
            this.txtNewWord.Location = new System.Drawing.Point(200, 122);
            this.txtNewWord.Multiline = true;
            this.txtNewWord.Name = "txtNewWord";
            this.txtNewWord.Size = new System.Drawing.Size(378, 43);
            this.txtNewWord.TabIndex = 4;
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(200, 207);
            this.txtImage.Multiline = true;
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(378, 41);
            this.txtImage.TabIndex = 5;
            // 
            // txtVoice
            // 
            this.txtVoice.Location = new System.Drawing.Point(200, 302);
            this.txtVoice.Multiline = true;
            this.txtVoice.Name = "txtVoice";
            this.txtVoice.Size = new System.Drawing.Size(378, 44);
            this.txtVoice.TabIndex = 6;
            // 
            // btnUploadVoice
            // 
            this.btnUploadVoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUploadVoice.Location = new System.Drawing.Point(641, 302);
            this.btnUploadVoice.Name = "btnUploadVoice";
            this.btnUploadVoice.Size = new System.Drawing.Size(129, 44);
            this.btnUploadVoice.TabIndex = 8;
            this.btnUploadVoice.Text = "Upload";
            this.btnUploadVoice.UseVisualStyleBackColor = false;
            this.btnUploadVoice.Click += new System.EventHandler(this.btnUploadVoice_Click_1);
            // 
            // btnNewSubmit
            // 
            this.btnNewSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNewSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSubmit.Location = new System.Drawing.Point(266, 384);
            this.btnNewSubmit.Name = "btnNewSubmit";
            this.btnNewSubmit.Size = new System.Drawing.Size(234, 54);
            this.btnNewSubmit.TabIndex = 9;
            this.btnNewSubmit.Text = "Submit";
            this.btnNewSubmit.UseVisualStyleBackColor = false;
            this.btnNewSubmit.Click += new System.EventHandler(this.btnNewSubmit_Click_1);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpload.Location = new System.Drawing.Point(641, 208);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(129, 40);
            this.btnUpload.TabIndex = 10;
            this.btnUpload.Text = "upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp6.Properties.Resources._2961734;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnNewSubmit);
            this.Controls.Add(this.btnUploadVoice);
            this.Controls.Add(this.txtVoice);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.txtNewWord);
            this.Controls.Add(this.lblVoice);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblInsert);
            this.Name = "Form3";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInsert;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblVoice;
        private System.Windows.Forms.TextBox txtNewWord;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.TextBox txtVoice;
        private System.Windows.Forms.Button btnUploadVoice;
        private System.Windows.Forms.Button btnNewSubmit;
        private System.Windows.Forms.Button btnUpload;
    }
}