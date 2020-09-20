using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Add_Categorie_Voiture : Form
    {
        public Add_Categorie_Voiture(string action, string idClick)
        {
            InitializeComponent();
            this.action = action;

            this.idClick = idClick;
        }
        string action;
        string idClick;
      
        BindingSource bsC2;
        BindingSource bsC;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AnnulerE_Click(object sender, EventArgs e)
        {

            if (action == "add")
            {


                this.Close();




            }
            else if (action == "modifi")
            {



                this.Close();
                Db.syncroniser("Categorie_Voiture");



            }
        }
        public void bsDataBindings()
        {



            bsC = Db.remplirText("Select * from Categorie_Voiture", "Categorie_Voiture");



            text_N_C.DataBindings.Add("text", bsC, "Nom_Categorie");
            text_N_p.DataBindings.Add("text", bsC, "Nombre_Bagages");
            text_N_B.DataBindings.Add("text", bsC, "Nombre_Perssonne");
            text_Cout_Par_Jour.DataBindings.Add("text", bsC, "Cout_par_Jour");
            text_emailPar_Heur.DataBindings.Add("text", bsC, "Frois_Retard_par_Heur");





        }

        private void Add_Categorie_Voiture_Load(object sender, EventArgs e)
        {
            if (action == "add")
            {
                text_N_C.Focus();
                ActionF.Text = "AJOUTER";


                bsDataBindings();

                bsC.AddNew();



                text_N_C.Focus();



            }
            else if (action == "modifi")
            {

                ActionF.Text = "MODIFIER";


                bsC = Db.remplirText("Select * from Categorie_Voiture", "Categorie_Voiture");











                listBox1.DataSource = bsC;
                listBox1.ValueMember = "Nom_Categorie";
                listBox1.DisplayMember = "Nom_Categorie";



                listBox1.SelectedValue = idClick.ToString();








                text_N_C.DataBindings.Add("text", bsC, "Nom_Categorie");
                text_N_p.DataBindings.Add("text", bsC, "Nombre_Bagages");
                text_N_B.DataBindings.Add("text", bsC, "Nombre_Perssonne");
                text_Cout_Par_Jour.DataBindings.Add("text", bsC, "Cout_par_Jour");
                text_emailPar_Heur.DataBindings.Add("text", bsC, "Frois_Retard_par_Heur");






                text_N_C.Enabled = false;
                text_N_B.Focus();
            }
        }

        private void btn_ValiderE_Click(object sender, EventArgs e)
        {
            if (action == "add")
            {






                if (text_N_C.Text == "")
                {
                    string t2 = "Nom Categorie Id non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t2);
                    v.ShowDialog();

                    text_N_C.Focus();
                    return;
                }







                if (text_N_B.Text == "")
                {
                    string t3 = "Nombre bBagages   non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t3);
                    v.ShowDialog();

                    text_N_B.Focus();
                    return;
                }





                if (text_N_p.Text.ToString() == "")
                {
                    string t4 = " Nombre Perssonne  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t4);
                    v.ShowDialog();

                    text_N_p.Focus();
                    return;
                }



                if (text_Cout_Par_Jour.Text.ToString() == "")
                {
                    string t4 = " Cout Par Jour  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t4);
                    v.ShowDialog();

                    text_Cout_Par_Jour.Focus();
                    return;
                }
                if (text_emailPar_Heur.Text.ToString() == "")
                {
                    string t4 = " Frois Retard par Heur  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t4);
                    v.ShowDialog();

                    text_emailPar_Heur.Focus();
                    return;
                }
               
                try
                {

                    bsC.EndEdit();

                    Db.syncroniser("Categorie_Voiture");
                    btn_ValiderE.Enabled = false;
                    groupBox1.Enabled = false;



                    string actions = "Processus Ajouté";
                    string smss = "Il a ajouté  avec succès";

                    Msg_Ajouter lk = new Msg_Ajouter(actions, smss);
                    lk.Show();


                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Violation of PRIMARY KEY constraint"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Cet identifiant existe déjà");
                        m.ShowDialog();
                        text_N_C.Clear();
                        text_N_C.Focus();
                    }
                    else
                        MessageBox.Show(ex.Message);
                }


















            }
            else if (action == "modifi")
            {


                try
                {
                    bsC.EndEdit();
                    bsC.CancelEdit();
                    Db.syncroniser("Categorie_Voiture");
                    groupBox1.Enabled = false;
                    btn_ValiderE.Enabled = false;
                    string actions = "Processus Mise à Jour";
                    string smss = "Il a Mise à Jour avec succès";

                    Msg_Ajouter f = new Msg_Ajouter(actions, smss);
                    f.Show();


                }
                catch (Exception ex)
                {



                }






            }
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void text_emailPar_Heur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) != true && e.KeyChar != 8 && e.KeyChar != ',')
                e.Handled = true;
            if (e.KeyChar == ',' && text_emailPar_Heur.Text.IndexOf(',') > 0)
                e.Handled = true;


        }

        private void text_Cout_Par_Jour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) != true && e.KeyChar != 8 && e.KeyChar != ',')
                e.Handled = true;
            if (e.KeyChar == ',' && text_Cout_Par_Jour.Text.IndexOf(',') > 0)
                e.Handled = true;

        }

        private void text_N_p_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) != true && e.KeyChar != 8)
                e.Handled = true;

        }

        private void text_N_B_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) != true && e.KeyChar != 8)
                e.Handled = true;

        }
    }
}
