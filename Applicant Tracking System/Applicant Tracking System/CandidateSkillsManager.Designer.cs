namespace Applicant_Tracking_System
{
    partial class CandidateSkillsManager
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
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSkill = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewSkills = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewSkillsPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ProficiencyBox = new System.Windows.Forms.ComboBox();
            this.InterestBox = new System.Windows.Forms.ComboBox();
            this.YearsOfExperience = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.SkillNameBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddSkillPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.ViewSkillsPanel.SuspendLayout();
            this.AddSkillPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(214)))), ((int)(((byte)(220)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.AddSkill,
            this.ViewSkills});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 25);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // AddSkill
            // 
            this.AddSkill.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSkill.ForeColor = System.Drawing.Color.White;
            this.AddSkill.Name = "AddSkill";
            this.AddSkill.Size = new System.Drawing.Size(79, 21);
            this.AddSkill.Text = "Add Skill";
            this.AddSkill.Click += new System.EventHandler(this.AddSkill_Click);
            // 
            // ViewSkills
            // 
            this.ViewSkills.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewSkills.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ViewSkills.Name = "ViewSkills";
            this.ViewSkills.Size = new System.Drawing.Size(90, 21);
            this.ViewSkills.Text = "View Skills";
            this.ViewSkills.Click += new System.EventHandler(this.ViewSkills_Click);
            // 
            // ViewSkillsPanel
            // 
            this.ViewSkillsPanel.AutoScroll = true;
            this.ViewSkillsPanel.Controls.Add(this.label4);
            this.ViewSkillsPanel.Controls.Add(this.label3);
            this.ViewSkillsPanel.Controls.Add(this.label2);
            this.ViewSkillsPanel.Controls.Add(this.label1);
            this.ViewSkillsPanel.Controls.Add(this.shapeContainer1);
            this.ViewSkillsPanel.Location = new System.Drawing.Point(50, 28);
            this.ViewSkillsPanel.Name = "ViewSkillsPanel";
            this.ViewSkillsPanel.Size = new System.Drawing.Size(614, 369);
            this.ViewSkillsPanel.TabIndex = 48;
            this.ViewSkillsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewSkillsPanel_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(346, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Experience";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(245, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Interest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(123, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proficiency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skill";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(614, 369);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.White;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 472;
            this.lineShape4.X2 = 472;
            this.lineShape4.Y1 = 349;
            this.lineShape4.Y2 = 12;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.White;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 334;
            this.lineShape3.X2 = 334;
            this.lineShape3.Y1 = 352;
            this.lineShape3.Y2 = 15;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.White;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 240;
            this.lineShape2.X2 = 240;
            this.lineShape2.Y1 = 354;
            this.lineShape2.Y2 = 17;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 120;
            this.lineShape1.X2 = 120;
            this.lineShape1.Y1 = 354;
            this.lineShape1.Y2 = 17;
            // 
            // ProficiencyBox
            // 
            this.ProficiencyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ProficiencyBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProficiencyBox.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProficiencyBox.ForeColor = System.Drawing.Color.White;
            this.ProficiencyBox.FormattingEnabled = true;
            this.ProficiencyBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ProficiencyBox.Location = new System.Drawing.Point(225, 99);
            this.ProficiencyBox.Name = "ProficiencyBox";
            this.ProficiencyBox.Size = new System.Drawing.Size(161, 25);
            this.ProficiencyBox.TabIndex = 41;
            this.ProficiencyBox.Text = "Proficiency";
            // 
            // InterestBox
            // 
            this.InterestBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.InterestBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InterestBox.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterestBox.ForeColor = System.Drawing.Color.White;
            this.InterestBox.FormattingEnabled = true;
            this.InterestBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.InterestBox.Location = new System.Drawing.Point(225, 163);
            this.InterestBox.Name = "InterestBox";
            this.InterestBox.Size = new System.Drawing.Size(161, 25);
            this.InterestBox.TabIndex = 42;
            this.InterestBox.Text = "Interest";
            // 
            // YearsOfExperience
            // 
            this.YearsOfExperience.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.YearsOfExperience.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YearsOfExperience.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearsOfExperience.ForeColor = System.Drawing.SystemColors.Window;
            this.YearsOfExperience.Location = new System.Drawing.Point(203, 233);
            this.YearsOfExperience.Multiline = true;
            this.YearsOfExperience.Name = "YearsOfExperience";
            this.YearsOfExperience.Size = new System.Drawing.Size(208, 40);
            this.YearsOfExperience.TabIndex = 43;
            this.YearsOfExperience.Text = "Years of Experience";
            this.YearsOfExperience.Click += new System.EventHandler(this.YearsOfExperience_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(206, 261);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(192, 1);
            this.panel9.TabIndex = 44;
            // 
            // SkillNameBox
            // 
            this.SkillNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.SkillNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SkillNameBox.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillNameBox.ForeColor = System.Drawing.SystemColors.Window;
            this.SkillNameBox.Location = new System.Drawing.Point(203, 33);
            this.SkillNameBox.Multiline = true;
            this.SkillNameBox.Name = "SkillNameBox";
            this.SkillNameBox.Size = new System.Drawing.Size(208, 40);
            this.SkillNameBox.TabIndex = 45;
            this.SkillNameBox.Text = "Skill Name";
            this.SkillNameBox.Click += new System.EventHandler(this.SkillNameBox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(206, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 1);
            this.panel1.TabIndex = 46;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.AddButton.Location = new System.Drawing.Point(191, 298);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(207, 41);
            this.AddButton.TabIndex = 47;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddSkillPanel
            // 
            this.AddSkillPanel.Controls.Add(this.AddButton);
            this.AddSkillPanel.Controls.Add(this.panel1);
            this.AddSkillPanel.Controls.Add(this.SkillNameBox);
            this.AddSkillPanel.Controls.Add(this.panel9);
            this.AddSkillPanel.Controls.Add(this.YearsOfExperience);
            this.AddSkillPanel.Controls.Add(this.InterestBox);
            this.AddSkillPanel.Controls.Add(this.ProficiencyBox);
            this.AddSkillPanel.Location = new System.Drawing.Point(50, 28);
            this.AddSkillPanel.Name = "AddSkillPanel";
            this.AddSkillPanel.Size = new System.Drawing.Size(614, 372);
            this.AddSkillPanel.TabIndex = 20;
            // 
            // CandidateSkillsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.ViewSkillsPanel);
            this.Controls.Add(this.AddSkillPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CandidateSkillsManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CandidateSkillsManager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ViewSkillsPanel.ResumeLayout(false);
            this.ViewSkillsPanel.PerformLayout();
            this.AddSkillPanel.ResumeLayout(false);
            this.AddSkillPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddSkill;
        private System.Windows.Forms.ToolStripMenuItem ViewSkills;
        private System.Windows.Forms.Panel ViewSkillsPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ComboBox ProficiencyBox;
        private System.Windows.Forms.ComboBox InterestBox;
        private System.Windows.Forms.TextBox YearsOfExperience;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox SkillNameBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel AddSkillPanel;
    }
}