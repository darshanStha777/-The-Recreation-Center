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
    public partial class VisitorDetails : Form
    {
        XmlSerializer xmlSerializer2;
        List<VistorDetails> vistorDetails;

        public VisitorDetails()
        {
            InitializeComponent();
            vistorDetails = new List<VistorDetails>();
            xmlSerializer2 = new XmlSerializer(typeof(List<VistorDetails>));
            abc();
            if(vistorDetails.Count > 0)
            {
                visiterdataGridV.DataSource = vistorDetails;
            }
            else
            {
                visiterdataGridV.DataSource = vistorDetails;
                Console.WriteLine("No visitor Entered Till date");
            }
        }

        private void abc()
        {
            FileStream fileStream = new FileStream(path.pathC, FileMode.Open, FileAccess.Read);
            try
            {
                var v = xmlSerializer2.Deserialize(fileStream);

                vistorDetails = (List<VistorDetails>)v;

                Console.WriteLine(vistorDetails);
                fileStream.Close();
            }
            catch (Exception e)
            {
                fileStream.Close();
            }

        }

        

        private void Visitor_Details_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Staffpanel staffpage = new Staffpanel();
            staffpage.Show();
            this.Hide();

        }
    }
}
