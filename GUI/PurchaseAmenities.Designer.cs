namespace GUI
{
    partial class PurchaseAmenities
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
            this.txtBookingReference = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowAmenities = new System.Windows.Forms.Button();
            this.cbxChooseYourFlights = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPassportNumber = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblYourCabinClassIs = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblItemsSelected = new System.Windows.Forms.Label();
            this.lblDutiesAndTaxes = new System.Windows.Forms.Label();
            this.lblTotalPayable = new System.Windows.Forms.Label();
            this.btnSaveAndConfirm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkAmenity = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking reference:";
            // 
            // txtBookingReference
            // 
            this.txtBookingReference.Location = new System.Drawing.Point(188, 10);
            this.txtBookingReference.Name = "txtBookingReference";
            this.txtBookingReference.Size = new System.Drawing.Size(367, 26);
            this.txtBookingReference.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(581, 9);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 29);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowAmenities);
            this.groupBox1.Controls.Add(this.cbxChooseYourFlights);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flight list";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnShowAmenities
            // 
            this.btnShowAmenities.Location = new System.Drawing.Point(800, 32);
            this.btnShowAmenities.Name = "btnShowAmenities";
            this.btnShowAmenities.Size = new System.Drawing.Size(149, 30);
            this.btnShowAmenities.TabIndex = 2;
            this.btnShowAmenities.Text = "Show Amenities";
            this.btnShowAmenities.UseVisualStyleBackColor = true;
            this.btnShowAmenities.Click += new System.EventHandler(this.btnShowAmenities_Click);
            // 
            // cbxChooseYourFlights
            // 
            this.cbxChooseYourFlights.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChooseYourFlights.FormattingEnabled = true;
            this.cbxChooseYourFlights.Location = new System.Drawing.Point(191, 33);
            this.cbxChooseYourFlights.Name = "cbxChooseYourFlights";
            this.cbxChooseYourFlights.Size = new System.Drawing.Size(580, 28);
            this.cbxChooseYourFlights.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose your flights:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Full name:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(114, 210);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(0, 20);
            this.lblFullName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Passport number:";
            // 
            // lblPassportNumber
            // 
            this.lblPassportNumber.AutoSize = true;
            this.lblPassportNumber.Location = new System.Drawing.Point(662, 210);
            this.lblPassportNumber.Name = "lblPassportNumber";
            this.lblPassportNumber.Size = new System.Drawing.Size(0, 20);
            this.lblPassportNumber.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Your cabin class is:";
            // 
            // lblYourCabinClassIs
            // 
            this.lblYourCabinClassIs.AutoSize = true;
            this.lblYourCabinClassIs.Location = new System.Drawing.Point(172, 249);
            this.lblYourCabinClassIs.Name = "lblYourCabinClassIs";
            this.lblYourCabinClassIs.Size = new System.Drawing.Size(0, 20);
            this.lblYourCabinClassIs.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Items selected:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 549);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Duties and taxes:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 603);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total payable:";
            // 
            // lblItemsSelected
            // 
            this.lblItemsSelected.AutoSize = true;
            this.lblItemsSelected.Location = new System.Drawing.Point(307, 495);
            this.lblItemsSelected.Name = "lblItemsSelected";
            this.lblItemsSelected.Size = new System.Drawing.Size(0, 20);
            this.lblItemsSelected.TabIndex = 14;
            // 
            // lblDutiesAndTaxes
            // 
            this.lblDutiesAndTaxes.AutoSize = true;
            this.lblDutiesAndTaxes.Location = new System.Drawing.Point(307, 549);
            this.lblDutiesAndTaxes.Name = "lblDutiesAndTaxes";
            this.lblDutiesAndTaxes.Size = new System.Drawing.Size(0, 20);
            this.lblDutiesAndTaxes.TabIndex = 15;
            // 
            // lblTotalPayable
            // 
            this.lblTotalPayable.AutoSize = true;
            this.lblTotalPayable.Location = new System.Drawing.Point(307, 603);
            this.lblTotalPayable.Name = "lblTotalPayable";
            this.lblTotalPayable.Size = new System.Drawing.Size(0, 20);
            this.lblTotalPayable.TabIndex = 16;
            // 
            // btnSaveAndConfirm
            // 
            this.btnSaveAndConfirm.Location = new System.Drawing.Point(747, 512);
            this.btnSaveAndConfirm.Name = "btnSaveAndConfirm";
            this.btnSaveAndConfirm.Size = new System.Drawing.Size(161, 30);
            this.btnSaveAndConfirm.TabIndex = 17;
            this.btnSaveAndConfirm.Text = "Save and Confirm";
            this.btnSaveAndConfirm.UseVisualStyleBackColor = true;
            this.btnSaveAndConfirm.Click += new System.EventHandler(this.btnSaveAndConfirm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(747, 572);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(161, 30);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkAmenity);
            this.groupBox2.Location = new System.Drawing.Point(26, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(968, 175);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AMONIC Airlines Amenities";
            // 
            // checkAmenity
            // 
            this.checkAmenity.ColumnWidth = 300;
            this.checkAmenity.FormattingEnabled = true;
            this.checkAmenity.Location = new System.Drawing.Point(27, 25);
            this.checkAmenity.MultiColumn = true;
            this.checkAmenity.Name = "checkAmenity";
            this.checkAmenity.Size = new System.Drawing.Size(909, 142);
            this.checkAmenity.TabIndex = 0;
            this.checkAmenity.SelectedIndexChanged += new System.EventHandler(this.checkAmenity_SelectedIndexChanged);
            // 
            // PurchaseAmenities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveAndConfirm);
            this.Controls.Add(this.lblTotalPayable);
            this.Controls.Add(this.lblDutiesAndTaxes);
            this.Controls.Add(this.lblItemsSelected);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblYourCabinClassIs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPassportNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtBookingReference);
            this.Controls.Add(this.label1);
            this.Name = "PurchaseAmenities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Amenities";
            this.Load += new System.EventHandler(this.PurchaseAmenities_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookingReference;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowAmenities;
        private System.Windows.Forms.ComboBox cbxChooseYourFlights;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPassportNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblYourCabinClassIs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblItemsSelected;
        private System.Windows.Forms.Label lblDutiesAndTaxes;
        private System.Windows.Forms.Label lblTotalPayable;
        private System.Windows.Forms.Button btnSaveAndConfirm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox checkAmenity;
    }
}

