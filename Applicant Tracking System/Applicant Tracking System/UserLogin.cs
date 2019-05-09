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
    public partial class UserLogin : Form
    {
        public static string LocalUsername;

        public UserLogin()
        {
            InitializeComponent();
        }

        private void UsernameBox_Click(object sender, EventArgs e)
        {
            UsernameBox.Text = "";
        //    UsernameBox.ForeColor = Color.FromArgb(68, 213, 216);
        }

        private void PasswordBox_Click(object sender, EventArgs e)
        {
            PasswordBox.Text = "";
            PasswordBox.PasswordChar = '*';

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Form RegistrationForm = new CandidateRegistraton();
            RegistrationForm.Show();
            this.Hide();
           
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();

            if (!string.IsNullOrEmpty(UsernameBox.Text) && !(UsernameBox.Text == "Username")  && 
                !string.IsNullOrEmpty(PasswordBox.Text) && !(PasswordBox.Text == "Password"))
            {
                SqlCommand cmd = new SqlCommand("select Mail,Username, Password from [Candidate]", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                bool exist = false;
                while (rdr.Read())
                {
                    string Username = (string)rdr["Username"];
                    string Password = (string)rdr["Password"];
                    if (Username == UsernameBox.Text && Password == PasswordBox.Text)
                    {
                        exist = true;
                        LocalUsername = Username;
                        Form Candidate = new CandidateHome();
                        Candidate.Show();
                        this.Hide(); break;
                    }
                    else if (Username == UsernameBox.Text && Password != PasswordBox.Text)
                    {
                        exist = true;
                        MessageBox.Show("Please Enter Correct Password.");
                        PasswordBox.Clear();
                    }
                }

                if (!exist)
                    MessageBox.Show("Make Sure You Entered Correct Username.");
            }
            else
                MessageBox.Show("Please Fill The Empty Boxes.");
            con.Close();

        }
    }
}
