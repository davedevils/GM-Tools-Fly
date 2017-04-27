namespace GM_Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.mess = new System.Windows.Forms.GroupBox();
            this.messtxt = new System.Windows.Forms.TextBox();
            this.messsend = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.gen.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.mess.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(806, 470);
            this.tabControl1.TabIndex = 0;
            // 
            // gen
            // 
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
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // françaisToolStripMenuItem
            // 
            this.françaisToolStripMenuItem.Name = "françaisToolStripMenuItem";
            this.françaisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.françaisToolStripMenuItem.Text = "Français";
            // 
            // anglaisToolStripMenuItem
            // 
            this.anglaisToolStripMenuItem.Name = "anglaisToolStripMenuItem";
            this.anglaisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.anglaisToolStripMenuItem.Text = "Anglais";
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
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

