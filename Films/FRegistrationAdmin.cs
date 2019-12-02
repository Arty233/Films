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
    public partial class FRegistrationAdmin : Form
    {
        public FRegistrationAdmin()
        {
            InitializeComponent();
        }

        FilmsDB films = new FilmsDB();

        private void FRegistration_Load(object sender, EventArgs e)
        {

        }

        private void BReg_Click(object sender, EventArgs e)
        {
            User us = films.NewUser(TbLogin.Text, TbPassword.Text, true);
            if (us == null)
                MessageBox.Show("Error in creating of new account, checking data, please");
            this.Close();
        }

        private void CbAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TbLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void FRegistrationAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
