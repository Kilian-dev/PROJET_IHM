namespace PROJETKR_2
{
    partial class C_CADRE
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C_CADRE));
            this.Liste_Box = new System.Windows.Forms.ListBox();
            this.Bouton_Ajouter = new System.Windows.Forms.Button();
            this.Bouton_Supprimer = new System.Windows.Forms.Button();
            this.Bouton_MAJ = new System.Windows.Forms.Button();
            this.Bouton_Sauvegarder = new System.Windows.Forms.Button();
            this.Text_Box_ID = new System.Windows.Forms.TextBox();
            this.Text_Box_Type = new System.Windows.Forms.TextBox();
            this.Text_Box_Couleur = new System.Windows.Forms.TextBox();
            this.Text_Box_Nom = new System.Windows.Forms.TextBox();
            this.Text_Box_Id_Groupe = new System.Windows.Forms.TextBox();
            this.Label_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Text_Box_Id_Ajouter = new System.Windows.Forms.TextBox();
            this.Text_Box_Type_Ajouter = new System.Windows.Forms.TextBox();
            this.Text_Box_Nom_Ajouter = new System.Windows.Forms.TextBox();
            this.Text_Box_Id_Groupe_Ajouter = new System.Windows.Forms.TextBox();
            this.Text_Box_Couleur_Ajouter = new System.Windows.Forms.TextBox();
            this.Label_Lecture = new System.Windows.Forms.Label();
            this.Label_Creation = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Check_Box_Ecriture = new System.Windows.Forms.CheckBox();
            this.Menu_Principal = new System.Windows.Forms.MenuStrip();
            this.Menu_Fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Ouvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.Ouvrir_Fichier = new System.Windows.Forms.FolderBrowserDialog();
            this.Text_Box_Fichier = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Menu_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Liste_Box
            // 
            this.Liste_Box.FormattingEnabled = true;
            this.Liste_Box.ItemHeight = 17;
            this.Liste_Box.Location = new System.Drawing.Point(37, 60);
            this.Liste_Box.Name = "Liste_Box";
            this.Liste_Box.Size = new System.Drawing.Size(212, 327);
            this.Liste_Box.TabIndex = 0;
            this.Liste_Box.SelectedIndexChanged += new System.EventHandler(this.Liste_Box_SelectedIndexChanged);
            // 
            // Bouton_Ajouter
            // 
            this.Bouton_Ajouter.Location = new System.Drawing.Point(616, 311);
            this.Bouton_Ajouter.Name = "Bouton_Ajouter";
            this.Bouton_Ajouter.Size = new System.Drawing.Size(119, 38);
            this.Bouton_Ajouter.TabIndex = 1;
            this.Bouton_Ajouter.Text = "Ajouter";
            this.Bouton_Ajouter.UseVisualStyleBackColor = true;
            this.Bouton_Ajouter.Click += new System.EventHandler(this.Bouton_Ajouter_Click);
            // 
            // Bouton_Supprimer
            // 
            this.Bouton_Supprimer.Location = new System.Drawing.Point(168, 411);
            this.Bouton_Supprimer.Name = "Bouton_Supprimer";
            this.Bouton_Supprimer.Size = new System.Drawing.Size(110, 39);
            this.Bouton_Supprimer.TabIndex = 2;
            this.Bouton_Supprimer.Text = "Supprimer";
            this.Bouton_Supprimer.UseVisualStyleBackColor = true;
            this.Bouton_Supprimer.Click += new System.EventHandler(this.Bouton_Supprimer_Click);
            // 
            // Bouton_MAJ
            // 
            this.Bouton_MAJ.Location = new System.Drawing.Point(367, 311);
            this.Bouton_MAJ.Name = "Bouton_MAJ";
            this.Bouton_MAJ.Size = new System.Drawing.Size(119, 38);
            this.Bouton_MAJ.TabIndex = 2;
            this.Bouton_MAJ.Text = "Mise à jour";
            this.Bouton_MAJ.UseVisualStyleBackColor = true;
            this.Bouton_MAJ.Click += new System.EventHandler(this.Bouton_MAJ_Click);
            // 
            // Bouton_Sauvegarder
            // 
            this.Bouton_Sauvegarder.Enabled = false;
            this.Bouton_Sauvegarder.Location = new System.Drawing.Point(21, 411);
            this.Bouton_Sauvegarder.Name = "Bouton_Sauvegarder";
            this.Bouton_Sauvegarder.Size = new System.Drawing.Size(110, 39);
            this.Bouton_Sauvegarder.TabIndex = 2;
            this.Bouton_Sauvegarder.Text = "Sauvegarder";
            this.Bouton_Sauvegarder.UseVisualStyleBackColor = true;
            this.Bouton_Sauvegarder.Click += new System.EventHandler(this.Bouton_Sauvegarder_Click);
            // 
            // Text_Box_ID
            // 
            this.Text_Box_ID.Location = new System.Drawing.Point(367, 151);
            this.Text_Box_ID.Name = "Text_Box_ID";
            this.Text_Box_ID.ReadOnly = true;
            this.Text_Box_ID.Size = new System.Drawing.Size(119, 23);
            this.Text_Box_ID.TabIndex = 4;
            // 
            // Text_Box_Type
            // 
            this.Text_Box_Type.Location = new System.Drawing.Point(367, 181);
            this.Text_Box_Type.Name = "Text_Box_Type";
            this.Text_Box_Type.ReadOnly = true;
            this.Text_Box_Type.Size = new System.Drawing.Size(119, 23);
            this.Text_Box_Type.TabIndex = 4;
            // 
            // Text_Box_Couleur
            // 
            this.Text_Box_Couleur.Location = new System.Drawing.Point(367, 210);
            this.Text_Box_Couleur.Name = "Text_Box_Couleur";
            this.Text_Box_Couleur.ReadOnly = true;
            this.Text_Box_Couleur.Size = new System.Drawing.Size(119, 23);
            this.Text_Box_Couleur.TabIndex = 4;
            // 
            // Text_Box_Nom
            // 
            this.Text_Box_Nom.Location = new System.Drawing.Point(367, 240);
            this.Text_Box_Nom.Name = "Text_Box_Nom";
            this.Text_Box_Nom.ReadOnly = true;
            this.Text_Box_Nom.Size = new System.Drawing.Size(119, 23);
            this.Text_Box_Nom.TabIndex = 4;
            // 
            // Text_Box_Id_Groupe
            // 
            this.Text_Box_Id_Groupe.Location = new System.Drawing.Point(367, 270);
            this.Text_Box_Id_Groupe.Name = "Text_Box_Id_Groupe";
            this.Text_Box_Id_Groupe.ReadOnly = true;
            this.Text_Box_Id_Groupe.Size = new System.Drawing.Size(119, 23);
            this.Text_Box_Id_Groupe.TabIndex = 4;
            // 
            // Label_ID
            // 
            this.Label_ID.AutoSize = true;
            this.Label_ID.Location = new System.Drawing.Point(281, 156);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(29, 17);
            this.Label_ID.TabIndex = 5;
            this.Label_ID.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Couleur :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID Groupe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(42, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Liste des ID:";
            // 
            // Text_Box_Id_Ajouter
            // 
            this.Text_Box_Id_Ajouter.Location = new System.Drawing.Point(616, 151);
            this.Text_Box_Id_Ajouter.Name = "Text_Box_Id_Ajouter";
            this.Text_Box_Id_Ajouter.ReadOnly = true;
            this.Text_Box_Id_Ajouter.Size = new System.Drawing.Size(119, 23);
            this.Text_Box_Id_Ajouter.TabIndex = 4;
            // 
            // Text_Box_Type_Ajouter
            // 
            this.Text_Box_Type_Ajouter.Location = new System.Drawing.Point(616, 181);
            this.Text_Box_Type_Ajouter.Name = "Text_Box_Type_Ajouter";
            this.Text_Box_Type_Ajouter.Size = new System.Drawing.Size(119, 23);
            this.Text_Box_Type_Ajouter.TabIndex = 4;
            // 
            // Text_Box_Nom_Ajouter
            // 
            this.Text_Box_Nom_Ajouter.Location = new System.Drawing.Point(616, 240);
            this.Text_Box_Nom_Ajouter.Name = "Text_Box_Nom_Ajouter";
            this.Text_Box_Nom_Ajouter.Size = new System.Drawing.Size(119, 23);
            this.Text_Box_Nom_Ajouter.TabIndex = 4;
            // 
            // Text_Box_Id_Groupe_Ajouter
            // 
            this.Text_Box_Id_Groupe_Ajouter.Location = new System.Drawing.Point(616, 270);
            this.Text_Box_Id_Groupe_Ajouter.Name = "Text_Box_Id_Groupe_Ajouter";
            this.Text_Box_Id_Groupe_Ajouter.Size = new System.Drawing.Size(119, 23);
            this.Text_Box_Id_Groupe_Ajouter.TabIndex = 4;
            // 
            // Text_Box_Couleur_Ajouter
            // 
            this.Text_Box_Couleur_Ajouter.Location = new System.Drawing.Point(616, 210);
            this.Text_Box_Couleur_Ajouter.Name = "Text_Box_Couleur_Ajouter";
            this.Text_Box_Couleur_Ajouter.Size = new System.Drawing.Size(119, 23);
            this.Text_Box_Couleur_Ajouter.TabIndex = 4;
            // 
            // Label_Lecture
            // 
            this.Label_Lecture.AutoSize = true;
            this.Label_Lecture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_Lecture.Location = new System.Drawing.Point(401, 108);
            this.Label_Lecture.Name = "Label_Lecture";
            this.Label_Lecture.Size = new System.Drawing.Size(66, 20);
            this.Label_Lecture.TabIndex = 7;
            this.Label_Lecture.Text = "Lecture";
            // 
            // Label_Creation
            // 
            this.Label_Creation.AutoSize = true;
            this.Label_Creation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_Creation.Location = new System.Drawing.Point(642, 107);
            this.Label_Creation.Name = "Label_Creation";
            this.Label_Creation.Size = new System.Drawing.Size(72, 20);
            this.Label_Creation.TabIndex = 8;
            this.Label_Creation.Text = "Création";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(529, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(529, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Type :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(529, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Couleur :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(529, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nom :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(529, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "ID Groupe :";
            // 
            // Check_Box_Ecriture
            // 
            this.Check_Box_Ecriture.AutoSize = true;
            this.Check_Box_Ecriture.Location = new System.Drawing.Point(366, 368);
            this.Check_Box_Ecriture.Name = "Check_Box_Ecriture";
            this.Check_Box_Ecriture.Size = new System.Drawing.Size(120, 21);
            this.Check_Box_Ecriture.TabIndex = 9;
            this.Check_Box_Ecriture.Text = "Accès écriture";
            this.Check_Box_Ecriture.UseVisualStyleBackColor = true;
            this.Check_Box_Ecriture.CheckedChanged += new System.EventHandler(this.Check_Box_Ecriture_CheckedChanged);
            // 
            // Menu_Principal
            // 
            this.Menu_Principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Fichier});
            this.Menu_Principal.Location = new System.Drawing.Point(0, 0);
            this.Menu_Principal.Name = "Menu_Principal";
            this.Menu_Principal.Size = new System.Drawing.Size(1119, 28);
            this.Menu_Principal.TabIndex = 10;
            this.Menu_Principal.Text = "menuStrip1";
            // 
            // Menu_Fichier
            // 
            this.Menu_Fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Ouvrir,
            this.toolStripMenuItem1,
            this.Menu_Quitter});
            this.Menu_Fichier.Name = "Menu_Fichier";
            this.Menu_Fichier.Size = new System.Drawing.Size(64, 24);
            this.Menu_Fichier.Text = "&Fichier";
            this.Menu_Fichier.Click += new System.EventHandler(this.ficherToolStripMenuItem_Click);
            // 
            // Menu_Ouvrir
            // 
            this.Menu_Ouvrir.Name = "Menu_Ouvrir";
            this.Menu_Ouvrir.Size = new System.Drawing.Size(216, 26);
            this.Menu_Ouvrir.Text = "&Ouvrir";
            this.Menu_Ouvrir.Click += new System.EventHandler(this.Ouvrir_Fichier_Menu);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 6);
            // 
            // Menu_Quitter
            // 
            this.Menu_Quitter.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Menu_Quitter.Name = "Menu_Quitter";
            this.Menu_Quitter.Size = new System.Drawing.Size(216, 26);
            this.Menu_Quitter.Text = "&Quitter";
            this.Menu_Quitter.Click += new System.EventHandler(this.Menu_Quitter_Click);
            // 
            // Text_Box_Fichier
            // 
            this.Text_Box_Fichier.Location = new System.Drawing.Point(861, 104);
            this.Text_Box_Fichier.Name = "Text_Box_Fichier";
            this.Text_Box_Fichier.Size = new System.Drawing.Size(107, 23);
            this.Text_Box_Fichier.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(857, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Fichier Json :";
            // 
            // C_CADRE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 478);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Text_Box_Fichier);
            this.Controls.Add(this.Check_Box_Ecriture);
            this.Controls.Add(this.Label_Creation);
            this.Controls.Add(this.Label_Lecture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Label_ID);
            this.Controls.Add(this.Text_Box_Id_Groupe_Ajouter);
            this.Controls.Add(this.Text_Box_Id_Groupe);
            this.Controls.Add(this.Text_Box_Nom_Ajouter);
            this.Controls.Add(this.Text_Box_Nom);
            this.Controls.Add(this.Text_Box_Couleur_Ajouter);
            this.Controls.Add(this.Text_Box_Couleur);
            this.Controls.Add(this.Text_Box_Type_Ajouter);
            this.Controls.Add(this.Text_Box_Type);
            this.Controls.Add(this.Text_Box_Id_Ajouter);
            this.Controls.Add(this.Text_Box_ID);
            this.Controls.Add(this.Bouton_Sauvegarder);
            this.Controls.Add(this.Bouton_MAJ);
            this.Controls.Add(this.Bouton_Supprimer);
            this.Controls.Add(this.Bouton_Ajouter);
            this.Controls.Add(this.Liste_Box);
            this.Controls.Add(this.Menu_Principal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu_Principal;
            this.Name = "C_CADRE";
            this.Text = "IHM USER";
            this.Menu_Principal.ResumeLayout(false);
            this.Menu_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Liste_Box;
        private System.Windows.Forms.Button Bouton_Ajouter;
        private System.Windows.Forms.Button Bouton_Supprimer;
        private System.Windows.Forms.Button Bouton_MAJ;
        private System.Windows.Forms.Button Bouton_Sauvegarder;
        private System.Windows.Forms.TextBox Text_Box_ID;
        private System.Windows.Forms.TextBox Text_Box_Type;
        private System.Windows.Forms.TextBox Text_Box_Couleur;
        private System.Windows.Forms.TextBox Text_Box_Nom;
        private System.Windows.Forms.TextBox Text_Box_Id_Groupe;
        private System.Windows.Forms.Label Label_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Text_Box_Id_Ajouter;
        private System.Windows.Forms.TextBox Text_Box_Type_Ajouter;
        private System.Windows.Forms.TextBox Text_Box_Nom_Ajouter;
        private System.Windows.Forms.TextBox Text_Box_Id_Groupe_Ajouter;
        private System.Windows.Forms.TextBox Text_Box_Couleur_Ajouter;
        private System.Windows.Forms.Label Label_Lecture;
        private System.Windows.Forms.Label Label_Creation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox Check_Box_Ecriture;
        private System.Windows.Forms.MenuStrip Menu_Principal;
        private System.Windows.Forms.ToolStripMenuItem Menu_Fichier;
        private System.Windows.Forms.ToolStripMenuItem Menu_Ouvrir;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Quitter;
        private System.Windows.Forms.FolderBrowserDialog Ouvrir_Fichier;
        private System.Windows.Forms.TextBox Text_Box_Fichier;
        private System.Windows.Forms.Label label11;
    }
}

