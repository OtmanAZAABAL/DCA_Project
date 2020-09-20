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
    public partial class Detail_Remise : Form
    {

        BindingSource bsC;
        BindingSource bsC2;
        public Detail_Remise()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
      
       
        private void Detail_Remise_Load(object sender, EventArgs e)
        {
            bsC = Db.remplirText("Select * from Detail_Remise", "Detail_Remise");
            bsC2 = Db.remplirText("Select * from Detail_Remise", "Detail_Remise");


            bsC = Db.remplirGrille(dataGridView1, "Detail_Remise");


            label2.DataBindings.Add("text", bsC, "Code_Remise");


















            listBox1.DataSource = bsC;
            listBox1.ValueMember = "Code_Remise";
            listBox1.DisplayMember = "Code_Remise";


        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {


                String t1 = label2.Text;
                String t2 = label3.Text;



                string t = "Etes vous certain de vouloir supprimer ce Remise" + " " + label2.Text;

                Msg_Suppression f = new Msg_Suppression(t, "Detail_Remise", listBox1.SelectedValue.ToString(),"");
                f.Show();



            }
            else
            {

                String s = "Vous ne pouvez pas supprimer";
                Msg_Erreur k = new Msg_Erreur(s);
                k.ShowDialog();



            }
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow.IsNewRow == false)
            {


                Add_Detail_Remise a = new Add_Detail_Remise("modifi", listBox1.SelectedValue.ToString());
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Add_Detail_Remise a = new Add_Detail_Remise("add", "");
            a.ShowDialog();
        }

     

        private void btn_RechercherC_Click(object sender, EventArgs e)
        {
            //bsC = Db.remplirText("Select * from Detail_Remise", "Detail_Remise");

            bsC.Filter = "Nom_Remise like '%" + text_RechercherC.Text.Replace("'", "''")+"%'";

        }

        private void text_RechercherC_TextChanged(object sender, EventArgs e)
        {
            btn_RechercherC.PerformClick();

        }

        private void text_RechercherC_MouseEnter(object sender, EventArgs e)
        {
            if (text_RechercherC.Text == "Recherchez le Nom Remise")
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
