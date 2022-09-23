namespace ContractManagementSystem.Forms
{
    partial class Form_Assign_Work
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
            this.btnSaveAssignedWork = new System.Windows.Forms.Button();
            this.btnCancelAssign = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.txtCaCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTsNumber = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbContractors = new System.Windows.Forms.ComboBox();
            this.lblTsAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.dateTimeAssignDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnSaveAssignedWork
            // 
            this.btnSaveAssignedWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveAssignedWork.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveAssignedWork.FlatAppearance.BorderSize = 0;
            this.btnSaveAssignedWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAssignedWork.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveAssignedWork.ForeColor = System.Drawing.Color.Black;
            this.btnSaveAssignedWork.Location = new System.Drawing.Point(447, 306);
            this.btnSaveAssignedWork.Name = "btnSaveAssignedWork";
            this.btnSaveAssignedWork.Size = new System.Drawing.Size(93, 43);
            this.btnSaveAssignedWork.TabIndex = 19;
            this.btnSaveAssignedWork.Text = "Save";
            this.btnSaveAssignedWork.UseVisualStyleBackColor = false;
            this.btnSaveAssignedWork.Click += new System.EventHandler(this.btnSaveAssignedWork_Click);
            // 
            // btnCancelAssign
            // 
            this.btnCancelAssign.Location = new System.Drawing.Point(317, 307);
            this.btnCancelAssign.Name = "btnCancelAssign";
            this.btnCancelAssign.Size = new System.Drawing.Size(109, 43);
            this.btnCancelAssign.TabIndex = 20;
            this.btnCancelAssign.Text = "Cancel";
            this.btnCancelAssign.UseVisualStyleBackColor = true;
            this.btnCancelAssign.Click += new System.EventHandler(this.btnCancelAssign_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2021-22",
            "2022-23",
            "2023-24",
            "2024-25"});
            this.cmbYear.Location = new System.Drawing.Point(157, 257);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(163, 28);
            this.cmbYear.TabIndex = 18;
            // 
            // txtCaCost
            // 
            this.txtCaCost.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCaCost.Location = new System.Drawing.Point(157, 215);
            this.txtCaCost.Name = "txtCaCost";
            this.txtCaCost.Size = new System.Drawing.Size(163, 27);
            this.txtCaCost.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(87, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "CA Cost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(98, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(65, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "TS Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(72, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Work Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(245, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Assign Work";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(157, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 19);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "label7";
            // 
            // lblTsNumber
            // 
            this.lblTsNumber.AutoSize = true;
            this.lblTsNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTsNumber.Location = new System.Drawing.Point(157, 128);
            this.lblTsNumber.Name = "lblTsNumber";
            this.lblTsNumber.Size = new System.Drawing.Size(45, 19);
            this.lblTsNumber.TabIndex = 22;
            this.lblTsNumber.Text = "label3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(344, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Assign Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(25, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Select Contractor:";
            // 
            // cmbContractors
            // 
            this.cmbContractors.FormattingEnabled = true;
            this.cmbContractors.Location = new System.Drawing.Point(157, 154);
            this.cmbContractors.Name = "cmbContractors";
            this.cmbContractors.Size = new System.Drawing.Size(404, 23);
            this.cmbContractors.TabIndex = 26;
            this.cmbContractors.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbContractors.Leave += new System.EventHandler(this.cmbContractors_Leave);
            // 
            // lblTsAmount
            // 
            this.lblTsAmount.AutoSize = true;
            this.lblTsAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTsAmount.Location = new System.Drawing.Point(447, 128);
            this.lblTsAmount.Name = "lblTsAmount";
            this.lblTsAmount.Size = new System.Drawing.Size(45, 19);
            this.lblTsAmount.TabIndex = 28;
            this.lblTsAmount.Text = "label3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(350, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "TS Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(86, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Address:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(157, 185);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(0, 19);
            this.lblAddress.TabIndex = 30;
            // 
            // dateTimeAssignDate
            // 
            this.dateTimeAssignDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimeAssignDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeAssignDate.Location = new System.Drawing.Point(441, 217);
            this.dateTimeAssignDate.Name = "dateTimeAssignDate";
            this.dateTimeAssignDate.Size = new System.Drawing.Size(129, 27);
            this.dateTimeAssignDate.TabIndex = 31;
            // 
            // Assign_Work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 383);
            this.Controls.Add(this.dateTimeAssignDate);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTsAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbContractors);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTsNumber);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSaveAssignedWork);
            this.Controls.Add(this.btnCancelAssign);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.txtCaCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Assign_Work";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign_Work";
            this.Load += new System.EventHandler(this.Assign_Work_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSaveAssignedWork;
        private Button btnCancelAssign;
        private ComboBox cmbYear;
        private TextBox txtCaCost;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label lblTitle;
        private Label lblTsNumber;
        private Label label8;
        private Label label9;
        private ComboBox cmbContractors;
        private Label lblTsAmount;
        private Label label7;
        private Label label3;
        private Label lblAddress;
        private DateTimePicker dateTimeAssignDate;
    }
}