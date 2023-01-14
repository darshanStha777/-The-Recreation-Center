
namespace Recreation_Centre_System
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.staffloginbtn = new System.Windows.Forms.Button();
            this.staffcancelbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.showpcheckBoxstaff = new System.Windows.Forms.CheckBox();
            this.staff_paswordtxt = new System.Windows.Forms.TextBox();
            this.staff_usernametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.adminloginbtn = new System.Windows.Forms.Button();
            this.admincancelbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showpcheckBoxadmin = new System.Windows.Forms.CheckBox();
            this.admin_passwordtxt = new System.Windows.Forms.TextBox();
            this.admin_usernametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(77, 136);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(443, 468);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.staffloginbtn);
            this.tabPage1.Controls.Add(this.staffcancelbtn);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.showpcheckBoxstaff);
            this.tabPage1.Controls.Add(this.staff_paswordtxt);
            this.tabPage1.Controls.Add(this.staff_usernametxt);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(435, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Staff";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // staffloginbtn
            // 
            this.staffloginbtn.BackColor = System.Drawing.Color.Lime;
            this.staffloginbtn.Location = new System.Drawing.Point(104, 355);
            this.staffloginbtn.Name = "staffloginbtn";
            this.staffloginbtn.Size = new System.Drawing.Size(105, 32);
            this.staffloginbtn.TabIndex = 17;
            this.staffloginbtn.Text = "Login";
            this.staffloginbtn.UseVisualStyleBackColor = false;
            this.staffloginbtn.Click += new System.EventHandler(this.staffloginbtn_Click);
            // 
            // staffcancelbtn
            // 
            this.staffcancelbtn.BackColor = System.Drawing.Color.Red;
            this.staffcancelbtn.Location = new System.Drawing.Point(246, 354);
            this.staffcancelbtn.Name = "staffcancelbtn";
            this.staffcancelbtn.Size = new System.Drawing.Size(103, 33);
            this.staffcancelbtn.TabIndex = 16;
            this.staffcancelbtn.Text = "Cancel";
            this.staffcancelbtn.UseVisualStyleBackColor = false;
            this.staffcancelbtn.Click += new System.EventHandler(this.staffcancelbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(82, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(294, 189);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // showpcheckBoxstaff
            // 
            this.showpcheckBoxstaff.AutoSize = true;
            this.showpcheckBoxstaff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpcheckBoxstaff.Location = new System.Drawing.Point(72, 304);
            this.showpcheckBoxstaff.Name = "showpcheckBoxstaff";
            this.showpcheckBoxstaff.Size = new System.Drawing.Size(137, 20);
            this.showpcheckBoxstaff.TabIndex = 12;
            this.showpcheckBoxstaff.Text = "Show Password";
            this.showpcheckBoxstaff.UseVisualStyleBackColor = true;
            this.showpcheckBoxstaff.CheckedChanged += new System.EventHandler(this.showpcheckBoxstaff_CheckedChanged);
            // 
            // staff_paswordtxt
            // 
            this.staff_paswordtxt.Location = new System.Drawing.Point(176, 255);
            this.staff_paswordtxt.Name = "staff_paswordtxt";
            this.staff_paswordtxt.Size = new System.Drawing.Size(190, 31);
            this.staff_paswordtxt.TabIndex = 11;
            this.staff_paswordtxt.UseSystemPasswordChar = true;
            // 
            // staff_usernametxt
            // 
            this.staff_usernametxt.Location = new System.Drawing.Point(176, 201);
            this.staff_usernametxt.Name = "staff_usernametxt";
            this.staff_usernametxt.Size = new System.Drawing.Size(190, 31);
            this.staff_usernametxt.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Usernane:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.adminloginbtn);
            this.tabPage2.Controls.Add(this.admincancelbtn);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.showpcheckBoxadmin);
            this.tabPage2.Controls.Add(this.admin_passwordtxt);
            this.tabPage2.Controls.Add(this.admin_usernametxt);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(435, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Admin";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // adminloginbtn
            // 
            this.adminloginbtn.BackColor = System.Drawing.Color.Lime;
            this.adminloginbtn.Location = new System.Drawing.Point(122, 376);
            this.adminloginbtn.Name = "adminloginbtn";
            this.adminloginbtn.Size = new System.Drawing.Size(95, 33);
            this.adminloginbtn.TabIndex = 9;
            this.adminloginbtn.Text = "Login";
            this.adminloginbtn.UseVisualStyleBackColor = false;
            this.adminloginbtn.Click += new System.EventHandler(this.adminloginbtn_Click);
            // 
            // admincancelbtn
            // 
            this.admincancelbtn.BackColor = System.Drawing.Color.Red;
            this.admincancelbtn.Location = new System.Drawing.Point(280, 376);
            this.admincancelbtn.Name = "admincancelbtn";
            this.admincancelbtn.Size = new System.Drawing.Size(94, 33);
            this.admincancelbtn.TabIndex = 8;
            this.admincancelbtn.Text = "Cancel";
            this.admincancelbtn.UseVisualStyleBackColor = false;
            this.admincancelbtn.Click += new System.EventHandler(this.admincancelbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(107, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // showpcheckBoxadmin
            // 
            this.showpcheckBoxadmin.AutoSize = true;
            this.showpcheckBoxadmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpcheckBoxadmin.Location = new System.Drawing.Point(80, 307);
            this.showpcheckBoxadmin.Name = "showpcheckBoxadmin";
            this.showpcheckBoxadmin.Size = new System.Drawing.Size(137, 20);
            this.showpcheckBoxadmin.TabIndex = 4;
            this.showpcheckBoxadmin.Text = "Show Password";
            this.showpcheckBoxadmin.UseVisualStyleBackColor = true;
            this.showpcheckBoxadmin.CheckedChanged += new System.EventHandler(this.showpcheckBoxadmin_CheckedChanged);
            // 
            // admin_passwordtxt
            // 
            this.admin_passwordtxt.Location = new System.Drawing.Point(184, 258);
            this.admin_passwordtxt.Name = "admin_passwordtxt";
            this.admin_passwordtxt.Size = new System.Drawing.Size(190, 31);
            this.admin_passwordtxt.TabIndex = 3;
            this.admin_passwordtxt.UseSystemPasswordChar = true;
            // 
            // admin_usernametxt
            // 
            this.admin_usernametxt.Location = new System.Drawing.Point(184, 204);
            this.admin_usernametxt.Name = "admin_usernametxt";
            this.admin_usernametxt.Size = new System.Drawing.Size(190, 31);
            this.admin_usernametxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usernane:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Welcome Back!";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 84);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 636);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox showpcheckBoxstaff;
        private System.Windows.Forms.TextBox staff_paswordtxt;
        private System.Windows.Forms.TextBox staff_usernametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox showpcheckBoxadmin;
        private System.Windows.Forms.TextBox admin_passwordtxt;
        private System.Windows.Forms.TextBox admin_usernametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button staffcancelbtn;
        private System.Windows.Forms.Button staffloginbtn;
        private System.Windows.Forms.Button admincancelbtn;
        private System.Windows.Forms.Button adminloginbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}