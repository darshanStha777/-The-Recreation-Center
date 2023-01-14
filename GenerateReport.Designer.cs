
namespace Recreation_Centre_System
{
    partial class GenerateReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateReport));
            this.dailydataGView = new System.Windows.Forms.DataGridView();
            this.dailyreportbtn = new System.Windows.Forms.Button();
            this.totalvisitortxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.weeklyreportbtn = new System.Windows.Forms.Button();
            this.weeklydataGView = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.earningrbtn = new System.Windows.Forms.Button();
            this.weeklychartbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dailydataGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklydataGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // dailydataGView
            // 
            this.dailydataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailydataGView.Location = new System.Drawing.Point(44, 129);
            this.dailydataGView.Name = "dailydataGView";
            this.dailydataGView.RowHeadersWidth = 51;
            this.dailydataGView.RowTemplate.Height = 24;
            this.dailydataGView.Size = new System.Drawing.Size(545, 391);
            this.dailydataGView.TabIndex = 0;
            // 
            // dailyreportbtn
            // 
            this.dailyreportbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyreportbtn.Location = new System.Drawing.Point(216, 587);
            this.dailyreportbtn.Name = "dailyreportbtn";
            this.dailyreportbtn.Size = new System.Drawing.Size(117, 39);
            this.dailyreportbtn.TabIndex = 1;
            this.dailyreportbtn.Text = "Daily Report";
            this.dailyreportbtn.UseVisualStyleBackColor = true;
            this.dailyreportbtn.Click += new System.EventHandler(this.dailyreportbtn_Click);
            // 
            // totalvisitortxt
            // 
            this.totalvisitortxt.Location = new System.Drawing.Point(291, 539);
            this.totalvisitortxt.Name = "totalvisitortxt";
            this.totalvisitortxt.ReadOnly = true;
            this.totalvisitortxt.Size = new System.Drawing.Size(116, 22);
            this.totalvisitortxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total No of Today Vistors:";
            // 
            // weeklyreportbtn
            // 
            this.weeklyreportbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyreportbtn.Location = new System.Drawing.Point(939, 587);
            this.weeklyreportbtn.Name = "weeklyreportbtn";
            this.weeklyreportbtn.Size = new System.Drawing.Size(117, 39);
            this.weeklyreportbtn.TabIndex = 4;
            this.weeklyreportbtn.Text = "Weekly Report";
            this.weeklyreportbtn.UseVisualStyleBackColor = true;
            this.weeklyreportbtn.Click += new System.EventHandler(this.weeklyreportbtn_Click);
            // 
            // weeklydataGView
            // 
            this.weeklydataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weeklydataGView.Location = new System.Drawing.Point(735, 129);
            this.weeklydataGView.Name = "weeklydataGView";
            this.weeklydataGView.RowHeadersWidth = 51;
            this.weeklydataGView.RowTemplate.Height = 24;
            this.weeklydataGView.Size = new System.Drawing.Size(561, 391);
            this.weeklydataGView.TabIndex = 5;
            this.weeklydataGView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1097, 536);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Visitors";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // earningrbtn
            // 
            this.earningrbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earningrbtn.Location = new System.Drawing.Point(981, 536);
            this.earningrbtn.Name = "earningrbtn";
            this.earningrbtn.Size = new System.Drawing.Size(75, 25);
            this.earningrbtn.TabIndex = 7;
            this.earningrbtn.Text = "Earning";
            this.earningrbtn.UseVisualStyleBackColor = true;
            this.earningrbtn.Click += new System.EventHandler(this.earningrbtn_Click);
            // 
            // weeklychartbtn
            // 
            this.weeklychartbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklychartbtn.Location = new System.Drawing.Point(1097, 587);
            this.weeklychartbtn.Name = "weeklychartbtn";
            this.weeklychartbtn.Size = new System.Drawing.Size(117, 39);
            this.weeklychartbtn.TabIndex = 8;
            this.weeklychartbtn.Text = "Weekly Chart";
            this.weeklychartbtn.UseVisualStyleBackColor = true;
            this.weeklychartbtn.Click += new System.EventHandler(this.weeklychartbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Transparent;
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.Location = new System.Drawing.Point(23, 33);
            this.backbtn.Margin = new System.Windows.Forms.Padding(4);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(47, 40);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backbtn.TabIndex = 55;
            this.backbtn.TabStop = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(609, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 32);
            this.label2.TabIndex = 56;
            this.label2.Text = "Report";
            // 
            // GenerateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1332, 690);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.weeklychartbtn);
            this.Controls.Add(this.earningrbtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.weeklydataGView);
            this.Controls.Add(this.weeklyreportbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalvisitortxt);
            this.Controls.Add(this.dailyreportbtn);
            this.Controls.Add(this.dailydataGView);
            this.Name = "GenerateReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dailydataGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklydataGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dailydataGView;
        private System.Windows.Forms.Button dailyreportbtn;
        private System.Windows.Forms.TextBox totalvisitortxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button weeklyreportbtn;
        private System.Windows.Forms.DataGridView weeklydataGView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button earningrbtn;
        private System.Windows.Forms.Button weeklychartbtn;
        private System.Windows.Forms.PictureBox backbtn;
        private System.Windows.Forms.Label label2;
    }
}