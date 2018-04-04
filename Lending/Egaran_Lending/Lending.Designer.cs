namespace Egaran_Lending
{
    partial class Lending
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
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpLname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpFname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpMname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(294, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lending";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataEmployees
            // 
            this.dataEmployees.AllowUserToAddRows = false;
            this.dataEmployees.AllowUserToDeleteRows = false;
            this.dataEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpID,
            this.EmpLname,
            this.EmpFname,
            this.EmpMname,
            this.Borrowed,
            this.Paid});
            this.dataEmployees.Location = new System.Drawing.Point(31, 89);
            this.dataEmployees.Name = "dataEmployees";
            this.dataEmployees.ReadOnly = true;
            this.dataEmployees.Size = new System.Drawing.Size(674, 321);
            this.dataEmployees.TabIndex = 4;
            this.dataEmployees.SelectionChanged += new System.EventHandler(this.dataEmployees_SelectionChanged);
            // 
            // EmpID
            // 
            this.EmpID.HeaderText = "ID";
            this.EmpID.Name = "EmpID";
            this.EmpID.ReadOnly = true;
            // 
            // EmpLname
            // 
            this.EmpLname.HeaderText = "Last Name";
            this.EmpLname.Name = "EmpLname";
            this.EmpLname.ReadOnly = true;
            this.EmpLname.Width = 120;
            // 
            // EmpFname
            // 
            this.EmpFname.HeaderText = "First Name";
            this.EmpFname.Name = "EmpFname";
            this.EmpFname.ReadOnly = true;
            this.EmpFname.Width = 110;
            // 
            // EmpMname
            // 
            this.EmpMname.HeaderText = "Middle Initial";
            this.EmpMname.Name = "EmpMname";
            this.EmpMname.ReadOnly = true;
            // 
            // Borrowed
            // 
            this.Borrowed.HeaderText = "Borrowed";
            this.Borrowed.Name = "Borrowed";
            this.Borrowed.ReadOnly = true;
            // 
            // Paid
            // 
            this.Paid.HeaderText = "Paid";
            this.Paid.Name = "Paid";
            this.Paid.ReadOnly = true;
            // 
            // btnBorrow
            // 
            this.btnBorrow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.btnBorrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.ForeColor = System.Drawing.Color.White;
            this.btnBorrow.Location = new System.Drawing.Point(484, 458);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(194, 62);
            this.btnBorrow.TabIndex = 13;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(302, 484);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(138, 27);
            this.txtAmount.TabIndex = 14;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Enabled = false;
            this.txtEmpID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(99, 484);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(138, 27);
            this.txtEmpID.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(95, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Employee ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(298, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Amount:";
            // 
            // Lending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(93)))), ((int)(((byte)(108)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.dataEmployees);
            this.Controls.Add(this.label1);
            this.Name = "Lending";
            this.Size = new System.Drawing.Size(744, 628);
            this.Load += new System.EventHandler(this.Lending_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpLname;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpFname;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpMname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paid;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
