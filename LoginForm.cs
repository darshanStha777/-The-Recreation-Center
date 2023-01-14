using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Recreation_Centre_System
{
    public partial class LoginForm : Form
    {
        Thread th;
        public LoginForm()
        {
            InitializeComponent();
        }

        


        private void staffcancelbtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure ?", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.OK)
            {
                staff_usernametxt.Clear();
                staff_paswordtxt.Clear();
            }
        }

        private void staffloginbtn_Click(object sender, EventArgs e)
        {
            String staff_Username = "manish";
            String staff_Password = "manish123";

            String get_staff_Username = staff_usernametxt.Text.Trim();
            String get_staff_Password = staff_paswordtxt.Text.Trim();

            if (get_staff_Username != "" || get_staff_Password != "")
            {
                if (staff_Username == get_staff_Username && staff_Password == get_staff_Password)
                {
                    this.Close();
                    th = new Thread(openstaffform);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please ! input username or password", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void admincancelbtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure ?", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.OK)
            {
                admin_usernametxt.Clear();
                admin_passwordtxt.Clear();
            }
        }
        private void opennewform(Object obj)
        {
            Application.Run(new AdminForm());

        }
        private void openstaffform(Object obj)
        {
            Application.Run(new Staffpanel());

        }

        private void adminloginbtn_Click(object sender, EventArgs e)
        {
            String admin_userName = "admin";
            String admin_password = "admin123";

            String get_admin_userName = admin_usernametxt.Text.Trim();
            String get_admin_password = admin_passwordtxt.Text.Trim();

            if (get_admin_userName != "" || get_admin_password != "")
            {
                if (admin_userName == get_admin_userName && admin_password == get_admin_password)
                {
                    //Admin admin_dashboard = new Admin();
                    //this.Hide();
                    //admin_dashboard.ShowDialog();
                    
                    this.Close();
                    th = new Thread(opennewform);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please ! input username or password", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void showpcheckBoxstaff_CheckedChanged(object sender, EventArgs e)
        {
             if (showpcheckBoxstaff.Checked)
            {
                staff_paswordtxt.UseSystemPasswordChar = false;
            }
            else
            {
                staff_paswordtxt.UseSystemPasswordChar = true;
            }
        }

        private void showpcheckBoxadmin_CheckedChanged(object sender, EventArgs e)
        {
            if (showpcheckBoxadmin.Checked)
            {
                admin_passwordtxt.UseSystemPasswordChar = false;
            }
            else
            {
                admin_passwordtxt.UseSystemPasswordChar = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
