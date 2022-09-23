namespace ContractManagementSystem.UserControls
{
    partial class UC_Contractors
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchContractor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveContractor = new System.Windows.Forms.Button();
            this.txtContractorAddress = new System.Windows.Forms.TextBox();
            this.txtContractorName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvContractor = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteContractor = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.txtSearchContractor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSaveContractor);
            this.panel1.Controls.Add(this.txtContractorAddress);
            this.panel1.Controls.Add(this.txtContractorName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 292);
            this.panel1.TabIndex = 0;
            // 
            // txtSearchContractor
            // 
            this.txtSearchContractor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearchContractor.Location = new System.Drawing.Point(732, 263);
            this.txtSearchContractor.Name = "txtSearchContractor";
            this.txtSearchContractor.Size = new System.Drawing.Size(171, 23);
            this.txtSearchContractor.TabIndex = 16;
            this.txtSearchContractor.TextChanged += new System.EventHandler(this.txtSearchContractor_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(685, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Search:";
            // 
            // btnSaveContractor
            // 
            this.btnSaveContractor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveContractor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveContractor.FlatAppearance.BorderSize = 0;
            this.btnSaveContractor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveContractor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveContractor.ForeColor = System.Drawing.Color.Transparent;
            this.btnSaveContractor.Location = new System.Drawing.Point(632, 197);
            this.btnSaveContractor.Name = "btnSaveContractor";
            this.btnSaveContractor.Size = new System.Drawing.Size(93, 43);
            this.btnSaveContractor.TabIndex = 14;
            this.btnSaveContractor.Text = "Save";
            this.btnSaveContractor.UseVisualStyleBackColor = false;
            this.btnSaveContractor.Click += new System.EventHandler(this.btnSaveContractor_Click);
            // 
            // txtContractorAddress
            // 
            this.txtContractorAddress.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContractorAddress.Location = new System.Drawing.Point(289, 119);
            this.txtContractorAddress.Multiline = true;
            this.txtContractorAddress.Name = "txtContractorAddress";
            this.txtContractorAddress.Size = new System.Drawing.Size(436, 72);
            this.txtContractorAddress.TabIndex = 13;
            // 
            // txtContractorName
            // 
            this.txtContractorName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContractorName.Location = new System.Drawing.Point(289, 77);
            this.txtContractorName.Name = "txtContractorName";
            this.txtContractorName.Size = new System.Drawing.Size(436, 27);
            this.txtContractorName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(214, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(204, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Full Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(400, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add a New Contrator";
            // 
            // dgvContractor
            // 
            this.dgvContractor.AllowUserToAddRows = false;
            this.dgvContractor.AllowUserToDeleteRows = false;
            this.dgvContractor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContractor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContractor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvContractor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContractor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.full_name,
            this.address,
            this.deleteContractor});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContractor.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvContractor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContractor.Location = new System.Drawing.Point(0, 292);
            this.dgvContractor.Name = "dgvContractor";
            this.dgvContractor.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContractor.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvContractor.RowHeadersVisible = false;
            this.dgvContractor.RowTemplate.Height = 25;
            this.dgvContractor.Size = new System.Drawing.Size(923, 305);
            this.dgvContractor.TabIndex = 1;
            this.dgvContractor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContractor_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // full_name
            // 
            this.full_name.DataPropertyName = "full_name";
            this.full_name.HeaderText = "Full Name";
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // deleteContractor
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteContractor.DefaultCellStyle = dataGridViewCellStyle6;
            this.deleteContractor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteContractor.HeaderText = "Action";
            this.deleteContractor.Name = "deleteContractor";
            this.deleteContractor.ReadOnly = true;
            this.deleteContractor.Text = "Delete";
            this.deleteContractor.ToolTipText = "Delete";
            this.deleteContractor.UseColumnTextForButtonValue = true;
            // 
            // UC_Contractors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvContractor);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Contractors";
            this.Size = new System.Drawing.Size(923, 597);
            this.Load += new System.EventHandler(this.UC_Contractors_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView dgvContractor;
        private TextBox txtContractorAddress;
        private TextBox txtContractorName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSaveContractor;
        private TextBox txtSearchContractor;
        private Label label4;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn full_name;
        private DataGridViewTextBoxColumn address;
        private DataGridViewButtonColumn deleteContractor;
    }
}
