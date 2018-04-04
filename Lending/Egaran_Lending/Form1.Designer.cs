namespace Egaran_Lending
{
    partial class LendingCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LendingCompany));
            this.Dashboard = new System.Windows.Forms.Panel();
            this.dashbtnHome = new System.Windows.Forms.Button();
            this.dashbtnPayment = new System.Windows.Forms.Button();
            this.dashbtnLending = new System.Windows.Forms.Button();
            this.dashbtnEmp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Payment = new Egaran_Lending.Payments();
            this.Lending = new Egaran_Lending.Lending();
            this.Profiles = new Egaran_Lending.EmployeeProfiles();
            this.Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Dashboard.Controls.Add(this.dashbtnHome);
            this.Dashboard.Controls.Add(this.dashbtnPayment);
            this.Dashboard.Controls.Add(this.dashbtnLending);
            this.Dashboard.Controls.Add(this.dashbtnEmp);
            this.Dashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.Dashboard.Location = new System.Drawing.Point(0, 0);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(266, 628);
            this.Dashboard.TabIndex = 0;
            // 
            // dashbtnHome
            // 
            this.dashbtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dashbtnHome.FlatAppearance.BorderSize = 0;
            this.dashbtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashbtnHome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashbtnHome.ForeColor = System.Drawing.Color.White;
            this.dashbtnHome.Location = new System.Drawing.Point(0, -6);
            this.dashbtnHome.Name = "dashbtnHome";
            this.dashbtnHome.Size = new System.Drawing.Size(266, 92);
            this.dashbtnHome.TabIndex = 3;
            this.dashbtnHome.Text = "Home";
            this.dashbtnHome.UseVisualStyleBackColor = false;
            this.dashbtnHome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dashbtnHome_MouseClick);
            // 
            // dashbtnPayment
            // 
            this.dashbtnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dashbtnPayment.FlatAppearance.BorderSize = 0;
            this.dashbtnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashbtnPayment.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashbtnPayment.ForeColor = System.Drawing.Color.White;
            this.dashbtnPayment.Location = new System.Drawing.Point(0, 210);
            this.dashbtnPayment.Name = "dashbtnPayment";
            this.dashbtnPayment.Size = new System.Drawing.Size(266, 67);
            this.dashbtnPayment.TabIndex = 2;
            this.dashbtnPayment.Text = "Payment History";
            this.dashbtnPayment.UseVisualStyleBackColor = false;
            this.dashbtnPayment.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dashbtnPayment_MouseClick);
            // 
            // dashbtnLending
            // 
            this.dashbtnLending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dashbtnLending.FlatAppearance.BorderSize = 0;
            this.dashbtnLending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashbtnLending.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashbtnLending.ForeColor = System.Drawing.Color.White;
            this.dashbtnLending.Location = new System.Drawing.Point(0, 149);
            this.dashbtnLending.Name = "dashbtnLending";
            this.dashbtnLending.Size = new System.Drawing.Size(266, 67);
            this.dashbtnLending.TabIndex = 1;
            this.dashbtnLending.Text = "Lending";
            this.dashbtnLending.UseVisualStyleBackColor = false;
            this.dashbtnLending.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dashbtnLending_MouseClick);
            // 
            // dashbtnEmp
            // 
            this.dashbtnEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dashbtnEmp.FlatAppearance.BorderSize = 0;
            this.dashbtnEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashbtnEmp.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashbtnEmp.ForeColor = System.Drawing.Color.White;
            this.dashbtnEmp.Location = new System.Drawing.Point(0, 86);
            this.dashbtnEmp.Name = "dashbtnEmp";
            this.dashbtnEmp.Size = new System.Drawing.Size(266, 67);
            this.dashbtnEmp.TabIndex = 0;
            this.dashbtnEmp.Text = "Employee Profile";
            this.dashbtnEmp.UseVisualStyleBackColor = false;
            this.dashbtnEmp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dashbtnEmp_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(315, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Lending and Payments";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(205, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 542);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Payment
            // 
            this.Payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(93)))), ((int)(((byte)(108)))));
            this.Payment.Location = new System.Drawing.Point(265, 0);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(744, 628);
            this.Payment.TabIndex = 5;
            this.Payment.Visible = false;
            // 
            // Lending
            // 
            this.Lending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(93)))), ((int)(((byte)(108)))));
            this.Lending.Location = new System.Drawing.Point(265, 0);
            this.Lending.Name = "Lending";
            this.Lending.Size = new System.Drawing.Size(744, 628);
            this.Lending.TabIndex = 4;
            this.Lending.Visible = false;
            // 
            // Profiles
            // 
            this.Profiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(93)))), ((int)(((byte)(108)))));
            this.Profiles.Location = new System.Drawing.Point(265, 0);
            this.Profiles.Name = "Profiles";
            this.Profiles.Size = new System.Drawing.Size(744, 628);
            this.Profiles.TabIndex = 3;
            this.Profiles.Visible = false;
            // 
            // LendingCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(93)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(1006, 628);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.Lending);
            this.Controls.Add(this.Profiles);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LendingCompany";
            this.Text = "Lending";
            this.Dashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Dashboard;
        private System.Windows.Forms.Button dashbtnPayment;
        private System.Windows.Forms.Button dashbtnLending;
        private System.Windows.Forms.Button dashbtnEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dashbtnHome;
        private EmployeeProfiles Profiles;
        private Lending Lending;
        private Payments Payment;
    }
}

