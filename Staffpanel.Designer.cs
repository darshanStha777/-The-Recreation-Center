
namespace Recreation_Centre_System
{
    partial class Staffpanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staffpanel));
            this.ticketbillingbtn = new System.Windows.Forms.Button();
            this.dticketsbtn = new System.Windows.Forms.Button();
            this.dvisitorbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logoutbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketbillingbtn
            // 
            this.ticketbillingbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketbillingbtn.Location = new System.Drawing.Point(232, 107);
            this.ticketbillingbtn.Name = "ticketbillingbtn";
            this.ticketbillingbtn.Size = new System.Drawing.Size(142, 47);
            this.ticketbillingbtn.TabIndex = 0;
            this.ticketbillingbtn.Text = "Ticket Billing";
            this.ticketbillingbtn.UseVisualStyleBackColor = true;
            this.ticketbillingbtn.Click += new System.EventHandler(this.ticketbillingbtn_Click);
            // 
            // dticketsbtn
            // 
            this.dticketsbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dticketsbtn.Location = new System.Drawing.Point(232, 187);
            this.dticketsbtn.Name = "dticketsbtn";
            this.dticketsbtn.Size = new System.Drawing.Size(142, 47);
            this.dticketsbtn.TabIndex = 1;
            this.dticketsbtn.Text = "Details of Tickets";
            this.dticketsbtn.UseVisualStyleBackColor = true;
            this.dticketsbtn.Click += new System.EventHandler(this.dticketsbtn_Click);
            // 
            // dvisitorbtn
            // 
            this.dvisitorbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvisitorbtn.Location = new System.Drawing.Point(232, 270);
            this.dvisitorbtn.Name = "dvisitorbtn";
            this.dvisitorbtn.Size = new System.Drawing.Size(142, 47);
            this.dvisitorbtn.TabIndex = 2;
            this.dvisitorbtn.Text = "Details of Visitor";
            this.dvisitorbtn.UseVisualStyleBackColor = true;
            this.dvisitorbtn.Click += new System.EventHandler(this.dvisitorbtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutbtn.Image")));
            this.logoutbtn.Location = new System.Drawing.Point(551, 12);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(28, 27);
            this.logoutbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoutbtn.TabIndex = 6;
            this.logoutbtn.TabStop = false;
            this.toolTip1.SetToolTip(this.logoutbtn, "Logout");
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 405);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.dvisitorbtn);
            this.Controls.Add(this.dticketsbtn);
            this.Controls.Add(this.ticketbillingbtn);
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoutbtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ticketbillingbtn;
        private System.Windows.Forms.Button dticketsbtn;
        private System.Windows.Forms.Button dvisitorbtn;
        private System.Windows.Forms.PictureBox logoutbtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}