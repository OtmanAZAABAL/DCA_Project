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
    public partial class Details_Facture : Form
    {
        public Details_Facture()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Add_Details_Facture a = new Add_Details_Facture("add", "");
            a.ShowDialog();
        }

        private void btn_ModifierC_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow.IsNewRow == false)
            {


                Add_Details_Facture a = new Add_Details_Facture("modifi", listBox1.SelectedValue.ToString());
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



                string t = "Etes vous certain de vouloir supprimer ce Facture" + " " + label2.Text;

                Msg_Suppression f = new Msg_Suppression(t, "Details_Facture", listBox1.SelectedValue.ToString(),"");
                f.Show();




            }
            else
            {

                String s = "Vous ne pouvez pas supprimer";
                Msg_Erreur k = new Msg_Erreur(s);
                k.ShowDialog();



            }
        }

        private void Details_Facture_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Details_Facture_Load_1(object sender, EventArgs e)
        {

        }

        private void text_RechercherC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
