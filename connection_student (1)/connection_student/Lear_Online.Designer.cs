namespace connection_student
{
    partial class Lear_Online
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btStop = new System.Windows.Forms.Button();
            this.tbchat = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.tbsend = new System.Windows.Forms.TextBox();
            this.btRaisehands = new System.Windows.Forms.Button();
            this.hand = new System.Windows.Forms.PictureBox();
            this.btMic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hand)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::connection_student.Properties.Resources.Screenshot_2024_11_30_094809;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(702, 396);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btStop
            // 
            this.btStop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btStop.Location = new System.Drawing.Point(871, 414);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(109, 42);
            this.btStop.TabIndex = 1;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = false;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // tbchat
            // 
            this.tbchat.Location = new System.Drawing.Point(720, 51);
            this.tbchat.Multiline = true;
            this.tbchat.Name = "tbchat";
            this.tbchat.Size = new System.Drawing.Size(260, 327);
            this.tbchat.TabIndex = 3;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(897, 353);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(83, 25);
            this.btSend.TabIndex = 5;
            this.btSend.Text = "send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // tbsend
            // 
            this.tbsend.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbsend.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbsend.Location = new System.Drawing.Point(720, 353);
            this.tbsend.Name = "tbsend";
            this.tbsend.Size = new System.Drawing.Size(182, 22);
            this.tbsend.TabIndex = 6;
            // 
            // btRaisehands
            // 
            this.btRaisehands.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btRaisehands.Location = new System.Drawing.Point(605, 414);
            this.btRaisehands.Name = "btRaisehands";
            this.btRaisehands.Size = new System.Drawing.Size(109, 42);
            this.btRaisehands.TabIndex = 7;
            this.btRaisehands.Text = "Raise hands";
            this.btRaisehands.UseVisualStyleBackColor = false;
            this.btRaisehands.Click += new System.EventHandler(this.btRaisehands_Click);
            // 
            // hand
            // 
            this.hand.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.hand.BackColor = System.Drawing.Color.Transparent;
            this.hand.BackgroundImage = global::connection_student.Properties.Resources.hand;
            this.hand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hand.Location = new System.Drawing.Point(683, 12);
            this.hand.Name = "hand";
            this.hand.Size = new System.Drawing.Size(31, 24);
            this.hand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hand.TabIndex = 8;
            this.hand.TabStop = false;
            this.hand.Visible = false;
            // 
            // btMic
            // 
            this.btMic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btMic.Location = new System.Drawing.Point(441, 414);
            this.btMic.Name = "btMic";
            this.btMic.Size = new System.Drawing.Size(146, 42);
            this.btMic.TabIndex = 9;
            this.btMic.Text = "on/of Microphone";
            this.btMic.UseVisualStyleBackColor = false;
            // 
            // Lear_Online
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::connection_student.Properties.Resources.Eng;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 465);
            this.Controls.Add(this.btMic);
            this.Controls.Add(this.hand);
            this.Controls.Add(this.btRaisehands);
            this.Controls.Add(this.tbsend);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.tbchat);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Lear_Online";
            this.Text = "Lear Online";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.TextBox tbchat;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TextBox tbsend;
        private System.Windows.Forms.Button btRaisehands;
        private System.Windows.Forms.PictureBox hand;
        private System.Windows.Forms.Button btMic;
    }
}

