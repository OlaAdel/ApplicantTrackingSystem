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
    public partial class CandidateHome : Form
    {
        public static int LocalJobID;
        public CandidateHome()
        {

            InitializeComponent();
          

            
        }

        private void EditProfile_Click(object sender, EventArgs e)
        {
            Form CandidateProfileManager = new CandidateProfileManager();
            CandidateProfileManager.Show();
            this.Hide();
        }

        private void SkillManager_Click(object sender, EventArgs e)
        {
            Form f = new CandidateSkillsManager();
            f.Show();
            this.Hide();
        }

        private void WorkManager_Click(object sender, EventArgs e)
        {
            Form f = new WorkExperiencesManager();
            f.Show();
            this.Hide();
        }
        private void ViewJobButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            LocalJobID = button.TabIndex;
            Form f = new ViewJob();
            f.Show();
            this.Hide();
        }

        private void ExplorePanel_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select ID,CompanyName,CareerLevel,Role,Type,JobTitle from [Job]", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            int Vertical = 130;
            while (rdr.Read())
            {
                int horizontal = 20;



                if (CareerLevelBox.Text != "" && CareerLevelBox.Text != "Career Level")
                {
                    if ((string)rdr["CareerLevel"] != CareerLevelBox.Text)
                        continue;
                }
                if (JobRoleBox.Text != "" && JobRoleBox.Text != "Job Role")
                {
                    if ((string)rdr["Role"] != JobRoleBox.Text)
                        continue;
                }

                if (TypeBox.Text != "" && TypeBox.Text != "Job Type")
                {
                    if ((string)rdr["Type"] != TypeBox.Text)
                        continue;
                }








                Label JobTitleLabel = new Label();

                JobTitleLabel.AutoSize = true;
                JobTitleLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                JobTitleLabel.ForeColor = System.Drawing.Color.White;
                JobTitleLabel.Location = new System.Drawing.Point(horizontal, Vertical);
                JobTitleLabel.Size = new System.Drawing.Size(116, 25);
                JobTitleLabel.Text = (string)rdr["JobTitle"];

                horizontal += 145;




                Label CompanyLabel = new Label();

                CompanyLabel.AutoSize = true;
                CompanyLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                CompanyLabel.ForeColor = System.Drawing.Color.White;
                CompanyLabel.Location = new System.Drawing.Point(horizontal, Vertical);
                CompanyLabel.Size = new System.Drawing.Size(116, 25);
                CompanyLabel.Text = (string)rdr["CompanyName"];

                horizontal += 140;

                Label JobTypeLabel = new Label();

                JobTypeLabel.AutoSize = true;
                JobTypeLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                JobTypeLabel.ForeColor = System.Drawing.Color.White;
                JobTypeLabel.Location = new System.Drawing.Point(horizontal, Vertical);
                JobTypeLabel.Size = new System.Drawing.Size(116, 25);
                JobTypeLabel.Text = (string)rdr["Type"];

                horizontal += 120;


                Label CareerLevelLabel = new Label();

                CareerLevelLabel.AutoSize = true;
                CareerLevelLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                CareerLevelLabel.ForeColor = System.Drawing.Color.White;
                CareerLevelLabel.Location = new System.Drawing.Point(horizontal, Vertical);
                CareerLevelLabel.Size = new System.Drawing.Size(116, 25);
                CareerLevelLabel.Text = (string)rdr["CareerLevel"];

                horizontal += 120;

                Button ViewJobButton = new Button();
                ViewJobButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
                ViewJobButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                ViewJobButton.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ViewJobButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
                ViewJobButton.Location = new System.Drawing.Point(horizontal, Vertical);
                ViewJobButton.Size = new System.Drawing.Size(100, 40);
                ViewJobButton.TabIndex = (int)rdr["ID"];

                ViewJobButton.Text = "View";
                ViewJobButton.Click += ViewJobButton_Click;


                ExplorePanel.Controls.Add(JobTitleLabel);
                ExplorePanel.Controls.Add(CompanyLabel);
                ExplorePanel.Controls.Add(CareerLevelLabel);
                ExplorePanel.Controls.Add(JobTypeLabel);
                ExplorePanel.Controls.Add(ViewJobButton);

                Vertical += 50;
            }
            con.Close();
        }

        private void ApplicationsPanel_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Job.ID,Job.JobTitle,Application.Status from Job inner join Application on Application.JobID=Job.ID where Application.CandidateUsername=@Username", con);
            cmd.Parameters.AddWithValue("@Username", UserLogin.LocalUsername);
            SqlDataReader rdr = cmd.ExecuteReader();
            int Vertical = 70;
            while (rdr.Read())
            {
                int horizontal = 90;

                Label JobTitleLabel = new Label();

                JobTitleLabel.AutoSize = true;
                JobTitleLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                JobTitleLabel.ForeColor = System.Drawing.Color.White;
                JobTitleLabel.Location = new System.Drawing.Point(horizontal, Vertical);
                JobTitleLabel.Size = new System.Drawing.Size(116, 25);
                JobTitleLabel.Text = (string)rdr["JobTitle"];

                horizontal += 195;




                Label StatusLabel = new Label();

                StatusLabel.AutoSize = true;
                StatusLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                StatusLabel.ForeColor = System.Drawing.Color.White;
                StatusLabel.Location = new System.Drawing.Point(horizontal, Vertical);
                StatusLabel.Size = new System.Drawing.Size(116, 25);
                StatusLabel.Text = (string)rdr["Status"];

                horizontal += 140;

               

                Button ViewJobButton = new Button();
                ViewJobButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
                ViewJobButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                ViewJobButton.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ViewJobButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
                ViewJobButton.Location = new System.Drawing.Point(horizontal, Vertical);
                ViewJobButton.Size = new System.Drawing.Size(100, 40);
                ViewJobButton.TabIndex = (int)rdr["ID"];

                ViewJobButton.Text = "View";
                ViewJobButton.Click += ViewJobButton_Click;


                ApplicationsPanel.Controls.Add(JobTitleLabel);
                ApplicationsPanel.Controls.Add(StatusLabel);
                ApplicationsPanel.Controls.Add(ViewJobButton);
                Vertical += 50;
            }
            con.Close();






        }

        private void applicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationsPanel.Show();
            ExplorePanel.Hide();
            ResumePanel.Hide();

        }

        private void Explore_Click(object sender, EventArgs e)
        {
            ExplorePanel.Show();
            ApplicationsPanel.Hide();
            ResumePanel.Hide();
           
        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string RoleTemp = JobRoleBox.Text;
            string CareerTemp = CareerLevelBox.Text;

            this.Controls.Clear();
            this.InitializeComponent();
            TypeBox.SelectedIndexChanged -= TypeBox_SelectedIndexChanged;
            this.TypeBox.Text = (sender as ComboBox).Text;
            TypeBox.SelectedIndexChanged += TypeBox_SelectedIndexChanged;

            JobRoleBox.SelectedIndexChanged -= JobRoleBox_SelectedIndexChanged;
            JobRoleBox.Text = RoleTemp;
            JobRoleBox.SelectedIndexChanged += JobRoleBox_SelectedIndexChanged;

            CareerLevelBox.SelectedIndexChanged -= CareerLevelBox_SelectedIndexChanged;
            CareerLevelBox.Text = CareerTemp;
            CareerLevelBox.SelectedIndexChanged += CareerLevelBox_SelectedIndexChanged;
            ApplicationsPanel.Hide();
            ResumePanel.Hide();
            ExplorePanel.Hide();
            ExplorePanel.Show();



        }

        private void JobRoleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TypeTemp = TypeBox.Text;
            string CareerTemp = CareerLevelBox.Text;
           
            this.Controls.Clear();
            this.InitializeComponent();
            JobRoleBox.SelectedIndexChanged -= JobRoleBox_SelectedIndexChanged;
            this.JobRoleBox.Text = (sender as ComboBox).Text;
            JobRoleBox.SelectedIndexChanged += JobRoleBox_SelectedIndexChanged;

            TypeBox.SelectedIndexChanged -= TypeBox_SelectedIndexChanged;
            TypeBox.Text = TypeTemp;
            TypeBox.SelectedIndexChanged += TypeBox_SelectedIndexChanged;

            CareerLevelBox.SelectedIndexChanged -= CareerLevelBox_SelectedIndexChanged;
            CareerLevelBox.Text = CareerTemp;
            CareerLevelBox.SelectedIndexChanged += CareerLevelBox_SelectedIndexChanged;
            ApplicationsPanel.Hide();
            ResumePanel.Hide();

            ExplorePanel.Hide();
            ExplorePanel.Show();
        }

        private void CareerLevelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TypeTemp = TypeBox.Text;
            string RoleTemp = JobRoleBox.Text;

            this.Controls.Clear();
            this.InitializeComponent();
            CareerLevelBox.SelectedIndexChanged -= CareerLevelBox_SelectedIndexChanged;
            this.CareerLevelBox.Text = (sender as ComboBox).Text;
            CareerLevelBox.SelectedIndexChanged += CareerLevelBox_SelectedIndexChanged;

            TypeBox.SelectedIndexChanged -= TypeBox_SelectedIndexChanged;
            TypeBox.Text = TypeTemp;
            TypeBox.SelectedIndexChanged += TypeBox_SelectedIndexChanged;

            JobRoleBox.SelectedIndexChanged -= JobRoleBox_SelectedIndexChanged;
            JobRoleBox.Text = RoleTemp;
            JobRoleBox.SelectedIndexChanged += JobRoleBox_SelectedIndexChanged;
            ApplicationsPanel.Hide();
            ResumePanel.Hide();

            ExplorePanel.Hide();
            ExplorePanel.Show();

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Form f = new UserLogin();
            f.Show();
            this.Hide();
        }

        private void ResumeButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFile.FileName;
                byte[] file;
                using (var stream = new FileStream(filepath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        file = reader.ReadBytes((int)stream.Length);
                    }
                }
                SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
                con.Open();
                SqlCommand cmd = new SqlCommand("update [Candidate] set Resume=@File where Username=@Username", con);

                cmd.Parameters.AddWithValue("@Username", UserLogin.LocalUsername);
                cmd.Parameters.AddWithValue("@File", file);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("resume has been uploaded successfully");

          
            }

        }

        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResumePanel.Show();
            ApplicationsPanel.Hide();
            ExplorePanel.Hide();
        }

       


      

       

      
    }
}
