namespace connection_student
{
    partial class Chose_type
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
            this.btFindquickly = new System.Windows.Forms.Button();
            this.pictureS = new System.Windows.Forms.PictureBox();
            this.btFind_doc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureS)).BeginInit();
            this.SuspendLayout();
            // 
            // btFindquickly
            // 
            this.btFindquickly.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btFindquickly.Location = new System.Drawing.Point(47, 102);
            this.btFindquickly.Name = "btFindquickly";
            this.btFindquickly.Size = new System.Drawing.Size(132, 50);
            this.btFindquickly.TabIndex = 0;
            this.btFindquickly.Text = "Find quickly";
            this.btFindquickly.UseVisualStyleBackColor = false;
            this.btFindquickly.Click += new System.EventHandler(this.btFindquickly_Click);
            // 
            // pictureS
            // 
            this.pictureS.BackColor = System.Drawing.Color.Transparent;
            this.pictureS.BackgroundImage = global::connection_student.Properties.Resources._8726517_spinner_icon;
            this.pictureS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureS.Location = new System.Drawing.Point(185, 91);
            this.pictureS.Name = "pictureS";
            this.pictureS.Size = new System.Drawing.Size(67, 70);
            this.pictureS.TabIndex = 1;
            this.pictureS.TabStop = false;
            this.pictureS.Visible = false;
            // 
            // btFind_doc
            // 
            this.btFind_doc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btFind_doc.Location = new System.Drawing.Point(267, 102);
            this.btFind_doc.Name = "btFind_doc";
            this.btFind_doc.Size = new System.Drawing.Size(132, 50);
            this.btFind_doc.TabIndex = 2;
            this.btFind_doc.Text = "Find documents";
            this.btFind_doc.UseVisualStyleBackColor = false;
            this.btFind_doc.Click += new System.EventHandler(this.btFind_doc_Click);
            // 
            // Chose_type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::connection_student.Properties.Resources.Eng;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(437, 269);
            this.Controls.Add(this.btFind_doc);
            this.Controls.Add(this.pictureS);
            this.Controls.Add(this.btFindquickly);
            this.Name = "Chose_type";
            this.Text = "Chose_type";
            ((System.ComponentModel.ISupportInitialize)(this.pictureS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFindquickly;
        private System.Windows.Forms.PictureBox pictureS;
        private System.Windows.Forms.Button btFind_doc;
    }
}