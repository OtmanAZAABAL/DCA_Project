using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PlayerUI
{
    public partial class Add_Client : Form
    {
        string action;
        string idClick;
        string id_user;
        int i;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        string k;
        public Add_Client(string action, string idClick, string id_user)
        {
            InitializeComponent();
            this.action = action;
            this.id_user = id_user;
            this.idClick = idClick;

        }




        BindingSource bsC2;
        BindingSource bsC;
        BindingSource bsH;



        public void bsDataBindings()
        {


            bsC = Db.remplirText("Select * from Client", "Client");


            text_idC.DataBindings.Add("text", bsC, "Id_Client");
            text_Permis.DataBindings.Add("text", bsC, "Permis_de_conduire");

            text_nomC.DataBindings.Add("text", bsC, "Nom_Client");
            text_prnomC.DataBindings.Add("text", bsC, "Prenom_Client");
            text_teleC.DataBindings.Add("text", bsC, "Tel_Client");
            text_emailC.DataBindings.Add("text", bsC, "Email_Client");
            text_villeC.DataBindings.Add("text", bsC, "Ville_Client");
            text_po.DataBindings.Add("text", bsC, "ZipCod_Client");
            text_AdreC.DataBindings.Add("text", bsC, "Adresse_Client");


        }
        public void bsDataBindingsHistory()
        {


            bsH = Db.remplirText("Select * from HistoryClient", "HistoryClient");


            text_idCH.DataBindings.Add("text", bsH, "Id_Client");
           // text_Permis.DataBindings.Add("text", bsC, "Permis_de_conduire");

            text_nomCH.DataBindings.Add("text", bsH, "Nom_Client");
            text_prnomCH.DataBindings.Add("text", bsH, "Prenom_Client");
            text_teleCH.DataBindings.Add("text", bsH, "Tel_Client");
            text_emailCH.DataBindings.Add("text", bsH, "Email_Client");
            text_villeCH.DataBindings.Add("text", bsH, "Ville_Client");
            Zibe_CH.DataBindings.Add("text", bsH, "ZipCod_Client");
            text_AdreCH.DataBindings.Add("text", bsH, "Adresse_Client");
            lblAction.DataBindings.Add("text", bsH, "Action");
            dt_Action.DataBindings.Add("text", bsH, "DateAction");
            lb_id_user.DataBindings.Add("text", bsH, "user");



        }

        private void Add_Client_Load(object sender, EventArgs e)
        {

            if (action == "add")
            {
                text_idC.Focus();
                ActionF.Text = "AJOUTER";




                bsDataBindings();

                bsC.AddNew();

                bsDataBindingsHistory();
                bsH.AddNew();

                lblAction.Text = "Added";
                lb_id_user.Text = id_user.ToString()+" ";
                DateTime dt = DateTime.Now;
                dt_Action.Text = dt.ToString();
                text_idC.Focus();



            }
            else if (action == "modifi")
            {

                ActionF.Text = "MODIFIER";



                bsC = Db.remplirText("Select * from Client", "Client");







                listBox1.DataSource = bsC;
                listBox1.ValueMember = "Id_Client";
                listBox1.DisplayMember = "Id_Client";



                listBox1.SelectedValue = idClick.ToString();

                text_idC.DataBindings.Add("text", bsC, "Id_Client");
                text_Permis.DataBindings.Add("text", bsC, "Permis_de_conduire");

                text_nomC.DataBindings.Add("text", bsC, "Nom_Client");
                text_prnomC.DataBindings.Add("text", bsC, "Prenom_Client");
                text_teleC.DataBindings.Add("text", bsC, "Tel_Client");
                text_emailC.DataBindings.Add("text", bsC, "Email_Client");
                text_villeC.DataBindings.Add("text", bsC, "Ville_Client");
                text_po.DataBindings.Add("text", bsC, "ZipCod_Client");
                text_AdreC.DataBindings.Add("text", bsC, "Adresse_Client");








                text_idC.Enabled = false;
                text_nomC.Focus();






                bsH = Db.remplirText("Select * from HistoryClient", "HistoryClient");


                text_idCH.DataBindings.Add("text", bsH, "Id_Client");

                text_nomCH.DataBindings.Add("text", bsH, "Nom_Client");
                text_prnomCH.DataBindings.Add("text", bsH, "Prenom_Client");
                text_teleCH.DataBindings.Add("text", bsH, "Tel_Client");
                text_emailCH.DataBindings.Add("text", bsH, "Email_Client");
                text_villeCH.DataBindings.Add("text", bsH, "Ville_Client");
                Zibe_CH.DataBindings.Add("text", bsH, "ZipCod_Client");
                text_AdreCH.DataBindings.Add("text", bsH, "Adresse_Client");
                lblAction.DataBindings.Add("text", bsH, "Action");
                dt_Action.DataBindings.Add("text", bsH, "DateAction");
                lb_id_user.DataBindings.Add("text", bsH, "user");


                bsH.AddNew();

                text_idCH.Text = idClick.ToString();

                lb_id_user.Text = id_user.ToString() + " ";
                DateTime dt = DateTime.Now;
                dt_Action.Text = dt.ToString();
                lblAction.Text = "Updated";


            }

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_ValiderE_Click(object sender, EventArgs e)
        {

            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    if (listBox1.== text_idC.Text)
            //    {


            //        k = listBox1.Items[i].ToString();
            //        return;


            //    }
            //}
            ////for (i = 0; i < ds.Tables["Client"].Rows.Count; i++)
            ////{
            ////    if (ds.Tables["Client"].Rows[i][0].ToString() == text_idC.Text.ToString())
            ////    {

            ////        test = true;
            ////    }

            ////}
            ////if (test == true)
            ////{

            ////    MessageBox.Show("this id client is enstge !");
            ////    text_idC.Focus();
            ////    return;


            ////}
            ////else {
            ////    return;

            //////}

            //for ( i = 0; i < listBox1.Items.Count; i++)
            //{
            //    if (listBox1.Items[i].ToString()== text_idC.Text)
            //    {


            //        k = listBox1.Items[i].ToString();
            //        return;


            //    }
            //}


            if (action == "add")
            {


                Regex objemailTextEdit = new Regex("[a-zA-Z0-9]{1,30}@[a-zA-Z0-9]{1,30}.[a-zA-Z]{2,3}");



                if (text_idC.Text == "")
                {
                    string t1 = "id Client  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t1);
                    v.ShowDialog();

                    text_idC.Focus();
                    return;
                }

                if (text_Permis.Text == "")
                {
                    string t1 = "Permis de  Client  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t1);
                    v.ShowDialog();

                    text_idC.Focus();
                    return;
                }




                if (text_idC.Text == k)
                {
                    string t2 = "id Client  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t2);
                    v.ShowDialog();

                    text_idC.Focus();
                    return;
                }







                if (text_idC.Text == "")
                {
                    string t3 = "id Client  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t3);
                    v.ShowDialog();

                    text_idC.Focus();
                    return;
                }





                if (text_nomC.Text == "")
                {
                    string t4 = "Nom Client  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t4);
                    v.ShowDialog();

                    text_nomC.Focus();
                    return;
                }
                if (text_prnomC.Text == "")
                {
                    string t5 = "Prenom Client  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t5);
                    v.ShowDialog();

                    text_prnomC.Focus();
                    return;
                }
                if (text_teleC.Text == "")
                {
                    string t6 = "Tele Client  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t6);
                    v.ShowDialog();

                    text_teleC.Focus();
                    return;
                }
                if (Convert.ToInt32(text_emailC.ToString().Length) < 1 && !objemailTextEdit.IsMatch(text_emailC.Text))
                {
                    string t7 = "Email Client  non renseigné";

                    Msg_Verifier v = new Msg_Verifier(t7);
                    v.ShowDialog();

                    text_emailC.Focus();
                    return;
                }
                if (!objemailTextEdit.IsMatch(text_emailC.Text))
                {


                    string t8 = "Email Client  non renseigné";

                    Msg_Verifier v = new Msg_Verifier(t8);
                    v.ShowDialog();

                    text_emailC.Focus();
                    return;

                }
                if (text_villeC.Text == "")
                {
                    string t9 = "Ville Client  non renseigné";

                    Msg_Verifier v = new Msg_Verifier(t9);
                    v.ShowDialog();

                    text_villeC.Focus();
                    return;
                }
                if (text_po.Text == "")
                {
                    string t10 = " Zip code Client  non renseigné";

                    Msg_Verifier v = new Msg_Verifier(t10);
                    v.ShowDialog();

                    text_po.Focus();
                    return;
                }
                if (text_AdreC.Text == "")
                {
                    string t11 = "Adresse Client  non renseigné";

                    Msg_Verifier v = new Msg_Verifier(t11);
                    v.ShowDialog();

                    text_AdreC.Focus();
                    return;
                }

                try
                {

                    bsC.EndEdit();
                    bsH.EndEdit();

                    Db.syncroniser("Client");


                    Db.syncroniser("HistoryClient");
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
                        Msg_Erreur m = new Msg_Erreur("Cet identifiant existe déjà");
                        m.ShowDialog();
                        text_idC.Clear();
                        text_idC.Focus();
                    }
                    else if (ex.Message.Contains("Uunique_Email_Client"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Cet Email Client existe déjà");
                        m.ShowDialog();
                        text_emailC.Clear();
                        text_emailC.Focus();
                    }
                    else if (ex.Message.Contains("Violation of UNIQUE KEY constraint"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Cet Email Client existe déjà");
                        m.ShowDialog();
                        text_emailC.Clear();
                        text_emailC.Focus();
                    }
                    else

                        MessageBox.Show(ex.Message);
                }


















            }
            else if (action == "modifi")
            {

                text_nomCH.Text = text_nomC.Text;
                text_prnomCH.Text = text_prnomC.Text;
                text_teleCH.Text = text_teleC.Text;
                text_emailCH.Text = text_emailC.Text;
                text_villeCH.Text = text_villeC.Text;
                Zibe_CH.Text = text_po.Text;
                text_AdreCH.Text = text_AdreC.Text;
                lb_id_user.Text = id_user.ToString();

                lblAction.Text = "Updated";

                DateTime dt = DateTime.Now;
                lb_id_user.Text = id_user.ToString() + " ";

                dt_Action.Text = dt.ToString();

                try
                {
                    bsC.EndEdit();
                    bsC.CancelEdit();
                    bsH.EndEdit();
                    bsH.CancelEdit();

                    Db.syncroniser("Client");


                    Db.syncroniser("HistoryClient");
                    groupBox1.Enabled = false;
                    btn_ValiderE.Enabled = false;


                    string actions = "Processus Mise à Jour";
                    string smss = "Il a Mise à Jour avec succès";

                    Msg_Ajouter f = new Msg_Ajouter(actions, smss);
                    f.Show();

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Violation of PRIMARY KEY constraint"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Cet identifiant existe déjà");
                        m.ShowDialog();
                        text_idC.Clear();
                        text_idC.Focus();
                    }
                    else if (ex.Message.Contains("Uunique_Email_Client"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Cet Email Client existe déjà");
                        m.ShowDialog();
                        text_emailC.Clear();
                        text_emailC.Focus();
                    }
                    else if (ex.Message.Contains("Violation of UNIQUE KEY constraint"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Cet Email Client existe déjà");
                        m.ShowDialog();
                        text_emailC.Clear();
                        text_emailC.Focus();
                    }
                    else

                        MessageBox.Show(ex.Message);
                }





            }
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
                Db.syncroniser("Client");



            }

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void text_idC_TextChanged(object sender, EventArgs e)
        {
            text_idCH.Text = text_idC.Text;
        }

  

        private void text_nomC_TextChanged(object sender, EventArgs e)
        {
            text_nomCH.Text = text_nomC.Text;

        }

        private void text_prnomC_TextChanged(object sender, EventArgs e)
        {
            text_prnomCH.Text = text_prnomC.Text;
        }

        private void text_teleC_TextChanged(object sender, EventArgs e)
        {
            text_teleCH.Text = text_teleC.Text;

        }

        private void text_emailC_TextChanged(object sender, EventArgs e)
        {
            text_emailCH.Text = text_emailC.Text;

        }

        private void text_villeC_TextChanged(object sender, EventArgs e)
        {
            text_villeCH.Text = text_villeC.Text;

        }

        private void Zibe_C_TextChanged(object sender, EventArgs e)
        {
            Zibe_CH.Text = text_po.Text;

        }

        private void text_AdreC_TextChanged(object sender, EventArgs e)
        {
            text_AdreCH.Text = text_AdreC.Text;

        }

    }
}
