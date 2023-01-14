
namespace Recreation_Centre_System
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.setticketbtn = new System.Windows.Forms.Button();
            this.dwreportbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logoutbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // setticketbtn
            // 
            this.setticketbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setticketbtn.Location = new System.Drawing.Point(227, 137);
            this.setticketbtn.Name = "setticketbtn";
            this.setticketbtn.Size = new System.Drawing.Size(158, 59);
            this.setticketbtn.TabIndex = 0;
            this.setticketbtn.Text = "Set Ticket Prices";
            this.setticketbtn.UseVisualStyleBackColor = true;
            this.setticketbtn.Click += new System.EventHandler(this.setticketbtn_Click);
            // 
            // dwreportbtn
            // 
            this.dwreportbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dwreportbtn.Location = new System.Drawing.Point(227, 249);
            this.dwreportbtn.Name = "dwreportbtn";
            this.dwreportbtn.Size = new System.Drawing.Size(158, 60);
            this.dwreportbtn.TabIndex = 4;
            this.dwreportbtn.Text = "Daily-Weekly Report";
            this.dwreportbtn.UseVisualStyleBackColor = true;
            this.dwreportbtn.Click += new System.EventHandler(this.dwreportbtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutbtn.Image")));
            this.logoutbtn.Location = new System.Drawing.Point(596, 31);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(28, 27);
            this.logoutbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoutbtn.TabIndex = 5;
            this.logoutbtn.TabStop = false;
            this.toolTip1.SetToolTip(this.logoutbtn, "logout");
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 462);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.dwreportbtn);
            this.Controls.Add(this.setticketbtn);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoutbtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button setticketbtn;
        private System.Windows.Forms.Button dwreportbtn;
        private System.Windows.Forms.PictureBox logoutbtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}