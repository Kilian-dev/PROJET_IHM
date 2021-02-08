using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace PROJETKR_2
{
    public partial class C_CADRE : Form
    {
        
        C_BASE Base = new C_BASE();



        public C_CADRE()
        {
            InitializeComponent();
            Base.Charge_Toi();
            C_BASE.nbr_id = Base.Les_Users.Count()+ 1;
            Text_Box_Id_Ajouter.Text = C_BASE.nbr_id.ToString();
            Liste_Box.DataSource = Base.Les_Users;
            Liste_Box.DisplayMember = "ID";
            if (Text_Box_Id_Groupe_Ajouter.Text.All(char.IsDigit) == false) { MessageBox.Show("Veuillez rentré une valeur conforme"); };
        }

        private void Bouton_Sauvegarder_Click(object sender, EventArgs e)
        {
            Base.Sauvegarde_Toi();
            Bouton_Sauvegarder.Enabled = false;
        }

        private void Bouton_Supprimer_Click(object sender, EventArgs e)
        {
            C_USER User_Remove = (C_USER)Liste_Box.SelectedItem;
            if (User_Remove != null)
            {
                Base.Les_Users.Remove(User_Remove);
                Bouton_Sauvegarder.Enabled = true;

            }
        }

        private void Bouton_Ajouter_Click(object sender, EventArgs e)
        {
            C_USER Nouveau_Utilisateur = new C_USER();
            Nouveau_Utilisateur.Nom = Text_Box_Nom_Ajouter.Text;
            Nouveau_Utilisateur.Type = Text_Box_Type_Ajouter.Text;
            Nouveau_Utilisateur.ID = Convert.ToInt32(Text_Box_Id_Ajouter.Text);
            Nouveau_Utilisateur.Couleur = Convert.ToInt32(Text_Box_Couleur_Ajouter.Text);
            Nouveau_Utilisateur.ID_Groupe = Convert.ToInt32(Text_Box_Id_Groupe_Ajouter.Text);
            Base.Les_Users.Add(Nouveau_Utilisateur);
            
            Bouton_Sauvegarder.Enabled = true;
            Text_Box_Nom_Ajouter.Clear();
            Text_Box_Type_Ajouter.Clear();
            Text_Box_Id_Ajouter.Clear();
            Text_Box_Couleur_Ajouter.Clear();
            Text_Box_Id_Groupe_Ajouter.Clear();
            C_BASE.nbr_id = Base.Les_Users.Count() + 1;
            Text_Box_Id_Ajouter.Text = C_BASE.nbr_id.ToString();
        }

        private void Bouton_MAJ_Click(object sender, EventArgs e)
        {
            C_USER User_Selectionne = Liste_Box.SelectedItem as C_USER;
            if (User_Selectionne != null)
            {
                User_Selectionne.Couleur = Convert.ToInt32(Text_Box_Couleur.Text);
                User_Selectionne.ID_Groupe = Convert.ToInt32(Text_Box_Id_Groupe.Text);
                Bouton_Sauvegarder.Enabled = true;
                Text_Box_Nom.ReadOnly = true;
                Text_Box_Couleur.ReadOnly = true;
                Text_Box_Id_Groupe.ReadOnly = true;
                Check_Box_Ecriture.Checked = false;
            }
        }

        private void Liste_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_USER User_Selectionne = Liste_Box.SelectedItem as C_USER;
            if (User_Selectionne != null)
            {
                Text_Box_Type.Text = User_Selectionne.Type;
                Text_Box_Nom.Text = User_Selectionne.Nom;
                Text_Box_ID.Text = User_Selectionne.ID.ToString();
                Text_Box_Couleur.Text = User_Selectionne.Couleur.ToString();
                Text_Box_Id_Groupe.Text = User_Selectionne.ID_Groupe.ToString();

            }
        }

        private void Check_Box_Ecriture_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_Box_Ecriture.Checked == true)
            {
                Text_Box_Nom.ReadOnly = false;
                Text_Box_Couleur.ReadOnly = false;
                Text_Box_Id_Groupe.ReadOnly = false;
            }
            else
            {
                Text_Box_Nom.ReadOnly = true;
                Text_Box_Couleur.ReadOnly = true;
                Text_Box_Id_Groupe.ReadOnly = true;
            }
        }

        private void ficherToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Menu_Quitter_Click(object sender, EventArgs e)
        {
            if (Bouton_Sauvegarder.Enabled == false)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Veuillez sauvegarder avant quitter.");
            }
        }

        private void Ouvrir_Fichier_Menu(object sender, EventArgs e)
        {
            Ouvrir_Fichier.ShowDialog();
        }
    }
}
