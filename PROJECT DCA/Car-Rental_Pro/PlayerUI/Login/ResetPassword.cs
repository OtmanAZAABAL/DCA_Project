using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace PlayerUI
{
    public partial class ResetPassword : Form
    {


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        BindingSource bsC;

        string id;
      
        public ResetPassword(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            bsC = Db.remplirText("Select * from utilisateur", "utilisateur");

            listBox1.DataSource = bsC;
            listBox1.ValueMember = "id_User";
            listBox1.DisplayMember = "id_User";

            listBox1.SelectedValue = id.ToString();



            textBox2.DataBindings.Add("text", bsC, "Password_User");

            textBox2.Text = "";

            btn_AnnulerE.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_AnnulerE_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.ShowDialog();
        }

        private void btn_ValiderE_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != textBox1.Text)
            {
                string t10 = " le nouveau mot de passe ne correspond pas";

                Msg_Verifier v = new Msg_Verifier(t10);
                v.ShowDialog();

                textBox1.Focus();
                return;
            }


            try
                {
                    bsC.EndEdit();
                    bsC.CancelEdit();
                    Db.syncroniser("utilisateur");
                  

                    string actions = "Processus modifier";
                    string smss = "reset successfully";

                    Msg_Ajouter f = new Msg_Ajouter(actions, smss);
                    f.ShowDialog();
                    btn_AnnulerE.Enabled = true;


                }
                catch (Exception ex)
                {



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

        private void BarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
