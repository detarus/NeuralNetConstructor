using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNC_1
{
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
        }

        public void Hider()
        {
            try
            { Application.OpenForms.OfType<Classic>().FirstOrDefault().Hide(); }
            catch
            {
                MessageBox.Show("deem");
            }
        }
        private void groupBox15_Enter(object sender, EventArgs e)
        {

        }

        private void graphInput_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Classic>().FirstOrDefault().MenuFileOpen_Click(sender,e);
            this.dgvLearningSource.DataSource = Application.OpenForms.OfType<Classic>().FirstOrDefault().dgvLearningSource.DataSource;
            this.graphInput.DataSource= Application.OpenForms.OfType<Classic>().FirstOrDefault().graphInput.DataSource;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Creation create = new Creation();
            this.Hide();
            create.ShowDialog();
            this.Close();
        }

        private void открытьКлассическоеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms.OfType<Classic>().FirstOrDefault().Show();
        }
    }
}
