using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Info_societe : Form
    {
        BindingSource bsC;

        public Info_societe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Info_societe_Load(object sender, EventArgs e)
        {
            bsC = Db.remplirText("Select * from societe", "societe");



        
         // id.DataBindings.Add("text", bsC, "idS");

            text_nomS.DataBindings.Add("text", bsC, "nom_societe");
            txet_Adre.DataBindings.Add("text", bsC, "Adress__societe");
            txet_ville.DataBindings.Add("text", bsC, "ville_societe");
            text_tele.DataBindings.Add("text", bsC, "tele");
            text_Emil.DataBindings.Add("text", bsC, "email");
            text_wibsite.DataBindings.Add("text", bsC, "website");
            text_Code_Postal.DataBindings.Add("text", bsC, "Code_postal");
            text_Region.DataBindings.Add("text", bsC, "region_societe");













        }

        private void btn_ValiderE_Click(object sender, EventArgs e)
        {

        }

        private void btn_AnnulerE_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_AnnulerE_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ValiderE_Click_1(object sender, EventArgs e)
        {
            if (text_nomS.Text == "")
            {
                string t1 = "Nom societe renseigné";
                Msg_Verifier v = new Msg_Verifier(t1);
                v.ShowDialog();

                text_nomS.Focus();
                return;
            }




            if (txet_Adre.Text == "")
            {
                string t2 = "Adress societe non renseigné";
                Msg_Verifier v = new Msg_Verifier(t2);
                v.ShowDialog();

                txet_Adre.Focus();
                return;
            }










            if (text_Emil.Text == "")
            {
                string t4 = "Email   non renseigné";
                Msg_Verifier v = new Msg_Verifier(t4);
                v.ShowDialog();

                text_Emil.Focus();
                return;
            }

            if (text_tele.Text == "")
            {
                string t6 = "tele non renseigné";
                Msg_Verifier v = new Msg_Verifier(t6);
                v.ShowDialog();

                text_tele.Focus();
                return;
            }

            if (txet_ville.Text == "")
            {
                string t9 = " ville   non renseigné";

                Msg_Verifier v = new Msg_Verifier(t9);
                v.ShowDialog();

                txet_ville.Focus();
                return;
            }
            if (text_Code_Postal.Text =="")
            {
                string t10 = " Code postal  non renseigné";

                Msg_Verifier v = new Msg_Verifier(t10);
                v.ShowDialog();

                text_Code_Postal.Focus();
                return;
            }
            if (text_Region.Text == "")
            {
                string t11 = "Region      non renseigné";

                Msg_Verifier v = new Msg_Verifier(t11);
                v.ShowDialog();

                text_Region.Focus();
                return;
            }

           

            try
            {

                bsC.EndEdit();
                bsC.CancelEdit();

                Db.syncroniser("societe");
                btn_ValiderE.Enabled = false;
                groupBox1.Enabled = false;


                string actions = "Processus Ajouté";
                string smss = "Il a ajouté avec succès";

                Msg_Ajouter f = new Msg_Ajouter(actions, smss);
                f.Show();

            }
            catch (Exception ex)
            {
               
                
                    MessageBox.Show(ex.Message);
            }
        }
    }
}
