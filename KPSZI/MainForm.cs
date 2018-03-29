using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPSZI
{
    public partial class MainForm : Form
    {
        TabPage tab1, tab2;

        public MainForm()
        {
            InitializeComponent();

            /*TabControl.TabPageCollection pages = tabControl.TabPages;
            foreach (TabPage page in pages)
            {
            }*/

            tabControl.SelectTab(tabControl.TabPages.IndexOfKey("tabPage1"));
            tab1 = tabControl.SelectedTab;
            tabControl.SelectTab(tabControl.TabPages.IndexOfKey("tabPage2"));
            tab2 = tabControl.SelectedTab;

            tabControl.TabPages.Clear();
        }

        private void создатьПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void createProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            tabControl.TabPages.Clear();

            if (treeView1.SelectedNode.Name == "Node0_0")
            {
                tabControl.TabPages.Add(tab1);
                tab1.Text = treeView1.SelectedNode.Text;

            }

            if (treeView1.SelectedNode.Name == "Node0_1")
            {
                tabControl.TabPages.Add(tab2);
                tab2.Text = treeView1.SelectedNode.Text;


            }


        }
    }
}
