﻿namespace Bai01_Client
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
            this.btnSend = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            this.btnImg = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.lBoxMessage = new System.Windows.Forms.ListBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtClientIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(358, 251);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 64);
            this.btnSend.TabIndex = 17;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnMusic
            // 
            this.btnMusic.Location = new System.Drawing.Point(358, 110);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(75, 23);
            this.btnMusic.TabIndex = 16;
            this.btnMusic.Text = "Music";
            this.btnMusic.UseVisualStyleBackColor = true;
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(358, 163);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(75, 23);
            this.btnImg.TabIndex = 15;
            this.btnImg.Text = "Image";
            this.btnImg.UseVisualStyleBackColor = true;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(358, 56);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 23);
            this.btnFile.TabIndex = 14;
            this.btnFile.Text = "Files";
            this.btnFile.UseVisualStyleBackColor = true;
            // 
            // lBoxMessage
            // 
            this.lBoxMessage.FormattingEnabled = true;
            this.lBoxMessage.Location = new System.Drawing.Point(76, 56);
            this.lBoxMessage.Name = "lBoxMessage";
            this.lBoxMessage.Size = new System.Drawing.Size(260, 173);
            this.lBoxMessage.TabIndex = 13;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(75, 248);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(261, 67);
            this.txtMessage.TabIndex = 12;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // txtClientIP
            // 
            this.txtClientIP.Enabled = false;
            this.txtClientIP.Location = new System.Drawing.Point(76, 15);
            this.txtClientIP.Name = "txtClientIP";
            this.txtClientIP.Size = new System.Drawing.Size(183, 20);
            this.txtClientIP.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Message:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Server IP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 329);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.lBoxMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtClientIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chat Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.ListBox lBoxMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtClientIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

