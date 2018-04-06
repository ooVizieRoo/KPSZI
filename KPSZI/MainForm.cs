﻿using KPSZI.Model;
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
            stages.Add("tnOptions", new StageOptions(returnTabPage("tpOptions"), returnTreeNode("tnOptions"), this));
            stages.Add("tnClassification", new StageClassification(returnTabPage("tpClassification"), returnTreeNode("tnClassification"), this));
            
            // закрываем все вкладки в TabControl
            tabControl.TabPages.Clear();

            // связываем дерево с набором иконок
            treeView.ImageList = iconList;

            

            using (KPSZIContext db = new KPSZIContext())
            {
                //KPSZIContext.Seed(db);

                var hui = db.InfoTypes.ToList();                
                
                ((ListBox)checkedListBox1).DataSource = hui;
                ((ListBox)checkedListBox1).DisplayMember = "TypeName";
                ((ListBox)checkedListBox1).ValueMember = "InfoTypeId";
            }
            
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                // add itemChecked to InfoType-list in IS class
            }
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
            // берем
            string nodeName = treeView.SelectedNode.Name;
            if (treeView.SelectedNode.Nodes.Count == 0)
            {
                tabControl.TabPages.Add(stages[nodeName].stageTab);
                tabControl.SelectedTab.Text = treeView.SelectedNode.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
