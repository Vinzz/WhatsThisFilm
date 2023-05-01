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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ListeFilms = new System.Windows.Forms.ListBox();
            panel1 = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            btnRename = new System.Windows.Forms.Button();
            btnDeleteFiche = new System.Windows.Forms.Button();
            lblResume = new System.Windows.Forms.Label();
            btnAbout = new System.Windows.Forms.Button();
            btnWatchMovie = new System.Windows.Forms.Button();
            btnNext = new System.Windows.Forms.Button();
            btnPrev = new System.Windows.Forms.Button();
            panelFilm = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            lnklblAllocine = new System.Windows.Forms.LinkLabel();
            label9 = new System.Windows.Forms.Label();
            lblPresse = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            lblDirector = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            lblGenres = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            lnklblFiche = new System.Windows.Forms.LinkLabel();
            label4 = new System.Windows.Forms.Label();
            lblDuree = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lblYear = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label5 = new System.Windows.Forms.Label();
            lblTotal = new System.Windows.Forms.Label();
            lblIndex = new System.Windows.Forms.Label();
            btnBrowse = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            txtFiltre = new System.Windows.Forms.TextBox();
            btnSnipDir = new System.Windows.Forms.Button();
            btnFilter = new System.Windows.Forms.Button();
            directoryDDList = new System.Windows.Forms.ComboBox();
            panel1.SuspendLayout();
            panelFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ListeFilms
            // 
            ListeFilms.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            ListeFilms.FormattingEnabled = true;
            ListeFilms.HorizontalScrollbar = true;
            ListeFilms.Location = new System.Drawing.Point(16, 91);
            ListeFilms.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ListeFilms.Name = "ListeFilms";
            ListeFilms.Size = new System.Drawing.Size(428, 549);
            ListeFilms.TabIndex = 0;
            ListeFilms.DrawItem += ListeFilms_DrawItem;
            ListeFilms.SelectedIndexChanged += ListeFilms_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnRename);
            panel1.Controls.Add(btnDeleteFiche);
            panel1.Controls.Add(lblResume);
            panel1.Controls.Add(btnAbout);
            panel1.Controls.Add(btnWatchMovie);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(btnPrev);
            panel1.Controls.Add(panelFilm);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(lblIndex);
            panel1.Location = new System.Drawing.Point(451, 12);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(775, 628);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(318, 314);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(142, 27);
            button1.TabIndex = 13;
            button1.Text = "Effacer fichier";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnDeleteMovie_Click;
            // 
            // btnRename
            // 
            btnRename.Location = new System.Drawing.Point(318, 281);
            btnRename.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRename.Name = "btnRename";
            btnRename.Size = new System.Drawing.Size(142, 27);
            btnRename.TabIndex = 12;
            btnRename.Text = "Renommer le fichier";
            toolTip1.SetToolTip(btnRename, "Renommer le fichier avec le titre du film");
            btnRename.UseVisualStyleBackColor = true;
            btnRename.Click += buttonRename_Click;
            // 
            // btnDeleteFiche
            // 
            btnDeleteFiche.Location = new System.Drawing.Point(536, 3);
            btnDeleteFiche.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDeleteFiche.Name = "btnDeleteFiche";
            btnDeleteFiche.Size = new System.Drawing.Size(24, 24);
            btnDeleteFiche.TabIndex = 11;
            btnDeleteFiche.Text = "!";
            toolTip1.SetToolTip(btnDeleteFiche, "Effacer fiche");
            btnDeleteFiche.UseVisualStyleBackColor = true;
            btnDeleteFiche.Click += btnDelete_Click;
            // 
            // lblResume
            // 
            lblResume.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblResume.Location = new System.Drawing.Point(16, 424);
            lblResume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblResume.Name = "lblResume";
            lblResume.Size = new System.Drawing.Size(532, 187);
            lblResume.TabIndex = 10;
            lblResume.Text = "label6";
            // 
            // btnAbout
            // 
            btnAbout.Location = new System.Drawing.Point(741, 3);
            btnAbout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new System.Drawing.Size(23, 25);
            btnAbout.TabIndex = 6;
            btnAbout.Text = "?";
            toolTip1.SetToolTip(btnAbout, "A propos");
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnWatchMovie
            // 
            btnWatchMovie.Location = new System.Drawing.Point(556, 424);
            btnWatchMovie.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnWatchMovie.Name = "btnWatchMovie";
            btnWatchMovie.Size = new System.Drawing.Size(69, 42);
            btnWatchMovie.TabIndex = 7;
            btnWatchMovie.Text = "Regarder";
            toolTip1.SetToolTip(btnWatchMovie, "Lancer le film");
            btnWatchMovie.UseVisualStyleBackColor = true;
            btnWatchMovie.Click += btnWatchMovie_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new System.Drawing.Point(681, 3);
            btnNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(24, 24);
            btnNext.TabIndex = 5;
            btnNext.Text = ">";
            toolTip1.SetToolTip(btnNext, "Fiche suivante");
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.Enabled = false;
            btnPrev.Location = new System.Drawing.Point(581, 3);
            btnPrev.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new System.Drawing.Size(24, 24);
            btnPrev.TabIndex = 4;
            btnPrev.Text = "<";
            toolTip1.SetToolTip(btnPrev, "Fiche précédente");
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // panelFilm
            // 
            panelFilm.Controls.Add(pictureBox2);
            panelFilm.Controls.Add(lnklblAllocine);
            panelFilm.Controls.Add(label9);
            panelFilm.Controls.Add(lblPresse);
            panelFilm.Controls.Add(label7);
            panelFilm.Controls.Add(lblDirector);
            panelFilm.Controls.Add(label8);
            panelFilm.Controls.Add(lblGenres);
            panelFilm.Controls.Add(label6);
            panelFilm.Controls.Add(lnklblFiche);
            panelFilm.Controls.Add(label4);
            panelFilm.Controls.Add(lblDuree);
            panelFilm.Controls.Add(label3);
            panelFilm.Controls.Add(lblYear);
            panelFilm.Controls.Add(lblTitle);
            panelFilm.Controls.Add(label2);
            panelFilm.Controls.Add(label1);
            panelFilm.Location = new System.Drawing.Point(308, 33);
            panelFilm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelFilm.Name = "panelFilm";
            panelFilm.Size = new System.Drawing.Size(661, 228);
            panelFilm.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.TMDBLogo;
            pictureBox2.Location = new System.Drawing.Point(373, 70);
            pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(72, 72);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            toolTip1.SetToolTip(pictureBox2, "Fiches fournies par Allociné");
            pictureBox2.Click += logoBox_Click;
            // 
            // lnklblAllocine
            // 
            lnklblAllocine.AutoSize = true;
            lnklblAllocine.Location = new System.Drawing.Point(114, 201);
            lnklblAllocine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lnklblAllocine.Name = "lnklblAllocine";
            lnklblAllocine.Size = new System.Drawing.Size(60, 15);
            lnklblAllocine.TabIndex = 15;
            lnklblAllocine.TabStop = true;
            lnklblAllocine.Text = "linkLabel2";
            toolTip1.SetToolTip(lnklblAllocine, "Fiche sur le site allociné");
            lnklblAllocine.LinkClicked += lnklblFiche_LinkClicked;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(14, 201);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(52, 13);
            label9.TabIndex = 14;
            label9.Text = "Allociné";
            // 
            // lblPresse
            // 
            lblPresse.AutoSize = true;
            lblPresse.Location = new System.Drawing.Point(114, 150);
            lblPresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPresse.Name = "lblPresse";
            lblPresse.Size = new System.Drawing.Size(24, 15);
            lblPresse.TabIndex = 13;
            lblPresse.Text = "4/5";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(14, 150);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(64, 13);
            label7.TabIndex = 12;
            label7.Text = "Popularité";
            label7.Click += label7_Click;
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Location = new System.Drawing.Point(114, 45);
            lblDirector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new System.Drawing.Size(38, 15);
            lblDirector.TabIndex = 11;
            lblDirector.Text = "label3";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(14, 45);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(71, 13);
            label8.TabIndex = 10;
            label8.Text = "Réalisateur";
            // 
            // lblGenres
            // 
            lblGenres.AutoSize = true;
            lblGenres.Location = new System.Drawing.Point(114, 125);
            lblGenres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblGenres.Name = "lblGenres";
            lblGenres.Size = new System.Drawing.Size(38, 15);
            lblGenres.TabIndex = 9;
            lblGenres.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(14, 125);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(47, 13);
            label6.TabIndex = 8;
            label6.Text = "Genres";
            // 
            // lnklblFiche
            // 
            lnklblFiche.AutoSize = true;
            lnklblFiche.Location = new System.Drawing.Point(114, 173);
            lnklblFiche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lnklblFiche.Name = "lnklblFiche";
            lnklblFiche.Size = new System.Drawing.Size(60, 15);
            lnklblFiche.TabIndex = 7;
            lnklblFiche.TabStop = true;
            lnklblFiche.Text = "linkLabel1";
            toolTip1.SetToolTip(lnklblFiche, "Fiche sur le site allociné");
            lnklblFiche.LinkClicked += lnklblFiche_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(14, 173);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 13);
            label4.TabIndex = 6;
            label4.Text = "Fiche";
            // 
            // lblDuree
            // 
            lblDuree.AutoSize = true;
            lblDuree.Location = new System.Drawing.Point(114, 99);
            lblDuree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDuree.Name = "lblDuree";
            lblDuree.Size = new System.Drawing.Size(38, 15);
            lblDuree.TabIndex = 5;
            lblDuree.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(14, 99);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 13);
            label3.TabIndex = 4;
            label3.Text = "Durée";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new System.Drawing.Point(114, 70);
            lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblYear.Name = "lblYear";
            lblYear.Size = new System.Drawing.Size(38, 15);
            lblYear.TabIndex = 3;
            lblYear.Text = "label4";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(114, 17);
            lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(38, 15);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(14, 70);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 13);
            label2.TabIndex = 1;
            label2.Text = "Année";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(14, 17);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(33, 13);
            label1.TabIndex = 0;
            label1.Text = "Titre";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(14, 12);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(286, 396);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(637, 8);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(12, 15);
            label5.TabIndex = 9;
            label5.Text = "/";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new System.Drawing.Point(651, 8);
            lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(19, 15);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "99";
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new System.Drawing.Point(612, 8);
            lblIndex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new System.Drawing.Size(19, 15);
            lblIndex.TabIndex = 6;
            lblIndex.Text = "99";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new System.Drawing.Point(236, 15);
            btnBrowse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new System.Drawing.Size(29, 24);
            btnBrowse.TabIndex = 4;
            btnBrowse.Text = "...";
            toolTip1.SetToolTip(btnBrowse, "Ajouter un répertoire");
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtFiltre
            // 
            txtFiltre.Location = new System.Drawing.Point(16, 50);
            txtFiltre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFiltre.Name = "txtFiltre";
            txtFiltre.Size = new System.Drawing.Size(248, 23);
            txtFiltre.TabIndex = 7;
            toolTip1.SetToolTip(txtFiltre, "N'afficher que les films contenant le texte entré");
            txtFiltre.TextChanged += txtFiltre_TextChanged;
            txtFiltre.KeyDown += txtFiltre_KeyDown;
            // 
            // btnSnipDir
            // 
            btnSnipDir.Location = new System.Drawing.Point(272, 15);
            btnSnipDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSnipDir.Name = "btnSnipDir";
            btnSnipDir.Size = new System.Drawing.Size(30, 24);
            btnSnipDir.TabIndex = 11;
            btnSnipDir.Text = "X";
            toolTip1.SetToolTip(btnSnipDir, "Supprimer le répertoire");
            btnSnipDir.UseVisualStyleBackColor = true;
            btnSnipDir.Click += btnSnipDir_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new System.Drawing.Point(285, 50);
            btnFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new System.Drawing.Size(55, 23);
            btnFilter.TabIndex = 8;
            btnFilter.Text = "Filtrer";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // directoryDDList
            // 
            directoryDDList.FormattingEnabled = true;
            directoryDDList.Location = new System.Drawing.Point(16, 15);
            directoryDDList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            directoryDDList.Name = "directoryDDList";
            directoryDDList.Size = new System.Drawing.Size(212, 23);
            directoryDDList.TabIndex = 9;
            directoryDDList.SelectedIndexChanged += directoryDDList_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new System.Drawing.Size(1213, 633);
            Controls.Add(btnSnipDir);
            Controls.Add(directoryDDList);
            Controls.Add(btnFilter);
            Controls.Add(txtFiltre);
            Controls.Add(btnBrowse);
            Controls.Add(panel1);
            Controls.Add(ListeFilms);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "WhatsThisFilm?";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelFilm.ResumeLayout(false);
            panelFilm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.LinkLabel lnklblAllocine;
        private System.Windows.Forms.Label label9;
    }
}

