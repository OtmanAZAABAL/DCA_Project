using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class GPS : Form
    {
        BindingSource bsC;
        public GPS()
        {
            InitializeComponent();
        }

        private void OpeanForm(object Forms)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Forms as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }


        private void GPS_Load(object sender, EventArgs e)
        {
            ////if (rd_GPS.Checked)
            ////{
            ////    OpeanForm(new Form_GPS());

            ////}
            ////else if(RD_GPS_LINE.Checked){
            ////    OpeanForm(new FORM_GPS_LINK());


            ////}
            //OpeanForm(new Form_GPS());




            string s = "select * from Voiture where link !=''";
            bsC = Db.remplirListe(cb_link,s, "Voiture", "Numero_Enrg", "Numero_Enrg");
            text_img.DataBindings.Add("text", bsC, "Photo_Voiture");


            txet_link.DataBindings.Add("text", bsC, "link");
           






        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Close();
        }

        private void btn_Gps_Click(object sender, EventArgs e)
        {
        }

        private void btn_gp_link_Click(object sender, EventArgs e)
        {
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txet_link.Text);

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

        private void text_img_TextChanged(object sender, EventArgs e)
        {

            string photo = text_img.Text == "" ? "vide.png" : text_img.Text;

            pictureBox1.Load("imagesV/" + photo);
        }
    }
}
