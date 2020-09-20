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
    public partial class Form1 : Form
    {
        String id;
        String type;
        BindingSource bsC;
        BindingSource bsnbC;
        BindingSource bsCVoiture;
        BindingSource bsCClients;
        BindingSource bsCDetails_Reservation;
        BindingSource bc_E;


        string id_user;
        public Form1(String id , String type)
        {
            InitializeComponent();
            hideSubMenu();

            this.id = id;
            this.type = type;
        }

        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Clients(id_user));
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            openChildForm(new Details_Reservation(id_user));

            //..
            //your codes
            //..
            hideSubMenu();
            this.Refresh();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            
            openChildForm(new Detail_Remise());

            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            openChildForm(new Assurence_Voiture());

            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);

        }

        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            openChildForm(new Voiture());

            this.Refresh();

            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new Categorie_Voiture());

            hideSubMenu();
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new Details_Emplacment());

            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            openChildForm(new GPS());

        }
        #endregion

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }
        #region ToolsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
          
            openChildForm(new Clients(id_user));
            this.Refresh();

            hideSubMenu();

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

 
        private void button18_Click(object sender, EventArgs e)
        {
            openChildForm(new Employer());

            hideSubMenu();
            
        }

     
       

        private void button27_Click(object sender, EventArgs e)
        {
            Settings n = new Settings();
            n.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            About he = new About();
            he.ShowDialog();
        }

     

        private void button16_Click(object sender, EventArgs e)
        {
            openChildForm(new Details_Reservation(""));

            hideSubMenu();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            
            openChildForm(new Gestion_User(id_user));

            hideSubMenu();
            this.Refresh();

        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            Settings n = new Settings();
            n.ShowDialog();
            this.Refresh();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {













            bsCVoiture = Db.remplirListe(lst_Voiture, "Voiture", "Numero_Enrg", "Numero_Enrg");



            bc_E = Db.remplirListe(lstphoto_Ec, "Parametres", "id_P", "id_P");

            bsCClients = Db.remplirListe(lst_Client, "Client", "Id_Client", "Id_Client");
            bsCDetails_Reservation = Db.remplirListe(lst_Details_Reservation, "Details_Reservation", "Reservation_id", "Reservation_id");


            //string s = "select * from Details_Reservation where DATEPART(d, getdate()) = DATEPART(d, Date_Location);";
            //bsCDetails_Reservation = Db.remplirListe(lst_Details_Reservation, s, "Details_Reservation", "Reservation_id", "Reservation_id");
            bc_E = Db.remplirText("Select * from Parametres", "Parametres");


            bsC = Db.remplirText("Select * from utilisateur", "utilisateur");



            int lstcli = lst_Client.Items.Count;
            label16.Text = lstcli.ToString();


            int lstv = lst_Voiture.Items.Count;
            label2.Text = lstv.ToString();


            int lstre = lst_Details_Reservation.Items.Count;
            label1.Text = lstre.ToString();










            lst_id_user.DataSource = bsC;
            lst_id_user.ValueMember = "id_User";
            lst_id_user.DisplayMember = "id_User";



            lst_id_user.SelectedValue = id.ToString();

         
            lst_nom.DataSource = bsC;
            lst_nom.ValueMember = "id_User";
            lst_nom.DisplayMember = "Nom_User";


            lst_prenom.DataSource = bsC;
            lst_prenom.ValueMember = "id_User";
            lst_prenom.DisplayMember = "Prenom_User";

            lst_email.DataSource = bsC;
            lst_email.ValueMember = "id_User";
            lst_email.DisplayMember = "Email_User";



            lst_type.DataSource = bsC;
            lst_type.ValueMember = "id_User";
            lst_type.DisplayMember = "Type_User";



            lst_photos.DataSource = bsC;
            lst_photos.ValueMember = "id_User";
            lst_photos.DisplayMember = "photo_User";



            lstphoto_Ec.DataSource = bc_E;
            lstphoto_Ec.ValueMember = "id_P";
            lstphoto_Ec.DisplayMember = "fond_d_ecran";
            


            lb_Email.Text = lst_email.Text.ToString();
            label3.Text ="User :"+ lst_id_user.Text.ToString();
            string nom  = lst_nom.Text.ToString();
              string prenom = lst_prenom.Text.ToString();
            lb_nom_Com.Text = nom + " " + prenom;



            text_photo.Text = lst_photos.Text.ToString();


            text_photo_E.Text = lstphoto_Ec.Text.ToString();



            text_photo.Enabled = false;
            text_photo_E.Enabled = false;

            id_user = lst_id_user.Text.ToString();
            if (type == "User")
            {









                bnt_Location.Enabled = true;
                btn_V.Enabled = true;

                //btn_m.Enabled = true;

                btnC.Enabled = true;
                btn_Emp.Enabled = false;

                Btn_fa.Enabled = true;
              //btn_repo.Enabled = false;
                btn_Uti.Enabled = false;
                btn_para.Enabled = false;

                btn_about.Enabled = true;

            }
            else if (type == "Admin")
            {
                



                bnt_Location.Enabled = true;
                btn_V.Enabled = true;

                //btn_m.Enabled = true;

                btnC.Enabled = true;
                btn_Emp.Enabled = true;

                Btn_fa.Enabled = true;
             //   btn_repo.Enabled = true;
                btn_Uti.Enabled = true;
                btn_para.Enabled = true;

                btn_about.Enabled = true;


            }
        }





        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void circular_PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void lb_photo_Click(object sender, EventArgs e)
        {

        }

        private void text_photo_TextChanged(object sender, EventArgs e)
        {
            string photo = text_photo.Text == "" ? "vide.png" : text_photo.Text;

            PictureBox1.Load("imagesUser/" + photo);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {



            lb_h.Text = DateTime.Now.ToString("hh:mm:ss ");



        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            openChildForm(new history());

            hideSubMenu();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lb_h_Click(object sender, EventArgs e)
        {

        }

        private void panelChildForm_MouseLeave(object sender, EventArgs e)
        {

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            string nomFichier = openFileDialog1.FileName;
            string ext = Path.GetExtension(nomFichier);

            Random n = new Random();
            long i = n.Next();

            string d = DateTime.Now.ToString().Replace("/", "").Replace(" ", "").Replace(":", "");
            File.Copy(nomFichier, "imagesE/" + d + i + ext);
            text_photo_E.Text = d + i + ext;
            Application.DoEvents();

        }

        private void text_photo_E_TextChanged(object sender, EventArgs e)
        {
            string photo = text_photo_E.Text == "" ? "vide.png" : text_photo_E.Text;

            pictureBox2.Load("imagesE/" + photo);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_repo_Click(object sender, EventArgs e)

        {
        //    openChildForm(new Rapports());

        //    hideSubMenu();

            Rapports s =new Rapports();
            s.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            About f = new About();
            f.ShowDialog();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

         //   openChildForm(new GPS());

            //hideSubMenu();

        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            

       //     openChildForm(new Details_Reservation(id_user));

            //hideSubMenu();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
           // openChildForm(new Details_Reservation(id_user));

            //hideSubMenu();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
          //  openChildForm(new GPS());

            //hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            openChildForm(new GPS());

            hideSubMenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }
    }
}
