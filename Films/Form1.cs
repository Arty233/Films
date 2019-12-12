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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FilmsDB films = new FilmsDB();

        private void BLoggin_Click(object sender, EventArgs e)
        {
            if (films.Authorisation(TbLogin.Text, TbPassword.Text) == 0)
            {
                FUsers fUse = new FUsers();
                fUse.Show();
            }
            else
            {
                if (films.Authorisation(TbLogin.Text,TbPassword.Text) == 1)
                {
                    FAdministration fAdmin = new FAdministration();
                    fAdmin.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect data");
                }
            }

        }

        private void BRegistration_Click(object sender, EventArgs e)
        {
            FRegistration fReg = new FRegistration();
            fReg.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {          
        }

        
    }
}
