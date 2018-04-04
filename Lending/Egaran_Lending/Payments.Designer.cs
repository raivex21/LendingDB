namespace Egaran_Lending
{
    partial class Payments
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataEmployees = new System.Windows.Forms.DataGridView();
            this.dataHistory = new System.Windows.Forms.DataGridView();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.Empid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpLname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(227, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Payment History";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataEmployees
            // 
            this.dataEmployees.AllowUserToAddRows = false;
            this.dataEmployees.AllowUserToDeleteRows = false;
            this.dataEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Empid,
            this.EmpLname,
            this.Borrowed,
            this.Paid});
            this.dataEmployees.Location = new System.Drawing.Point(19, 100);
            this.dataEmployees.Name = "dataEmployees";
            this.dataEmployees.ReadOnly = true;
            this.dataEmployees.Size = new System.Drawing.Size(413, 321);
            this.dataEmployees.TabIndex = 5;
            this.dataEmployees.SelectionChanged += new System.EventHandler(this.dataEmployees_SelectionChanged);
            // 
            // dataHistory
            // 
            this.dataHistory.AllowUserToAddRows = false;
            this.dataHistory.AllowUserToDeleteRows = false;
            this.dataHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataHistory.Location = new System.Drawing.Point(438, 100);
            this.dataHistory.Name = "dataHistory";
            this.dataHistory.ReadOnly = true;
            this.dataHistory.Size = new System.Drawing.Size(293, 321);
            this.dataHistory.TabIndex = 6;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(309, 488);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(138, 27);
            this.txtAmount.TabIndex = 15;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Enabled = false;
            this.txtEmpID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(112, 488);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(138, 27);
            this.txtEmpID.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(108, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Employee ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(305, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Amount:";
            // 
            // btnPay
            // 
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.btnPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(499, 469);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(194, 62);
            this.btnPay.TabIndex = 19;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // Empid
            // 
            this.Empid.HeaderText = "ID";
            this.Empid.Name = "Empid";
            this.Empid.ReadOnly = true;
            this.Empid.Width = 50;
            // 
            // EmpLname
            // 
            this.EmpLname.HeaderText = "Employee Name";
            this.EmpLname.Name = "EmpLname";
            this.EmpLname.ReadOnly = true;
            this.EmpLname.Width = 140;
            // 
            // Borrowed
            // 
            this.Borrowed.HeaderText = "Borrowed";
            this.Borrowed.Name = "Borrowed";
            this.Borrowed.ReadOnly = true;
            this.Borrowed.Width = 80;
            // 
            // Paid
            // 
            this.Paid.HeaderText = "Paid";
            this.Paid.Name = "Paid";
            this.Paid.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Amount Paid";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date Paid";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(93)))), ((int)(((byte)(108)))));
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.dataHistory);
            this.Controls.Add(this.dataEmployees);
            this.Controls.Add(this.label1);
            this.Name = "Payments";
            this.Size = new System.Drawing.Size(744, 628);
            this.Load += new System.EventHandler(this.Payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataEmployees;
        private System.Windows.Forms.DataGridView dataHistory;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empid;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpLname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
