namespace Applicant_Tracking_System
{
    partial class ViewApplicants
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
            this.Home = new System.Windows.Forms.ToolStripMenuItem();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.EducationalLevelBox = new System.Windows.Forms.ComboBox();
            this.CareerLevelBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(214)))), ((int)(((byte)(220)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Home});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Home
            // 
            this.Home.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(59, 21);
            this.Home.Text = "Home";
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.White;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 166;
            this.lineShape5.X2 = 166;
            this.lineShape5.Y1 = 471;
            this.lineShape5.Y2 = 134;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineShape5});
            this.shapeContainer1.Size = new System.Drawing.Size(500, 400);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 307;
            this.lineShape1.X2 = 307;
            this.lineShape1.Y1 = 473;
            this.lineShape1.Y2 = 136;
            // 
            // EducationalLevelBox
            // 
            this.EducationalLevelBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.EducationalLevelBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EducationalLevelBox.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EducationalLevelBox.ForeColor = System.Drawing.Color.White;
            this.EducationalLevelBox.FormattingEnabled = true;
            this.EducationalLevelBox.Items.AddRange(new object[] {
            "",
            "Bachelor’s Degree",
            "Master’s Degree",
            "Doctorate’s Degree",
            "High School",
            "Diploma"});
            this.EducationalLevelBox.Location = new System.Drawing.Point(315, 49);
            this.EducationalLevelBox.Name = "EducationalLevelBox";
            this.EducationalLevelBox.Size = new System.Drawing.Size(161, 25);
            this.EducationalLevelBox.TabIndex = 40;
            this.EducationalLevelBox.Text = "Educational Level";
            this.EducationalLevelBox.SelectedIndexChanged += new System.EventHandler(this.EducationalLevelBox_SelectedIndexChanged);
            // 
            // CareerLevelBox
            // 
            this.CareerLevelBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CareerLevelBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CareerLevelBox.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CareerLevelBox.ForeColor = System.Drawing.Color.White;
            this.CareerLevelBox.FormattingEnabled = true;
            this.CareerLevelBox.Items.AddRange(new object[] {
            "",
            "Student",
            "Entry Level",
            "Experienced",
            "Manager",
            "Senior Manager"});
            this.CareerLevelBox.Location = new System.Drawing.Point(148, 49);
            this.CareerLevelBox.Name = "CareerLevelBox";
            this.CareerLevelBox.Size = new System.Drawing.Size(161, 25);
            this.CareerLevelBox.TabIndex = 39;
            this.CareerLevelBox.Text = "Career Level";
            this.CareerLevelBox.SelectedIndexChanged += new System.EventHandler(this.CareerLevelBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "Filter by";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 42;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(206, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 43;
            this.label3.Text = "Status";
            // 
            // ViewApplicants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EducationalLevelBox);
            this.Controls.Add(this.CareerLevelBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewApplicants";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewApplicants";
            this.Load += new System.EventHandler(this.ViewApplicants_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Home;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.ComboBox EducationalLevelBox;
        private System.Windows.Forms.ComboBox CareerLevelBox;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}