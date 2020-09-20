using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Formkey : Form
    {
        //int i = ((32 * 2 * 999) - (100 * 2) + 99312 + 55 - 3 - 2 + 24 + 5+1)/2;

        int i = 40;
        string realKey;
        string key;
        public Formkey()
        {
            InitializeComponent();
        }


     
      //  string X;
     //   String realKey;
      //  String oper = Convert.ToString(i);
      //  string s = string.Empty + i.ToString();


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void Formkey_Load(object sender, EventArgs e)
        {


             key = GetHDDSerial();


           

            string keys = key.Trim();
            textBox2.Text = keys;


        }

        public string GetHDDSerial()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");

            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                // get the hardware serial .
                if (wmi_HD["SerialNumber"] != null)
                    return wmi_HD["SerialNumber"].ToString();
            }

            return string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ValiderE_Click(object sender, EventArgs e)
        {

            key = GetHDDSerial();
           
            realKey = key + i.ToString();

            string trim = realKey.ToString();

            if (text_key.Text == "")
            {

                Msg_Verifier f = new Msg_Verifier("Code d'activation non renseigné");
                f.ShowDialog();
      

                return;
            }

            if (text_key.Text == trim.TrimStart().ToString())
            {
               
                Properties.Settings.Default.key = "Yes";
                Properties.Settings.Default.Save();
                Msg_Ajouter f = new Msg_Ajouter("Activation", "Activer le programme avec succès");
                f.ShowDialog();

                this.Close();
            }
            else
            {
                Msg_Erreur f = new Msg_Erreur("Code d'activation incorrect");
                f.ShowDialog();


            }
        }

        private void btn_AnnulerE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            About h = new About();
            h.ShowDialog();

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);


        }
    }
}
