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
    public partial class Add_Details_Emplacment : Form
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

        string k;
        public Add_Details_Emplacment(string action, string idClick)
        {
            InitializeComponent();
            this.action = action;

            this.idClick = idClick;
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
                Db.syncroniser("Details_Emplacment");



            }
        }


        public void bsDataBindings()
        {
            


            bsC = Db.remplirText("Select * from Details_Emplacment", "Details_Emplacment");
         


            text_idEM.DataBindings.Add("text", bsC, "Emplacement_Id");
            text_nomEmp.DataBindings.Add("text", bsC, "Nom_Emplacment");
            text_Rue.DataBindings.Add("text", bsC, "Rue");
            text_Ville.DataBindings.Add("text", bsC, "Ville");
            text_Zip_Code.DataBindings.Add("text", bsC, "Zip_code");
            text_Region.DataBindings.Add("text", bsC, "Region");





        }




        private void Add_Details_Emplacment_Load(object sender, EventArgs e)
        {
            if (action == "add")
            {
                text_idEM.Focus();
                ActionF.Text = "AJOUTER";


                bsDataBindings();

                bsC.AddNew();



                text_idEM.Focus();



            }
            else if (action == "modifi")
            {

                ActionF.Text = "MODIFIER";








                bsC = Db.remplirText("Select * from Details_Emplacment", "Details_Emplacment");




                listBox1.DataSource = bsC;
                listBox1.ValueMember = "Emplacement_Id";
                listBox1.DisplayMember = "Emplacement_Id";



                listBox1.SelectedValue = idClick.ToString();








                text_idEM.DataBindings.Add("text", bsC, "Emplacement_Id");
                text_nomEmp.DataBindings.Add("text", bsC, "Nom_Emplacment");
                text_Rue.DataBindings.Add("text", bsC, "Rue");
                text_Ville.DataBindings.Add("text", bsC, "Ville");
                text_Zip_Code.DataBindings.Add("text", bsC, "Zip_code");
                text_Region.DataBindings.Add("text", bsC, "Region");







                text_idEM.Enabled = false;
                text_nomEmp.Focus();
            }
        }

        private void btn_ValiderE_Click(object sender, EventArgs e)
        {
            if (action == "add")
            {






                if (text_idEM.Text == "")
                {
                    string t2 = "Emplacement Id non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t2);
                    v.ShowDialog();

                    text_idEM.Focus();
                    return;
                }







                if (text_nomEmp.Text == "")
                {
                    string t3 = "Nom Emplacment  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t3);
                    v.ShowDialog();

                    text_nomEmp.Focus();
                    return;
                }





                if (text_Rue.Text.ToString() == "")
                {
                    string t4 = " Rue  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t4);
                    v.ShowDialog();

                    text_Rue.Focus();
                    return;
                }



                if (text_Ville.Text.ToString() == "")
                {
                    string t4 = " Ville  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t4);
                    v.ShowDialog();

                    text_Ville.Focus();
                    return;
                }
                if (text_Zip_Code.Text.ToString() == "")
                {
                    string t4 = " code postal  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t4);
                    v.ShowDialog();

                    text_Zip_Code.Focus();
                    return;
                }
                if (text_Region.Text.ToString() == "")
                {
                    string t4 = " Region    non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t4);
                    v.ShowDialog();

                    text_Region.Focus();
                    return;
                }

                try
                {

                    bsC.EndEdit();

                    Db.syncroniser("Details_Emplacment");
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
                        text_idEM.Clear();
                        text_idEM.Focus();
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
                    Db.syncroniser("Details_Emplacment");
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
    }
}
