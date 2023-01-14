using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Recreation_Centre_System
{
    public partial class Details_of_TicketPrice : Form
    {
        XmlSerializer xmlSerializer;
        List<TicketPrice> ticketPrices;

        public Details_of_TicketPrice()
        {
            InitializeComponent();
            ticketPrices = new List<TicketPrice>();
            xmlSerializer = new XmlSerializer(typeof(List<TicketPrice>));
            abc();
            ticketpricedataGridView.DataSource = ticketPrices;
        }

        private void abc()
        {
            FileStream fileStream = new FileStream(path.pathB, FileMode.Open, FileAccess.Read);
            try
            {
                var v = xmlSerializer.Deserialize(fileStream);

                ticketPrices = (List<TicketPrice>)v;

                fileStream.Close();
            }
            catch (Exception e)
            {
                fileStream.Close();
            }

        }

        private void ticketpricedataGridView_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Staffpanel staffpage = new Staffpanel();
            staffpage.Show();
            this.Hide();

        }

        private void ticketpricedataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
