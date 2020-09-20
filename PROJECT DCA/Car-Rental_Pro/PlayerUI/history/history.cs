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
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
        }
        private void OpeanForm(object Forms)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Forms as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void history_Load(object sender, EventArgs e)
        {
            OpeanForm(new Clients_history());

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            OpeanForm(new Clients_history());

        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
           OpeanForm(new Details_Reservation_History());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
