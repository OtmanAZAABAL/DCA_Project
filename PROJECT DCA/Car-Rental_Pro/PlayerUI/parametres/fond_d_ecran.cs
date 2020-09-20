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
    public partial class fond_d_ecran : Form
    {
        BindingSource bc_E;
        public fond_d_ecran()
        {
            InitializeComponent();
        }

        private void btn_AnnulerE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fond_d_ecran_Load(object sender, EventArgs e)
        {
            bc_E = Db.remplirText("Select * from Parametres", "Parametres");

            text_img.DataBindings.Add("text", bc_E, "fond_d_ecran");

       
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string nomFichier = openFileDialog1.FileName;
            string ext = Path.GetExtension(nomFichier);

            Random n = new Random();
            long i = n.Next();

            string d = DateTime.Now.ToString().Replace("/", "").Replace(" ", "").Replace(":", "");
            File.Copy(nomFichier, "imagesE/" + d + i + ext);
            text_img.Text = d + i + ext;
        }

        private void picture_Ecran_Click(object sender, EventArgs e)
        {








        }

        private void picture_Ecran_MouseClick(object sender, MouseEventArgs e)
        {
            openFileDialog1.ShowDialog();
          
        }

        private void text_img_TextChanged(object sender, EventArgs e)
        {
            string photo = text_img.Text == "" ? "vide.png" : text_img.Text;

            picture_Ecran.Load("imagesE/" + photo);
        }

        private void btn_ValiderE_Click(object sender, EventArgs e)
        {

            bc_E.EndEdit();
            bc_E.CancelEdit();
                Db.syncroniser("Parametres");
                btn_ValiderE.Enabled = false;
                picture_Ecran.Enabled = false;
                btn_ValiderE.Enabled = false;


                string actions = "Processus Enregistré";
                string smss = "Il a Enregistré avec succès";

                Msg_Ajouter f = new Msg_Ajouter(actions, smss);
                f.Show();

         
        }
    }
}
