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
    public partial class TicketsPriceSet : Form
    {
        XmlSerializer xmlSerializer;
        List<TicketPrice> ticketPrices;

        public TicketsPriceSet()
        {
            InitializeComponent();
            ticketPrices = new List<TicketPrice>();
            xmlSerializer = new XmlSerializer(typeof(List<TicketPrice>));
            abc();
        }

        private void setpricebtn_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(path.pathB, FileMode.OpenOrCreate, FileAccess.Write);
            
            Random ra = new Random();

            TicketPrice Tprice = new TicketPrice();

            if (dayTypeCBox.SelectedIndex == 0)
            {

                if (rbtnchild.Checked || rbtnadult.Checked)
                {
                    Tprice.dayType = dayTypeCBox.SelectedItem.ToString();

                    if (rbtnchild.Checked)
                    {
                        if (ticketPrices.Count > 0)
                        {
                            foreach (TicketPrice t in ticketPrices)
                            {
                                if (t.dayType == "Weekday" && (t.age >= 5 && t.age <= 12))
                                {
                                    Console.WriteLine("Already Exist");
                                    fileStream.Close();
                                    return;
                                }
                            }
                        }

                        Tprice.age = ra.Next(5, 11);
                    }
                    else
                    {
                        if(ticketPrices.Count > 0)
                        {
                            foreach (TicketPrice t in ticketPrices)
                            {
                                if (t.dayType == "Weekday" && (t.age >= 13 && t.age <= 60))
                                {
                                    Console.WriteLine("already exist");
                                    fileStream.Close();
                                    return;
                                }
                            }
                        }

                        Tprice.age = ra.Next(12, 60);
                    }

                    Tprice.group = 0;

                    Tprice.oneHour = Int32.Parse(onehourtxtb.Text);
                    Tprice.twoHour = Int32.Parse(twohourtxtb.Text);
                    Tprice.threeHour = Int32.Parse(threehourtxtb.Text);
                    Tprice.fourHour = Int32.Parse(fourhourtxtb.Text);
                    Tprice.wholeday = Int32.Parse(wholedaytextb.Text);

                    Console.WriteLine("Radio button weekday");
                    Console.WriteLine(Tprice.dayType);
                }

                if(comboBox2.SelectedIndex >= 0)
                {
                    if(ticketPrices.Count > 0) {
                        if (comboBox2.SelectedIndex == 0)
                        {
                            foreach (TicketPrice t in ticketPrices)
                            {
                                if (t.dayType == "Weekday" && t.group == 5)
                                {
                                    Console.WriteLine("already exist");
                                    fileStream.Close();
                                    return;
                                }
                            }
                        }


                        if (comboBox2.SelectedIndex == 1)
                        {
                            foreach (TicketPrice t in ticketPrices)
                            {
                                if (t.dayType == "Weekday" && t.group == 10)
                                {
                                    Console.WriteLine("already exist");
                                    fileStream.Close();
                                    return;
                                }
                            }
                        }

                        if (comboBox2.SelectedIndex == 2)
                        {
                            foreach (TicketPrice t in ticketPrices)
                            {
                                if (t.dayType == "Weekday" && t.group == 15)
                                {
                                    Console.WriteLine("already exist");
                                    fileStream.Close();
                                    return;
                                }
                            }
                        }

                        if (comboBox2.SelectedIndex == 3)
                        {
                            foreach (TicketPrice t in ticketPrices)
                            {
                                if (t.dayType == "Weekday" && t.group == 20)
                                {
                                    Console.WriteLine("already exist");
                                    fileStream.Close();
                                    return;
                                }
                            }
                        }
                    }

                    Tprice.dayType = dayTypeCBox.SelectedItem.ToString();

                    Tprice.age = 0;

                    Tprice.group = Int32.Parse(comboBox2.SelectedItem.ToString());

                    Tprice.oneHour = Int32.Parse(onehourtxtb.Text);
                    Tprice.twoHour = Int32.Parse(twohourtxtb.Text);
                    Tprice.threeHour = Int32.Parse(threehourtxtb.Text);
                    Tprice.fourHour = Int32.Parse(fourhourtxtb.Text);
                    Tprice.wholeday = Int32.Parse(wholedaytextb.Text);

                    Console.WriteLine("combobox weekday");
                    Console.WriteLine(Tprice.dayType);

                }

            }
            else
            {
                if (rbtnchild.Checked || rbtnadult.Checked)
                {
                    Tprice.dayType = dayTypeCBox.SelectedItem.ToString();

                    if (rbtnchild.Checked)
                    {
                        if(ticketPrices.Count > 0)
                        {
                            foreach (TicketPrice t in ticketPrices)
                            {
                                if (t.dayType == "Holiday" && (t.age >= 5 && t.age <= 12))
                                {
                                    Console.WriteLine("Already Exist");
                                    fileStream.Close();
                                    return;
                                }
                            }
                        }

                        Tprice.age = ra.Next(5, 11);
                    }
                    else
                    {
                        if(ticketPrices.Count > 0)
                        {
                            foreach (TicketPrice t in ticketPrices)
                            {
                                if (t.dayType == "Holiday" && (t.age >= 13 && t.age <= 60))
                                {
                                    Console.WriteLine("already exist");
                                    fileStream.Close();
                                    return;
                                }
                            }
                        }

                        Tprice.age = ra.Next(12, 60);
                    }

                    Tprice.group = 0;

                    Tprice.oneHour = Int32.Parse(onehourtxtb.Text);
                    Tprice.twoHour = Int32.Parse(twohourtxtb.Text);
                    Tprice.threeHour = Int32.Parse(threehourtxtb.Text);
                    Tprice.fourHour = Int32.Parse(fourhourtxtb.Text);
                    Tprice.wholeday = Int32.Parse(wholedaytextb.Text);

                    Console.WriteLine("Radio button holiday");
                    Console.WriteLine(Tprice.dayType);

                }

                if (comboBox2.SelectedIndex >= 0)
                {
                    if (ticketPrices.Count > 0)
                    {
                        if (comboBox2.SelectedIndex == 0)
                        {
                            foreach (TicketPrice t in ticketPrices)
                            {
                                if (t.dayType == "Holiday" && t.group == 5)
                                {
                                    Console.WriteLine("already exist");
                                    fileStream.Close();
                                    return;
                                }
                            }
                        }


                        if (comboBox2.SelectedIndex == 1)
                        {
                            foreach (TicketPrice t in ticketPrices)
                            {
                                if (t.dayType == "Holiday" && t.group == 10)
                                {
                                    Console.WriteLine("already exist");
                                    fileStream.Close();
                                    return;
                                }
                            }
                        }

                        if (comboBox2.SelectedIndex == 2)
                        {
                            foreach (TicketPrice t in ticketPrices)
                            {
                                if (t.dayType == "Holiday" && t.group == 15)
                                {
                                    Console.WriteLine("already exist");
                                    fileStream.Close();
                                    return;
                                }
                            }
                        }

                        if (comboBox2.SelectedIndex == 3)
                        {
                            foreach (TicketPrice t in ticketPrices)
                            {
                                if (t.dayType == "Holiday" && t.group == 20)
                                {
                                    Console.WriteLine("already exist");
                                    fileStream.Close();
                                    return;
                                }
                            }
                        }
                        
                    }

                    Tprice.dayType = dayTypeCBox.SelectedItem.ToString();

                    Tprice.age = 0;

                    Tprice.group = Int32.Parse(comboBox2.SelectedItem.ToString());

                    Tprice.oneHour = Int32.Parse(onehourtxtb.Text);
                    Tprice.twoHour = Int32.Parse(twohourtxtb.Text);
                    Tprice.threeHour = Int32.Parse(threehourtxtb.Text);
                    Tprice.fourHour = Int32.Parse(fourhourtxtb.Text);
                    Tprice.wholeday = Int32.Parse(wholedaytextb.Text);

                    Console.WriteLine("combobox holiday");
                    Console.WriteLine(Tprice.dayType);

                }

            }


            ticketPrices.Add(Tprice);
            xmlSerializer.Serialize(fileStream, ticketPrices);
            fileStream.Close();
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox2.Enabled = false;
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox2.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbtnchild.Enabled = false;
            rbtnadult.Enabled = false;
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            rbtnchild.Checked = false;
            rbtnadult.Checked = false;
            comboBox2.SelectedIndex = -1;
            comboBox2.Text = "Group of";
            comboBox2.Enabled = true;
            rbtnchild.Enabled = true;
            rbtnadult.Enabled = true;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminForm a = new AdminForm();
            a.Show();
            this.Hide();
        }

        private void onehourtxtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void twohour_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
