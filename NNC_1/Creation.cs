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
    public partial class Creation : Form
    {
        public Creation()
        {
            InitializeComponent();
            timer1.Interval = 10;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void learningRateBox_TextChanged(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Classic>().FirstOrDefault().learningRateBox.Text = learningRateBox.Text;
        }

        private void alphaBox_TextChanged(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Classic>().FirstOrDefault().alphaBox.Text = alphaBox.Text;
        }

        private void neuronsBox_TextChanged(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Classic>().FirstOrDefault().neuronsBox.Text = neuronsBox.Text;
        }

        private void cbRegularization_CheckedChanged(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Classic>().FirstOrDefault().cbRegularization.Checked = cbRegularization.Checked;
        }

        private void cbNguyenWidrow_CheckedChanged(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Classic>().FirstOrDefault().cbNguyenWidrow.Checked = cbNguyenWidrow.Checked;
        }

        private void cbSameWeights_CheckedChanged(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Classic>().FirstOrDefault().cbSameWeights.Checked = cbSameWeights.Checked;

        }

        private void iterationsBox_TextChanged(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Classic>().FirstOrDefault().iterationsBox.Text = iterationsBox.Text;
        }

        private void currentIterationBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void currentErrorBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void currentElapsed_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentElapsed.Text = Application.OpenForms.OfType<Classic>().FirstOrDefault().currentElapsed.Text;
            currentErrorBox.Text = Application.OpenForms.OfType<Classic>().FirstOrDefault().currentErrorBox.Text;
            currentIterationBox.Text = Application.OpenForms.OfType<Classic>().FirstOrDefault().currentIterationBox.Text;
            zedGraphControl2.DataSource = Application.OpenForms.OfType<Classic>().FirstOrDefault().zedGraphControl2.DataSource;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Classic>().FirstOrDefault().btnCreate_Click(sender, e);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Classic>().FirstOrDefault().stopButton_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Testing test = new Testing();
            this.Hide();
            test.ShowDialog(this);
            this.Close();   
        }

        private void открытьКлассическоеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms.OfType<Classic>().FirstOrDefault().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            this.Hide();
            inp.ShowDialog(this);
            this.Close();
        }
    }
}
