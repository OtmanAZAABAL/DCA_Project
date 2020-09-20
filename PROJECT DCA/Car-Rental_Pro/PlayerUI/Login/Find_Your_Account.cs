using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace PlayerUI
{
    public partial class Find_Your_Account : Form
    {
        string id;
        public Find_Your_Account()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Find_Your_Account_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            btn_find.Enabled = false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection(@"data source=DESKTOP-J2RFDBR\SQLEXPRESS;initial catalog=Car_Rental_Pro_V1; Integrated Security = True; User Id=sa;Password=442662;");
            string query = "select * from utilisateur where Email_User= '" + text_Rechercher.Text.Replace("'", "''") + "' or  id_User='" + text_Rechercher.Text.Replace("'", "''") + "'";

            SqlDataAdapter dalogin = new SqlDataAdapter(query, cn);

            DataTable dtbl = new DataTable();
            dalogin.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                pictureBox1.Visible = true;
                text_Rechercher.Enabled = false;
                btn_find.Enabled = true;
                btn_login.Enabled = false;

                 id = text_Rechercher.Text;

                //  Gestion_Ventes.getGestion_Ventes.btnANC.Enabled = true;
                //    Form1 F = new Form1(d.ToString(), "User");
                ///     this.Hide();
                //  F.Show();

            }
            else
            {

                string msg = "Informations d'inscription incorrectes";
                Msg_Erreur f = new Msg_Erreur(msg);
                f.ShowDialog();



            }


        }

        private void text_email_Enter(object sender, EventArgs e)
        {
            if (text_Rechercher.Text == "Veuillez saisir votre adresse é-mail ou votre ID user")
            {
                text_Rechercher.Text = "";
                text_Rechercher.ForeColor = Color.LightCyan;
            }
        }

        private void text_email_Leave(object sender, EventArgs e)
        {

            if (text_Rechercher.Text == "")
            {
                text_Rechercher.Text = "Nom d'utilisateur ou E-mail";
                text_Rechercher.ForeColor = Color.DimGray;
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            Recupérez_votre_compte f = new Recupérez_votre_compte(id.ToString());
            this.Hide();
            
            f.ShowDialog();
        }

        private void Find_Your_Account_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    
    }
}
