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
    
    public partial class Help : Form
    {
        private List<TabPage> hiddenPages = new List<TabPage>();
        public Help()
        {
            InitializeComponent();
        }
        private void EP(TabPage page, bool enable)
        {
            if (enable)
            {
                tabControl1.TabPages.Add(page);
                hiddenPages.Remove(page);
            }
            else
            {
                tabControl1.TabPages.Remove(page);
                hiddenPages.Add(page);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            MultiPagePanel a = new MultiPagePanel();
                bool found = false;
                int ind = listView1.SelectedItems[0].Index;
                TabPage tp = new TabPage();

                string name = "tabPage" + (ind + 1);
                foreach (TabPage tp1 in hiddenPages)
                    if (tp1.Name == name) { tp = tp1; found = true; }
                if (found == true) { EP(tp, true); tabControl1.SelectedTab = tp; }
                else foreach (TabPage tp2 in tabControl1.TabPages)
                        if (tp2.Name == name) tabControl1.SelectedTab = tp2;
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
