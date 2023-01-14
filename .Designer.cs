
namespace Recreation_Centre_System
{
    partial class TicketsPriceSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketsPriceSet));
            this.label1 = new System.Windows.Forms.Label();
            this.dayTypeCBox = new System.Windows.Forms.ComboBox();
            this.rbtnadult = new System.Windows.Forms.RadioButton();
            this.rbtnchild = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.setpricebtn = new System.Windows.Forms.Button();
            this.onehourtxtb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.twohourtxtb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.threehourtxtb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fourhourtxtb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.wholedaytextb = new System.Windows.Forms.TextBox();
            this.restbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Day Type:";
            // 
            // dayTypeCBox
            // 
            this.dayTypeCBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayTypeCBox.FormattingEnabled = true;
            this.dayTypeCBox.Items.AddRange(new object[] {
            "Weekday",
            "Holiday"});
            this.dayTypeCBox.Location = new System.Drawing.Point(667, 151);
            this.dayTypeCBox.Margin = new System.Windows.Forms.Padding(4);
            this.dayTypeCBox.Name = "dayTypeCBox";
            this.dayTypeCBox.Size = new System.Drawing.Size(200, 25);
            this.dayTypeCBox.TabIndex = 1;
            this.dayTypeCBox.Text = "Choose  Day Type";
            // 
            // rbtnadult
            // 
            this.rbtnadult.AutoSize = true;
            this.rbtnadult.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnadult.Location = new System.Drawing.Point(797, 212);
            this.rbtnadult.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnadult.Name = "rbtnadult";
            this.rbtnadult.Size = new System.Drawing.Size(120, 21);
            this.rbtnadult.TabIndex = 4;
            this.rbtnadult.TabStop = true;
            this.rbtnadult.Text = "Adult ( > 12 )";
            this.rbtnadult.UseVisualStyleBackColor = true;
            this.rbtnadult.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.rbtnadult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton2_MouseClick);
            // 
            // rbtnchild
            // 
            this.rbtnchild.AutoSize = true;
            this.rbtnchild.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnchild.Location = new System.Drawing.Point(667, 213);
            this.rbtnchild.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnchild.Name = "rbtnchild";
            this.rbtnchild.Size = new System.Drawing.Size(120, 21);
            this.rbtnchild.TabIndex = 3;
            this.rbtnchild.TabStop = true;
            this.rbtnchild.Text = "Child (5 - 12)";
            this.rbtnchild.UseVisualStyleBackColor = true;
            this.rbtnchild.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton1_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Group:";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.comboBox2.Location = new System.Drawing.Point(667, 271);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(96, 25);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.Text = "Group of";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 339);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Price for 1 Hour Visit:";
            // 
            // setpricebtn
            // 
            this.setpricebtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.setpricebtn.Location = new System.Drawing.Point(621, 649);
            this.setpricebtn.Margin = new System.Windows.Forms.Padding(4);
            this.setpricebtn.Name = "setpricebtn";
            this.setpricebtn.Size = new System.Drawing.Size(153, 41);
            this.setpricebtn.TabIndex = 23;
            this.setpricebtn.Text = "Set Price";
            this.setpricebtn.UseVisualStyleBackColor = false;
            this.setpricebtn.Click += new System.EventHandler(this.setpricebtn_Click);
            // 
            // onehourtxtb
            // 
            this.onehourtxtb.Location = new System.Drawing.Point(667, 336);
            this.onehourtxtb.Margin = new System.Windows.Forms.Padding(4);
            this.onehourtxtb.Name = "onehourtxtb";
            this.onehourtxtb.Size = new System.Drawing.Size(217, 27);
            this.onehourtxtb.TabIndex = 24;
            this.onehourtxtb.TextChanged += new System.EventHandler(this.onehourtxtb_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 398);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = " Price for 2 Hour Visit:";
            // 
            // twohourtxtb
            // 
            this.twohourtxtb.Location = new System.Drawing.Point(667, 391);
            this.twohourtxtb.Margin = new System.Windows.Forms.Padding(4);
            this.twohourtxtb.Name = "twohourtxtb";
            this.twohourtxtb.Size = new System.Drawing.Size(217, 27);
            this.twohourtxtb.TabIndex = 26;
            this.twohourtxtb.TextChanged += new System.EventHandler(this.twohour_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 451);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Price for 3 Hour Visit:";
            // 
            // threehourtxtb
            // 
            this.threehourtxtb.Location = new System.Drawing.Point(667, 444);
            this.threehourtxtb.Margin = new System.Windows.Forms.Padding(4);
            this.threehourtxtb.Name = "threehourtxtb";
            this.threehourtxtb.Size = new System.Drawing.Size(217, 27);
            this.threehourtxtb.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 508);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Price for 4 Hour Visit:";
            // 
            // fourhourtxtb
            // 
            this.fourhourtxtb.Location = new System.Drawing.Point(667, 501);
            this.fourhourtxtb.Margin = new System.Windows.Forms.Padding(4);
            this.fourhourtxtb.Name = "fourhourtxtb";
            this.fourhourtxtb.Size = new System.Drawing.Size(217, 27);
            this.fourhourtxtb.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 565);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Price for whole Day Visit:";
            // 
            // wholedaytextb
            // 
            this.wholedaytextb.Location = new System.Drawing.Point(667, 558);
            this.wholedaytextb.Margin = new System.Windows.Forms.Padding(4);
            this.wholedaytextb.Name = "wholedaytextb";
            this.wholedaytextb.Size = new System.Drawing.Size(217, 27);
            this.wholedaytextb.TabIndex = 32;
            // 
            // restbtn
            // 
            this.restbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restbtn.Location = new System.Drawing.Point(797, 271);
            this.restbtn.Margin = new System.Windows.Forms.Padding(4);
            this.restbtn.Name = "restbtn";
            this.restbtn.Size = new System.Drawing.Size(152, 33);
            this.restbtn.TabIndex = 33;
            this.restbtn.Text = "Reset Age - Group";
            this.restbtn.UseVisualStyleBackColor = true;
            this.restbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(564, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 32);
            this.label9.TabIndex = 35;
            this.label9.Text = "Set Ticket Price";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Transparent;
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.Location = new System.Drawing.Point(29, 30);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(63, 63);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backbtn.TabIndex = 36;
            this.backbtn.TabStop = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // TicketsPriceSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 737);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.restbtn);
            this.Controls.Add(this.wholedaytextb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fourhourtxtb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.threehourtxtb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.twohourtxtb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.onehourtxtb);
            this.Controls.Add(this.setpricebtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbtnadult);
            this.Controls.Add(this.rbtnchild);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dayTypeCBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TicketsPriceSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dayTypeCBox;
        private System.Windows.Forms.RadioButton rbtnadult;
        private System.Windows.Forms.RadioButton rbtnchild;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button setpricebtn;
        private System.Windows.Forms.TextBox onehourtxtb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox twohourtxtb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox threehourtxtb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fourhourtxtb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox wholedaytextb;
        private System.Windows.Forms.Button restbtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox backbtn;
    }
}

