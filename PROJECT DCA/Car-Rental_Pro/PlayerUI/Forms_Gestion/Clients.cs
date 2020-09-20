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
    public partial class Clients : Form
    {
        BindingSource bsC;
        BindingSource bsC2;

        String id_user;
        public Clients(string id_user)

        {
            this.id_user = id_user;
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //if (listBox1.Items.Count > 0)
            //{
            //    Add_Client a = new Add_Client("add", "");
            //    a.ShowDialog();

            //}
            //else 

            //{
            //    Add_Client a = new Add_Client("add", "");
            //    a.ShowDialog();

            //}



            Add_Client a = new Add_Client("add", "",id_user.ToString());
               a.ShowDialog();


        }

        private void Clients_Load(object sender, EventArgs e)
        {




            bsC = Db.remplirText("Select * from Client", "Client");
            bsC2 = Db.remplirText("Select * from Client", "Client");


            bsC = Db.remplirGrille(dataGridView1, "Client");


            label2.DataBindings.Add("text", bsC, "Nom_Client");
            label3.DataBindings.Add("text", bsC, "Prenom_Client");




            listBox1.DataSource = bsC;
            listBox1.ValueMember = "Id_Client";
            listBox1.DisplayMember = "Id_Client";


        }

        private void btn_ModifierC_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow.IsNewRow == false)
            {


                Add_Client a = new Add_Client("modifi", listBox1.SelectedValue.ToString(),id_user.ToString());
                a.ShowDialog();



            }
            else
            {

                String s = "Vous ne pouvez pas Modifier";
                Msg_Erreur k= new Msg_Erreur(s);
                k.ShowDialog();

                // Vous ne pouvez pas Modifier
                // Vous ne pouvez pas supprimer
                //Erreur


            }




        }

        private void btn_supprimerC_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 )
            {


                String t1 = label2.Text;
                String t2 = label3.Text;


           
                string t = "Etes vous certain de vouloir supprimer ce Client" + " " + label2.Text + "\n" + " " + label3.Text;

                Msg_Suppression f = new Msg_Suppression(t, "Client", listBox1.SelectedValue.ToString(),id_user.ToString());
                f.Show();




            }
            else
            {

                String s = "Vous ne pouvez pas supprimer";
                Msg_Erreur k = new Msg_Erreur(s);
                k.ShowDialog();



            }
        }
        private void btn_RechercherC_Click(object sender, EventArgs e)
        {
            bsC.Filter = " Id_Client like  '%" + text_RechercherC.Text.Replace("'", "''") + "%'  or  Tel_Client like '%" + text_RechercherC.Text.Replace("'", "''") + "%' ";

        }

        private void text_RechercherC_TextChanged(object sender, EventArgs e)
        {
            btn_RechercherC.PerformClick();

        }

        private void text_RechercherC_MouseEnter(object sender, EventArgs e)
        {
            if (text_RechercherC.Text == "Recherchez le  Client  id ou Tele Client")
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
