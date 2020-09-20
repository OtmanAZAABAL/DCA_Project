using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Add_Employer : Form
    {

        string action;
        string idClick;
        int i;
        BindingSource bsC2;
        BindingSource bsC;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public Add_Employer(string action, string idClick)
        {
            InitializeComponent();
            this.action = action;

            this.idClick = idClick;
        }
        public void bsDataBindings()
        {



     
            bsC2 = Db.remplirListe(cb_desiE, "Employer", "Designation", "Id_Employer");

            bsC = Db.remplirText("Select * from Employer", "Employer");


            text_idE.DataBindings.Add("text", bsC, "Id_Employer");
            text_nomE.DataBindings.Add("text", bsC, "Nom_Employer");
            text_prnomE.DataBindings.Add("text", bsC, "Prenom_Employer");
            text_teleE.DataBindings.Add("text", bsC, "Tele_Employer");
            text_emailE.DataBindings.Add("text", bsC, "Email_Employer");
            text_AdreE.DataBindings.Add("text", bsC, "Adresse_Employer");
            text_villeE.DataBindings.Add("text", bsC, "ville");
            text_Sa.DataBindings.Add("text", bsC, "Salaire_Employer");
            cb_desiE.DataBindings.Add("text", bsC, "Designation");


            dateDeDh.DataBindings.Add(new Binding("text", bsC, "Date_da_dhesion"));
           

          



            text_nomE.Focus();

        }
        private void Add_Employer_Load(object sender, EventArgs e)
        {
            if (action == "add")
            {
                ActionF.Text = "AJOUTER";

                bsDataBindings();
                bsC.AddNew();

                text_idE.Focus();

            }
            else if (action == "modifi")
            {
                ActionF.Text = "MODIFIER";





                bsC2 = Db.remplirListe(cb_desiE, "Employer", "Designation", "Id_Employer");
                bsC = Db.remplirText("Select * from Employer", "Employer");


                listBox1.DataSource = bsC;
                listBox1.ValueMember = "Id_Employer";
                listBox1.DisplayMember = "Id_Employer";



                listBox1.SelectedValue = idClick.ToString();

                text_idE.DataBindings.Add("text", bsC, "Id_Employer");
                text_nomE.DataBindings.Add("text", bsC, "Nom_Employer");
                text_prnomE.DataBindings.Add("text", bsC, "Prenom_Employer");
                text_teleE.DataBindings.Add("text", bsC, "Tele_Employer");
                text_emailE.DataBindings.Add("text", bsC, "Email_Employer");
                text_AdreE.DataBindings.Add("text", bsC, "Adresse_Employer");
                text_villeE.DataBindings.Add("text", bsC, "ville");
                text_Sa.DataBindings.Add("text", bsC, "Salaire_Employer");



                dateDeDh.DataBindings.Add(new Binding("text", bsC, "Date_da_dhesion"));

                cb_desiE.DataBindings.Add("text", bsC, "Designation");






                text_idE.Enabled = false;
                text_nomE.Focus();


            }
        }

        private void btn_ValiderE_Click(object sender, EventArgs e)
        {

            if (action == "add")
            {


                Regex objemailTextEdit = new Regex("[a-zA-Z0-9]{1,30}@[a-zA-Z0-9]{1,30}.[a-zA-Z]{2,3}");

                

                if (text_idE.Text == "")
                {
                    string t1 = "id Employer  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t1);
                    v.ShowDialog();

                    text_idE.Focus();
                    return;
                }




                if (text_nomE.Text =="")
                {
                    string t2 = " Nom Employer non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t2);
                    v.ShowDialog();

                    text_nomE.Focus();
                    return;
                }










                if (text_prnomE.Text == "")
                {
                    string t4 = "Prenom Employer  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t4);
                    v.ShowDialog();

                    text_prnomE.Focus();
                    return;
                }
              
                if (text_teleE.Text == "")
                {
                    string t6 = "Tele Employer  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t6);
                    v.ShowDialog();

                    text_teleE.Focus();
                    return;
                }
                if (Convert.ToInt32(text_emailE.ToString().Length) < 1 && !objemailTextEdit.IsMatch(text_emailE.Text))
                {
                    string t7 = "Email Employer  non renseigné";

                    Msg_Verifier v = new Msg_Verifier(t7);
                    v.ShowDialog();

                    text_emailE.Focus();
                    return;
                }
                if (!objemailTextEdit.IsMatch(text_emailE.Text))
                {


                    string t8 = "Email Employer  non renseigné";

                    Msg_Verifier v = new Msg_Verifier(t8);
                    v.ShowDialog();

                    text_emailE.Focus();
                    return;

                }
                if (text_AdreE.Text == "")
                {
                    string t9 = "Adresse  Employer   non renseigné";

                    Msg_Verifier v = new Msg_Verifier(t9);
                    v.ShowDialog();

                    text_AdreE.Focus();
                    return;
                }
                if (text_villeE.Text == "")
                {
                    string t10 = " villeE Employer  non renseigné";

                    Msg_Verifier v = new Msg_Verifier(t10);
                    v.ShowDialog();

                    text_villeE.Focus();
                    return;
                }
                if (cb_desiE.Text == "")
                {
                    string t11 = "Designation  Employer  non renseigné";

                    Msg_Verifier v = new Msg_Verifier(t11);
                    v.ShowDialog();

                    cb_desiE.Focus();
                    return;
                }

                if (text_Sa.Text == "")
                {
                    string t11 = "Salaire Employer   non renseigné";

                    Msg_Verifier v = new Msg_Verifier(t11);
                    v.ShowDialog();

                    text_Sa.Focus();
                    return;
                }

                if (dateDeDh.Value.ToString()== "")
                {
                    string t11 = "Date da dhesion Employer  non renseigné";

                    Msg_Verifier v = new Msg_Verifier(t11);
                    v.ShowDialog();

                    text_villeE.Focus();
                    return;
                }

              
                try
                {

                    bsC.EndEdit();

                    Db.syncroniser("Employer");
                    btn_ValiderE.Enabled = false;
                    groupBox1.Enabled = false;


                    string actions = "Processus Ajouté";
                    string smss = "Il a ajouté avec succès";

                    Msg_Ajouter f = new Msg_Ajouter(actions, smss);
                    f.Show();

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Violation of PRIMARY KEY constraint"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Cet identifiant existe déjà"); m.ShowDialog();
                        text_idE.Clear();
                        text_idE.Focus();
                    }
                    else if (ex.Message.Contains("ck_Date_da_dhesion"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Date da dhesion  Plus petit de la date d'aujourd'hui");
                        m.ShowDialog();
                        dateDeDh.Focus();
                    }
                    else if (ex.Message.Contains("Uunique_Email_Employer"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Cet Email Client existe déjà");
                        m.ShowDialog();
                        text_emailE.Clear();
                        text_emailE.Focus();
                    }
                    else if (ex.Message.Contains("Violation of UNIQUE KEY constraint"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Cet Email Employer existe déjà");
                        m.ShowDialog();
                        text_emailE.Clear();
                        text_emailE.Focus();
                    }
                    else if (ex.Message.Contains("'Date_da_dhesion'"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Date da dhesion  non renseigné");
                        m.ShowDialog();
                        //dateDeDhR.Focus();
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
                    Db.syncroniser("Employer");
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

        private void btnMedia_Click(object sender, EventArgs e)
        {









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
                Db.syncroniser("Employer");



            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void textphoto_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void text_idE_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) != true && e.KeyChar != 8)
                e.Handled = true;

        }

        private void text_Sa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) != true && e.KeyChar != 8 && e.KeyChar != ',')
                e.Handled = true;
            if (e.KeyChar == ',' && text_Sa.Text.IndexOf(',') > 0)
                e.Handled = true;
        }
    }
}
