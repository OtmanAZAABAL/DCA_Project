using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Add_Voiture : Form
    {
        string action;
        string idClick;
        int i;
        BindingSource bsDetails_Emplacment;
        BindingSource bsC;
        BindingSource Categorie_Voiture;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public Add_Voiture(string action, string idClick)
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
                Db.syncroniser("Voiture");



            }
        }
        public void bsDataBindings()
        {


            bsDetails_Emplacment = Db.remplirListe(cb_emplacemrnt, "Details_Emplacment", "Emplacement_Id", "Emplacement_Id");
            Categorie_Voiture = Db.remplirListe(cb_nom_Ctegorie, "Categorie_Voiture", "Nom_Categorie", "Nom_Categorie");

            bsC = Db.remplirText("Select * from Voiture", "Voiture");



            text_Numero_Enrg.DataBindings.Add("text", bsC, "Numero_Enrg");
            text_nom_Model.DataBindings.Add("text", bsC, "Nom_Model");
            text_Marque.DataBindings.Add("text", bsC, "Marque");


            text_anne_Model.DataBindings.Add("text", bsC, "Anne_Model");


            text_Kilometrage.DataBindings.Add("text", bsC, "Kilometrage");
            text_img.DataBindings.Add("text", bsC, "Photo_Voiture");
            text_Le_lien.DataBindings.Add("text", bsC, "link");


            text_Matricule.DataBindings.Add("text", bsC, "Matricule");

            //text_Latitude.DataBindings.Add("text", bsC, "Latitude");
            //text_Longitude.DataBindings.Add("text", bsC, "Longitude");
            cb_nom_Ctegorie.DataBindings.Add("selectedvalue", bsC, "Nom_Categorie");

             cb_emplacemrnt.DataBindings.Add("selectedvalue", bsC, "Emplacement_Id");




        //  cb_emplacemrnt.DataBindings.Add("selectedvalue", bsC, "Emplacement_Id");







            text_Numero_Enrg.Focus();

        }

        private void Add_Voiture_Load(object sender, EventArgs e)
        {
           
            //if (rd_GPS.Checked)
            //{
            //    grp_gps.Enabled = true;
            //    grp_gps_avec_line.Enabled = false;


            //}
            //else if (rd_AVEC_UN_LIEN.Checked)
            // {

            //    grp_gps.Enabled = false;
            //    grp_gps_avec_line.Enabled = true;



            //}



            //if (rd_GPS.Checked == true)
            //{
            //    grp_gps_avec_line.Enabled = false;
            //}

            //grp_gps.Enabled = false;
            //rd_AVEC_UN_LIEN.Enabled = true;
            

            if (action == "add")
            {
                ActionF.Text = "AJOUTER";


               


                bsDataBindings();
                bsC.AddNew();
                
                text_Numero_Enrg.Focus();


     
                text_img.Enabled = false;

            }
            else if (action == "modifi")
            {
                ActionF.Text = "MODIFIER";



                /////


                //bsDetails_Emplacment = Db.remplirListe(cb_emplacemrnt, "Details_Emplacment", "Emplacement_Id", "Emplacement_Id");
                //Categorie_Voiture = Db.remplirListe(cb_nom_Ctegorie, "Categorie_Voiture", "Nom_Categorie", "Nom_Categorie");

                //bsC = Db.remplirText("Select * from Voiture", "Voiture");



                //text_Numero_Enrg.DataBindings.Add("text", bsC, "Numero_Enrg");
                //text_nom_Model.DataBindings.Add("text", bsC, "Nom_Model");
                //text_Marque.DataBindings.Add("text", bsC, "Marque");


                //text_anne_Model.DataBindings.Add("text", bsC, "Anne_Model");


                //text_Kilometrage.DataBindings.Add("text", bsC, "Kilometrage");
                //text_img.DataBindings.Add("text", bsC, "Photo_Voiture");
                //text_Le_lien.DataBindings.Add("text", bsC, "link");

                //text_Latitude.DataBindings.Add("text", bsC, "Latitude");
                //text_Longitude.DataBindings.Add("text", bsC, "Longitude");
                //cb_nom_Ctegorie.DataBindings.Add("selectedvalue", bsC, "Nom_Categorie");

                //cb_emplacemrnt.DataBindings.Add("selectedvalue", bsC, "Emplacement_Id");

                //////


                bsDetails_Emplacment = Db.remplirListe(cb_emplacemrnt, "Details_Emplacment", "Emplacement_Id", "Emplacement_Id");
                Categorie_Voiture = Db.remplirListe(cb_nom_Ctegorie, "Categorie_Voiture", "Nom_Categorie", "Nom_Categorie");
                bsC = Db.remplirText("Select * from Voiture", "Voiture");



                listBox1.DataSource = bsC;
                listBox1.ValueMember = "Numero_Enrg";
                listBox1.DisplayMember = "Numero_Enrg";



               listBox1.SelectedValue = idClick.ToString();




                text_Numero_Enrg.DataBindings.Add("text", bsC, "Numero_Enrg");
                text_nom_Model.DataBindings.Add("text", bsC, "Nom_Model");
                text_Marque.DataBindings.Add("text", bsC, "Marque");
                text_anne_Model.DataBindings.Add("text", bsC, "Anne_Model");
                text_Kilometrage.DataBindings.Add("text", bsC, "Kilometrage");
                text_img.DataBindings.Add("text", bsC, "Photo_Voiture");
                text_Le_lien.DataBindings.Add("text", bsC, "link");
                //text_Latitude.DataBindings.Add("text", bsC, "Latitude");
                //text_Longitude.DataBindings.Add("text", bsC, "Longitude");
                cb_nom_Ctegorie.DataBindings.Add("text", bsC, "Nom_Categorie");
                 cb_emplacemrnt.DataBindings.Add("text", bsC, "Emplacement_Id");
                //cb_emplacemrnt.DataBindings.Add("selectedvalue", bsC, "ville");
                text_Matricule.DataBindings.Add("text", bsC, "Matricule");
                text_img.Enabled = false;



                text_Numero_Enrg.Enabled = false;
                text_nom_Model.Focus();


            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void text_img_TextChanged(object sender, EventArgs e)
        {
            string photo = text_img.Text == "" ? "vide.png" : text_img.Text;

            pictureBox1.Load("imagesV/" + photo);
        }

        private void btn_ValiderE_Click(object sender, EventArgs e)
        {
            if (action == "add")
            {





                if (text_Numero_Enrg.Text == "")
                {
                    string t1 = "Numero Enrg  non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t1);
                    v.ShowDialog();

                    text_Numero_Enrg.Focus();
                    return;
                }


                if (text_Matricule.Text == "")
                {
                    string t1 = " Matricule   non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t1);
                    v.ShowDialog();

                    text_Matricule.Focus();
                    return;
                }




                if (text_nom_Model.Text == "")
                {
                    string t2 = "Nom Modelr non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t2);
                    v.ShowDialog();

                    text_nom_Model.Focus();
                    return;
                }










                if (text_Marque.Text == "")
                {
                    string t4 = "Marque   non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t4);
                    v.ShowDialog();

                    text_Marque.Focus();
                    return;
                }

                if (text_anne_Model.Text == "")
                {
                    string t6 = "Anne Model   non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t6);
                    v.ShowDialog();

                    text_anne_Model.Focus();
                    return;
                }

                if (text_Kilometrage.Text == "")
                {
                    string t9 = " Kilometrage   non renseigné";

                    Msg_Verifier v = new Msg_Verifier(t9);
                    v.ShowDialog();

                    text_Kilometrage.Focus();
                    return;
                }
                if (text_img.Text == "")
                {
                    string t10 = " Photo_Voiture non renseigné";

                    Msg_Verifier v = new Msg_Verifier(t10);
                    v.ShowDialog();

                    text_img.Focus();
                    return;
                }
                if (cb_nom_Ctegorie.Text == "")
                {
                    string t11 = "Nom_Categorie    non renseigné";

                    Msg_Verifier v = new Msg_Verifier(t11);
                    v.ShowDialog();

                    cb_nom_Ctegorie.Focus();
                    return;
                }

                if (cb_emplacemrnt.Text == "")
                {
                    string t11 = "Emplacement Id   non renseigné";

                    Msg_Verifier v = new Msg_Verifier(t11);
                    v.ShowDialog();

                    cb_emplacemrnt.Focus();
                    return;
                }
                if (text_Le_lien.Text == "")
                {
                    text_Le_lien.Text = "";
                }


                try
                {

                    bsC.EndEdit();

                    Db.syncroniser("Voiture");
                    btn_ValiderE.Enabled = false;
                    groupBox1.Enabled = false;
                    //grp_gps.Enabled = false;
                    //grp_gps_avec_line.Enabled = false;


                    string actions = "Processus Ajouté";
                    string smss = "Il a ajouté avec succès";

                    Msg_Ajouter f = new Msg_Ajouter(actions, smss);
                    f.Show();

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Violation of PRIMARY KEY constraint"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Numero Enrg est duplicate");
                        m.ShowDialog();
                        text_Numero_Enrg.Clear();
                        text_Numero_Enrg.Focus();
                    }
                    else if (ex.Message.Contains("'Nom_Categorie'"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Choisissez Nom Categorie");
                        m.ShowDialog();
                        
                        cb_nom_Ctegorie.Focus();


                    }

                    else if (ex.Message.Contains("'Emplacement_Id'"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Choisissez  Emplacement_Id");
                        m.ShowDialog();

                        cb_nom_Ctegorie.Focus();



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
                    Db.syncroniser("Voiture");
                    groupBox1.Enabled = false;
                    btn_ValiderE.Enabled = false;


                    string actions = "Processus modifier";
                    string smss = "Il a modifier avec succès";

                    Msg_Ajouter f = new Msg_Ajouter(actions, smss);
                    f.Show();

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("'Nom_Categorie'"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Choisissez Nom Categorie");
                        m.ShowDialog();

                        cb_nom_Ctegorie.Focus();


                    }

                    else if (ex.Message.Contains("'Emplacement_Id'"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Choisissez  Emplacement_Id");
                        m.ShowDialog();

                        cb_nom_Ctegorie.Focus();



                    }
                    else
                        MessageBox.Show(ex.Message);


                }






            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void text_anne_Model_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) != true && e.KeyChar != 8)
                e.Handled = true;

        }

        private void text_Kilometrage_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) != true && e.KeyChar != 8)
                e.Handled = true;

        }

        private void text_Numero_Enrg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) != true && e.KeyChar != 8)
                e.Handled = true;
        }

        private void cb_emplacemrnt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
