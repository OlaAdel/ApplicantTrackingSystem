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
    public partial class CandidateProfileManager : Form
    {
        string UserID;

        public CandidateProfileManager()
        {
            InitializeComponent();
        }

        private void CareerInterestsTab_Click(object sender, EventArgs e)
        {
            CareerInterestsPanel.Show();
            PersonalInfoPanel.Hide();

        }

        private void PersonalInfoTab_Click(object sender, EventArgs e)
        {
            PersonalInfoPanel.Show();
            CareerInterestsPanel.Hide();
        }

        private void CandidateProfileManager_Load(object sender, EventArgs e)
        {
            UserID = UserLogin.LocalUsername;

            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();

            SqlCommand PersonalInfoCommand = new SqlCommand("select FirstName,LastName,Birthdate,Country,City,Area,MobileNumber from [PersonalInformation] where Username=@Username", con);
            PersonalInfoCommand.Parameters.AddWithValue("@Username", UserID);
            SqlDataReader rdr = PersonalInfoCommand.ExecuteReader();
            while (rdr.Read())
            {
                FirstName.Text = (string)rdr["FirstName"];
                LastName.Text = (string)rdr["LastName"];
                Birthdate.Value =(DateTime)rdr["Birthdate"];
                CountryBox.Text = (string)rdr["Country"];
                CityBox.Text = (string)rdr["City"];
                AreaBox.Text = (string)rdr["Area"];
                MobileBox.Text = (string)rdr["MobileNumber"];
            }
            rdr.Close();

            SqlCommand CareerCommand = new SqlCommand("select EducationLevel,CareerLevel,ExperienceYears from [CareerInterests] where Username=@Username", con);
            CareerCommand.Parameters.AddWithValue("@Username", UserID);
            rdr = CareerCommand.ExecuteReader();
            while (rdr.Read())
            {
                EducationalLevelBox.Text = (string)rdr["EducationLevel"];
                CareerLevelBox.Text = (string)rdr["CareerLevel"];
                YearsOfExperience.Text = Convert.ToString((int)rdr["ExperienceYears"]);

            }
            con.Close();






        }

        private void SaveButton_Click(object sender, EventArgs e)
        {


            if ( !(CareerLevelBox.Text == "Career Level") && !string.IsNullOrEmpty(CareerLevelBox.Text)
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
                    SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
                    con.Open();

                    SqlCommand PersonalInfoCommand = new SqlCommand(@"update [PersonalInformation] set FirstName=@FirstName, LastName=@LastName, Birthdate=@Birthdate, Country=@Country, City=@City,  Area=@Area, MobileNumber=@MobileNumber where Username=@Username", con);
                    PersonalInfoCommand.Parameters.AddWithValue("@Username", UserID);
                    PersonalInfoCommand.Parameters.AddWithValue("@FirstName", FirstName.Text);
                    PersonalInfoCommand.Parameters.AddWithValue("@LastName", LastName.Text);
                    PersonalInfoCommand.Parameters.AddWithValue("@Birthdate", Birthdate.Value.Date.ToString("yyyyMMdd"));
                    PersonalInfoCommand.Parameters.AddWithValue("@Country", CountryBox.Text);
                    PersonalInfoCommand.Parameters.AddWithValue("@City", CityBox.Text);
                    PersonalInfoCommand.Parameters.AddWithValue("@Area", AreaBox.Text);
                    PersonalInfoCommand.Parameters.AddWithValue("@MobileNumber", MobileBox.Text);

                    PersonalInfoCommand.ExecuteNonQuery();
                    //Username,EducationLevel,CareerLevel,ExperienceYears
                    SqlCommand CareerCommand = new SqlCommand("update [CareerInterests] set EducationLevel=@EducationLevel, CareerLevel=@CareerLevel, ExperienceYears=@ExperienceYears where Username=@Username", con);


                    CareerCommand.Parameters.AddWithValue("@Username", UserID);
                    CareerCommand.Parameters.AddWithValue("@EducationLevel", EducationalLevelBox.Text);
                    CareerCommand.Parameters.AddWithValue("@CareerLevel", CareerLevelBox.Text);
                    CareerCommand.Parameters.AddWithValue("@ExperienceYears", Convert.ToInt64(YearsOfExperience.Text));


                    CareerCommand.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Profile has been updated successfully");

                }
                else
                    MessageBox.Show("Please Fill the Empty Boxes");












          






        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new CandidateHome();
            f.Show();
            this.Hide();

        }

  
    }
}
