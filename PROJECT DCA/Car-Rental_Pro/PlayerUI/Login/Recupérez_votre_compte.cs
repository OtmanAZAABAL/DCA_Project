using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace PlayerUI
{
    public partial class Recupérez_votre_compte : Form
    {
        BindingSource bsC;


        public int code;
        Random rnd = new Random();


        string email;

        string randomCode;
        public static string to;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        string id;



        pass p;

        public Recupérez_votre_compte(string id )
        {
            InitializeComponent();
            this.id = id;
        }

        private void Recupérez_votre_compte_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            bsC = Db.remplirText("Select * from utilisateur", "utilisateur");


            lst_Users.DataSource = bsC;
            lst_Users.ValueMember = "id_User";
            lst_Users.DisplayMember = "id_User";



            lst_Users.SelectedValue = id.ToString();



            text_Email.DataBindings.Add("text", bsC, "Email_User");



            String email ;
            String lstemail;

            lstemail = text_Email.Text;
            string last6 = lstemail.Substring(lstemail.Length - 6, 6);
            lbwith.Text = text_Email.Text.Substring(0, 3) + "******" + "" + last6.ToString();



            email = lbwith.ToString();






        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (randomCode == (text_Code_V.Text).ToString())
            {
                to = text_Email.Text;
                ResetPassword rp = new ResetPassword(id.ToString());
                this.Hide();
                rp.Show();
            }
            else
            {
                string g = "Le code est incorrect";
                Msg_Erreur f = new Msg_Erreur(g);

              
            }

     

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   
        private void btn_AnnulerE_Click(object sender, EventArgs e)
        {

            
            string t = "Veuillez utiliser ce code pour réinitialiser le mot de passe du compte  " + ":" + lbwith.Text + "\n  \n Voici votre code: ";

            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (text_Email.Text).ToString();
            from = "dragonsavers2020@gmail.com";
            pass = "YOUSSEF@AARAB2";
            messageBody = t + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "password reseting code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);


            try
            {
                smtp.Send(message);
                string msg = "code envoyé avec succès";
                Msg_Ajouter f = new Msg_Ajouter("", msg);
                f.ShowDialog();
                groupBox2.Enabled = true;
                text_Code_V.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btn_ValiderE_Click(object sender, EventArgs e)
        {
            if (randomCode == (text_Code_V.Text).ToString())
            {
                to = text_Email.Text;
                ResetPassword rp = new ResetPassword(id.ToString());
                this.Hide();
                rp.Show();
            }
            else
            {
                string g = "Le code est incorrect";
                Msg_Erreur f = new Msg_Erreur(g);
                f.ShowDialog();
                text_Code_V.Clear();
                text_Code_V.Focus();


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Recupérez_votre_compte_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_test_Click(object sender, EventArgs e)
        {

        }
    }
}
