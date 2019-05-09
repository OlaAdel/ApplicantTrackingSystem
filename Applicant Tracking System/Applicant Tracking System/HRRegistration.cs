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
    public partial class HRRegistration : Form
    {
        public HRRegistration()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=ApplicantTrackingSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();

            bool Reg, UsedUsername;

            if(!string.IsNullOrEmpty(MailBox.Text) && !(MailBox.Text == "E-mail")
                && !string.IsNullOrEmpty(CompanyBox.Text) && !(CompanyBox.Text == "Company Name")
                && !string.IsNullOrEmpty(PasswordBox.Text) && !(PasswordBox.Text == "Password")
                )
              {
                    SqlCommand cmd = new SqlCommand("select CompanyName, Mail from [Company]", con);
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
                            Form form = new HRLogin();
                            form.Show();
                            this.Hide();

                            break;

                        }

                        string UserName = (string)rdr["CompanyName"];
                        if (UserName == CompanyBox.Text)
                        {
                            UsedUsername = true;
                            MessageBox.Show("This Company already used, Please write another one.");
                            CompanyBox.Clear();
                            break;
                        }
                    }

                    rdr.Close();
                    if (!Reg && !UsedUsername)
                    {
                        SqlCommand insertcmd = new SqlCommand("INSERT INTO [Company]VALUES  (@Mail,@CompanyName,@Password)", con);
                        insertcmd.Parameters.AddWithValue("@Mail", MailBox.Text);
                        insertcmd.Parameters.AddWithValue("@CompanyName", CompanyBox.Text);
                        insertcmd.Parameters.AddWithValue("@Password", PasswordBox.Text);
                        insertcmd.ExecuteNonQuery();
                        MessageBox.Show("Registration Completed, Now you have an account and you can log in.");
                        Form form = new HRLogin();
                        form.Show();
                        this.Hide();


                    }
            }
            else
                MessageBox.Show("Please Fill the Empty Boxes");


        }

        private void MailBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void CompanyBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void MailBox_Click(object sender, EventArgs e)
        {
            MailBox.Text = "";
        }

        private void CompanyBox_Click(object sender, EventArgs e)
        {
            CompanyBox.Text = "";
        }

        private void PasswordBox_Click(object sender, EventArgs e)
        {
            PasswordBox.Text = "";
            PasswordBox.PasswordChar = '*';
        }
    }
}
