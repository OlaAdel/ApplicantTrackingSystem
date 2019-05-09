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
    public partial class ViewJob : Form
    {
        public ViewJob()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select  * from [Application] where CandidateUsername=@Username and JobID=@ID", con);
            cmd.Parameters.AddWithValue("@Username", UserLogin.LocalUsername);
            cmd.Parameters.AddWithValue("@ID", CandidateHome.LocalJobID);

            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                ApplyButton.Hide();

            }
            con.Close();
            
        }

        private void ViewJob_Load(object sender, EventArgs e)
        {
            //CompanyName,ExperienceYears,PostDate,CareerLevel,Type,Vacancies,Description,Requirements,Role,JobTitle

            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select CompanyName,ExperienceYears,PostDate,CareerLevel,Type,Vacancies,Description,Requirements,Role,JobTitle from [Job] where ID=@JobID", con);
            cmd.Parameters.AddWithValue("@JobID", CandidateHome.LocalJobID);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {

                CompanyLabel.Text = (string)rdr["CompanyName"];
                YearsOfExperienceLabel.Text = Convert.ToString((int)rdr["ExperienceYears"]);
                PostDateLabel.Text = ((DateTime)rdr["PostDate"]).ToString("dd-MM-yyyy");
                CareerLevelLabel.Text = (string)rdr["CareerLevel"];
                JobTypeLabel.Text = (string)rdr["Type"];
                VacanciesLabel.Text = Convert.ToString((int)rdr["Vacancies"]);
                DescriptionLabel.Text = (string)rdr["Description"];
                RequirementsLabel.Text = (string)rdr["Requirements"];
                JobRoleLabel.Text = (string)rdr["Role"];
                JobTitleLabel.Text = (string)rdr["JobTitle"];

            }
            con.Close();














        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [Application](CandidateUsername,JobID,Status) VALUES (@CandidateUsername,@JobID,@Status)", con);
            cmd.Parameters.AddWithValue("@CandidateUsername", UserLogin.LocalUsername);
            cmd.Parameters.AddWithValue("@JobID", CandidateHome.LocalJobID);
            cmd.Parameters.AddWithValue("@Status", "Applied");


            cmd.ExecuteNonQuery();

            MessageBox.Show("You applied successfully, Good luck!");

        }

        private void Home_Click(object sender, EventArgs e)
        {
            Form f = new CandidateHome();
            f.Show();
            this.Hide();
        }

     
    }
}
