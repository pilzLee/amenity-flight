namespace GUI
{
    partial class AmenitiesReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMakeReport = new System.Windows.Forms.Button();
            this.txtFlightID = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.amenity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "from:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "to:";
            // 
            // btnMakeReport
            // 
            this.btnMakeReport.Location = new System.Drawing.Point(782, 104);
            this.btnMakeReport.Name = "btnMakeReport";
            this.btnMakeReport.Size = new System.Drawing.Size(169, 32);
            this.btnMakeReport.TabIndex = 3;
            this.btnMakeReport.Text = "Make Report";
            this.btnMakeReport.UseVisualStyleBackColor = true;
            this.btnMakeReport.Click += new System.EventHandler(this.btnMakeReport_Click);
            // 
            // txtFlightID
            // 
            this.txtFlightID.Location = new System.Drawing.Point(90, 43);
            this.txtFlightID.Name = "txtFlightID";
            this.txtFlightID.Size = new System.Drawing.Size(294, 26);
            this.txtFlightID.TabIndex = 4;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(90, 105);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(294, 26);
            this.txtFrom.TabIndex = 5;
            this.txtFrom.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(490, 107);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(274, 26);
            this.txtTo.TabIndex = 6;
            this.txtTo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amenity,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvReport.Location = new System.Drawing.Point(16, 25);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 62;
            this.dgvReport.RowTemplate.Height = 28;
            this.dgvReport.Size = new System.Drawing.Size(940, 250);
            this.dgvReport.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvReport);
            this.groupBox1.Location = new System.Drawing.Point(31, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 293);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFlightID);
            this.groupBox2.Controls.Add(this.txtTo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtFrom);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnMakeReport);
            this.groupBox2.Location = new System.Drawing.Point(31, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(972, 161);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report";
            // 
            // amenity
            // 
            this.amenity.HeaderText = "Amenities";
            this.amenity.MinimumWidth = 8;
            this.amenity.Name = "amenity";
            this.amenity.Width = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Extra Blanket";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Next Seat Free";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Two Neighboring Seats Free";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tablet Rental";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Laptop Rental";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Longue Access";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Premium Headphones Rental";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 50;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Extra Bag";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 50;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Fast Checkin Lane";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.Width = 50;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Wi-Fi 250 mb";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.Width = 50;
            // 
            // AmenitiesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AmenitiesReport";
            this.Text = "AmenitiesReport";
            this.Load += new System.EventHandler(this.AmenitiesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMakeReport;
        private System.Windows.Forms.TextBox txtFlightID;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn amenity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}