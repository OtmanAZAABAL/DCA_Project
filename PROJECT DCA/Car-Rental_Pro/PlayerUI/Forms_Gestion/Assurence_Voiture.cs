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
    public partial class Assurence_Voiture : Form
    {
        BindingSource bsC;
        BindingSource bsC2;
        public Assurence_Voiture()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Add_Assurence_Voiture a = new Add_Assurence_Voiture("add", "");
            a.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Assurence_Voiture_Load(object sender, EventArgs e)
        {
            bsC = Db.remplirText("Select * from Assurence_Voiture", "Assurence_Voiture");
            bsC2 = Db.remplirText("Select * from Assurence_Voiture", "Assurence_Voiture");
            //bsC2 = Db.remplirListe(comboBox1, "Assurence_Voiture", "TYpe_Converture", "Cod_Assurences");


            bsC = Db.remplirGrille(dataGridView1, "Assurence_Voiture");


            label2.DataBindings.Add("text", bsC, "Nom_Assurences");
         

















            listBox1.DataSource = bsC;
            listBox1.ValueMember = "Cod_Assurences";
            listBox1.DisplayMember = "Cod_Assurences";


        }

        private void btn_RechercherC_Click(object sender, EventArgs e)
        {
           bsC.Filter = "Nom_Assurences like'%"+text_RechercherC.Text.Replace("'", "''")+"%' ";

        }

        private void text_RechercherC_TextChanged(object sender, EventArgs e)
        {
            btn_RechercherC.PerformClick();

        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {


                String t1 = label2.Text;
                String t2 = label3.Text;



                string t = "Etes vous certain de vouloir supprimer ce Assurences" + " " + label2.Text ;

                Msg_Suppression f = new Msg_Suppression(t, "Assurence_Voiture", listBox1.SelectedValue.ToString(),"");
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


                Add_Assurence_Voiture a = new Add_Assurence_Voiture("modifi", listBox1.SelectedValue.ToString());
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

        private void text_RechercherC_MouseEnter(object sender, EventArgs e)
        {
            if (text_RechercherC.Text == "Recherchez le  Voiture  Cod Assurences")
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
