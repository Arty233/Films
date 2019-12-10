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
    public partial class FAddGenre : Form
    {
        public FAddGenre()
        {
            InitializeComponent();
        }

        FilmsDB films = new FilmsDB();
        private void BCansel_Click(object sender, EventArgs e)
        {
            FAdministration fAdministration = new FAdministration();
            fAdministration.Show();
            this.Close();
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Name can't be empty");
                return;
            }
            
            Genre genre = films.NewGenre(textBox1.Text);
            if (genre == null)
                MessageBox.Show("Error in creating of new genre");
            FAdministration fAdministration = new FAdministration();
            fAdministration.Show();
            this.Close();
        }
    }
}
