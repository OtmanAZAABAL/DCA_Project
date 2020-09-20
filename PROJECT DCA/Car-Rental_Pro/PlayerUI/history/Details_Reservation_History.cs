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
    public partial class Details_Reservation_History : Form
    {
        BindingSource bsC;

        public Details_Reservation_History()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Details_Reservation_History_Load(object sender, EventArgs e)
        {
            bsC = Db.remplirText("Select * from HistoryReservation", "HistoryReservation");


            bsC = Db.remplirGrille(dataGridView1, "HistoryReservation");
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
