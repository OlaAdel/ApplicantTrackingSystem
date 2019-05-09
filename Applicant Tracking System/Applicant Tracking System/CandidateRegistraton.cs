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
    public partial class CandidateRegistraton : Form
    {
        public CandidateRegistraton()
        {
            InitializeComponent();
        }


        private void Explore_Click(object sender, EventArgs e)
        {
            CareerInterestsPanel.Hide();
            PersonalInfoPanel.Hide();
            ProfileInfoPanel.Show();
        }

        private void PersonalInfoTab_Click(object sender, EventArgs e)
        {
            CareerInterestsPanel.Hide();
            ProfileInfoPanel.Hide();
            PersonalInfoPanel.Show();

        }

        private void CareerInterestsTab_Click(object sender, EventArgs e)
        {
            ProfileInfoPanel.Hide();
            PersonalInfoPanel.Hide();
            CareerInterestsPanel.Show();


        }

        private void SignUpButton_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();

            bool Reg, UsedUsername;

            if (!string.IsNullOrEmpty(MailBox.Text) && !(MailBox.Text == "E-mail")
                && !string.IsNullOrEmpty(UsernameBox.Text) && !(UsernameBox.Text == "Username")
                && !string.IsNullOrEmpty(PasswordBox.Text) && !(PasswordBox.Text == "Password")
                && !(CareerLevelBox.Text == "Career Level") && !string.IsNullOrEmpty(CareerLevelBox.Text)
                && !(EducationalLevelBox.Text == "Educational Level") && !string.IsNullOrEmpty(EducationalLevelBox.Text)
                && !(YearsOfExperience.Text == "Years of Experience") && !string.IsNullOrEmpty(YearsOfExperience.Text)
                && !(FirstName.Text == "First Name") && !string.IsNullOrEmpty(FirstName.Text)
                && !(LastName.Text == "Last Name") && !string.IsNullOrEmpty(LastName.Text)
                && !(CountryBox.Text == "Country") && !string.IsNullOrEmpty(CountryBox.Text)
                && !(CityBox.Text == "City") && !string.IsNullOrEmpty(CityBox.Text)
                && !(AreaBox.Text == "Area") && !string.IsNullOrEmpty(AreaBox.Text)
                && !(MobileBox.Text == "Mobile Number") && !string.IsNullOrEmpty(MobileBox.Text)
                )
            {

                SqlCommand cmd = new SqlCommand("select Username, Mail from [Candidate]", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                Reg = false;
                UsedUsername = false;

                while (rdr.Read())
                {
                    string Mail = (string)rdr["Mail"];
                    if (Mail != MailBox.Text)
                        Reg = false;
                    else
                    {
                        Reg = true;
                        MessageBox.Show("You already have an account! You can log in.");
                        Form form = new UserLogin();
                        form.Show();
                        this.Hide();

                        break;

                    }

                    string UserName = (string)rdr["Username"];
                    if (UserName == UsernameBox.Text)
                    {
                        UsedUsername = true;
                        MessageBox.Show("This Usename already used, Please write another one.");
                        UsernameBox.Clear();
                        break;
                    }
                }

                rdr.Close();
                if (!Reg && !UsedUsername)
                {

                    string CandidateInsertCommand = "INSERT INTO [Candidate](Username,Mail , Password)VALUES  (@Username,@Mail , @Password)";
                    SqlCommand CandidateInsert = new SqlCommand(CandidateInsertCommand, con);


                    CandidateInsert.Parameters.AddWithValue("@Mail", MailBox.Text);
                    CandidateInsert.Parameters.AddWithValue("@Username", UsernameBox.Text);
                    CandidateInsert.Parameters.AddWithValue("@Password", PasswordBox.Text);
                    CandidateInsert.ExecuteNonQuery();

                    string PersonalInfoInsertCommand = "INSERT INTO [PersonalInformation](Username,FirstName,LastName,Birthdate,Country,City,Area,MobileNumber) VALUES (@Username,@FirstName,@LastName,@Birthdate,@Country,@City,@Area,@MobileNumber)";
                    SqlCommand PersonalInfoInsert = new SqlCommand(PersonalInfoInsertCommand, con);
                    //Username,FirstName,LastName,Birthdate,Country,City,Area,MobileNumber

                    PersonalInfoInsert.Parameters.AddWithValue("@Username", UsernameBox.Text);
                    PersonalInfoInsert.Parameters.AddWithValue("@FirstName", FirstName.Text);
                    PersonalInfoInsert.Parameters.AddWithValue("@LastName", LastName.Text);
                    PersonalInfoInsert.Parameters.AddWithValue("@Birthdate", Birthdate.Value.Date.ToString("yyyyMMdd"));
                    PersonalInfoInsert.Parameters.AddWithValue("@Country", CountryBox.Text);
                    PersonalInfoInsert.Parameters.AddWithValue("@City", CityBox.Text);
                    PersonalInfoInsert.Parameters.AddWithValue("@Area", AreaBox.Text);
                    PersonalInfoInsert.Parameters.AddWithValue("@MobileNumber", MobileBox.Text);

                    PersonalInfoInsert.ExecuteNonQuery();












                    string CareerInsertCommand = "INSERT INTO [CareerInterests](Username,EducationLevel,CareerLevel,ExperienceYears) VALUES (@Username,@EducationLevel,@CareerLevel,@ExperienceYears)";
                    SqlCommand CareerInsert = new SqlCommand(CareerInsertCommand, con);
                    //EducationalLevel,CareerLevel,ExperienceYears
                    CareerInsert.Parameters.AddWithValue("@Username", UsernameBox.Text);
                    CareerInsert.Parameters.AddWithValue("@EducationLevel", EducationalLevelBox.Text);
                    CareerInsert.Parameters.AddWithValue("@CareerLevel", CareerLevelBox.Text);
                    CareerInsert.Parameters.AddWithValue("@ExperienceYears", Convert.ToInt64(YearsOfExperience.Text));


                    CareerInsert.ExecuteNonQuery();


                    MessageBox.Show("Registration Completed, Now you have an account and you can log in.");
                    Form form = new UserLogin();
                    form.Show();
                    this.Hide();

                }
            }
            else
                MessageBox.Show("Please Fill the Empty Boxes");
            con.Close();

        }

        private void MailBox_Click_1(object sender, EventArgs e)
        {
            MailBox.Text = "";

        }

        private void UsernameBox_Click_1(object sender, EventArgs e)
        {
            UsernameBox.Text = "";
        }

        private void PasswordBox_Click_1(object sender, EventArgs e)
        {
            PasswordBox.Text = "";
            PasswordBox.PasswordChar = '*';
        }

        private void FirseName_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
        }

        private void LastName_Click(object sender, EventArgs e)
        {
            LastName.Text = "";
        }

        private void AreaBox_Click(object sender, EventArgs e)
        {
            AreaBox.Text = "";
        }

        private void MobileBox_Click(object sender, EventArgs e)
        {
            MobileBox.Text = "";
        }

        private void YearsOfExperience_Click(object sender, EventArgs e)
        {
            YearsOfExperience.Text = "";
        }

        
    }
}
