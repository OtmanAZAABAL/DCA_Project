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
    public partial class testM : Form
    {
        string msg;
        string action;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public testM(string msg, string action)
        {
            this.msg = msg;
            this.action = action;
            InitializeComponent();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public enum mess
        {
        done,warning,errore,information
        
        }

        private void testM_Load(object sender, EventArgs e)
        {
            ActionF.Text = action.ToString();
            //sms.Text = msg.ToString();

            sms.TextAlign = ContentAlignment.MiddleCenter;

            sms.Text = msg.ToString();
        }

        private void btn_ValiderE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}
