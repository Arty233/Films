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
    public partial class FUsers : Form
    {
        public FUsers()
        {
            InitializeComponent();
        }

        private void FUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'filmsDataSet.Films' table. You can move, or remove it, as needed.
            this.filmsTableAdapter.Fill(this.filmsDataSet.Films);

        }

        private void BInspect_Click(object sender, EventArgs e)
        {
            string filmToInspect = DgFilms.CurrentRow.Cells["filmNameDataGridViewTextBoxColumn"].Value.ToString();
            FUserInspect ui = new FUserInspect(filmToInspect);
            ui.Show();

        }
    }
}
