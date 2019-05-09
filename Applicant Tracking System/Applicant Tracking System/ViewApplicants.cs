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
    public partial class ViewApplicants : Form
    {
        public static string LocalCandidateUsername;
        public ViewApplicants()
        {
            InitializeComponent();
        }
        private void ViewCandidateButton_Click(object sender, EventArgs e)
        {
            LocalCandidateUsername = (sender as Button).ImageKey;

            Form f = new ViewProfile();
            f.Show();
            this.Hide();



        }

        private void StatusBox_Changed(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("update [Application] set Status=@Status where ID=@ApplicationID", con);
            cmd.Parameters.AddWithValue("@Status", (sender as ComboBox).Text);
            cmd.Parameters.AddWithValue("@ApplicationID", (sender as ComboBox).TabIndex);

            cmd.ExecuteNonQuery();
            con.Close();


        }

        private void ViewApplicants_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select CareerInterests.EducationLevel,CareerInterests.CareerLevel,PersonalInformation.FirstName,PersonalInformation.LastName,PersonalInformation.Username,Application.Status,Application.ID from Application inner join PersonalInformation on Application.CandidateUsername=PersonalInformation.Username inner join CareerInterests on PersonalInformation.Username = CareerInterests.Username where Application.JobID=@JobID", con);
            cmd.Parameters.AddWithValue("JobID",HRHome.LocaJobID);
            SqlDataReader rdr = cmd.ExecuteReader();
            int Vertical = 140;

            while (rdr.Read())
            {


                if (CareerLevelBox.Text != "" && CareerLevelBox.Text != "Career Level")
                {
                    if ((string)rdr["CareerLevel"] != CareerLevelBox.Text)
                        continue;
                }
                if (EducationalLevelBox.Text != "" && EducationalLevelBox.Text != "Educational Level")
                {
                    if ((string)rdr["EducationLevel"] != EducationalLevelBox.Text)
                        continue;
                }



                int horizontal = 40;

                Label NameLabel = new Label();

                NameLabel.AutoSize = true;
                NameLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                NameLabel.ForeColor = System.Drawing.Color.White;
                NameLabel.Location = new System.Drawing.Point(horizontal, Vertical);
                NameLabel.Size = new System.Drawing.Size(116, 25);
                NameLabel.Text = (string)rdr["FirstName"] +" " + (string)rdr["LastName"];
                horizontal += 140;




                ComboBox StatusBox = new ComboBox();
                StatusBox.AutoSize = true;
                StatusBox.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                StatusBox.ForeColor = System.Drawing.Color.FromArgb(34, 36, 49);
                StatusBox.Location = new System.Drawing.Point(horizontal, Vertical);
                StatusBox.Size = new System.Drawing.Size(116, 25);
                StatusBox.Text = (string)rdr["Status"];
                StatusBox.TabIndex = (int)rdr["ID"];
                StatusBox.Items.Add("Applied");
                StatusBox.Items.Add("Viewed");
                StatusBox.Items.Add("Short-Listed");
                StatusBox.Items.Add("Accepted");
                StatusBox.Items.Add("Rejected");

                StatusBox.SelectedIndexChanged += StatusBox_Changed;
                horizontal += 140;

                Button ViewCandidateButton = new Button();
                ViewCandidateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
                ViewCandidateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                ViewCandidateButton.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ViewCandidateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
                ViewCandidateButton.Location = new System.Drawing.Point(horizontal, Vertical);
                ViewCandidateButton.Size = new System.Drawing.Size(100, 40);
                ViewCandidateButton.ImageKey = (string)rdr["Username"];

                ViewCandidateButton.Text = "View";
                ViewCandidateButton.Click += ViewCandidateButton_Click;

                this.Controls.Add(NameLabel);
                this.Controls.Add(StatusBox);
                this.Controls.Add(ViewCandidateButton);

                Vertical += 40;

            }
            con.Close();




        }

        private void Home_Click(object sender, EventArgs e)
        {
            Form f = new HRHome();
            f.Show();
            this.Hide();
        }

        private void EducationalLevelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CareerLevelTemp = CareerLevelBox.Text;

            
            this.Controls.Clear();
            this.InitializeComponent();
            EducationalLevelBox.SelectedIndexChanged -= EducationalLevelBox_SelectedIndexChanged;
            this.EducationalLevelBox.Text = (sender as ComboBox).Text;
            EducationalLevelBox.SelectedIndexChanged += EducationalLevelBox_SelectedIndexChanged;


            CareerLevelBox.SelectedIndexChanged -= CareerLevelBox_SelectedIndexChanged;
            CareerLevelBox.Text = CareerLevelTemp;
            CareerLevelBox.SelectedIndexChanged += CareerLevelBox_SelectedIndexChanged;

            ViewApplicants_Load(new object(), new EventArgs());
            



        }

        private void CareerLevelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string EducationLevelTemp = EducationalLevelBox.Text;

            this.Controls.Clear();
            this.InitializeComponent();
            CareerLevelBox.SelectedIndexChanged -= CareerLevelBox_SelectedIndexChanged;
            this.CareerLevelBox.Text = (sender as ComboBox).Text;
            CareerLevelBox.SelectedIndexChanged += CareerLevelBox_SelectedIndexChanged;

            EducationalLevelBox.SelectedIndexChanged -= EducationalLevelBox_SelectedIndexChanged;
            EducationalLevelBox.Text = EducationLevelTemp;
            EducationalLevelBox.SelectedIndexChanged += EducationalLevelBox_SelectedIndexChanged;

            ViewApplicants_Load(new object(), new EventArgs());

        }
    }
}
