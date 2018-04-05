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
        // Dictionary - аналог ассоциативных массивов в C#
        // Обращаемся к элементу массива (коллекции) по названию (string)
        // 
        internal Dictionary<string, Stage> stages = new Dictionary<string, Stage>();

        public MainForm()
        {
            InitializeComponent();

            // Заполняем коллекцию этапами (название, ссылка на вкладку, ссылка на пункт в дереве) 
            stages.Add("tnOptions", new StageOptions(tabControl.TabPages[tabControl.TabPages.IndexOfKey("tpOptions")],
                treeView1.Nodes[0].Nodes[0], this));
            stages.Add("Node0", new Stage(tabControl.TabPages[tabControl.TabPages.IndexOfKey("tabPage2")],
                treeView1.Nodes[0], this));
            
            
            // закрываем все вкладки в TabControl
            tabControl.TabPages.Clear();


            // балуюсь с разными иконками в дереве
            treeView1.ImageList = imageList1;            
            
            
        }
        
        // переключение этапа в дереве
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tabControl.TabPages.Clear();
            // берем
            string nodeName = treeView1.SelectedNode.Name;
            tabControl.TabPages.Add(stages[nodeName].stageTab);
            tabControl.SelectedTab.Text = treeView1.SelectedNode.Text;

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

        
    }
}
