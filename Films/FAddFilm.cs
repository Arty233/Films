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
    public partial class FAddFilm : Form
    {
        public FAddFilm()
        {
            InitializeComponent();
        }

        FilmsDB films = new FilmsDB();

        private void BAdd_Click(object sender, EventArgs e)
        {
            Film film = films.NewFilm(TbName.Text, Convert.ToDateTime(TbDate.Text), TbDescr.Text);
            if (film == null)
                MessageBox.Show("Error in creating of new film, checking data, please");
            FAdministration fAdministration = new FAdministration();
            fAdministration.Show();
            this.Close();
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            FAdministration fAdministration = new FAdministration();
            fAdministration.Show();
            this.Close();
        }

        private void FAddFilm_Load(object sender, EventArgs e)
        {

        }
    }
}
