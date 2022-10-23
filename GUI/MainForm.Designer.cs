namespace WhatsThisFilm
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ListeFilms = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnDeleteFiche = new System.Windows.Forms.Button();
            this.lblResume = new System.Windows.Forms.Label();
            this.btnWatchMovie = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.panelFilm = new System.Windows.Forms.Panel();
            this.lblPresse = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGenres = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lnklblFiche = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDuree = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAbout = new System.Windows.Forms.Button();
            this.txtFiltre = new System.Windows.Forms.TextBox();
            this.btnSnipDir = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.directoryDDList = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ListeFilms
            // 
            this.ListeFilms.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ListeFilms.FormattingEnabled = true;
            this.ListeFilms.HorizontalScrollbar = true;
            this.ListeFilms.Location = new System.Drawing.Point(14, 79);
            this.ListeFilms.Name = "ListeFilms";
            this.ListeFilms.Size = new System.Drawing.Size(367, 589);
            this.ListeFilms.TabIndex = 0;
            this.ListeFilms.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListeFilms_DrawItem);
            this.ListeFilms.SelectedIndexChanged += new System.EventHandler(this.ListeFilms_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnRename);
            this.panel1.Controls.Add(this.btnDeleteFiche);
            this.panel1.Controls.Add(this.lblResume);
            this.panel1.Controls.Add(this.btnWatchMovie);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.panelFilm);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblIndex);
            this.panel1.Location = new System.Drawing.Point(387, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 602);
            this.panel1.TabIndex = 1;
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(327, 225);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(122, 23);
            this.btnRename.TabIndex = 12;
            this.btnRename.Text = "Renommer le fichier";
            this.toolTip1.SetToolTip(this.btnRename, "Renommer le fichier avec le titre du film");
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // btnDeleteFiche
            // 
            this.btnDeleteFiche.Location = new System.Drawing.Point(459, 3);
            this.btnDeleteFiche.Name = "btnDeleteFiche";
            this.btnDeleteFiche.Size = new System.Drawing.Size(21, 21);
            this.btnDeleteFiche.TabIndex = 11;
            this.btnDeleteFiche.Text = "!";
            this.toolTip1.SetToolTip(this.btnDeleteFiche, "Effacer fiche");
            this.btnDeleteFiche.UseVisualStyleBackColor = true;
            this.btnDeleteFiche.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblResume
            // 
            this.lblResume.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResume.Location = new System.Drawing.Point(14, 418);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(456, 168);
            this.lblResume.TabIndex = 10;
            this.lblResume.Text = "label6";
            // 
            // btnWatchMovie
            // 
            this.btnWatchMovie.Location = new System.Drawing.Point(546, 374);
            this.btnWatchMovie.Name = "btnWatchMovie";
            this.btnWatchMovie.Size = new System.Drawing.Size(59, 36);
            this.btnWatchMovie.TabIndex = 7;
            this.btnWatchMovie.Text = "Regarder";
            this.toolTip1.SetToolTip(this.btnWatchMovie, "Lancer le film");
            this.btnWatchMovie.UseVisualStyleBackColor = true;
            this.btnWatchMovie.Click += new System.EventHandler(this.btnWatchMovie_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(584, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(21, 21);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">";
            this.toolTip1.SetToolTip(this.btnNext, "Fiche suivante");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Enabled = false;
            this.btnPrev.Location = new System.Drawing.Point(498, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(21, 21);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.Text = "<";
            this.toolTip1.SetToolTip(this.btnPrev, "Fiche précédente");
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // panelFilm
            // 
            this.panelFilm.Controls.Add(this.lblPresse);
            this.panelFilm.Controls.Add(this.label7);
            this.panelFilm.Controls.Add(this.lblDirector);
            this.panelFilm.Controls.Add(this.label8);
            this.panelFilm.Controls.Add(this.lblGenres);
            this.panelFilm.Controls.Add(this.label6);
            this.panelFilm.Controls.Add(this.lnklblFiche);
            this.panelFilm.Controls.Add(this.label4);
            this.panelFilm.Controls.Add(this.lblDuree);
            this.panelFilm.Controls.Add(this.label3);
            this.panelFilm.Controls.Add(this.lblYear);
            this.panelFilm.Controls.Add(this.lblTitle);
            this.panelFilm.Controls.Add(this.label2);
            this.panelFilm.Controls.Add(this.label1);
            this.panelFilm.Location = new System.Drawing.Point(327, 30);
            this.panelFilm.Name = "panelFilm";
            this.panelFilm.Size = new System.Drawing.Size(278, 178);
            this.panelFilm.TabIndex = 3;
            // 
            // lblPresse
            // 
            this.lblPresse.AutoSize = true;
            this.lblPresse.Location = new System.Drawing.Point(98, 130);
            this.lblPresse.Name = "lblPresse";
            this.lblPresse.Size = new System.Drawing.Size(24, 13);
            this.lblPresse.TabIndex = 13;
            this.lblPresse.Text = "4/5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Note Presse";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(98, 39);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(35, 13);
            this.lblDirector.TabIndex = 11;
            this.lblDirector.Text = "label3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Réalisateur";
            // 
            // lblGenres
            // 
            this.lblGenres.AutoSize = true;
            this.lblGenres.Location = new System.Drawing.Point(98, 108);
            this.lblGenres.Name = "lblGenres";
            this.lblGenres.Size = new System.Drawing.Size(35, 13);
            this.lblGenres.TabIndex = 9;
            this.lblGenres.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Genres";
            // 
            // lnklblFiche
            // 
            this.lnklblFiche.AutoSize = true;
            this.lnklblFiche.Location = new System.Drawing.Point(98, 150);
            this.lnklblFiche.Name = "lnklblFiche";
            this.lnklblFiche.Size = new System.Drawing.Size(55, 13);
            this.lnklblFiche.TabIndex = 7;
            this.lnklblFiche.TabStop = true;
            this.lnklblFiche.Text = "linkLabel1";
            this.toolTip1.SetToolTip(this.lnklblFiche, "Fiche sur le site allociné");
            this.lnklblFiche.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblFiche_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fiche";
            // 
            // lblDuree
            // 
            this.lblDuree.AutoSize = true;
            this.lblDuree.Location = new System.Drawing.Point(98, 86);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(35, 13);
            this.lblDuree.TabIndex = 5;
            this.lblDuree.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Durée";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(98, 61);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(35, 13);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "label4";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(98, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Année";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 400);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "/";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(558, 7);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(19, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "99";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(525, 7);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(19, 13);
            this.lblIndex.TabIndex = 6;
            this.lblIndex.Text = "99";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(202, 13);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(25, 21);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "...";
            this.toolTip1.SetToolTip(this.btnBrowse, "Ajouter un répertoire");
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(815, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 35);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Fiches fournies par Allociné");
            this.pictureBox2.Click += new System.EventHandler(this.logoBox_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(972, 2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(20, 22);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "?";
            this.toolTip1.SetToolTip(this.btnAbout, "A propos");
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // txtFiltre
            // 
            this.txtFiltre.Location = new System.Drawing.Point(14, 43);
            this.txtFiltre.Name = "txtFiltre";
            this.txtFiltre.Size = new System.Drawing.Size(213, 20);
            this.txtFiltre.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtFiltre, "N\'afficher que les films contenant le texte entré");
            this.txtFiltre.TextChanged += new System.EventHandler(this.txtFiltre_TextChanged);
            this.txtFiltre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltre_KeyDown);
            // 
            // btnSnipDir
            // 
            this.btnSnipDir.Location = new System.Drawing.Point(233, 13);
            this.btnSnipDir.Name = "btnSnipDir";
            this.btnSnipDir.Size = new System.Drawing.Size(26, 21);
            this.btnSnipDir.TabIndex = 11;
            this.btnSnipDir.Text = "X";
            this.toolTip1.SetToolTip(this.btnSnipDir, "Supprimer le répertoire");
            this.btnSnipDir.UseVisualStyleBackColor = true;
            this.btnSnipDir.Click += new System.EventHandler(this.btnSnipDir_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(244, 43);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(47, 20);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Filtrer";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // directoryDDList
            // 
            this.directoryDDList.FormattingEnabled = true;
            this.directoryDDList.Location = new System.Drawing.Point(14, 13);
            this.directoryDDList.Name = "directoryDDList";
            this.directoryDDList.Size = new System.Drawing.Size(182, 21);
            this.directoryDDList.TabIndex = 9;
            this.directoryDDList.SelectedIndexChanged += new System.EventHandler(this.directoryDDList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Effacer fichier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1005, 691);
            this.Controls.Add(this.btnSnipDir);
            this.Controls.Add(this.directoryDDList);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtFiltre);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ListeFilms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "WhatsThisFilm?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFilm.ResumeLayout(false);
            this.panelFilm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListeFilms;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelFilm;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Button btnWatchMovie;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblDuree;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.LinkLabel lnklblFiche;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblResume;
        private System.Windows.Forms.Label lblGenres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFiltre;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblPresse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDeleteFiche;
        private System.Windows.Forms.ComboBox directoryDDList;
        private System.Windows.Forms.Button btnSnipDir;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button button1;
    }
}

