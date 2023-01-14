
namespace Recreation_Centre_System
{
    partial class VisitorDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitorDetails));
            this.visiterdataGridV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.visiterdataGridV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // visiterdataGridV
            // 
            this.visiterdataGridV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visiterdataGridV.Location = new System.Drawing.Point(21, 92);
            this.visiterdataGridV.Name = "visiterdataGridV";
            this.visiterdataGridV.RowHeadersWidth = 51;
            this.visiterdataGridV.RowTemplate.Height = 24;
            this.visiterdataGridV.Size = new System.Drawing.Size(1539, 430);
            this.visiterdataGridV.TabIndex = 0;
            this.visiterdataGridV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(636, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Visiter Details";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Transparent;
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.Location = new System.Drawing.Point(21, 13);
            this.backbtn.Margin = new System.Windows.Forms.Padding(4);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(70, 60);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backbtn.TabIndex = 55;
            this.backbtn.TabStop = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // VisitorDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 564);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.visiterdataGridV);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "VisitorDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visitor_Details";
            this.Load += new System.EventHandler(this.Visitor_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visiterdataGridV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView visiterdataGridV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox backbtn;
    }
}