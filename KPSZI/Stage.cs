using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPSZI
{
    // экземпляр класса Stage - конкретный этап, реализованный в отдельной вкладке интерфейса
    abstract class Stage
    {
        public TabPage stageTab; // ссылка на вкладку 
        public TreeNode stageNode; // ссылка на пункт в дереве
        public string stageName; // название этапа, отображается в дереве
        public int treeImageIcon; // иконка этапа в дереве
        public bool isDone; // завершен ли этап
        public MainForm mf; // ссылка на главную форму интерфейса
        public InformationSystem IS;


        public Stage(TabPage stageTab, TreeNode stageNode, MainForm mainForm, InformationSystem IS)
        {
            this.stageTab = stageTab;
            this.stageNode = stageNode;
            stageName = stageNode.Text;
            stageTab.Text = stageName;
            mf = mainForm;
            this.IS = IS;
        }

        // сохранение содержимого вкладки
        public abstract void saveChanges();

        public abstract void enterTabPage();

    }
}
