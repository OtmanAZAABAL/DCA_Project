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
using System.Data.SqlClient;
using PlayerUI.Properties;

namespace PlayerUI
{
    public partial class Login : Form
    {
        BindingSource bsC;
        bool check;
        int nb;
        int thisnb;
        int i;
        String d;
        String type;

        SqlConnection cn = new SqlConnection(@"data source=DESKTOP-J2RFDBR\SQLEXPRESS;initial catalog=Car_Rental_Pro_V1; Integrated Security = True; User Id=sa;Password=442662;");
        //DataSet ds = new DataSet();

        //BindingSource bsLogin = new BindingSource();
        //SqlDataAdapter daLogin;
        //SqlCommand comLogin = new SqlCommand();



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (text_user.Text == "ID ou Email")
            {
                text_user.Text = "";
                text_user.ForeColor = Color.LightCyan;
            }
        }

        private void text_pas_Enter(object sender, EventArgs e)
        {
            if (text_pas.Text == "Mot de passe")
            {
                text_pas.Text = "";
                text_pas.ForeColor = Color.LightCyan;
                text_pas.UseSystemPasswordChar = true;
            }
        }

        private void text_user_Leave(object sender, EventArgs e)
        {
            if (text_user.Text == "")
            {
                text_user.Text = "ID ou Email";
                text_user.ForeColor = Color.DimGray;
            }
        }

        private void text_pas_Leave(object sender, EventArgs e)
        {
            if (text_pas.Text == "")
            {

                text_pas.Text = "Mot de passe";
                text_pas.ForeColor = Color.DimGray;
                text_pas.UseSystemPasswordChar = false;

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //bsC = Db.remplirText("Select * from utilisateur", "utilisateur");
            ////bsC2 = Db.remplirListe(comboBox1, "Assurence_Voiture", "TYpe_Converture", "Cod_Assurences");


            //bsC = Db.remplirGrille(dataGridView1, "utilisateur");

            //cn.Open();

            //comLogin.CommandText = "select * from utilisateur";
            //comLogin.Connection = cn;
            //daLogin = new SqlDataAdapter(comLogin);
            //daLogin.Fill(ds, "utilisateur");

            //bsLogin.DataSource = ds;
            //bsLogin.DataMember = "utilisateur";




            //dataGridView1.DataSource = bsLogin;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        int rest = 0;
          int thisnb2=0;
        public bool Trial2s()
        {
            int nb2 = Properties.Settings.Default.Trial2;
            thisnb2 = nb2 + 1;
            Properties.Settings.Default.Trial2 = thisnb2;
            Properties.Settings.Default.Save();
                if (thisnb >= 2)
                {
                    return false;
                }
                else
                {
                    rest = 2 - thisnb2;
                }
           
            return true;
        }
      
      
        private void btn_login_Click(object sender, EventArgs e)
        {

     //  Properties.Settings.Default.Reset();
         
                bool check2;
                check2 = Trial2s();
                if (check2 == false )
                {
                    return;


                }


            if (rest >= 0)
            {


              //  MessageBox.Show("Ceci est une version d'essai et vous êtes laissé un certain nombre de fois" + baky, "Confirmer");
                string msg = "Ceci est une version d'essai et vous êtes laissé un certain  \n  nombre de fois"+" "+ rest;

                testM f = new testM(msg, "Confirmer");
                f.ShowDialog();

               
            }





            if (rest > 0 )
                {



                

                SqlConnection cn = new SqlConnection(@"data source=DESKTOP-J2RFDBR\SQLEXPRESS;initial catalog=Car_Rental_Pro_V1; Integrated Security = True; User Id=sa;Password=442662;");
                string query = "select * from utilisateur where (id_User= '" + text_user.Text.Replace("'", "''") + "' or Email_User= '" + text_user.Text.Replace("'", "''") + "')  and Password_User='" + text_pas.Text.Replace("'", "''") + "'  and Type_User='User'";
                string query2 = "select * from utilisateur where (id_User= '" + text_user.Text.Replace("'", "''") + "' or Email_User= '" + text_user.Text.Replace("'", "''") + "')  and Password_User='" + text_pas.Text.Replace("'", "''") + "'  and Type_User='dministarteur'";

                SqlDataAdapter dalogin = new SqlDataAdapter(query, cn);
                SqlDataAdapter daloginType = new SqlDataAdapter(query2, cn);

                DataTable dtbl = new DataTable();
                dalogin.Fill(dtbl);
                DataTable dtb2 = new DataTable();
                daloginType.Fill(dtb2);

                if (dtbl.Rows.Count == 1)
                {







                    d = text_user.Text;


                    Form1 F = new Form1(d.ToString(), "User");
                    this.Hide();
                    F.ShowDialog();

                }
                else
                    if (dtb2.Rows.Count == 1)
                {




                    d = text_user.Text;
                    Form1 F = new Form1(d.ToString(), "Admin");
                    this.Hide();
                    F.ShowDialog();

                }
                else
                {

                    string msg = "Informations d'inscription incorrectes";
                    Msg_Erreur f = new Msg_Erreur(msg);
                    f.ShowDialog();

                }



            }
            else {
                if (Properties.Settings.Default.key == "no"){
                    Formkey k = new Formkey();
                    k.ShowDialog();
                    return;
                }
                else
                {
                    SqlConnection cn = new SqlConnection(@"data source=DESKTOP-J2RFDBR\SQLEXPRESS;initial catalog=Car_Rental_Pro_V1; Integrated Security = True; User Id=sa;Password=442662; ");
                    string query = "select * from utilisateur where (id_User= '" + text_user.Text.Replace("'", "''") + "' or Email_User= '" + text_user.Text.Replace("'", "''") + "')  and Password_User='" + text_pas.Text.Replace("'", "''") + "'  and Type_User='User'";
                    string query2 = "select * from utilisateur where (id_User= '" + text_user.Text.Replace("'", "''") + "' or Email_User= '" + text_user.Text.Replace("'", "''") + "')  and Password_User='" + text_pas.Text.Replace("'", "''") + "'  and Type_User='administarteur'";

                    SqlDataAdapter dalogin = new SqlDataAdapter(query, cn);
                    SqlDataAdapter daloginType = new SqlDataAdapter(query2, cn);

                    DataTable dtbl = new DataTable();
                    dalogin.Fill(dtbl);
                    DataTable dtb2 = new DataTable();
                    daloginType.Fill(dtb2);

                    if (dtbl.Rows.Count == 1)
                    {
                        d = text_user.Text;
                        Form1 F = new Form1(d.ToString(), "User");
                        this.Hide();
                        F.ShowDialog();
                    }
                    else if (dtb2.Rows.Count == 1)
                    {
                        d = text_user.Text;
                        Form1 F = new Form1(d.ToString(), "Admin");
                        this.Hide();
                        F.ShowDialog();

                    }
                    else
                    {
                      //  MessageBox.Show("Login ou Password incorrect !!");
                        string msg ="Informations d'inscription incorrectes";
                        Msg_Erreur f = new Msg_Erreur(msg);
                        f.ShowDialog();
                    }
                }
            }
        }






        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Find_Your_Account().Show();
        }


    



        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }


      
        private void button2_Click(object sender, EventArgs e)
        {

            Form1 f = new Form1("","");
            f.ShowDialog();

        }

        private void btn_login_MouseClick(object sender, MouseEventArgs e)
        {
         //   button2.pre
        }

        private void text_pas_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_pas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }

        private void text_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }
    }
}
