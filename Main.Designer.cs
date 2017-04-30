namespace GM_Tools
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.gen = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hourmute = new System.Windows.Forms.TextBox();
            this.mute = new System.Windows.Forms.Button();
            this.mouvstart = new System.Windows.Forms.Button();
            this.mouvstop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playername = new System.Windows.Forms.TextBox();
            this.mess = new System.Windows.Forms.GroupBox();
            this.messsend = new System.Windows.Forms.Button();
            this.messtxt = new System.Windows.Forms.TextBox();
            this.itm = new System.Windows.Forms.TabPage();
            this.mon = new System.Windows.Forms.TabPage();
            this.GG = new System.Windows.Forms.TabPage();
            this.fam = new System.Windows.Forms.TabPage();
            this.stat = new System.Windows.Forms.TabPage();
            this.other = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.miseÀJourParLesRESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.françaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anglaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copy = new System.Windows.Forms.Button();
            this.resultbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ud = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.penyaqt = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.gen.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.mess.SuspendLayout();
            this.stat.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.gen);
            this.tabControl1.Controls.Add(this.itm);
            this.tabControl1.Controls.Add(this.mon);
            this.tabControl1.Controls.Add(this.GG);
            this.tabControl1.Controls.Add(this.fam);
            this.tabControl1.Controls.Add(this.stat);
            this.tabControl1.Controls.Add(this.other);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(806, 470);
            this.tabControl1.TabIndex = 0;
            // 
            // gen
            // 
            this.gen.Controls.Add(this.groupBox1);
            this.gen.Controls.Add(this.mess);
            this.gen.Location = new System.Drawing.Point(4, 22);
            this.gen.Name = "gen";
            this.gen.Padding = new System.Windows.Forms.Padding(3);
            this.gen.Size = new System.Drawing.Size(798, 444);
            this.gen.TabIndex = 0;
            this.gen.Text = "Général";
            this.gen.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.hourmute);
            this.groupBox1.Controls.Add(this.mute);
            this.groupBox1.Controls.Add(this.mouvstart);
            this.groupBox1.Controls.Add(this.mouvstop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.playername);
            this.groupBox1.Location = new System.Drawing.Point(8, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 355);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion Joueur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre d\'heure";
            // 
            // hourmute
            // 
            this.hourmute.Location = new System.Drawing.Point(39, 302);
            this.hourmute.Name = "hourmute";
            this.hourmute.Size = new System.Drawing.Size(115, 20);
            this.hourmute.TabIndex = 8;
            this.hourmute.Text = "1";
            this.hourmute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mute
            // 
            this.mute.Location = new System.Drawing.Point(21, 325);
            this.mute.Name = "mute";
            this.mute.Size = new System.Drawing.Size(146, 27);
            this.mute.TabIndex = 7;
            this.mute.Text = "Interdiction de parler";
            this.mute.UseVisualStyleBackColor = true;
            this.mute.Click += new System.EventHandler(this.mute_Click);
            // 
            // mouvstart
            // 
            this.mouvstart.Location = new System.Drawing.Point(21, 103);
            this.mouvstart.Name = "mouvstart";
            this.mouvstart.Size = new System.Drawing.Size(146, 27);
            this.mouvstart.TabIndex = 6;
            this.mouvstart.Text = "Débloquer Mouvement";
            this.mouvstart.UseVisualStyleBackColor = true;
            this.mouvstart.Click += new System.EventHandler(this.mouvstart_Click);
            // 
            // mouvstop
            // 
            this.mouvstop.Location = new System.Drawing.Point(21, 70);
            this.mouvstop.Name = "mouvstop";
            this.mouvstop.Size = new System.Drawing.Size(146, 27);
            this.mouvstop.TabIndex = 5;
            this.mouvstop.Text = "Bloquer Mouvement";
            this.mouvstop.UseVisualStyleBackColor = true;
            this.mouvstop.Click += new System.EventHandler(this.mouvstop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom du Joueur";
            // 
            // playername
            // 
            this.playername.Location = new System.Drawing.Point(6, 44);
            this.playername.Name = "playername";
            this.playername.Size = new System.Drawing.Size(180, 20);
            this.playername.TabIndex = 4;
            this.playername.Text = "NomDuPersonnage";
            this.playername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mess
            // 
            this.mess.Controls.Add(this.messsend);
            this.mess.Controls.Add(this.messtxt);
            this.mess.Location = new System.Drawing.Point(8, 6);
            this.mess.Name = "mess";
            this.mess.Size = new System.Drawing.Size(609, 74);
            this.mess.TabIndex = 0;
            this.mess.TabStop = false;
            this.mess.Text = "Message Collectif";
            // 
            // messsend
            // 
            this.messsend.Location = new System.Drawing.Point(253, 45);
            this.messsend.Name = "messsend";
            this.messsend.Size = new System.Drawing.Size(109, 23);
            this.messsend.TabIndex = 1;
            this.messsend.Text = "Crée message";
            this.messsend.UseVisualStyleBackColor = true;
            this.messsend.Click += new System.EventHandler(this.messsend_Click);
            // 
            // messtxt
            // 
            this.messtxt.Location = new System.Drawing.Point(6, 19);
            this.messtxt.Name = "messtxt";
            this.messtxt.Size = new System.Drawing.Size(597, 20);
            this.messtxt.TabIndex = 0;
            this.messtxt.Text = "Bonjour et bienvenue sur le serveur !";
            // 
            // itm
            // 
            this.itm.Location = new System.Drawing.Point(4, 22);
            this.itm.Name = "itm";
            this.itm.Padding = new System.Windows.Forms.Padding(3);
            this.itm.Size = new System.Drawing.Size(798, 444);
            this.itm.TabIndex = 1;
            this.itm.Text = "Items";
            this.itm.UseVisualStyleBackColor = true;
            // 
            // mon
            // 
            this.mon.Location = new System.Drawing.Point(4, 22);
            this.mon.Name = "mon";
            this.mon.Size = new System.Drawing.Size(798, 444);
            this.mon.TabIndex = 5;
            this.mon.Text = "Monstre";
            this.mon.UseVisualStyleBackColor = true;
            // 
            // GG
            // 
            this.GG.Location = new System.Drawing.Point(4, 22);
            this.GG.Name = "GG";
            this.GG.Size = new System.Drawing.Size(798, 444);
            this.GG.TabIndex = 2;
            this.GG.Text = "Guilde & Groupe";
            this.GG.UseVisualStyleBackColor = true;
            // 
            // fam
            // 
            this.fam.Location = new System.Drawing.Point(4, 22);
            this.fam.Name = "fam";
            this.fam.Size = new System.Drawing.Size(798, 444);
            this.fam.TabIndex = 3;
            this.fam.Text = "Familier";
            this.fam.UseVisualStyleBackColor = true;
            // 
            // stat
            // 
            this.stat.Controls.Add(this.groupBox3);
            this.stat.Controls.Add(this.groupBox2);
            this.stat.Location = new System.Drawing.Point(4, 22);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(798, 444);
            this.stat.TabIndex = 4;
            this.stat.Text = "Statut GM";
            this.stat.UseVisualStyleBackColor = true;
            // 
            // other
            // 
            this.other.Location = new System.Drawing.Point(4, 22);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(798, 444);
            this.other.TabIndex = 6;
            this.other.Text = "Autre";
            this.other.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.languageToolStripMenuItem,
            this.creditToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miseÀJourParLesRESToolStripMenuItem,
            this.toolStripSeparator1,
            this.aideToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Fichier";
            // 
            // miseÀJourParLesRESToolStripMenuItem
            // 
            this.miseÀJourParLesRESToolStripMenuItem.Name = "miseÀJourParLesRESToolStripMenuItem";
            this.miseÀJourParLesRESToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.miseÀJourParLesRESToolStripMenuItem.Text = "Mise à Jour par les .RES";
            this.miseÀJourParLesRESToolStripMenuItem.Click += new System.EventHandler(this.miseÀJourParLesRESToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.françaisToolStripMenuItem,
            this.anglaisToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // françaisToolStripMenuItem
            // 
            this.françaisToolStripMenuItem.Name = "françaisToolStripMenuItem";
            this.françaisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.françaisToolStripMenuItem.Text = "Français";
            this.françaisToolStripMenuItem.Click += new System.EventHandler(this.françaisToolStripMenuItem_Click);
            // 
            // anglaisToolStripMenuItem
            // 
            this.anglaisToolStripMenuItem.Name = "anglaisToolStripMenuItem";
            this.anglaisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.anglaisToolStripMenuItem.Text = "Anglais";
            this.anglaisToolStripMenuItem.Click += new System.EventHandler(this.anglaisToolStripMenuItem_Click);
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.creditToolStripMenuItem.Text = "Credit";
            this.creditToolStripMenuItem.Click += new System.EventHandler(this.creditToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // copy
            // 
            this.copy.Location = new System.Drawing.Point(655, 507);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(146, 27);
            this.copy.TabIndex = 2;
            this.copy.Text = "Copier la commande";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // resultbox
            // 
            this.resultbox.Location = new System.Drawing.Point(4, 510);
            this.resultbox.Name = "resultbox";
            this.resultbox.Size = new System.Drawing.Size(645, 20);
            this.resultbox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Se Téléportée vers lui";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "Le Téléporter vers vous";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 27);
            this.button3.TabIndex = 12;
            this.button3.Text = "Expulser le Joueur";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.ud);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 355);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestion De Son Personnage";
            // 
            // ud
            // 
            this.ud.Location = new System.Drawing.Point(18, 19);
            this.ud.Name = "ud";
            this.ud.Size = new System.Drawing.Size(146, 27);
            this.ud.TabIndex = 7;
            this.ud.Text = "Immortel (SANS PV)";
            this.ud.UseVisualStyleBackColor = true;
            this.ud.Click += new System.EventHandler(this.ud_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 27);
            this.button4.TabIndex = 8;
            this.button4.Text = "Immortel (AVEC PV)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 85);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 27);
            this.button5.TabIndex = 9;
            this.button5.Text = "Mortel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(18, 135);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(146, 27);
            this.button6.TabIndex = 10;
            this.button6.Text = "Invisible";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(18, 168);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(146, 27);
            this.button7.TabIndex = 11;
            this.button7.Text = "Visible";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.penyaqt);
            this.groupBox3.Location = new System.Drawing.Point(201, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(594, 46);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ajout de Penya";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(476, 16);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(109, 23);
            this.button8.TabIndex = 3;
            this.button8.Text = "Ajouter Penya";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // penyaqt
            // 
            this.penyaqt.Location = new System.Drawing.Point(6, 19);
            this.penyaqt.Name = "penyaqt";
            this.penyaqt.Size = new System.Drawing.Size(448, 20);
            this.penyaqt.TabIndex = 2;
            this.penyaqt.Text = "500";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 535);
            this.Controls.Add(this.resultbox);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(810, 562);
            this.MinimumSize = new System.Drawing.Size(810, 562);
            this.Name = "Main";
            this.Text = "Outils Maitre de Jeu - Flyff";
            this.tabControl1.ResumeLayout(false);
            this.gen.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mess.ResumeLayout(false);
            this.mess.PerformLayout();
            this.stat.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage gen;
        private System.Windows.Forms.TabPage itm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.TabPage GG;
        private System.Windows.Forms.TabPage fam;
        private System.Windows.Forms.TabPage stat;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.TextBox resultbox;
        private System.Windows.Forms.ToolStripMenuItem françaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anglaisToolStripMenuItem;
        private System.Windows.Forms.TabPage mon;
        private System.Windows.Forms.GroupBox mess;
        private System.Windows.Forms.Button messsend;
        private System.Windows.Forms.TextBox messtxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button mouvstart;
        private System.Windows.Forms.Button mouvstop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playername;
        private System.Windows.Forms.TabPage other;
        private System.Windows.Forms.TextBox hourmute;
        private System.Windows.Forms.Button mute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem miseÀJourParLesRESToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ud;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox penyaqt;
    }
}

