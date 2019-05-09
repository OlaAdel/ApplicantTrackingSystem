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
    public partial class HRHome : Form
    {
        public HRHome()
        {
            InitializeComponent();
        }
        public static int LocaJobID;
        private void ViewJobButton_Click(object sender, EventArgs e)
        {
            LocaJobID = (sender as Button).TabIndex;
            Form f = new ViewApplicants();
            f.Show();
            this.Hide();


        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            if (
               !(JobTitleBox.Text == "Job Title") && !string.IsNullOrEmpty(JobTitleBox.Text)
               && !(YearsOfExperience.Text == "Years of Experience") && !string.IsNullOrEmpty(YearsOfExperience.Text)
               && !(TypeBox.Text == "Job Type") && !string.IsNullOrEmpty(TypeBox.Text)
               && !(JobRoleBox.Text == "Job Role") && !string.IsNullOrEmpty(JobRoleBox.Text)
               && !(CareerLevelBox.Text == "Career Level") && !string.IsNullOrEmpty(CareerLevelBox.Text)
               && !(VacanciesBox.Text == "Vacancies") && !string.IsNullOrEmpty(VacanciesBox.Text)
               && !string.IsNullOrEmpty(DescBox.Text) && !string.IsNullOrEmpty(ReqBox.Text)
               )
            {
                SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO [Job](CompanyName,ExperienceYears,PostDate,CareerLevel,Type,Vacancies,Description,Requirements,Role,JobTitle) VALUES (@CompanyName,@ExperienceYears,@PostDate,@CareerLevel,@Type,@Vacancies,@Description,@Requirements,@Role,@JobTitle)", con);
                //CompanyName,ExperienceYears,PostDate,CareerLevel,Type,Vacancies,Description,Requirements,Role,JobTitle
                cmd.Parameters.AddWithValue("@CompanyName", HRLogin.LocalCompanyName);
                cmd.Parameters.AddWithValue("@ExperienceYears", YearsOfExperience.Text);
                cmd.Parameters.AddWithValue("@PostDate", DateTime.Now.ToString("yyyyMMdd"));
                cmd.Parameters.AddWithValue("@CareerLevel", CareerLevelBox.Text);
                cmd.Parameters.AddWithValue("@Type", TypeBox.Text);
                cmd.Parameters.AddWithValue("@Vacancies", VacanciesBox.Text );
                cmd.Parameters.AddWithValue("@Description", DescBox.Text);
                cmd.Parameters.AddWithValue("@Requirements", ReqBox.Text);

                cmd.Parameters.AddWithValue("@Role", JobRoleBox.Text);
                cmd.Parameters.AddWithValue("@JobTitle", JobTitleBox.Text);





                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Job has been added successfully");
                ViewJobsPanel.Show();
                AddJobPanel.Hide();

            }
            else
                MessageBox.Show("Please Fill the Empty Boxes");


        }

        private void ViewJobsPanel_Paint(object sender, PaintEventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select ID,JobTitle from Job where CompanyName=@CompanyName", con);
            cmd.Parameters.AddWithValue("@CompanyName", HRLogin.LocalCompanyName);
            SqlDataReader rdr = cmd.ExecuteReader();
            int Vertical = 30;
            while (rdr.Read())
            {
               

                Button ViewJobButton = new Button();
                ViewJobButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
                ViewJobButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                ViewJobButton.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ViewJobButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
                ViewJobButton.Location = new System.Drawing.Point(50, Vertical);
             
                ViewJobButton.Size = new System.Drawing.Size(600, 40);
                ViewJobButton.TabIndex = (int)rdr["ID"];

                ViewJobButton.Text = (string)rdr["JobTitle"];
                ViewJobButton.Click += ViewJobButton_Click;

               // EditButton.Click += Edit_Click;



                ViewJobsPanel.Controls.Add(ViewJobButton);

                Vertical += 50;
            }
            con.Close();

        }

        private void ViewJobs_Click(object sender, EventArgs e)
        {
            ViewJobsPanel.Show();
            AddJobPanel.Hide();
        }

        private void AddJob_Click(object sender, EventArgs e)
        {
            AddJobPanel.Show();
            ViewJobsPanel.Hide();

        }

        private void VacanciesBox_Click(object sender, EventArgs e)
        {
            VacanciesBox.Text = "";
        }

        private void YearsOfExperience_Click(object sender, EventArgs e)
        {
            YearsOfExperience.Text = "";
        }

        private void JobTitleBox_Click(object sender, EventArgs e)
        {
            JobTitleBox.Text = "";
        }

        private void JobTitleBox_Click_1(object sender, EventArgs e)
        {
            JobTitleBox.Text = "";

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new HRLogin();
            f.Show();
            this.Hide();
        }
    }
}
