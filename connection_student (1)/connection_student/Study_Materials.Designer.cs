namespace connection_student
{
    partial class Study_Materials
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btOpenFile = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btDowload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(574, 384);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            // 
            // btOpenFile
            // 
            this.btOpenFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btOpenFile.Location = new System.Drawing.Point(628, 286);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(129, 39);
            this.btOpenFile.TabIndex = 1;
            this.btOpenFile.Text = "Open File";
            this.btOpenFile.UseVisualStyleBackColor = false;
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btExit.Location = new System.Drawing.Point(628, 399);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(129, 39);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btDowload
            // 
            this.btDowload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btDowload.Location = new System.Drawing.Point(628, 341);
            this.btDowload.Name = "btDowload";
            this.btDowload.Size = new System.Drawing.Size(129, 39);
            this.btDowload.TabIndex = 3;
            this.btDowload.Text = "Dowload File";
            this.btDowload.UseVisualStyleBackColor = false;
            // 
            // Study_Materials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::connection_student.Properties.Resources.Eng;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.btDowload);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btOpenFile);
            this.Controls.Add(this.listView1);
            this.Name = "Study_Materials";
            this.Text = "Study Materials";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btDowload;
    }
}