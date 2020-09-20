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
    public partial class Employer : Form
    {
        BindingSource bsC;
        BindingSource bsC2;
        public Employer()

        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            Add_Employer a = new Add_Employer("add", "");
            a.ShowDialog();
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow.IsNewRow == false)
            {


                Add_Employer a = new Add_Employer("modifi", listBox1.SelectedValue.ToString());
                a.ShowDialog();


            }
            else
            {

                String s = "Vous ne pouvez pas Modifier";
                Msg_Erreur k = new Msg_Erreur(s);
                k.ShowDialog();

                // Vous ne pouvez pas Modifier
                // Vous ne pouvez pas supprimer
                //Erreur


            }

        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {


                String t1 = label2.Text;
                String t2 = label3.Text;



                string t = "Etes vous certain de vouloir supprimer ce Employer" + " " + label2.Text + "\n" + " " + label3.Text;

                Msg_Suppression f = new Msg_Suppression(t, "Employer", listBox1.SelectedValue.ToString(),"");
                f.Show();




            }
            else
            {

                String s = "Vous ne pouvez pas supprimer";
                Msg_Erreur k = new Msg_Erreur(s);
                k.ShowDialog();



            }
        }

        private void Employer_Load(object sender, EventArgs e)
        {
            bsC = Db.remplirText("Select * from Employer", "Employer");
            bsC2 = Db.remplirText("Select * from Employer", "Employer");


            bsC = Db.remplirGrille(dataGridView1, "Employer");



            label2.DataBindings.Add("text", bsC, "Nom_Employer");
            label3.DataBindings.Add("text", bsC, "Prenom_Employer");

            


            listBox1.DataSource = bsC;
            listBox1.ValueMember = "Id_Employer";
            listBox1.DisplayMember = "Id_Employer";

        }

        private void btn_RechercherC_Click(object sender, EventArgs e)
        {
            if (text_RechercherC.Text == "")
            {
                string t4 = " Id_Employer   non renseigné";
                Msg_Verifier v = new Msg_Verifier(t4);
                v.ShowDialog();

                text_RechercherC.Focus();
                return;
            }
            else 
                bsC.Filter = " Id_Employer = " + text_RechercherC.Text +   "";
        }

        private void text_RechercherC_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
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
            //if (text_RechercherC.Text == "Recherchez le  Employer id ou Tele Employer")
            //{
            //    text_RechercherC.Text = "";
            //    text_RechercherC.ForeColor = Color.Black;
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_RechercherC.PerformClick();
        }
    }
}
