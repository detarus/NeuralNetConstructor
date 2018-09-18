using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Controls;
namespace NNC_1
{
    public partial class Testing : Form
    {
        public Testing()
        {
            InitializeComponent();
            dgvTestingSource.DataSource = Application.OpenForms.OfType<Classic>().FirstOrDefault().dgvTestingSource.DataSource;
            dgvPerformance.AutoGenerateColumns = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnTestingRun_Click(object sender, EventArgs e)
        {
            
                dgvPerformance.Columns[0].Visible = true;
            dgvPerformance.Columns[1].Visible = true;
            dgvPerformance.Columns[2].Visible = true;
            dgvPerformance.Columns[3].Visible = true;
            dgvPerformance.Columns[4].Visible = true;
            dgvPerformance.Columns[5].Visible = true;
            dgvPerformance.Columns[6].Visible = true;
            dgvPerformance.Columns[7].Visible = true;
            dgvPerformance.Columns[8].Visible = true;
            dgvPerformance.Columns[9].Visible = true;
            Application.OpenForms.OfType<Classic>().FirstOrDefault().btnTestingRun_Click(sender, e);
            dgvPerformance.DataSource=Application.OpenForms.OfType<Classic>().FirstOrDefault().dgvPerformance.DataSource;
            Application.OpenForms.OfType<Classic>().FirstOrDefault().zedGraphControl1.Copy(false);
            pictureBox1.Image=(Clipboard.GetImage());
          
        }

        private void открытьКлассическоеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms.OfType<Classic>().FirstOrDefault().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            this.Hide();
            inp.ShowDialog(this);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Creation create = new Creation();
            this.Hide();
            create.ShowDialog();
            this.Close();
        }
    }
}
