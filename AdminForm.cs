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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void setticketbtn_Click(object sender, EventArgs e)
        {
            TicketsPriceSet tps = new TicketsPriceSet();
            tps.Show();
            this.Hide();
        }

        


        private void visitordetailsbtn_Click(object sender, EventArgs e)
        {
            VisitorDetails vd = new VisitorDetails();
            vd.Show();
            this.Hide();
        }

        private void dwreportbtn_Click(object sender, EventArgs e)
        {
            GenerateReport gr = new GenerateReport();
            gr.Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Console.WriteLine(System.IO.Path.GetDirectoryName(Application.ExecutablePath));
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
