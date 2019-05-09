namespace Applicant_Tracking_System
{
    partial class SystemHome
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CandidateBox = new System.Windows.Forms.PictureBox();
            this.HRBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CandidateBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HRBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(135, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "HR Specialist";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(451, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Candidate";
            // 
            // CandidateBox
            // 
            this.CandidateBox.BackgroundImage = global::Applicant_Tracking_System.Properties.Resources.curriculums;
            this.CandidateBox.Location = new System.Drawing.Point(390, 60);
            this.CandidateBox.Name = "CandidateBox";
            this.CandidateBox.Size = new System.Drawing.Size(259, 249);
            this.CandidateBox.TabIndex = 1;
            this.CandidateBox.TabStop = false;
            this.CandidateBox.Click += new System.EventHandler(this.CandidateBox_Click);
            // 
            // HRBox
            // 
            this.HRBox.BackgroundImage = global::Applicant_Tracking_System.Properties.Resources.consultation__2_;
            this.HRBox.Location = new System.Drawing.Point(58, 60);
            this.HRBox.Name = "HRBox";
            this.HRBox.Size = new System.Drawing.Size(282, 249);
            this.HRBox.TabIndex = 0;
            this.HRBox.TabStop = false;
            this.HRBox.Click += new System.EventHandler(this.HRBox_Click);
            // 
            // SystemHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CandidateBox);
            this.Controls.Add(this.HRBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SystemHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemHome";
            ((System.ComponentModel.ISupportInitialize)(this.CandidateBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HRBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HRBox;
        private System.Windows.Forms.PictureBox CandidateBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}