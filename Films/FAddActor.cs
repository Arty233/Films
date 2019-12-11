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
    public partial class FAddActor : Form
    {
        public FAddActor()
        {
            InitializeComponent();
        }

        FilmsDB films = new FilmsDB();

        private void BAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Name can't be empty");
                return;
            }

            Actor actor = films.NewActor(textBox1.Text);
            if (actor == null)
                MessageBox.Show("Error in creating of new genre");
            FAdministration fAdministration = new FAdministration();
            fAdministration.Show();
            this.Close();
        }

        private void BCansel_Click(object sender, EventArgs e)
        {
            FAdministration fAdministration = new FAdministration();
            fAdministration.Show();
            this.Close();
        }
    }
}
