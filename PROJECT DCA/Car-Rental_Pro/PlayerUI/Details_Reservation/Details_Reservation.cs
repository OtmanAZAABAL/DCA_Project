using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Details_Reservation : Form
    {
        string id_user;
        //BindingSource bsDetails_Emplacment;
        //BindingSource bsUser;


        //BindingSource bsVoiture;
        //BindingSource bsDetail_Remise;
        //BindingSource bsAssurence_Voiture;
        //BindingSource bsClient;

        //BindingSource bsEmployer;

        BindingSource bsC;
        BindingSource bsC2;
        public Details_Reservation(string id_user)
        {
            InitializeComponent();
            this.id_user = id_user;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Add_Details_Reservation a = new Add_Details_Reservation("add", "", id_user.ToString());
            a.ShowDialog();
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow.IsNewRow == false)
            {


                Add_Details_Reservation a = new Add_Details_Reservation("modifi", listBox1.SelectedValue.ToString(), id_user.ToString());
                a.ShowDialog();



            }
            else
            {

                String s = "Vous ne pouvez pas Modifier";
                Msg_Erreur k = new Msg_Erreur(s);
                k.ShowDialog();




            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {


                String t1 = label2.Text;
                String t2 = label3.Text;



                string t = "Etes vous certain de vouloir supprimer ce Reservation" + " " + label2.Text;


                Msg_Suppression f = new Msg_Suppression(t, "Details_Reservation", listBox1.SelectedValue.ToString(),id_user.ToString());
                f.Show();




            }
            else
            {

                String s = "Vous ne pouvez pas supprimer";
                Msg_Erreur k = new Msg_Erreur(s);
                k.ShowDialog();



            }
        }

        private void Details_Reservation_Load(object sender, EventArgs e)
        {
            bsC = Db.remplirText("Select * from Details_Reservation", "Details_Reservation");
            bsC2 = Db.remplirText("Select * from Details_Reservation", "Details_Reservation");
            bsC = Db.remplirListe(cb, "Details_Reservation", "Reservation_id", "Reservation_id");




            bsC = Db.remplirText("Select * from Details_Reservation", "Details_Reservation");



            bsC = Db.remplirGrille(dataGridView1, "Details_Reservation");




          







            label2.DataBindings.Add("text", bsC, "Reservation_id");













            listBox1.DataSource = bsC;
            listBox1.ValueMember = "Reservation_id";
            listBox1.DisplayMember = "Reservation_id";


          //  label2.DataBindings.Add("text", bsC, "Reservation_id");













            listBox1.DataSource = bsC;
            listBox1.ValueMember = "Reservation_id";
            listBox1.DisplayMember = "Reservation_id";




        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (dataGridView1.Rows.Count > 0)
            {

                Facture_Pro l = new Facture_Pro();

                string filtre = "{Details_Reservation.Reservation_id} =" + (listBox1.SelectedValue.ToString());

                FrmImpression2 f = new FrmImpression2(l, filtre);
                f.ShowDialog();
                this.Refresh();



            }
            else
            {

                String s = "Vous ne pouvez pas Imprimer ";
                Msg_Erreur k = new Msg_Erreur(s);
                k.ShowDialog();



            }

          

        }

        private void btn_RechercherC_Click(object sender, EventArgs e)
        {
            if (text_RechercherC.Text == "")
            {
                string t4 = " Reservation_id   non renseigné";
                Msg_Verifier v = new Msg_Verifier(t4);
                v.ShowDialog();

                text_RechercherC.Focus();
                return;
            }
            else
            bsC.Filter = " Reservation_id = " + text_RechercherC.Text + "";

          //  bsC.Filter = "   Reservation_id = '" + Int32.Parse(text_RechercherC.Text) + "' ";
        }

        private void text_RechercherC_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_RechercherC_MouseLeave(object sender, EventArgs e)
        {
            //if (text_RechercherC.Text == "")
            //{
            //    text_RechercherC.Text = "";
            //    text_RechercherC.ForeColor = Color.DimGray;
            //}

        }

        private void text_RechercherC_MouseEnter(object sender, EventArgs e)
        {
            //if (text_RechercherC.Text == "Recherchez le Reservation id")
            //{
            //    text_RechercherC.Text = "";
            //    text_RechercherC.ForeColor = Color.Black;
            //}
        }

        private void text_RechercherC_KeyDown(object sender, KeyEventArgs e)
        {

          
        }

        private void text_RechercherC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) != true && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn_RechercherC.PerformClick();

        }
    }
}
