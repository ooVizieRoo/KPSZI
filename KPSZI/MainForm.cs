using KPSZI.Model;
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

        InformationSystem IS = new InformationSystem();

        public MainForm()
        {
            InitializeComponent();

            // Заполняем коллекцию этапами (название, ссылка на вкладку, ссылка на пункт в дереве) 
            stages.Add("tnOptions", new StageOptions(returnTabPage("tpOptions"), returnTreeNode("tnOptions"), this));
            stages.Add("tnClassification", new StageClassification(returnTabPage("tpClassification"), returnTreeNode("tnClassification"), this));
            
            // закрываем все вкладки в TabControl
            tabControl.TabPages.Clear();

            // связываем дерево с набором иконок
            treeView.ImageList = iconList;


            tabControlInfoTypes.TabPages.AddRange(((StageClassification)stages["tnClassification"]).tabPagesInfoTypes.ToArray());

        }

        // возвращает ссылку на TabPage по имени вкладки
        private TabPage returnTabPage(string tpName)
        {
            return tabControl.TabPages[tabControl.TabPages.IndexOfKey(tpName)];
        }
        // возвращает ссылку на TreeNode по имени пункта дерева
        private TreeNode returnTreeNode(string tnName)
        {
            return treeView.Nodes.Find(tnName, true)[0];
        }

        // переключение этапа в дереве
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tabControl.TabPages.Clear();
            // берем снова
            string nodeName = treeView.SelectedNode.Name;
            if (treeView.SelectedNode.Nodes.Count == 0)
            {
                tabControl.TabPages.Add(stages[nodeName].stageTab);
                tabControl.SelectedTab.Text = treeView.SelectedNode.Text;
            }

            if (treeView.SelectedNode.Name == "tnClassification")
            {
                tabControlInfoTypes.TabPages.Clear();
                //
                panelPDN.Enabled = false;
                panelPDN.Visible = false;
                foreach (InfoType it in IS.listOfInfoTypes)
                {
                    if (it.TypeName == "Персональные данные")
                    {
                        panelPDN.Enabled = true;
                        panelPDN.Visible = true;
                        continue;
                    }
                    tabControlInfoTypes.TabPages.Add(((StageClassification)stages["tnClassification"]).tabPagesInfoTypes.FindLast(t => t.Name == it.TypeName));
                }                
            }

            if (treeView.SelectedNode.Name == "tnOptions")
            {
                // берем из экземпляра выбранные виды информации и возвращаем их в чеклистбокс при переходе по вкладкам
                for (int i = 0; i < IS.listOfInfoTypes.Count; i++)
                {
                    int k = lbInfoTypes.Items.IndexOf(IS.listOfInfoTypes[i]);
                    lbInfoTypes.SetItemChecked(k, true);
                }
            }
        }
        
        private void lbInfoTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // При нажатии на галочку все выбранные 
            // виды информации помещаются в экземпляр ИС
            IS.ISName = textBox1.Text;
            object[] buf = new object[lbInfoTypes.CheckedItems.Count];
            IS.listOfInfoTypes.Clear();
            lbInfoTypes.CheckedItems.CopyTo(buf, 0);
            for (int i = 0; i < buf.Length; i++)
            {
                IS.listOfInfoTypes.Add((InfoType)buf.GetValue(i));
            }
        }
    }
}