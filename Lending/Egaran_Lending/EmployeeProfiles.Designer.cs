namespace Egaran_Lending
{
    partial class EmployeeProfiles
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpLname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmpFname = new System.Windows.Forms.TextBox();
            this.txtEmpMname = new System.Windows.Forms.TextBox();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(218, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee Profile";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.EmpMname});
            this.dataEmployees.Location = new System.Drawing.Point(173, 101);
            this.dataEmployees.Name = "dataEmployees";
            this.dataEmployees.ReadOnly = true;
            this.dataEmployees.Size = new System.Drawing.Size(544, 500);
            this.dataEmployees.TabIndex = 3;
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
            this.EmpLname.Width = 150;
            // 
            // EmpFname
            // 
            this.EmpFname.HeaderText = "First Name";
            this.EmpFname.Name = "EmpFname";
            this.EmpFname.ReadOnly = true;
            this.EmpFname.Width = 150;
            // 
            // EmpMname
            // 
            this.EmpMname.HeaderText = "Middle Initial";
            this.EmpMname.Name = "EmpMname";
            this.EmpMname.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(11, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee ID:";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Enabled = false;
            this.txtEmpID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(15, 210);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(138, 27);
            this.txtEmpID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name:";
            // 
            // txtEmpLname
            // 
            this.txtEmpLname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpLname.Location = new System.Drawing.Point(15, 274);
            this.txtEmpLname.Name = "txtEmpLname";
            this.txtEmpLname.Size = new System.Drawing.Size(138, 27);
            this.txtEmpLname.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Middle Name:";
            // 
            // txtEmpFname
            // 
            this.txtEmpFname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpFname.Location = new System.Drawing.Point(15, 340);
            this.txtEmpFname.Name = "txtEmpFname";
            this.txtEmpFname.Size = new System.Drawing.Size(138, 27);
            this.txtEmpFname.TabIndex = 10;
            // 
            // txtEmpMname
            // 
            this.txtEmpMname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpMname.Location = new System.Drawing.Point(15, 406);
            this.txtEmpMname.Name = "txtEmpMname";
            this.txtEmpMname.Size = new System.Drawing.Size(138, 27);
            this.txtEmpMname.TabIndex = 11;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.btnAddEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.btnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.ForeColor = System.Drawing.Color.White;
            this.btnAddEmp.Location = new System.Drawing.Point(15, 453);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(138, 48);
            this.btnAddEmp.TabIndex = 12;
            this.btnAddEmp.Text = "Add";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(15, 507);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(138, 48);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // EmployeeProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(93)))), ((int)(((byte)(108)))));
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.txtEmpMname);
            this.Controls.Add(this.txtEmpFname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmpLname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataEmployees);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeProfiles";
            this.Size = new System.Drawing.Size(744, 628);
            this.Load += new System.EventHandler(this.EmployeeProfiles_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpLname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmpFname;
        private System.Windows.Forms.TextBox txtEmpMname;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnUpdate;
    }
}
