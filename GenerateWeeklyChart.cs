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
using System.Windows.Forms.DataVisualization.Charting;

namespace Recreation_Centre_System
{
    public partial class GenerateWeeklyChart : Form
    {
        XmlSerializer secondxmlSerializer;
        List<VistorDetails> vistorDtlstwo;

        String cDate = DateTime.Now.ToString("yyyy-MM-dd");
        public GenerateWeeklyChart()
        {
            InitializeComponent();
            secondxmlSerializer = new XmlSerializer(typeof(List<VistorDetails>));
            vistorDtlstwo = new List<VistorDetails>();
            weeklyChart(cDate);
        }

        private void weeklyChart(String date)
        {
            FileStream fileStream = new FileStream(path.pathC, FileMode.Open, FileAccess.Read);

            try
            {

                var vistor2 = secondxmlSerializer.Deserialize(fileStream);

                vistorDtlstwo = (List<VistorDetails>)vistor2;

                DataTable dataT = new DataTable();

                dataT.Columns.Add("Day");
                dataT.Columns.Add("Total Visitor");
                dataT.Columns.Add("Total Earning");

                int indate = ((int)DateTime.Parse(cDate).DayOfWeek);
                String fDate = (DateTime.Parse(cDate).AddDays(-indate)).ToString("yyyy-MM-dd");
                String LDate = (DateTime.Parse(cDate).AddDays((7 - indate))).ToString("yyyy-MM-dd");

                dataT.Rows.Add("Sunday", calender(fDate), totalPrice(fDate));
                dataT.Rows.Add("Monday", calender(DateTime.Parse(fDate).AddDays(1).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(1).ToString("yyyy-MM-dd")));
                dataT.Rows.Add("Tuesday", calender(DateTime.Parse(fDate).AddDays(2).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(2).ToString("yyyy-MM-dd")));
                dataT.Rows.Add("Wednesday", calender(DateTime.Parse(fDate).AddDays(3).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(3).ToString("yyyy-MM-dd")));
                dataT.Rows.Add("Thursday", calender(DateTime.Parse(fDate).AddDays(4).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(4).ToString("yyyy-MM-dd")));
                dataT.Rows.Add("Friday", calender(DateTime.Parse(fDate).AddDays(5).ToString("yyyy-MM-dd")), totalPrice(DateTime.Parse(fDate).AddDays(5).ToString("yyyy-MM-dd")));
                dataT.Rows.Add("Saturday", calender(LDate), totalPrice(LDate));

                chart1.Series["Series1"].LegendText = "Visitors";
                chart1.Series["Series1"].ChartType = SeriesChartType.Column;
                chart1.Series["Series1"].IsValueShownAsLabel = true;
                chart1.Series["Series1"].XValueMember = "Day";
                chart1.Series["Series1"].YValueMembers = "Total Visitor";
                chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
                chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
                chart1.DataSource = dataT;

                chart2.Series["Series1"].LegendText = "Price";
                chart2.Series["Series1"].ChartType = SeriesChartType.Column;
                chart2.Series["Series1"].IsValueShownAsLabel = true;
                chart2.Series["Series1"].XValueMember = "Day";
                chart2.Series["Series1"].YValueMembers = "Total Earning";
                chart2.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
                chart2.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
                chart2.DataSource = dataT;

                fileStream.Close();
            }
            catch(Exception e)
            {
                fileStream.Close();
            }


        }

        public int calender(String cal)
        {

            int child = vistorDtlstwo.Where(a => a.date.ToString("yyyy-MM-dd") == cal && (a.age >= 5 && a.age <= 12)).Count();
            int adult = vistorDtlstwo.Where(a => a.date.ToString("yyyy-MM-dd") == cal && (a.age >= 13 && a.age <= 60)).Count();
            int group5 = vistorDtlstwo.Where(a => a.date.ToString("yyyy-MM-dd") == cal && a.group == 5).Count() * 5;
            int group10 = vistorDtlstwo.Where(a => a.date.ToString("yyyy-MM-dd") == cal && a.group == 10).Count() * 10;
            int group15 = vistorDtlstwo.Where(a => a.date.ToString("yyyy-MM-dd") == cal && a.group == 15).Count() * 15;
            int group20 = vistorDtlstwo.Where(a => a.date.ToString("yyyy-MM-dd") == cal && a.group == 20).Count() * 20;

            int sum = child + adult + group5 + group10 + group15 + group20;
            return sum;
        }

        public int totalPrice(String cal)
        {

            int totalprice = vistorDtlstwo.Where(a => a.date.ToString("yyyy-MM-dd") == cal).Select(a => a.TotalPrice).Sum();

            return totalprice;
        }

        private void WeeklyChart_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GenerateReport r = new GenerateReport();
            r.Show();
            this.Hide();
        }
    }
}
