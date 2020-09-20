using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PlayerUI.Properties;



namespace PlayerUI
{
    public partial class Gestion_User : Form
    {
        String id_user;

        BindingSource bsC;

        public Gestion_User(String id_user)
        {
            InitializeComponent();
            this.id_user = id_user;
        }

        private void Gestion_User_Load(object sender, EventArgs e)
        {
            bsC = Db.remplirText("Select * from utilisateur", "utilisateur");

            //dataGridView1.ColumnCount =7;
            //dataGridView1.Columns[0].Width = 110;
            //dataGridView1.Columns[1].Width = 130;

            //dataGridView1.Columns[2].Width = 130;
            //dataGridView1.Columns[3].Width = 180;
            //dataGridView1.Columns[4].Width = 0;
            //dataGridView1.Columns[5].Width = 140;

            //dataGridView1.Columns[6].Width = 0;


            bsC = Db.remplirGrille(dataGridView1, "utilisateur");


            this.dataGridView1.Columns["photo_User"].Visible = false;
            this.dataGridView1.Columns["Password_User"].Visible = false;
            this.dataGridView1.Columns[0].Width = 150;

            this.dataGridView1.Columns[1].Width = 150;
            this.dataGridView1.Columns[2].Width = 150;
            this.dataGridView1.Columns[3].Width = 250;

            this.dataGridView1.Columns[5].Width = 150;



            label2.DataBindings.Add("text", bsC, "id_User");
            
            listBox1.DataSource = bsC;
            listBox1.ValueMember = "id_User";
            listBox1.DisplayMember = "id_User";
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Add_User a = new Add_User("add", "");
            a.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow.IsNewRow == false)
            {


                Add_User a = new Add_User("modifi", listBox1.SelectedValue.ToString());
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

            if (id_user.ToString() == label2.Text)
            {
                String s = "Impossible de supprimer";
                Msg_Erreur k = new Msg_Erreur(s);
                k.ShowDialog();


            }


            else     if (dataGridView1.Rows.Count > 0)
            {


                String t1 = label2.Text;



                string t = "Etes vous certain de vouloir supprimer ce utilisateur" + " " + label2.Text;

                Msg_Suppression f = new Msg_Suppression(t, "utilisateur", listBox1.SelectedValue.ToString(),"");
                f.Show();




            }
          

      





        
            else
            {

                String s = "Vous ne pouvez pas supprimer";
                Msg_Erreur k = new Msg_Erreur(s);
                k.ShowDialog();



            }
        }

        private void text_RechercherC_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void text_RechercherC_Enter(object sender, EventArgs e)
        {
            if (text_RechercherC.Text == "Recherchez le User en utilisant id  ou email ")
            {
                text_RechercherC.Text = "";
                text_RechercherC.ForeColor = Color.Black;
            }
        }

        private void text_RechercherC_Leave(object sender, EventArgs e)
        {
            if (text_RechercherC.Text == "")
            {
                text_RechercherC.Text = "";
                text_RechercherC.ForeColor = Color.DimGray;
            }
        }

        private void btn_RechercherC_Click(object sender, EventArgs e)
        {
            bsC.Filter = " id_User like  '%" + text_RechercherC.Text.Replace("'", "''") + "%'  or   Email_User like  '%" + text_RechercherC.Text.Replace("'", "''") + "%' ";

        }

        private void text_RechercherC_TextChanged(object sender, EventArgs e)
        {
            btn_RechercherC.PerformClick();

        }
    }
}
