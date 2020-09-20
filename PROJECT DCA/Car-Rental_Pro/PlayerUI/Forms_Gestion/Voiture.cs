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
    public partial class Voiture : Form
    {

        BindingSource bsC;
        BindingSource bsC2;
        BindingSource bsDetails_Emplacment;
        BindingSource Categorie_Voiture;

        public Voiture()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Add_Voiture a = new Add_Voiture("add", "");
            a.ShowDialog();
        }

        private void btn_ModifierC_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow.IsNewRow == false)
            {


                Add_Voiture a = new Add_Voiture("modifi", listBox1.SelectedValue.ToString());
                a.ShowDialog();



            }
            else
            {

                String s = "Vous ne pouvez pas Modifier";
                Msg_Erreur k = new Msg_Erreur(s);
                k.ShowDialog();

               


            }
        }

        private void btn_supprimerC_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {


                String t1 = label2.Text;



                string t = "Etes vous certain de vouloir supprimer ce Voiture" + " " + label2.Text ;

                Msg_Suppression f = new Msg_Suppression(t, "Voiture", listBox1.SelectedValue.ToString(),"");
                f.Show();




            }
            else
            {

                String s = "Vous ne pouvez pas supprimer";
                Msg_Erreur k = new Msg_Erreur(s);
                k.ShowDialog();



            }
        }

        private void Voiture_Load(object sender, EventArgs e)
        {
            bsC = Db.remplirText("Select * from Voiture", "Voiture");
            bsC2 = Db.remplirText("Select * from Voiture", "Voiture");
            //bsDetails_Emplacment = Db.remplirListe(cb_emplacemrnt, "Details_Emplacment", "Emplacement_Id", "Emplacement_Id");
            //Categorie_Voiture = Db.remplirListe(cb_nom_Ctegorie, "Categorie_Voiture", "Nom_Categorie", "Nom_Categorie");

            bsC = Db.remplirText("Select * from Voiture", "Voiture");



            bsC = Db.remplirGrille(dataGridView1, "Voiture");





          











            label2.DataBindings.Add("text", bsC, "Numero_Enrg");













            listBox1.DataSource = bsC;
            listBox1.ValueMember = "Numero_Enrg";
            listBox1.DisplayMember = "Numero_Enrg";
        }

        private void text_RechercherC_TextChanged(object sender, EventArgs e)
        {
            btn_RechercherC.PerformClick();

        }

        private void text_RechercherC_MouseLeave(object sender, EventArgs e)
        {
            if (text_RechercherC.Text == "")
            {
                text_RechercherC.Text = "";
                text_RechercherC.ForeColor = Color.DimGray;
            }

        }

        private void text_RechercherC_MouseEnter(object sender, EventArgs e)
        {
            if (text_RechercherC.Text == "Recherchez le  Voiture  Numero Enrg")
            {
                text_RechercherC.Text = "";
                text_RechercherC.ForeColor = Color.Black;
            }

        }

        private void btn_RechercherC_Click(object sender, EventArgs e)
        {
            bsC.Filter = " Numero_Enrg like  '%" + text_RechercherC.Text.Replace("'", "''") + "%'  ";

        }
    }
}
