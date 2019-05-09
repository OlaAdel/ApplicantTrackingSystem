using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applicant_Tracking_System
{
    public partial class SystemHome : Form
    {
        public SystemHome()
        {
            InitializeComponent();
        }

        private void CandidateBox_Click(object sender, EventArgs e)
        {
            Form f = new UserLogin();
            f.Show();
            this.Hide();
        }

        private void HRBox_Click(object sender, EventArgs e)
        {
            Form f = new HRLogin();
            f.Show();
            this.Hide();
        }
    }
}
