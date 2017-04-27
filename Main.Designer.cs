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
            this.itm = new System.Windows.Forms.TabPage();
            this.GG = new System.Windows.Forms.TabPage();
            this.fam = new System.Windows.Forms.TabPage();
            this.stat = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copy = new System.Windows.Forms.Button();
            this.resultbox = new System.Windows.Forms.TextBox();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.françaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anglaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mon = new System.Windows.Forms.TabPage();
            this.mess = new System.Windows.Forms.GroupBox();
            this.messtxt = new System.Windows.Forms.TextBox();
            this.messsend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.other = new System.Windows.Forms.TabPage();
            this.playername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mouvstop = new System.Windows.Forms.Button();
            this.mouvstart = new System.Windows.Forms.Button();
            this.mute = new System.Windows.Forms.Button();
            this.hourmute = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.miseÀJourParLesRESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1.SuspendLayout();
            this.gen.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.mess.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.stat.Location = new System.Drawing.Point(4, 22);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(798, 444);
            this.stat.TabIndex = 4;
            this.stat.Text = "Statut GM";
            this.stat.UseVisualStyleBackColor = true;
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
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.françaisToolStripMenuItem,
            this.anglaisToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.languageToolStripMenuItem.Text = "Language";
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
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.aideToolStripMenuItem.Text = "Aide";
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
            // mon
            // 
            this.mon.Location = new System.Drawing.Point(4, 22);
            this.mon.Name = "mon";
            this.mon.Size = new System.Drawing.Size(798, 444);
            this.mon.TabIndex = 5;
            this.mon.Text = "Monstre";
            this.mon.UseVisualStyleBackColor = true;
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
            // messtxt
            // 
            this.messtxt.Location = new System.Drawing.Point(6, 19);
            this.messtxt.Name = "messtxt";
            this.messtxt.Size = new System.Drawing.Size(597, 20);
            this.messtxt.TabIndex = 0;
            this.messtxt.Text = "Bonjour et bienvenue sur le serveur !";
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
            // groupBox1
            // 
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
            // other
            // 
            this.other.Location = new System.Drawing.Point(4, 22);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(798, 444);
            this.other.TabIndex = 6;
            this.other.Text = "Autre";
            this.other.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom du Joueur";
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
            // mute
            // 
            this.mute.Location = new System.Drawing.Point(21, 184);
            this.mute.Name = "mute";
            this.mute.Size = new System.Drawing.Size(146, 27);
            this.mute.TabIndex = 7;
            this.mute.Text = "Interdiction de parler";
            this.mute.UseVisualStyleBackColor = true;
            this.mute.Click += new System.EventHandler(this.mute_Click);
            // 
            // hourmute
            // 
            this.hourmute.Location = new System.Drawing.Point(38, 158);
            this.hourmute.Name = "hourmute";
            this.hourmute.Size = new System.Drawing.Size(115, 20);
            this.hourmute.TabIndex = 8;
            this.hourmute.Text = "1";
            this.hourmute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre d\'heure";
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
            // Form1
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
            this.Name = "Form1";
            this.Text = "Outils Maitre de Jeu - Flyff";
            this.tabControl1.ResumeLayout(false);
            this.gen.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mess.ResumeLayout(false);
            this.mess.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

