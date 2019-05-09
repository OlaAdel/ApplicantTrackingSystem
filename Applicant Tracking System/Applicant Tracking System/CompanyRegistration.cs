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
    public partial class CompanyRegistration : Form
    {
        public CompanyRegistration()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();

            bool Reg, UsedUsername;

            if (!string.IsNullOrEmpty(MailBox.Text) && !string.IsNullOrEmpty(CompanyBox.Text)
                && !string.IsNullOrEmpty(PasswordBox.Text) && !(MailBox.Text == "E-mail") 
                && !(CompanyBox.Text == "Username") && !(PasswordBox.Text == "Password"))
            {

                SqlCommand cmd = new SqlCommand("select Username, Mail from [Account]", con);
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
                    if (UserName == CompanyBox.Text)
                    {
                        UsedUsername = true;
                        MessageBox.Show("This Company already Exist");
                        CompanyBox.Clear();
                        break;
                    }
                }

                rdr.Close();
                if (!Reg && !UsedUsername)
                {
                    string AccountInsertCommand = "INSERT INTO [Account]VALUES  (@Mail, @Username, @Password,@Type)";
                    SqlCommand AccountInsert = new SqlCommand(AccountInsertCommand, con);


                    AccountInsert.Parameters.AddWithValue("@Mail", MailBox.Text);
                    AccountInsert.Parameters.AddWithValue("@Username", CompanyBox.Text);
                    AccountInsert.Parameters.AddWithValue("@Password", Convert.ToInt64(PasswordBox.Text));
                    AccountInsert.Parameters.AddWithValue("@Type", 1);
                    AccountInsert.ExecuteNonQuery();

                    MessageBox.Show("Registration Completed, Now you have an account and you can log in.");

                }
            }
            else
                MessageBox.Show("Please Fill the Empty Boxes");
            con.Close();
        }

        private void MailBox_Click(object sender, EventArgs e)
        {
            this.MailBox.Text = "";
        }

        private void CompanyBox_Click(object sender, EventArgs e)
        {
            this.CompanyBox.Text = "";
        }

        private void PasswordBox_Click(object sender, EventArgs e)
        {
            this.PasswordBox.Text = "";
        }

      
    }
}
