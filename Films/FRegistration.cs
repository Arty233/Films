using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Films
{
    public partial class FRegistration : Form
    {
        public FRegistration()
        {
            InitializeComponent();
        }

        FilmsDB films = new FilmsDB();

        private void FRegistration_Load(object sender, EventArgs e)
        {

        }

        private void BReg_Click(object sender, EventArgs e)
        {
            User us = films.NewUser(TbLogin.Text, TbPassword.Text, CbAdmin.Checked);
            if (us == null)
                MessageBox.Show("Error in creating of new account, checking data, please");
            this.Close();
        }
    }
}
