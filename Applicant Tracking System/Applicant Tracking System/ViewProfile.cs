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
using System.IO;

namespace Applicant_Tracking_System
{
    public partial class ViewProfile : Form
    {
        public ViewProfile()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select Resume from [Candidate] where Username=@Username", con);
            cmd.Parameters.AddWithValue("@Username", ViewApplicants.LocalCandidateUsername);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                if (DBNull.Value.Equals(rdr["Resume"]))
                {
                    resumeToolStripMenuItem.Visible = false;
                    ResumePanel.Visible = false;
                }
            } 
            con.Close();
        }

        private void PersonalInfoPanel_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();

            SqlCommand PersonalInfoCommand = new SqlCommand("select Birthdate,Country,City,Area,MobileNumber from [PersonalInformation] where Username=@Username", con);
            PersonalInfoCommand.Parameters.AddWithValue("@Username", ViewApplicants.LocalCandidateUsername);
            SqlDataReader rdr = PersonalInfoCommand.ExecuteReader();
            while (rdr.Read())
            {
                DateLabel.Text = ((DateTime)rdr["Birthdate"]).ToString("dd-MM-yyyy");
                CountryLabel.Text = (string)rdr["Country"];
                CityLabel.Text = (string)rdr["City"];
                AreaLabel.Text = (string)rdr["Area"];
                MobileLabel.Text = (string)rdr["MobileNumber"];
            }
            con.Close();
        }

        private void CareerPanel_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand CareerCommand = new SqlCommand("select EducationLevel,CareerLevel,ExperienceYears from [CareerInterests] where Username=@Username", con);
            CareerCommand.Parameters.AddWithValue("@Username", ViewApplicants.LocalCandidateUsername);
            SqlDataReader rdr = CareerCommand.ExecuteReader();
            while (rdr.Read())
            {
                EducationBox.Text = (string)rdr["EducationLevel"];
                CareerLabel.Text = (string)rdr["CareerLevel"];
                ExperienceBox.Text = Convert.ToString((int)rdr["ExperienceYears"]) + " " + "Years";

            }
            con.Close();
        }

        private void PersonalInfoTab_Click(object sender, EventArgs e)
        {
            PersonalInfoPanel.Show();
            CareerPanel.Hide();
            ViewSkillsPanel.Hide();
            ViewExperiencesPanel.Hide();
            ResumePanel.Hide();



        }

        private void CareerInterestsTab_Click(object sender, EventArgs e)
        {
            CareerPanel.Show();
            PersonalInfoPanel.Hide();
            ViewSkillsPanel.Hide();
            ViewExperiencesPanel.Hide();
            ResumePanel.Hide();




        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new HRHome();
            f.Show();
            this.Hide();
        }

        private void ViewSkillsPanel_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select SkillID,SkillName,Proficiency,Interest,ExperienceYears from [Skill] where Username=@Username", con);
            cmd.Parameters.AddWithValue("@Username", ViewApplicants.LocalCandidateUsername);
            SqlDataReader rdr = cmd.ExecuteReader();
            int Vertical = 60;
            while (rdr.Read())
            {
                int horizontal = 80;

                Label SkillNameLabel = new Label();

                SkillNameLabel.AutoSize = true;
                SkillNameLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                SkillNameLabel.ForeColor = System.Drawing.Color.White;
                SkillNameLabel.Location = new System.Drawing.Point(horizontal, Vertical);
                SkillNameLabel.Size = new System.Drawing.Size(116, 25);
                SkillNameLabel.Text = (string)rdr["SkillName"];

                horizontal += 190;


                Label SkillProfLabel = new Label();
                SkillProfLabel.AutoSize = true;
                SkillProfLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                SkillProfLabel.ForeColor = System.Drawing.Color.White;
                SkillProfLabel.Location = new System.Drawing.Point(horizontal, Vertical);
                SkillProfLabel.Size = new System.Drawing.Size(116, 25);
                SkillProfLabel.Text = Convert.ToString((int)rdr["Proficiency"]) + "/5";

                horizontal += 120;

                Label SkillInterestLabel = new Label();
                SkillInterestLabel.AutoSize = true;
                SkillInterestLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                SkillInterestLabel.ForeColor = System.Drawing.Color.White;
                SkillInterestLabel.Location = new System.Drawing.Point(horizontal, Vertical);
                SkillInterestLabel.Size = new System.Drawing.Size(116, 25);
                SkillInterestLabel.Text = Convert.ToString((int)rdr["Interest"]) + "/5";

                horizontal += 100;



                Label ExperienceYearsLabel = new Label();
                ExperienceYearsLabel.AutoSize = true;
                ExperienceYearsLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ExperienceYearsLabel.ForeColor = System.Drawing.Color.White;
                ExperienceYearsLabel.Location = new System.Drawing.Point(horizontal, Vertical);
                ExperienceYearsLabel.Size = new System.Drawing.Size(116, 25);
                ExperienceYearsLabel.Text = Convert.ToString((int)rdr["ExperienceYears"]) + " Years";

                ViewSkillsPanel.Controls.Add(SkillNameLabel);
                ViewSkillsPanel.Controls.Add(SkillProfLabel);
                ViewSkillsPanel.Controls.Add(SkillInterestLabel);
                ViewSkillsPanel.Controls.Add(ExperienceYearsLabel);

                Vertical += 50;
            }
        }

        private void skillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSkillsPanel.Show();
            PersonalInfoPanel.Hide();
            CareerPanel.Hide();
            ViewExperiencesPanel.Hide();
            ResumePanel.Hide();




        }

        private void ViewExperiencesPanel_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            //JobTitle,JobRole,CompanyName,ExperienceType,StartDate,EndDate
            SqlCommand cmd = new SqlCommand("Select ID,JobTitle,JobRole,CompanyName,ExperienceType,StartDate,EndDate from [ExperienceWork] where Username=@Username", con);
            cmd.Parameters.AddWithValue("@Username", ViewApplicants.LocalCandidateUsername);
            SqlDataReader rdr = cmd.ExecuteReader();
            int Vertical = 50;
            while (rdr.Read())
            {

                int horizontal = 0;

                Label JobTitleLabel = new Label();
                JobTitleLabel.AutoSize = true;
                JobTitleLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                JobTitleLabel.ForeColor = System.Drawing.Color.White;
                JobTitleLabel.Location = new System.Drawing.Point(horizontal, Vertical);
                JobTitleLabel.Size = new System.Drawing.Size(116, 25);
                JobTitleLabel.Text = (string)rdr["JobTitle"];

                horizontal += 150;


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
                horizontal += 80;


         

               
                ViewExperiencesPanel.Controls.Add(JobTitleLabel);
                ViewExperiencesPanel.Controls.Add(RoleLabel);
                ViewExperiencesPanel.Controls.Add(CompanyLabel);
                ViewExperiencesPanel.Controls.Add(TypeLabel);
                ViewExperiencesPanel.Controls.Add(StartLabel);
                ViewExperiencesPanel.Controls.Add(EndLabel);



                Vertical += 40;
            }
            con.Close();
        }

        private void workExperiencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewExperiencesPanel.Show();
            PersonalInfoPanel.Hide();
            CareerPanel.Hide();
            ViewSkillsPanel.Hide();
            ResumePanel.Hide();
        }

        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResumePanel.Show();
            ViewExperiencesPanel.Hide();
            PersonalInfoPanel.Hide();
            CareerPanel.Hide();
            ViewSkillsPanel.Hide();

        }

        private void ResumeButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
             con.Open();
             SqlCommand cmd = new SqlCommand("select Resume from [Candidate] where Username=@Username", con);
             cmd.Parameters.AddWithValue("@Username", ViewApplicants.LocalCandidateUsername);
             SqlDataReader rdr = cmd.ExecuteReader();
             if (rdr.Read())
             {
                 if (!DBNull.Value.Equals(rdr["Resume"]))
                 {
                    byte[] binaryString = (byte[])rdr["Resume"];
                    using (var fs = new FileStream(ViewApplicants.LocalCandidateUsername+ " " + "resume.pdf", FileMode.Create, FileAccess.Write))
                        fs.Write(binaryString, 0, binaryString.Length);        
                     MessageBox.Show("resume has been downloaded successfully");
                 }
             }
             con.Close();
        }

    }
}
