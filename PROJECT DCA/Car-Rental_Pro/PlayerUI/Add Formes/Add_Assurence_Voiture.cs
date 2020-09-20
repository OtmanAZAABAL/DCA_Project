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
    public partial class Add_Assurence_Voiture : Form
    {

        string action;
        string idClick;
        BindingSource bsC2;
        BindingSource bsC;


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        public Add_Assurence_Voiture(string action, string idClick)
        {
            InitializeComponent();
            this.action = action;
            this.idClick = idClick;

        }
        public void bsDataBindings()
        {


            bsC = Db.remplirText("Select * from Assurence_Voiture", "Assurence_Voiture");


            text_Cod_Assurences.DataBindings.Add("text", bsC, "Cod_Assurences");
            text_Nom_Assurences.DataBindings.Add("text", bsC, "Nom_Assurences");


            text_TYpe_Converture.DataBindings.Add("text", bsC, "TYpe_Converture");
            text_Cout_Par_Jour.DataBindings.Add("text", bsC, "Cout_par_Jour");



        }
        private void Add_Assurence_Voiture_Load(object sender, EventArgs e)
        {

            if (action == "add")
            {
                text_Cod_Assurences.Focus();
                ActionF.Text = "AJOUTER";


                bsDataBindings();

                bsC.AddNew();

                text_Cout_Par_Jour.Text = "0";

                text_Cod_Assurences.Focus();



            }
            else if (action == "modifi")
            {

                ActionF.Text = "MODIFIER";


                bsC = Db.remplirText("Select * from Assurence_Voiture", "Assurence_Voiture");
               






                listBox1.DataSource = bsC;
                listBox1.ValueMember = "Cod_Assurences";
                listBox1.DisplayMember = "Cod_Assurences";



                listBox1.SelectedValue = idClick.ToString();



                text_Cod_Assurences.DataBindings.Add("text", bsC, "Cod_Assurences");
                text_Nom_Assurences.DataBindings.Add("text", bsC, "Nom_Assurences");


                text_TYpe_Converture.DataBindings.Add("text", bsC, "TYpe_Converture");
                text_Cout_Par_Jour.DataBindings.Add("text", bsC, "Cout_par_Jour");









                text_Cod_Assurences.Enabled = false;
                text_Nom_Assurences.Focus();

            }
        }

        private void btn_ValiderE_Click(object sender, EventArgs e)
        {
            if (action == "add")
            {


               


             
                if (text_Cod_Assurences.Text == "")
                {
                    string t2 = "Cod Assurences  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t2);
                    v.ShowDialog();

                    text_Cod_Assurences.Focus();
                    return;
                }







                if (text_Nom_Assurences.Text == "")
                {
                    string t3 = " Nom Assurences  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t3);
                    v.ShowDialog();

                    text_Nom_Assurences.Focus();
                    return;
                }





                if (text_TYpe_Converture.Text == "")
                {
                    string t4 = "TYpe Converture  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t4);
                    v.ShowDialog();

                    text_TYpe_Converture.Focus();
                    return;
                }

                if (text_Cout_Par_Jour.Text == "")
                {
                    string t4 = "Cout par Jour  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t4);
                    v.ShowDialog();

                    text_Cout_Par_Jour.Focus();
                    return;
                }


                try
                {

                    bsC.EndEdit();

                    Db.syncroniser("Assurence_Voiture");
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
                        Msg_Erreur m = new Msg_Erreur("Cod Assurences est duplicate");
                        m.ShowDialog();
                        text_Cod_Assurences.Clear();
                        text_Cod_Assurences.Focus();
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
                    Db.syncroniser("Client");
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

        private void btn_AnnulerE_Click(object sender, EventArgs e)
        {
            if (action == "add")

            {


                this.Close();




            }
            else if (action == "modifi")
            {



                this.Close();
                Db.syncroniser("Assurence_Voiture");



            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void text_Cout_Par_Jour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) != true && e.KeyChar != 8 && e.KeyChar != ',')
                e.Handled = true;
            if (e.KeyChar == ',' && text_Cod_Assurences.Text.IndexOf(',') > 0)
                e.Handled = true;
        }
    }
}
