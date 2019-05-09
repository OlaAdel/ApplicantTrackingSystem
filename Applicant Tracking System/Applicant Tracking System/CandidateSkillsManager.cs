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
    public partial class CandidateSkillsManager : Form
    {
        public static int SkillID;
        string UserID;
        public CandidateSkillsManager()
        {
            InitializeComponent();
            UserID = UserLogin.LocalUsername;
            AddSkillPanel.Show();
            ViewSkillsPanel.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (
                !(SkillNameBox.Text == "Skill Name") && !string.IsNullOrEmpty(SkillNameBox.Text)
                && !(ProficiencyBox.Text == "Proficiency") && !string.IsNullOrEmpty(ProficiencyBox.Text)
                && !(InterestBox.Text == "Interest") && !string.IsNullOrEmpty(InterestBox.Text)
                && !(YearsOfExperience.Text == "Years of Experience") && !string.IsNullOrEmpty(YearsOfExperience.Text)
                )
            {
                SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
                con.Open();

                string SkillInsertCommand = "INSERT INTO [Skill](Username,SkillName,Proficiency,Interest,ExperienceYears) VALUES (@Username,@SkillName,@Proficiency,@Interest,@ExperienceYears)";
                SqlCommand SkillInsert = new SqlCommand(SkillInsertCommand, con);

                //@Username,@SkillName,@Proficiency,@Interest,@ExperienceYears
                SkillInsert.Parameters.AddWithValue("@Username", UserID);
                SkillInsert.Parameters.AddWithValue("@SkillName", SkillNameBox.Text);
                SkillInsert.Parameters.AddWithValue("@Proficiency", ProficiencyBox.Text);
                SkillInsert.Parameters.AddWithValue("@Interest", InterestBox.Text);
                SkillInsert.Parameters.AddWithValue("@ExperienceYears", YearsOfExperience.Text);

                SkillInsert.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Skill has been added successfully");
                ViewSkillsPanel.Show();
                AddSkillPanel.Hide();

            }
            else
                MessageBox.Show("Please Fill the Empty Boxes");

            

        }

        private void SkillNameBox_Click(object sender, EventArgs e)
        {
            SkillNameBox.Text = "";
        }

        private void YearsOfExperience_Click(object sender, EventArgs e)
        {
            YearsOfExperience.Text = "";

        }

        private void AddSkill_Click(object sender, EventArgs e)
        {
            AddSkillPanel.Show();
            ViewSkillsPanel.Hide();
        }

        private void ViewSkills_Click(object sender, EventArgs e)
        {
            ViewSkillsPanel.Show();
            AddSkillPanel.Hide();
        }
        protected void Edit_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            SkillID = button.TabIndex;
            Form f = new EditSkill();
            f.Show();
            this.Hide();




        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SkillID = button.TabIndex;

            SqlCommand cmd = new SqlCommand("Delete from [Skill] where SkillID=@SkillID", con);
            cmd.Parameters.AddWithValue("@SkillID", SkillID);


            cmd.ExecuteNonQuery();


            MessageBox.Show("Skill has been deleted successfully");
            Form f = new CandidateHome();
            f.Show();
            this.Hide();

        }
        private void ViewSkillsPanel_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select SkillID,SkillName,Proficiency,Interest,ExperienceYears from [Skill] where Username=@Username", con);
            cmd.Parameters.AddWithValue("@Username", UserID);
            SqlDataReader rdr = cmd.ExecuteReader();
            int Vertical = 60;
            while (rdr.Read())
            {
                int horizontal = 40;

                Label SkillNameLabel = new Label();

                SkillNameLabel.AutoSize = true;
                SkillNameLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                SkillNameLabel.ForeColor = System.Drawing.Color.White;
                SkillNameLabel.Location = new System.Drawing.Point(horizontal, Vertical);
                SkillNameLabel.Size = new System.Drawing.Size(116, 25);
                SkillNameLabel.Text = (string)rdr["SkillName"];

                horizontal += 120;


                Label SkillProfLabel = new Label();
                SkillProfLabel.AutoSize = true;
                SkillProfLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                SkillProfLabel.ForeColor = System.Drawing.Color.White;
                SkillProfLabel.Location = new System.Drawing.Point(horizontal, Vertical);
                SkillProfLabel.Size = new System.Drawing.Size(116, 25);
                SkillProfLabel.Text = Convert.ToString((int)rdr["Proficiency"]) + "/5";

                horizontal += 100;

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


                horizontal += 120;

                Button EditButton = new Button();
                EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
                EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                EditButton.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                EditButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
                EditButton.Location = new System.Drawing.Point(horizontal, Vertical);
                EditButton.Size = new System.Drawing.Size(100, 40);
                EditButton.TabIndex = (int)rdr["SkillID"];

                EditButton.Text = "Edit";
                EditButton.Click += Edit_Click;


                horizontal += 90;


                Button DeleteButton = new Button();
                DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
                DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                DeleteButton.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
                DeleteButton.Location = new System.Drawing.Point(horizontal, Vertical);
                DeleteButton.Size = new System.Drawing.Size(40, 40);
                DeleteButton.TabIndex = (int)rdr["SkillID"];

                DeleteButton.Text = "X";
                DeleteButton.Click += Delete_Click;

                EditButton.UseVisualStyleBackColor = false;
                ViewSkillsPanel.Controls.Add(SkillNameLabel);
                ViewSkillsPanel.Controls.Add(SkillProfLabel);
                ViewSkillsPanel.Controls.Add(SkillInterestLabel);
                ViewSkillsPanel.Controls.Add(ExperienceYearsLabel);
                ViewSkillsPanel.Controls.Add(DeleteButton);
                ViewSkillsPanel.Controls.Add(EditButton);

                Vertical += 50;
            }



        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new CandidateHome();
            f.Show();
            this.Hide();
        }

    }
}
