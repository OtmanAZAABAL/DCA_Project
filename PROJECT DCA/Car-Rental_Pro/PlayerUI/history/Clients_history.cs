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
    public partial class Clients_history : Form
    {
        BindingSource bsC;
        public Clients_history()
        {
            InitializeComponent();
        }

        private void Clients_history_Load(object sender, EventArgs e)
        {
            
            bsC = Db.remplirText("Select * from HistoryClient", "HistoryClient");


            bsC = Db.remplirGrille(dataGridView1, "HistoryClient");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
