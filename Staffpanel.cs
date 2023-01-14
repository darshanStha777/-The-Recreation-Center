using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recreation_Centre_System
{
    public partial class Staffpanel : Form
    {
        public Staffpanel()
        {
            InitializeComponent();
        }

        private void ticketbillingbtn_Click(object sender, EventArgs e)
        {
            TicketsBillingsForm billingTicket = new TicketsBillingsForm();
            billingTicket.Show();
            this.Hide();
        }

        private void dticketsbtn_Click(object sender, EventArgs e)
        {
            Details_of_TicketPrice tpd = new Details_of_TicketPrice();
            tpd.Show();
            this.Hide();
        }

        private void dvisitorbtn_Click(object sender, EventArgs e)
        {
            VisitorDetails vd = new VisitorDetails();
            vd.Show();
            this.Hide();
        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm aa = new LoginForm();
            this.Hide();
            aa.ShowDialog();
            this.Close();
        }
    }
}
