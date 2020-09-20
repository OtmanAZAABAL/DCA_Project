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
    public partial class Details_Emplacment : Form
    {

        BindingSource bsC;
        BindingSource bsC2;
        public Details_Emplacment()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Details_Emplacment_Load(object sender, EventArgs e)
        {

            bsC = Db.remplirText("Select * from Details_Emplacment", "Details_Emplacment");
            bsC2 = Db.remplirText("Select * from Details_Emplacment", "Details_Emplacment");


            bsC = Db.remplirGrille(dataGridView1, "Details_Emplacment");


            label2.DataBindings.Add("text", bsC, "Nom_Emplacment");




            listBox1.DataSource = bsC;
            listBox1.ValueMember = "Emplacement_Id";
            listBox1.DisplayMember = "Emplacement_Id";
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Add_Details_Emplacment a = new Add_Details_Emplacment("add", "");
            a.ShowDialog();
        }

        private void btn_ModifierC_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow.IsNewRow == false)
            {


                Add_Details_Emplacment a = new Add_Details_Emplacment("modifi", listBox1.SelectedValue.ToString());
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

        private void btn_supprimerC_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {


                String t1 = label2.Text;



                string t = "Etes vous certain de vouloir supprimer ce Emplacment" + " " + label2.Text;

                Msg_Suppression f = new Msg_Suppression(t, "Details_Emplacment", listBox1.SelectedValue.ToString(),"");
                f.ShowDialog();




            }
            else
            {

                String s = "Vous ne pouvez pas supprimer";
                Msg_Erreur k = new Msg_Erreur(s);
                k.ShowDialog();



            }
        }

        private void text_RechercherC_TextChanged(object sender, EventArgs e)
        {
            btn_RechercherC.PerformClick();

        }

        private void btn_RechercherC_Click(object sender, EventArgs e)
        {
            bsC.Filter = " Emplacement_Id like  '%" + text_RechercherC.Text.Replace("'", "''") + "%'  ";

        }

        private void text_RechercherC_MouseEnter(object sender, EventArgs e)
        {
            if (text_RechercherC.Text == "Recherchez le Emplacement Id")
            {
                text_RechercherC.Text = "";
                text_RechercherC.ForeColor = Color.Black;
            }

        }

        private void text_RechercherC_MouseLeave(object sender, EventArgs e)
        {
            if (text_RechercherC.Text == "")
            {
                text_RechercherC.Text = "";
                text_RechercherC.ForeColor = Color.DimGray;
            }

        }
    }

}

