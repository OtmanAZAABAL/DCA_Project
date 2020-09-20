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
    public partial class Add_User : Form
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
        public Add_User(string action, string idClick)
        {
            InitializeComponent();
            this.action = action;

            this.idClick = idClick;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void bsDataBindings()
        {


         

            bsC = Db.remplirText("Select * from utilisateur", "utilisateur");



            text_id_user.DataBindings.Add("text", bsC, "id_User");
            text_nomUser.DataBindings.Add("text", bsC, "Nom_User");
            text_prenom_user.DataBindings.Add("text", bsC, "Prenom_User");


            text_Mot_de_pasee.DataBindings.Add("text", bsC, "Password_User");


            text_Email.DataBindings.Add("text", bsC, "Email_User");
            cb_Type.DataBindings.Add("text", bsC, "Type_User");

            text_photo.DataBindings.Add("text", bsC, "photo_User");
        






            text_id_user.Focus();

        }

        private void Add_User_Load(object sender, EventArgs e)
        {
            if (action == "add")
            {
                ActionF.Text = "AJOUTER";

                bsDataBindings();
                bsC.AddNew();

                text_id_user.Focus();

            }
            else if (action == "modifi")
            {
                ActionF.Text = "MODIFIER";




                bsC = Db.remplirText("Select * from utilisateur", "utilisateur");


                listBox1.DataSource = bsC;
                listBox1.ValueMember = "id_User";
                listBox1.DisplayMember = "id_User";



                listBox1.SelectedValue = idClick.ToString();



                text_id_user.DataBindings.Add("text", bsC, "id_User");
                text_nomUser.DataBindings.Add("text", bsC, "Nom_User");
                text_prenom_user.DataBindings.Add("text", bsC, "Prenom_User");


                text_Mot_de_pasee.DataBindings.Add("text", bsC, "Password_User");
                txet_Confirm_Motdepasse.DataBindings.Add("text", bsC, "Password_User");


                text_Email.DataBindings.Add("text", bsC, "Email_User");
                cb_Type.DataBindings.Add("text", bsC, "Type_User");

                text_photo.DataBindings.Add("text", bsC, "photo_User");









                text_id_user.Enabled = false;
                text_nomUser.Focus();


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string nomFichier = openFileDialog1.FileName;
            string ext = Path.GetExtension(nomFichier);

            Random n = new Random();
            long i = n.Next();

            string d = DateTime.Now.ToString().Replace("/", "").Replace(" ", "").Replace(":", "");
            File.Copy(nomFichier, "imagesUser/" + d + i + ext);
            text_photo.Text = d + i + ext;
        }

        private void text_photo_TextChanged(object sender, EventArgs e)
        {
            string photo = text_photo.Text == "" ? "vide.png" : text_photo.Text;

            PictureBox1.Load("imagesUser/" + photo);
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
                Db.syncroniser("utilisateur");



            }
        }

        private void btn_ValiderE_Click(object sender, EventArgs e)
        {
            if (action == "add")
            {





                if (text_id_user.Text == "")
                {
                    string t1 = "id User non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t1);
                    v.ShowDialog();

                    text_id_user.Focus();
                    return;
                }




                if (text_nomUser.Text == "")
                {
                    string t2 = "Nom_User non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t2);
                    v.ShowDialog();

                    text_nomUser.Focus();
                    return;
                }










                if (text_prenom_user.Text == "")
                {
                    string t4 = "Prenom User   non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t4);
                    v.ShowDialog();

                    text_prenom_user.Focus();
                    return;
                }

                if (text_Email.Text == "")
                {
                    string t6 = "Email User non renseigné";
                    Msg_Verifier v = new Msg_Verifier(t6);
                    v.ShowDialog();

                    text_Email.Focus();
                    return;
                }

                if (text_Mot_de_pasee.Text == "")
                {
                    string t9 = " Password User   non renseigné";

                    Msg_Verifier v = new Msg_Verifier(t9);
                    v.ShowDialog();

                    text_Mot_de_pasee.Focus();
                    return;
                }
                if (text_Mot_de_pasee.Text != txet_Confirm_Motdepasse.Text)
                {
                    string t10 = " Confirm Mot de passe non renseigné";

                    Msg_Verifier v = new Msg_Verifier(t10);
                    v.ShowDialog();

                    text_Mot_de_pasee.Focus();
                    return;
                }
                if (cb_Type.Text == "")
                {
                    string t11 = "Type User    non renseigné";

                    Msg_Verifier v = new Msg_Verifier(t11);
                    v.ShowDialog();

                    cb_Type.Focus();
                    return;
                }

                if (text_photo.Text == "")
                {
                    string t11 = "photo User  non renseigné";

                    Msg_Verifier v = new Msg_Verifier(t11);
                    v.ShowDialog();

                    text_photo.Focus();
                    return;
                }


                try
                {

                    bsC.EndEdit();

                    Db.syncroniser("utilisateur");
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
                        text_id_user.Clear();
                        text_id_user.Focus();
                    }

                    else if (ex.Message.Contains("Uunique_Email_User"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Cet Email User existe déjà");
                        m.ShowDialog();
                        text_Email.Clear();
                        text_Email.Focus();
                    }
                    else if (ex.Message.Contains("Violation of UNIQUE KEY constraint"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Cet Email User existe déjà");
                        m.ShowDialog();
                        text_Email.Clear();
                        text_Email.Focus();
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
                    Db.syncroniser("utilisateur");
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
                        text_id_user.Clear();
                        text_id_user.Focus();
                    }

                    else if (ex.Message.Contains("Uunique_Email_User"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Cet Email User existe déjà");
                        m.ShowDialog();
                        text_Email.Clear();
                        text_Email.Focus();
                    }
                    else if (ex.Message.Contains("Violation of UNIQUE KEY constraint"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Cet Email User existe déjà");
                        m.ShowDialog();
                        text_Email.Clear();
                        text_Email.Focus();
                    }
                    else

                        MessageBox.Show(ex.Message);
                }






            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}
