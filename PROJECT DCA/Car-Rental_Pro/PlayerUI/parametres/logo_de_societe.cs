using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class logo_de_societe : Form
    {
        BindingSource bsC;

        public logo_de_societe()
        {
            InitializeComponent();
        }

        private void logo_de_societe_Load(object sender, EventArgs e)
        {
            bsC = Db.remplirText("Select * from societe", "societe");

            text_img.DataBindings.Add("text", bsC, "photo_societe");





        }

        private void text_img_TextChanged(object sender, EventArgs e)
        {
            string photo = text_img.Text == "" ? "vide.png" : text_img.Text;

            picture_Logo.Load("imagesV/" + photo);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            string nomFichier = openFileDialog1.FileName;
            string ext = Path.GetExtension(nomFichier);

            Random n = new Random();
            long i = n.Next();

            string d = DateTime.Now.ToString().Replace("/", "").Replace(" ", "").Replace(":", "");
            File.Copy(nomFichier, "imagesV/" + d + i + ext);
            text_img.Text = d + i + ext;




        }

        private void btn_ValiderE_Click(object sender, EventArgs e)
        {
            bsC.EndEdit();
            bsC.CancelEdit();

            Db.syncroniser("societe");
            btn_ValiderE.Enabled = false;
            picture_Logo.Enabled = false;
            btn_ValiderE.Enabled = false;


            string actions = "Processus Enregistré";
            string smss = "Il a Enregistré avec succès";

            Msg_Ajouter f = new Msg_Ajouter(actions, smss);
            f.ShowDialog();
            
        
        }

        private void picture_Logo_MouseEnter(object sender, EventArgs e)
        {
          

        }

        private void picture_Logo_Click(object sender, EventArgs e)
        {

        }

        private void picture_Logo_MouseClick(object sender, MouseEventArgs e)
        {
            openFileDialog1.ShowDialog();

        }
    }
}
