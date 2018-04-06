using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPSZI
{
    // экземпляр класса Stage - конкретный этап, реализованный в отдельной вкладке интерфейса
    class Stage
    {
        public TabPage stageTab; // ссылка на вкладку 
        public TreeNode stageNode; // ссылка на пункт в дереве
        public string stageName; // название этапа, отображается в дереве
        public int treeImageIcon; // иконка этапа в дереве
        public bool isDone; // завершен ли этап
        public MainForm mf; // ссылка на главную форму интерфейса


        public Stage(TabPage stageTab, TreeNode stageNode, MainForm mainForm)
        {
            this.stageTab = stageTab;
            this.stageNode = stageNode;
            stageName = stageNode.Text;
            stageTab.Text = stageName;
            mf = mainForm;
        }

        // метод переключения вкладки (не доделано!)
        public void nextTab()
        {
            mf.tabControl.TabPages.Clear();
            string nodeName = mf.treeView.SelectedNode.Name;
            mf.tabControl.TabPages.Add(mf.stages[nodeName].stageTab);
            mf.tabControl.SelectedTab.Text = mf.treeView.SelectedNode.Text;
        }


    }
}
