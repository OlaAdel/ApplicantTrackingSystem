namespace Applicant_Tracking_System
{
    partial class HRHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddJob = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewJobs = new System.Windows.Forms.ToolStripMenuItem();
            this.AddJobPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReqBox = new System.Windows.Forms.TextBox();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.VacanciesBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.YearsOfExperience = new System.Windows.Forms.TextBox();
            this.CareerLevelBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.JobTitleBox = new System.Windows.Forms.TextBox();
            this.JobRoleBox = new System.Windows.Forms.ComboBox();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.ViewJobsPanel = new System.Windows.Forms.Panel();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.AddJobPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(214)))), ((int)(((byte)(220)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddJob,
            this.ViewJobs,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 25);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddJob
            // 
            this.AddJob.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddJob.ForeColor = System.Drawing.Color.White;
            this.AddJob.Name = "AddJob";
            this.AddJob.Size = new System.Drawing.Size(110, 21);
            this.AddJob.Text = "Add Job Post";
            this.AddJob.Click += new System.EventHandler(this.AddJob_Click);
            // 
            // ViewJobs
            // 
            this.ViewJobs.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewJobs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ViewJobs.Name = "ViewJobs";
            this.ViewJobs.Size = new System.Drawing.Size(87, 21);
            this.ViewJobs.Text = "View Jobs";
            this.ViewJobs.Click += new System.EventHandler(this.ViewJobs_Click);
            // 
            // AddJobPanel
            // 
            this.AddJobPanel.Controls.Add(this.label2);
            this.AddJobPanel.Controls.Add(this.label1);
            this.AddJobPanel.Controls.Add(this.ReqBox);
            this.AddJobPanel.Controls.Add(this.DescBox);
            this.AddJobPanel.Controls.Add(this.panel3);
            this.AddJobPanel.Controls.Add(this.VacanciesBox);
            this.AddJobPanel.Controls.Add(this.panel2);
            this.AddJobPanel.Controls.Add(this.YearsOfExperience);
            this.AddJobPanel.Controls.Add(this.CareerLevelBox);
            this.AddJobPanel.Controls.Add(this.AddButton);
            this.AddJobPanel.Controls.Add(this.panel1);
            this.AddJobPanel.Controls.Add(this.JobTitleBox);
            this.AddJobPanel.Controls.Add(this.JobRoleBox);
            this.AddJobPanel.Controls.Add(this.TypeBox);
            this.AddJobPanel.Location = new System.Drawing.Point(12, 28);
            this.AddJobPanel.Name = "AddJobPanel";
            this.AddJobPanel.Size = new System.Drawing.Size(662, 372);
            this.AddJobPanel.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 21);
            this.label2.TabIndex = 59;
            this.label2.Text = "Job Requirements";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Job Description";
            // 
            // ReqBox
            // 
            this.ReqBox.Location = new System.Drawing.Point(155, 243);
            this.ReqBox.Multiline = true;
            this.ReqBox.Name = "ReqBox";
            this.ReqBox.Size = new System.Drawing.Size(495, 56);
            this.ReqBox.TabIndex = 58;
            // 
            // DescBox
            // 
            this.DescBox.Location = new System.Drawing.Point(155, 181);
            this.DescBox.Multiline = true;
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(495, 56);
            this.DescBox.TabIndex = 57;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(203, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 1);
            this.panel3.TabIndex = 56;
            // 
            // VacanciesBox
            // 
            this.VacanciesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.VacanciesBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VacanciesBox.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VacanciesBox.ForeColor = System.Drawing.SystemColors.Window;
            this.VacanciesBox.Location = new System.Drawing.Point(200, 135);
            this.VacanciesBox.Multiline = true;
            this.VacanciesBox.Name = "VacanciesBox";
            this.VacanciesBox.Size = new System.Drawing.Size(208, 40);
            this.VacanciesBox.TabIndex = 55;
            this.VacanciesBox.Text = "Vacancies";
            this.VacanciesBox.Click += new System.EventHandler(this.VacanciesBox_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(331, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 1);
            this.panel2.TabIndex = 54;
            // 
            // YearsOfExperience
            // 
            this.YearsOfExperience.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.YearsOfExperience.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YearsOfExperience.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearsOfExperience.ForeColor = System.Drawing.SystemColors.Window;
            this.YearsOfExperience.Location = new System.Drawing.Point(328, 23);
            this.YearsOfExperience.Multiline = true;
            this.YearsOfExperience.Name = "YearsOfExperience";
            this.YearsOfExperience.Size = new System.Drawing.Size(208, 40);
            this.YearsOfExperience.TabIndex = 53;
            this.YearsOfExperience.Text = "Years of Experience";
            this.YearsOfExperience.Click += new System.EventHandler(this.YearsOfExperience_Click);
            // 
            // CareerLevelBox
            // 
            this.CareerLevelBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CareerLevelBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CareerLevelBox.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CareerLevelBox.ForeColor = System.Drawing.Color.White;
            this.CareerLevelBox.FormattingEnabled = true;
            this.CareerLevelBox.Items.AddRange(new object[] {
            "Student",
            "Entry Level",
            "Experienced",
            "Manager",
            "Senior Manager"});
            this.CareerLevelBox.Location = new System.Drawing.Point(401, 79);
            this.CareerLevelBox.Name = "CareerLevelBox";
            this.CareerLevelBox.Size = new System.Drawing.Size(161, 25);
            this.CareerLevelBox.TabIndex = 52;
            this.CareerLevelBox.Text = "Career Level";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.AddButton.Location = new System.Drawing.Point(188, 319);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(207, 41);
            this.AddButton.TabIndex = 47;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(75, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 1);
            this.panel1.TabIndex = 46;
            // 
            // JobTitleBox
            // 
            this.JobTitleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.JobTitleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JobTitleBox.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobTitleBox.ForeColor = System.Drawing.SystemColors.Window;
            this.JobTitleBox.Location = new System.Drawing.Point(72, 23);
            this.JobTitleBox.Multiline = true;
            this.JobTitleBox.Name = "JobTitleBox";
            this.JobTitleBox.Size = new System.Drawing.Size(208, 40);
            this.JobTitleBox.TabIndex = 45;
            this.JobTitleBox.Text = "Job Title";
            this.JobTitleBox.Click += new System.EventHandler(this.JobTitleBox_Click_1);
            // 
            // JobRoleBox
            // 
            this.JobRoleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.JobRoleBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JobRoleBox.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobRoleBox.ForeColor = System.Drawing.Color.White;
            this.JobRoleBox.FormattingEnabled = true;
            this.JobRoleBox.Items.AddRange(new object[] {
            "Engineering",
            "Software/IT",
            "Human Resources",
            "Sales",
            "Media"});
            this.JobRoleBox.Location = new System.Drawing.Point(234, 79);
            this.JobRoleBox.Name = "JobRoleBox";
            this.JobRoleBox.Size = new System.Drawing.Size(161, 25);
            this.JobRoleBox.TabIndex = 42;
            this.JobRoleBox.Text = "Job Role";
            // 
            // TypeBox
            // 
            this.TypeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TypeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypeBox.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeBox.ForeColor = System.Drawing.Color.White;
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "Internship",
            "Student Activity",
            "Full Time",
            "Part Time"});
            this.TypeBox.Location = new System.Drawing.Point(67, 79);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(161, 25);
            this.TypeBox.TabIndex = 41;
            this.TypeBox.Text = "Job Type";
            // 
            // ViewJobsPanel
            // 
            this.ViewJobsPanel.Location = new System.Drawing.Point(12, 28);
            this.ViewJobsPanel.Name = "ViewJobsPanel";
            this.ViewJobsPanel.Size = new System.Drawing.Size(662, 369);
            this.ViewJobsPanel.TabIndex = 60;
            this.ViewJobsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewJobsPanel_Paint);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // HRHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.ViewJobsPanel);
            this.Controls.Add(this.AddJobPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HRHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HRHome";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AddJobPanel.ResumeLayout(false);
            this.AddJobPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddJob;
        private System.Windows.Forms.ToolStripMenuItem ViewJobs;
        private System.Windows.Forms.Panel AddJobPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox JobTitleBox;
        private System.Windows.Forms.ComboBox JobRoleBox;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.ComboBox CareerLevelBox;
        private System.Windows.Forms.TextBox ReqBox;
        private System.Windows.Forms.TextBox DescBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox VacanciesBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox YearsOfExperience;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ViewJobsPanel;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}