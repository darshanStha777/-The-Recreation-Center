
namespace Recreation_Centre_System
{
    partial class TicketsBillingsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketsBillingsForm));
            this.totalptxtb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.couttimetxtb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxVH = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxGV = new System.Windows.Forms.ComboBox();
            this.rbtnadult = new System.Windows.Forms.RadioButton();
            this.rbtnchild = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.itimetxtb = new System.Windows.Forms.TextBox();
            this.daytextb = new System.Windows.Forms.TextBox();
            this.datetxtb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mnumbertxtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fullnametxtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idtxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.restbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.backbtn = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // totalptxtb
            // 
            this.totalptxtb.Location = new System.Drawing.Point(644, 537);
            this.totalptxtb.Margin = new System.Windows.Forms.Padding(4);
            this.totalptxtb.Name = "totalptxtb";
            this.totalptxtb.Size = new System.Drawing.Size(184, 27);
            this.totalptxtb.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(528, 537);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "Total Price:";
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(629, 623);
            this.addbtn.Margin = new System.Windows.Forms.Padding(4);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(150, 61);
            this.addbtn.TabIndex = 47;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // couttimetxtb
            // 
            this.couttimetxtb.Location = new System.Drawing.Point(824, 451);
            this.couttimetxtb.Margin = new System.Windows.Forms.Padding(4);
            this.couttimetxtb.Name = "couttimetxtb";
            this.couttimetxtb.ReadOnly = true;
            this.couttimetxtb.Size = new System.Drawing.Size(226, 27);
            this.couttimetxtb.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(661, 451);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "Checkout Time:";
            // 
            // comboBoxVH
            // 
            this.comboBoxVH.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVH.FormattingEnabled = true;
            this.comboBoxVH.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "Whole Day"});
            this.comboBoxVH.Location = new System.Drawing.Point(824, 387);
            this.comboBoxVH.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxVH.Name = "comboBoxVH";
            this.comboBoxVH.Size = new System.Drawing.Size(184, 28);
            this.comboBoxVH.TabIndex = 44;
            this.comboBoxVH.Text = "Hours";
            this.comboBoxVH.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(719, 386);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Duration:";
            // 
            // comboBoxGV
            // 
            this.comboBoxGV.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGV.FormattingEnabled = true;
            this.comboBoxGV.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.comboBoxGV.Location = new System.Drawing.Point(824, 318);
            this.comboBoxGV.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxGV.Name = "comboBoxGV";
            this.comboBoxGV.Size = new System.Drawing.Size(184, 28);
            this.comboBoxGV.TabIndex = 42;
            this.comboBoxGV.Text = "Group of";
            this.comboBoxGV.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rbtnadult
            // 
            this.rbtnadult.AutoSize = true;
            this.rbtnadult.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnadult.Location = new System.Drawing.Point(939, 248);
            this.rbtnadult.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnadult.Name = "rbtnadult";
            this.rbtnadult.Size = new System.Drawing.Size(111, 20);
            this.rbtnadult.TabIndex = 41;
            this.rbtnadult.TabStop = true;
            this.rbtnadult.Text = "Adult ( >12 )";
            this.rbtnadult.UseVisualStyleBackColor = true;
            this.rbtnadult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton2_MouseClick);
            // 
            // rbtnchild
            // 
            this.rbtnchild.AutoSize = true;
            this.rbtnchild.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnchild.Location = new System.Drawing.Point(824, 248);
            this.rbtnchild.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnchild.Name = "rbtnchild";
            this.rbtnchild.Size = new System.Drawing.Size(107, 20);
            this.rbtnchild.TabIndex = 40;
            this.rbtnchild.TabStop = true;
            this.rbtnchild.Text = "Child (5-12)";
            this.rbtnchild.UseVisualStyleBackColor = true;
            this.rbtnchild.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton1_MouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(739, 317);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Group:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(752, 244);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Age:";
            // 
            // itimetxtb
            // 
            this.itimetxtb.Location = new System.Drawing.Point(412, 444);
            this.itimetxtb.Margin = new System.Windows.Forms.Padding(4);
            this.itimetxtb.Name = "itimetxtb";
            this.itimetxtb.ReadOnly = true;
            this.itimetxtb.Size = new System.Drawing.Size(226, 27);
            this.itimetxtb.TabIndex = 37;
            // 
            // daytextb
            // 
            this.daytextb.Location = new System.Drawing.Point(412, 379);
            this.daytextb.Margin = new System.Windows.Forms.Padding(4);
            this.daytextb.Name = "daytextb";
            this.daytextb.ReadOnly = true;
            this.daytextb.Size = new System.Drawing.Size(226, 27);
            this.daytextb.TabIndex = 36;
            // 
            // datetxtb
            // 
            this.datetxtb.Location = new System.Drawing.Point(412, 309);
            this.datetxtb.Margin = new System.Windows.Forms.Padding(4);
            this.datetxtb.Name = "datetxtb";
            this.datetxtb.ReadOnly = true;
            this.datetxtb.Size = new System.Drawing.Size(226, 27);
            this.datetxtb.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 451);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "In Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 379);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Day:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 309);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Date:";
            // 
            // mnumbertxtb
            // 
            this.mnumbertxtb.Location = new System.Drawing.Point(412, 244);
            this.mnumbertxtb.Margin = new System.Windows.Forms.Padding(4);
            this.mnumbertxtb.Name = "mnumbertxtb";
            this.mnumbertxtb.Size = new System.Drawing.Size(226, 27);
            this.mnumbertxtb.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Mobile Number:";
            // 
            // fullnametxtb
            // 
            this.fullnametxtb.Location = new System.Drawing.Point(824, 174);
            this.fullnametxtb.Margin = new System.Windows.Forms.Padding(4);
            this.fullnametxtb.Name = "fullnametxtb";
            this.fullnametxtb.Size = new System.Drawing.Size(226, 27);
            this.fullnametxtb.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(703, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Full Name:";
            // 
            // idtxtBox
            // 
            this.idtxtBox.Location = new System.Drawing.Point(412, 173);
            this.idtxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.idtxtBox.Name = "idtxtBox";
            this.idtxtBox.ReadOnly = true;
            this.idtxtBox.Size = new System.Drawing.Size(226, 27);
            this.idtxtBox.TabIndex = 27;
            this.idtxtBox.TextChanged += new System.EventHandler(this.idtxtBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID:";
            // 
            // restbtn
            // 
            this.restbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restbtn.Location = new System.Drawing.Point(864, 532);
            this.restbtn.Margin = new System.Windows.Forms.Padding(4);
            this.restbtn.Name = "restbtn";
            this.restbtn.Size = new System.Drawing.Size(156, 37);
            this.restbtn.TabIndex = 50;
            this.restbtn.Text = "Reset Age - Group";
            this.restbtn.UseVisualStyleBackColor = true;
            this.restbtn.Click += new System.EventHandler(this.restbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Transparent;
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.Location = new System.Drawing.Point(32, 21);
            this.backbtn.Margin = new System.Windows.Forms.Padding(4);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(70, 60);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backbtn.TabIndex = 53;
            this.backbtn.TabStop = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(550, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(315, 28);
            this.label12.TabIndex = 54;
            this.label12.Text = "Recreation Centre System";
            // 
            // BillingTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 737);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.restbtn);
            this.Controls.Add(this.totalptxtb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.couttimetxtb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxVH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxGV);
            this.Controls.Add(this.rbtnadult);
            this.Controls.Add(this.rbtnchild);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.itimetxtb);
            this.Controls.Add(this.daytextb);
            this.Controls.Add(this.datetxtb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mnumbertxtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fullnametxtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idtxtBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BillingTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillingTicket";
            this.Load += new System.EventHandler(this.BillingTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox totalptxtb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox couttimetxtb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxVH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxGV;
        private System.Windows.Forms.RadioButton rbtnadult;
        private System.Windows.Forms.RadioButton rbtnchild;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox itimetxtb;
        private System.Windows.Forms.TextBox daytextb;
        private System.Windows.Forms.TextBox datetxtb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mnumbertxtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fullnametxtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idtxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button restbtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox backbtn;
        private System.Windows.Forms.Label label12;
    }
}