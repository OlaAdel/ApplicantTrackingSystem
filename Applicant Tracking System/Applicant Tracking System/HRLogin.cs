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
    public partial class HRLogin : Form
    {
        public static string LocalCompanyName;
        public HRLogin()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();

            if (!string.IsNullOrEmpty(CompanyBox.Text) && !(CompanyBox.Text == "Company") &&
                !string.IsNullOrEmpty(PasswordBox.Text) && !(PasswordBox.Text == "Password"))
            {
                SqlCommand cmd = new SqlCommand("select Mail,CompanyName, Password from [Company]", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                bool exist = false;
                while (rdr.Read())
                {
                    string Username = (string)rdr["CompanyName"];
                    string Password = (string)rdr["Password"];
                    if (Username == CompanyBox.Text && Password == PasswordBox.Text)
                    {
                        exist = true;
                        LocalCompanyName = Username;

                        Form f = new HRHome();
                        f.Show();
                        this.Hide(); 
                        break;
                    }
                    else if (Username == CompanyBox.Text && Password != PasswordBox.Text)
                    {
                        exist = true;
                        MessageBox.Show("Please Enter Correct Password.");
                        PasswordBox.Clear();
                    }
                }
                if (!exist)
                    MessageBox.Show("Make Sure You Entered Correct Company Name.");
            }
            else
                MessageBox.Show("Please Fill The Empty Boxes.");
            con.Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Form f = new HRRegistration();
            f.Show();
            this.Hide();
        }

        private void CompanyBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void PasswordBox_Click(object sender, EventArgs e)
        {
            PasswordBox.Text = "";
            PasswordBox.PasswordChar = '*';
        }

        private void CompanyBox_Click(object sender, EventArgs e)
        {
            CompanyBox.Text = "";
        }
    }
}
