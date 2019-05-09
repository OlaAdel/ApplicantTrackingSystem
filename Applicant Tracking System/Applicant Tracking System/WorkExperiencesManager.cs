using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Applicant_Tracking_System
{
    public partial class WorkExperiencesManager : Form
    {
        string UserID;
        int ExperienceID;
        public WorkExperiencesManager()
        {
            InitializeComponent();
            UserID = UserLogin.LocalUsername;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (
                !(JobTitleBox.Text == "Job Title") && !string.IsNullOrEmpty(JobTitleBox.Text)
                && !(JobRoleBox.Text == "Job Role") && !string.IsNullOrEmpty(JobRoleBox.Text)
                && !(ExperienceTypeBox.Text == "Experience Type") && !string.IsNullOrEmpty(ExperienceTypeBox.Text)
                && !(CompanyNameBox.Text == "Company Name") && !string.IsNullOrEmpty(CompanyNameBox.Text)
                )
            {
                SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO [ExperienceWork](Username,JobTitle,JobRole,CompanyName,ExperienceType,StartDate,EndDate) VALUES (@Username,@JobTitle,@JobRole,@CompanyName,@ExperienceType,@StartDate,@EndDate)", con);
                //Username,JobTitle,JobRole,CompanyName,ExperienceType,StartDate,EndDate
                cmd.Parameters.AddWithValue("@Username", UserID);
                cmd.Parameters.AddWithValue("@JobTitle", JobTitleBox.Text);
                cmd.Parameters.AddWithValue("@JobRole", JobRoleBox.Text);
                cmd.Parameters.AddWithValue("@CompanyName", CompanyNameBox.Text);
                cmd.Parameters.AddWithValue("@ExperienceType", ExperienceTypeBox.Text);
                cmd.Parameters.AddWithValue("@StartDate", StartDate.Value.Date.ToString("yyyyMMdd"));
                cmd.Parameters.AddWithValue("@EndDate", EndDate.Value.Date.ToString("yyyyMMdd"));



                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Work Experience has been added successfully");
                ViewExperiencesPanel.Show();
                AddExperiencePanel.Hide();

            }
            else
                MessageBox.Show("Please Fill the Empty Boxes");
        }

     

        private void AddSExperience_Click(object sender, EventArgs e)
        {
            AddExperiencePanel.Show();
            JobRoleBox.Show();
            ViewExperiencesPanel.Hide();
        }

        private void ViewExperiences_Click(object sender, EventArgs e)
        {
            ViewExperiencesPanel.Show();
            JobRoleBox.Hide();
            AddExperiencePanel.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new CandidateHome();
            f.Show();
            this.Hide();
        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            ExperienceID = button.TabIndex;

            SqlCommand cmd = new SqlCommand("Delete from [ExperienceWork] where ID=@ExperienceID", con);
            cmd.Parameters.AddWithValue("@ExperienceID", ExperienceID);


            cmd.ExecuteNonQuery();


            MessageBox.Show("Work Experience has been deleted successfully");
            Form f = new CandidateHome();
            f.Show();
            this.Hide();

        }

        private void ViewExperiencesPanel_Paint_1(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            //JobTitle,JobRole,CompanyName,ExperienceType,StartDate,EndDate
            SqlCommand cmd = new SqlCommand("Select ID,JobTitle,JobRole,CompanyName,ExperienceType,StartDate,EndDate from [ExperienceWork] where Username=@Username", con);
            cmd.Parameters.AddWithValue("@Username", UserID);
            SqlDataReader rdr = cmd.ExecuteReader();
            int Vertical = 50;
            while (rdr.Read())
            {

                int horizontal = 0;

                Label JobTitleLabel = new Label();
                JobTitleLabel.AutoSize = true;
                JobTitleLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                JobTitleLabel.ForeColor = System.Drawing.Color.White;
                JobTitleLabel.Location = new System.Drawing.Point(horizontal, Vertical);
                JobTitleLabel.Size = new System.Drawing.Size(116, 25);
                JobTitleLabel.Text = (string)rdr["JobTitle"];

                horizontal += 115;


                Label CompanyLabel = new Label();
                CompanyLabel.AutoSize = true;
                CompanyLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                CompanyLabel.ForeColor = System.Drawing.Color.White;
                CompanyLabel.Location = new System.Drawing.Point(horizontal, Vertical);
                CompanyLabel.Size = new System.Drawing.Size(116, 25);
                CompanyLabel.Text = (string)rdr["CompanyName"];

                horizontal += 105;

                Label TypeLabel = new Label();
                TypeLabel.AutoSize = true;
                TypeLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                TypeLabel.ForeColor = System.Drawing.Color.White;
                TypeLabel.Location = new System.Drawing.Point(horizontal, Vertical);
                TypeLabel.Size = new System.Drawing.Size(116, 25);
                TypeLabel.Text = (string)rdr["ExperienceType"];

                horizontal += 95;



                Label RoleLabel = new Label();
                RoleLabel.AutoSize = true;
                RoleLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                RoleLabel.ForeColor = System.Drawing.Color.White;
                RoleLabel.Location = new System.Drawing.Point(horizontal, Vertical);
                RoleLabel.Size = new System.Drawing.Size(116, 25);
                RoleLabel.Text = (string)rdr["JobRole"];


                horizontal += 95;





                Label StartLabel = new Label();
                StartLabel.AutoSize = true;
                StartLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                StartLabel.ForeColor = System.Drawing.Color.White;
                StartLabel.Location = new System.Drawing.Point(horizontal, Vertical);
                StartLabel.Size = new System.Drawing.Size(116, 25);
                StartLabel.Text = ((DateTime)rdr["StartDate"]).ToString("dd-MM-yyyy");


                horizontal += 110;

                Label EndLabel = new Label();
                EndLabel.AutoSize = true;
                EndLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                EndLabel.ForeColor = System.Drawing.Color.White;
                EndLabel.Location = new System.Drawing.Point(horizontal, Vertical);
                EndLabel.Size = new System.Drawing.Size(116, 25);
                EndLabel.Text = ((DateTime)rdr["EndDate"]).ToString("dd-MM-yyyy");
                horizontal += 100;


                Button DeleteButton = new Button();
                DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
                DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                DeleteButton.Font = new System.Drawing.Font("Segoe UI Emoji", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
                DeleteButton.Location = new System.Drawing.Point(horizontal, Vertical);
                DeleteButton.Size = new System.Drawing.Size(20, 20);
                DeleteButton.TabIndex = (int)rdr["ID"];
                DeleteButton.Click += Delete_Click;

                DeleteButton.Text = "X";
                ViewExperiencesPanel.Controls.Add(JobTitleLabel);
                ViewExperiencesPanel.Controls.Add(RoleLabel);
                ViewExperiencesPanel.Controls.Add(CompanyLabel);
                ViewExperiencesPanel.Controls.Add(TypeLabel);
                ViewExperiencesPanel.Controls.Add(StartLabel);
                ViewExperiencesPanel.Controls.Add(EndLabel);
                ViewExperiencesPanel.Controls.Add(DeleteButton);



                Vertical += 40;
            }
            con.Close();
        }

        private void JobTitleBox_Click(object sender, EventArgs e)
        {
            JobTitleBox.Text = "";
        }

        private void CompanyNameBox_TextChanged(object sender, EventArgs e)
        {
            CompanyNameBox.Text = "";
        }

       
  

       
    }
}
