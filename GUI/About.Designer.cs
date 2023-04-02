namespace WhatsThisFilm
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            label1 = new System.Windows.Forms.Label();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            linkLabel2 = new System.Windows.Forms.LinkLabel();
            label2 = new System.Windows.Forms.Label();
            lblVersion = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(6, 23);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(175, 21);
            label1.TabIndex = 0;
            label1.Text = "Développé par Vincent Tollu.";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(13, 44);
            linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(146, 15);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "www.yocto.projects.free.fr";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new System.Drawing.Point(32, 125);
            linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new System.Drawing.Size(167, 15);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "https://www.themoviedb.org/";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(24, 104);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(175, 21);
            label2.TabIndex = 3;
            label2.Text = "Merci à The Movie DB";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new System.Drawing.Point(52, 77);
            lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new System.Drawing.Size(72, 15);
            lblVersion.TabIndex = 4;
            lblVersion.Text = "version 0.0.0";
            // 
            // About
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(252, 158);
            Controls.Add(lblVersion);
            Controls.Add(label2);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "A propos.";
            Load += About_Load;
            Click += About_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVersion;
    }
}