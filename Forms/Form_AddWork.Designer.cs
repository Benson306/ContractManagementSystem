namespace ContractManagementSystem
{
    partial class Form_AddWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddWork));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWorkTitle = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtTsNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTsAmount = new System.Windows.Forms.TextBox();
            this.cmType = new System.Windows.Forms.ComboBox();
            this.btnCancelWork = new System.Windows.Forms.Button();
            this.btnSaveWork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(215, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a New Work";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(19, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Work Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(29, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "TS Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(17, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Work Type:";
            // 
            // txtWorkTitle
            // 
            this.txtWorkTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWorkTitle.Location = new System.Drawing.Point(104, 126);
            this.txtWorkTitle.Name = "txtWorkTitle";
            this.txtWorkTitle.Size = new System.Drawing.Size(436, 27);
            this.txtWorkTitle.TabIndex = 1;
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLocation.Location = new System.Drawing.Point(104, 168);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(436, 27);
            this.txtLocation.TabIndex = 2;
            // 
            // txtTsNumber
            // 
            this.txtTsNumber.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTsNumber.Location = new System.Drawing.Point(104, 206);
            this.txtTsNumber.Name = "txtTsNumber";
            this.txtTsNumber.Size = new System.Drawing.Size(163, 27);
            this.txtTsNumber.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(287, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "TS Amount:";
            // 
            // txtTsAmount
            // 
            this.txtTsAmount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTsAmount.Location = new System.Drawing.Point(376, 206);
            this.txtTsAmount.Name = "txtTsAmount";
            this.txtTsAmount.Size = new System.Drawing.Size(163, 27);
            this.txtTsAmount.TabIndex = 4;
            // 
            // cmType
            // 
            this.cmType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmType.FormattingEnabled = true;
            this.cmType.Location = new System.Drawing.Point(104, 244);
            this.cmType.Name = "cmType";
            this.cmType.Size = new System.Drawing.Size(163, 28);
            this.cmType.TabIndex = 5;
            // 
            // btnCancelWork
            // 
            this.btnCancelWork.Location = new System.Drawing.Point(287, 310);
            this.btnCancelWork.Name = "btnCancelWork";
            this.btnCancelWork.Size = new System.Drawing.Size(109, 43);
            this.btnCancelWork.TabIndex = 7;
            this.btnCancelWork.Text = "Cancel";
            this.btnCancelWork.UseVisualStyleBackColor = true;
            this.btnCancelWork.Click += new System.EventHandler(this.btnCancelWork_Click);
            // 
            // btnSaveWork
            // 
            this.btnSaveWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveWork.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveWork.FlatAppearance.BorderSize = 0;
            this.btnSaveWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveWork.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveWork.ForeColor = System.Drawing.Color.Black;
            this.btnSaveWork.Location = new System.Drawing.Point(417, 309);
            this.btnSaveWork.Name = "btnSaveWork";
            this.btnSaveWork.Size = new System.Drawing.Size(93, 43);
            this.btnSaveWork.TabIndex = 6;
            this.btnSaveWork.Text = "Save";
            this.btnSaveWork.UseVisualStyleBackColor = false;
            this.btnSaveWork.Click += new System.EventHandler(this.btnSaveWork_Click);
            // 
            // Form_AddWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(587, 383);
            this.Controls.Add(this.btnSaveWork);
            this.Controls.Add(this.btnCancelWork);
            this.Controls.Add(this.cmType);
            this.Controls.Add(this.txtTsAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTsNumber);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtWorkTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_AddWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddWork";
            this.Load += new System.EventHandler(this.Form_AddWork_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtWorkTitle;
        private TextBox txtLocation;
        private TextBox txtTsNumber;
        private Label label6;
        private TextBox txtTsAmount;
        private ComboBox cmType;
        private Button btnCancelWork;
        private Button btnSaveWork;
    }
}