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
    public partial class EditSkill : Form
    {
        int SkillID;
        string UserID;

        public EditSkill()
        {
            InitializeComponent();
            SkillID = CandidateSkillsManager.SkillID;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new CandidateHome();
            f.Show();
            this.Hide();
        }

        private void EditSkill_Load(object sender, EventArgs e)
        {

            UserID = UserLogin.LocalUsername;


            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();

            SqlCommand PersonalInfoCommand = new SqlCommand("Select SkillName,Proficiency,Interest,ExperienceYears from [Skill] where SkillID=@SkillID", con);
            PersonalInfoCommand.Parameters.AddWithValue("@SkillID", SkillID);
            SqlDataReader rdr = PersonalInfoCommand.ExecuteReader();
            while (rdr.Read())
            {
                SkillNameBox.Text = (string)rdr["SkillName"];
                ProficiencyBox.Text = Convert.ToString((int)rdr["Proficiency"]);
                InterestBox.Text = Convert.ToString((int)rdr["Interest"]);
                YearsOfExperience.Text = Convert.ToString((int)rdr["ExperienceYears"]);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
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
                SqlCommand cmd = new SqlCommand("update [Skill] set SkillName=@SkillName,Proficiency=@Proficiency,Interest=@Interest,ExperienceYears=@ExperienceYears where SKillID=@SkillID", con);

                //@Username,@SkillName,@Proficiency,@Interest,@ExperienceYears
                cmd.Parameters.AddWithValue("@SkillName", SkillNameBox.Text);
                cmd.Parameters.AddWithValue("@Proficiency", ProficiencyBox.Text);
                cmd.Parameters.AddWithValue("@Interest", InterestBox.Text);
                cmd.Parameters.AddWithValue("@ExperienceYears", YearsOfExperience.Text);
                cmd.Parameters.AddWithValue("@SkillID", SkillID);


                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Skill has Updated added successfully");

            }
            else
                MessageBox.Show("Please Fill the Empty Boxes");
        }
    }
}
