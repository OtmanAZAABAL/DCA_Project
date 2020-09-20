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
    public partial class Add_Detail_Remise : Form
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




        public Add_Detail_Remise(string action, string idClick)
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
                Db.syncroniser("Detail_Remise");



            }
        }
        public void bsDataBindings()
        {
            comboBox1.Enabled = false;


            bsC = Db.remplirText("Select * from Detail_Remise", "Detail_Remise");
            bsC2 = Db.remplirListe(comboBox1, "Detail_Remise", "Code_Remise", "Code_Remise");



            text_Code_Remise.DataBindings.Add("text", bsC, "Code_Remise");
            text_nomR.DataBindings.Add("text", bsC, "Nom_Remise");
            text_Percountage_Remise.DataBindings.Add("text", bsC, "Percountage_Remise");
             dateDeDhR.DataBindings.Add(new Binding("text", bsC, "Date_Expiration"));
            comboBox1.DataBindings.Add("text", bsC, "Code_Remise");

  //dateDeDhR.DataBindings.Add("text", bsC, "Date_Expiration");

  //          dateDeDhR.va


        }
        private void Add_Detail_Remise_Load(object sender, EventArgs e)
        {

          //  dateDeDhR.Enabled = false;


            if (action == "add")
            {
                text_Code_Remise.Focus();
                ActionF.Text = "AJOUTER";
     
                bsDataBindings();

                bsC.AddNew();

                text_Percountage_Remise.Text = "0";

                text_Code_Remise.Focus();



            }
            else if (action == "modifi")
            {

                ActionF.Text = "MODIFIER";
                comboBox1.Enabled = false;


                bsC = Db.remplirText("Select * from Detail_Remise", "Detail_Remise");










                listBox1.DataSource = bsC;
                listBox1.ValueMember = "Code_Remise";
                listBox1.DisplayMember = "Code_Remise";



                listBox1.SelectedValue = idClick.ToString();






                text_Code_Remise.DataBindings.Add("text", bsC, "Code_Remise");
                text_nomR.DataBindings.Add("text", bsC, "Nom_Remise");
                text_Percountage_Remise.DataBindings.Add("text", bsC, "Percountage_Remise");


                dateDeDhR.Enabled = false;

             //   dateDeDhR.DataBindings.Add(new Binding("text", bsC, "Date_Expiration"));

                dateDeDhR.DataBindings.Add("text", bsC, "Date_Expiration");






                text_Code_Remise.Enabled = false;
                text_nomR.Focus();
            }
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_ValiderE_Click(object sender, EventArgs e)
        {

            if (action == "add")
            {






                if (text_Code_Remise.Text == "")
                {
                    string t2 = "Cod Remise  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t2);
                    v.ShowDialog();

                    text_Code_Remise.Focus();
                    return;
                }







                if (text_nomR.Text == "")
                {
                    string t3 = "Nom Remise  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t3);
                    v.ShowDialog();

                    text_nomR.Focus();
                    return;
                }
                //   System.DateType
                //     DateTime? dateDeDhR = null;

                ////if (!dateDeDhR.HasValue)
                ////{
                ////    MessageBox.Show("cc");
                ////    return;
                ////}
                //if (Convert.ToDateTime(dateDeDhR.Text).t =="")
                //{
                //    //unassigned
                //    string t3 = "date  non renseigné";
                //    Msg_Verifier v = new Msg_Verifier(t3);
                //    v.ShowDialog();
                //    return;

                //}

                //if (dateDeDhR.DataBindings.Equals("") == null)
                ////{
                ////    //unassigned
                ////    string t3 = "date  non renseigné";
                ////    Msg_Verifier v = new Msg_Verifier(t3);
                ////    v.ShowDialog();
                ////    return;

                //}



                //if (dateDeDhR.Value != default(DateTime))
                //{
                //    //do work for dateTimeVariable == null situation
                //    string t3 = "date  non renseigné";
                //    Msg_Verifier v = new Msg_Verifier(t3);
                //    v.ShowDialog();
                //    return;

                //}

                //if (!DateTime.TryParse(startDateTextBox.Text, out dateDeDhR))
                //{
                //    dateDeDhR.Text = DateTime.Today.ToShortDateString();
                //}
                //  System.DateType? myTime = null;

                //if (dateDeDhR.Value == default(DateTime))
                //{
                //    string t4 = "Date Expiration  non renseigné";
                //    Msg_Verifier v = new Msg_Verifier(t4);
                //    v.ShowDialog();

                //    dateDeDhR.Focus();
                //    return;
                //}




                if (text_Percountage_Remise.Text.ToString() == "")
                {
                    string t4 = " Percountage Remise  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t4);
                    v.ShowDialog();

                    text_Percountage_Remise.Focus();
                    return;
                }

                try
                {

                    bsC.EndEdit();

                    Db.syncroniser("Detail_Remise");
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
                        text_Code_Remise.Clear();
                        text_Code_Remise.Focus();
                    }
                    else if (ex.Message.Contains("ck_Date_Expiration"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Date Expiration Plus petit de la date d'aujourd'hui");
                        m.ShowDialog();
                        //dateDeDhR.Focus();
                    }
                    else if (ex.Message.Contains("'Date_Expiration'"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Date Expiration  non renseigné");
                        m.ShowDialog();
                        //dateDeDhR.Focus();
                    }
                    else if (ex.Message.Contains("ck_Percountage_Remise"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Assurez-vous que le nombre est compris entre 0 et 100");
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
                    Db.syncroniser("Detail_Remise");
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
                        text_Code_Remise.Clear();
                        text_Code_Remise.Focus();
                    }
                    else if (ex.Message.Contains("ck_Date_Expiration"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Date Expiration Plus petit de la date d'aujourd'hui");
                        m.ShowDialog();
                        //dateDeDhR.Focus();
                    }
                    else if (ex.Message.Contains("'Date_Expiration'"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Date Expiration  non renseigné");
                        m.ShowDialog();
                        //dateDeDhR.Focus();
                    }
                    else if (ex.Message.Contains("'ck_Percountage_Remise'"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Assurez-vous que le nombre est compris entre 0 et 100");
                        m.ShowDialog();
                        //dateDeDhR.Focus();
                    }
                    else

                        MessageBox.Show(ex.Message);
                }







            }
        }

        private void dateDeDhR_MouseHover(object sender, EventArgs e)
        {
            //dateDeDhR.Enabled = true;
        }

        private void dateDeDhR_MouseDown(object sender, MouseEventArgs e)
        {
         //   dateDeDhR.Enabled = true;

        }

        private void dateDeDhR_MouseEnter(object sender, EventArgs e)
        {
            //   dateDeDhR.Enabled = true;

        }

        private void dateDeDhR_MouseLeave(object sender, EventArgs e)
        {
          //  dateDeDhR.Enabled = true;

        }

        private void dateDeDhR_ValueChanged(object sender, EventArgs e)
        {
            //label4.Text = dateDeDhR.Value.ToString();
        }

        private void text_Percountage_Remise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) != true && e.KeyChar != 8 && e.KeyChar != ',')
                e.Handled = true;
            if (e.KeyChar == ',' && text_Code_Remise.Text.IndexOf(',') > 0)
                e.Handled = true;

        }
    }
}
