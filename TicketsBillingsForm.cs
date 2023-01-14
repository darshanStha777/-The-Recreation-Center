using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace Recreation_Centre_System
{
    public partial class TicketsBillingsForm : Form
    {
        XmlSerializer xmlSerializer;
        List<TicketPrice> ticketPrices;

        XmlSerializer xmlSerializer2;
        List<VistorDetails> vistorDetails;

        int count = 0;

        public TicketsBillingsForm()
        {
            InitializeComponent();
            xmlSerializer = new XmlSerializer(typeof(List<TicketPrice>));
            ticketPrices = new List<TicketPrice>();

            vistorDetails = new List<VistorDetails>();
            xmlSerializer2 = new XmlSerializer(typeof(List<VistorDetails>));
            abc();

        }

        private void restbtn_Click(object sender, EventArgs e)
        {
            rbtnchild.Checked = false;
            rbtnadult.Checked = false;
            comboBoxGV.SelectedIndex = -1;
            comboBoxGV.Text = "Group of";
            comboBoxGV.Enabled = true;
            rbtnchild.Enabled = true;
            rbtnadult.Enabled = true;
            comboBoxVH.SelectedIndex = -1;
            comboBoxVH.Text = "Hours";
            comboBoxVH.Enabled = false;
            couttimetxtb.Text = "";
            totalptxtb.Text = "";

        }

        private void BillingTicket_Load(object sender, EventArgs e)
        {
            /*Random rnd = new Random();
            int num = rnd.Next(1, 1000);
*/
            foreach (VistorDetails vis in vistorDetails)
            {
                count += 1;
            }

            count += 1; 
            timer1.Start();
            /*textBox1.Text = num.ToString();*/
            idtxtBox.Text = (count).ToString();
            datetxtb.Text = DateTime.Now.ToString("yyyy-MM-dd");
            daytextb.Text = DateTime.Today.DayOfWeek.ToString();
            itimetxtb.Text = DateTime.Now.ToLongTimeString();
            comboBoxVH.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            itimetxtb.Text = DateTime.Now.ToLongTimeString();

            DateTime date = DateTime.Parse(itimetxtb.Text, System.Globalization.CultureInfo.CurrentCulture);

            if (comboBoxVH.Text == "1")
            {
                couttimetxtb.Text = date.AddHours(1).ToLongTimeString();
            }

            if (comboBoxVH.Text == "2")
            {
                couttimetxtb.Text = date.AddHours(2).ToLongTimeString();
            }

            if (comboBoxVH.Text == "3")
            {
                couttimetxtb.Text = date.AddHours(3).ToLongTimeString();
            }

            if (comboBoxVH.Text == "4")
            {
                couttimetxtb.Text = date.AddHours(4).ToLongTimeString();
            }

            if (comboBoxVH.Text == "Whole Day")
            {
                couttimetxtb.Text = AbsoluteEnd(date).ToLongTimeString();
            }

            timer1.Start();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Start();

            FileStream fileStream = new FileStream(path.pathB, FileMode.Open, FileAccess.Read);

            var priceData = xmlSerializer.Deserialize(fileStream);

            ticketPrices = (List<TicketPrice>)priceData;

            DateTime date = DateTime.Parse(itimetxtb.Text, System.Globalization.CultureInfo.CurrentCulture);


            /*One Hours*/
            if (comboBoxVH.Text == "1")
            {
                couttimetxtb.Text = date.AddHours(1).ToLongTimeString();

                if (rbtnchild.Checked || rbtnadult.Checked)
                {
                    if (rbtnchild.Checked)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if(price.age >=5 && price.age <= 12)
                            {
                                if(daytextb.Text.Equals("Saturday"))
                                {
                                    Console.WriteLine(price.age);

                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.oneHour.ToString();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(price.age);
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.oneHour.ToString();
                                    }
                                }

                            }
                        }
                    }
                    if (rbtnadult.Checked)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.age >= 13 && price.age <= 60)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.oneHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.oneHour.ToString();
                                    }
                                }

                            }
                        }
                    }
                    return;
                }

                if (comboBoxGV.SelectedIndex >= 0)
                {
                    if(comboBoxGV.SelectedIndex == 0)
                    {
                        Console.WriteLine("hour of 1");
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 5)
                            {
                                Console.WriteLine("group of 5");
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.oneHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.oneHour.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (comboBoxGV.SelectedIndex == 1)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 10)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.oneHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.oneHour.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (comboBoxGV.SelectedIndex == 2)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 15)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.oneHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.oneHour.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (comboBoxGV.SelectedIndex == 3)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 20)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.oneHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.oneHour.ToString();
                                    }
                                }

                            }
                        }
                    }



                }
            }


            /*Two Hours*/
            if (comboBoxVH.Text == "2")
            {
                couttimetxtb.Text = date.AddHours(2).ToLongTimeString();

                if (rbtnchild.Checked || rbtnadult.Checked)
                {
                    if (rbtnchild.Checked)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.age >= 5 && price.age <= 12)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    Console.WriteLine(price.age);

                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.twoHour.ToString();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(price.age);
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.twoHour.ToString();
                                    }
                                }

                            }
                        }
                    }
                    if (rbtnadult.Checked)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.age >= 13 && price.age <= 60)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.twoHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.twoHour.ToString();
                                    }
                                }

                            }
                        }
                    }
                    return;
                }

                if (comboBoxGV.SelectedIndex >= 0)
                {
                    if (comboBoxGV.SelectedIndex == 0)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 5)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.twoHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.twoHour.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (comboBoxGV.SelectedIndex == 1)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 10)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.twoHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.twoHour.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (comboBoxGV.SelectedIndex == 2)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 15)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.twoHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.twoHour.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (comboBoxGV.SelectedIndex == 3)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 20)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.twoHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.twoHour.ToString();
                                    }
                                }

                            }
                        }
                    }
                }
            }

            /*Three Hours*/
            if (comboBoxVH.Text == "3")
            {
                couttimetxtb.Text = date.AddHours(3).ToLongTimeString();

                if (rbtnchild.Checked || rbtnadult.Checked)
                {
                    if (rbtnchild.Checked)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.age >= 5 && price.age <= 12)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    Console.WriteLine(price.age);

                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.threeHour.ToString();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(price.age);
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.threeHour.ToString();
                                    }
                                }

                            }
                        }
                    }
                    if (rbtnadult.Checked)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.age >= 13 && price.age <= 60)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.threeHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.threeHour.ToString();
                                    }
                                }

                            }
                        }
                    }
                    return;
                }

                if (comboBoxGV.SelectedIndex >= 0)
                {
                    if (comboBoxGV.SelectedIndex == 0)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 5)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.threeHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.threeHour.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (comboBoxGV.SelectedIndex == 1)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 10)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.threeHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.threeHour.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (comboBoxGV.SelectedIndex == 2)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 15)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.threeHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.threeHour.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (comboBoxGV.SelectedIndex == 3)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 20)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.threeHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.threeHour.ToString();
                                    }
                                }

                            }
                        }
                    }
                }
            }

            /*four Hours*/
            if (comboBoxVH.Text == "4")
            {
                couttimetxtb.Text = date.AddHours(4).ToLongTimeString();

                if (rbtnchild.Checked || rbtnadult.Checked)
                {
                    if (rbtnchild.Checked)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.age >= 5 && price.age <= 12)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    Console.WriteLine(price.age);

                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.fourHour.ToString();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(price.age);
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.fourHour.ToString();
                                    }
                                }

                            }
                        }
                    }
                    if (rbtnadult.Checked)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.age >= 13 && price.age <= 60)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.fourHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.fourHour.ToString();
                                    }
                                }

                            }
                        }
                    }
                    return;
                }

                if (comboBoxGV.SelectedIndex >= 0)
                {
                    if (comboBoxGV.SelectedIndex == 0)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 5)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.fourHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.fourHour.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (comboBoxGV.SelectedIndex == 1)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 10)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.fourHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.fourHour.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (comboBoxGV.SelectedIndex == 2)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 15)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.fourHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.fourHour.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (comboBoxGV.SelectedIndex == 3)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 20)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.fourHour.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.fourHour.ToString();
                                    }
                                }

                            }
                        }
                    }
                }
            }

            /*whole day*/
            if (comboBoxVH.Text == "Whole Day")
            {
                couttimetxtb.Text = AbsoluteEnd(date).ToLongTimeString();

                if (rbtnchild.Checked || rbtnadult.Checked)
                {
                    if (rbtnchild.Checked)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.age >= 5 && price.age <= 12)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.wholeday.ToString();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(price.age);
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.wholeday.ToString();
                                    }
                                }

                            }
                        }
                    }
                    if (rbtnadult.Checked)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.age >= 13 && price.age <= 60)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.wholeday.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.wholeday.ToString();
                                    }
                                }

                            }
                        }
                    }
                    return;
                }

                if (comboBoxGV.SelectedIndex >= 0)
                {
                    if (comboBoxGV.SelectedIndex == 0)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 5)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.wholeday.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.wholeday.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (comboBoxGV.SelectedIndex == 1)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 10)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.wholeday.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.wholeday.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (comboBoxGV.SelectedIndex == 2)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 15)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.wholeday.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.wholeday.ToString();
                                    }
                                }

                            }
                        }
                    }

                    if (comboBoxGV.SelectedIndex == 3)
                    {
                        foreach (TicketPrice price in ticketPrices)
                        {
                            if (price.group == 20)
                            {
                                if (daytextb.Text.Equals("Saturday"))
                                {
                                    if (price.dayType == "Holiday")
                                    {
                                        totalptxtb.Text = price.wholeday.ToString();
                                    }
                                }
                                else
                                {
                                    if (price.dayType == "Weekday")
                                    {
                                        totalptxtb.Text = price.wholeday.ToString();
                                    }
                                }

                            }
                        }
                    }
                }
            }
        }


        public static DateTime AbsoluteStart(DateTime dateTime)
        {
            return dateTime.Date;
        }

        public static DateTime AbsoluteEnd(DateTime dateTime)
        {
            return AbsoluteStart(dateTime).AddDays(1).AddTicks(-1);
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxGV.Enabled = false;
            comboBoxVH.Enabled = true;
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxGV.Enabled = false;
            comboBoxVH.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbtnchild.Enabled = false;
            rbtnadult.Enabled = false;
            comboBoxVH.Enabled = true;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            TimeSpan starttime = TimeSpan.Parse("10:00"); //10am o'clock
            TimeSpan endtime = TimeSpan.Parse("18:00");  //6pm o'clock
            TimeSpan currentdt = DateTime.Now.TimeOfDay;

            if ((currentdt > starttime) && (currentdt < endtime))
            {
                FileStream fileStream2 = new FileStream(path.pathC, FileMode.OpenOrCreate, FileAccess.Write);

                VistorDetails vd = new VistorDetails();

                vd.id = Int32.Parse(idtxtBox.Text);
                vd.name = fullnametxtb.Text;
                vd.contact = mnumbertxtb.Text;
                vd.date = DateTime.Parse(datetxtb.Text, System.Globalization.CultureInfo.CurrentCulture);
                /*v.date = Convert.ToDateTime(textBox4.Text);*/
                String todayDay = daytextb.Text;

                switch (todayDay)
                {
                    case "Sunday":
                        vd.day = DayOfWeek.Sunday;
                        break;
                    case "Monday":
                        vd.day = DayOfWeek.Monday;
                        break;
                    case "Tuesday":
                        vd.day = DayOfWeek.Tuesday;
                        break;
                    case "Wednesday":
                        vd.day = DayOfWeek.Wednesday;
                        break;
                    case "Thursday":
                        vd.day = DayOfWeek.Friday;
                        break;
                    case "Friday":
                        vd.day = DayOfWeek.Saturday;
                        break;
                    default:
                        vd.day = DayOfWeek.Saturday;
                        break;
                }

                vd.CheckInTime = DateTime.Parse(itimetxtb.Text, System.Globalization.CultureInfo.CurrentCulture);

                Random r = new Random();

                if ((!rbtnchild.Checked && !rbtnadult.Checked) && (comboBoxGV.SelectedItem == null))
                {
                    MessageBox.Show("Please select either Age or Group", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (rbtnchild.Checked)
                    {
                        vd.age = r.Next(5, 11);
                    }
                    else if (rbtnadult.Checked)
                    {
                        vd.age = r.Next(12, 60);
                    }
                    else
                    {
                        vd.age = 0;
                    }

                    if (comboBoxGV.SelectedItem == null)
                    {
                        vd.group = 0;
                    }
                    else
                    {
                        vd.group = Int32.Parse(comboBoxGV.Text);
                    }
                }

                if (comboBoxVH.SelectedItem == null)
                {
                    MessageBox.Show("Please select duration hours", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (comboBoxGV.Text == "1" || comboBoxGV.Text == "2" || comboBoxGV.Text == "3" || comboBoxGV.Text == "4")
                    {
                        vd.Duration = Int32.Parse(comboBoxVH.Text);
                    }
                    else
                    {
                        vd.Duration = 8;
                    }
                }

                vd.CheckoutTime = DateTime.Parse(couttimetxtb.Text, System.Globalization.CultureInfo.CurrentCulture);

                vd.TotalPrice = Int32.Parse(totalptxtb.Text);


                vistorDetails.Add(vd);
                xmlSerializer2.Serialize(fileStream2, vistorDetails);
                fileStream2.Close();

                Console.WriteLine(vd.id);
                Console.WriteLine(vd.name);
                Console.WriteLine(vd.contact);
                Console.WriteLine(vd.date);
                Console.WriteLine(vd.day);
                Console.WriteLine(vd.CheckInTime);
                Console.WriteLine(vd.age);
                Console.WriteLine(vd.group);
                Console.WriteLine(vd.Duration);
                Console.WriteLine(vd.CheckoutTime);
                Console.WriteLine(vd.TotalPrice);

                idtxtBox.Text = "";
                fullnametxtb.Text = "";
                mnumbertxtb.Text = "";
                couttimetxtb.Text = "";
                totalptxtb.Text = "";

                comboBoxGV.SelectedIndex = -1;
                comboBoxGV.Text = "Group of";

                rbtnchild.Checked = false;
                rbtnadult.Checked = false;

                comboBoxVH.SelectedIndex = -1;
                comboBoxVH.Text = "Hours";

                comboBoxGV.Enabled = true;
                rbtnchild.Enabled = true;
                rbtnadult.Enabled = true;
                comboBoxVH.Enabled = false;

                count += 1;
                idtxtBox.Text = count.ToString();

                /*Random rnd = new Random();
                int num = rnd.Next(1, 1000);
                textBox1.Text = num.ToString();*/
            }
            else
            {
                Console.WriteLine("Recreation centre is closed, It's opening time is 10am to 6pm");
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
            catch(Exception e)
            {
                fileStream.Close();
            }
           

        }
        private void backbtn_Click(object sender, EventArgs e)
        {
            Staffpanel staffpage = new Staffpanel();
            staffpage.Show();
            this.Hide();
        }

        private void idtxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}