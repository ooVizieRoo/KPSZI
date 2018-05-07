using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace KPSZI
{
    class StageSKZI : Stage
    {
        public StageSKZI(TabPage stageTab, TreeNode stageNode, MainForm mainForm, InformationSystem IS) : base(stageTab, stageNode, mainForm, IS)
        {

        }

        protected override ImageList imageListForTabPage { get; set; }
        
        public override void enterTabPage()
        {
           
        }

        public override void saveChanges()
        {

        }

        protected override void initTabPage()
        {
            mf.tcSKZI.TabPages[1].Enter += new EventHandler(enterTab2);
            mf.tcSKZI.TabPages[1].SetAutoScrollMargin(3, 15);
        }


        public void enterTab2(object sender, EventArgs e)
        {
            #region Строки
            DataGridViewRow dgr1 = new DataGridViewRow();
            dgr1.CreateCells(mf.dgvSKZIAttackAbils);
            dgr1.Cells[0].Value = "Возможность самостоятельно осуществлять создание способов атак, подготовку и проведение атак только за пределами контролируемой зоны";
            dgr1.Cells[1].Value = null;

            DataGridViewRow dgr2 = new DataGridViewRow();
            dgr2.CreateCells(mf.dgvSKZIAttackAbils);
            dgr2.Cells[0].Value = "Возможность самостоятельно осуществлять создание способов атак, подготовку и проведение атак в пределах контролируемой зоны, но без физического доступа к аппаратным средствам(далее – АС), на которых реализованы СКЗИ и среда их функционирования";
            dgr2.Cells[1].Value = null;

            DataGridViewRow dgr3 = new DataGridViewRow();
            dgr3.CreateCells(mf.dgvSKZIAttackAbils);
            dgr3.Cells[0].Value = "Возможность самостоятельно осуществлять создание способов атак, подготовку и проведение атак в пределах контролируемой зоны с физическим доступом к АС, на которых реализованы СКЗИ и среда их функционирования";
            dgr3.Cells[1].Value = null;

            DataGridViewRow dgr4 = new DataGridViewRow();
            dgr4.CreateCells(mf.dgvSKZIAttackAbils);
            dgr4.Cells[0].Value = "Возможность привлекать специалистов, имеющих опыт разработки и анализа СКЗИ (включая специалистов в области анализа сигналов линейной передачи и сигналов побочного электромагнитного излучения и наводок СКЗИ)";
            dgr4.Cells[1].Value = null;

            DataGridViewRow dgr5 = new DataGridViewRow();
            dgr5.CreateCells(mf.dgvSKZIAttackAbils);
            dgr5.Cells[0].Value = "Возможность привлекать специалистов, имеющих опыт разработки и анализа СКЗИ (включая специалистов в области использования для реализации атак недокументированных возможностей прикладного программного обеспечения)";
            dgr5.Cells[1].Value = null;

            DataGridViewRow dgr6 = new DataGridViewRow();
            dgr6.CreateCells(mf.dgvSKZIAttackAbils);
            dgr6.Cells[0].Value = "Возможность привлекать специалистов, имеющих опыт разработки и анализа СКЗИ (включая специалистов в области использования для реализации атак недокументированных возможностей аппаратного и программного компонентов среды функционирования СКЗИ)";
            dgr6.Cells[1].Value = null;
            #endregion
            DataGridViewRow[] rows = new DataGridViewRow[] { dgr1, dgr2, dgr3, dgr4, dgr5, dgr6 };
            mf.dgvSKZIAttackAbils.Rows.Clear();
            mf.dgvSKZIAttackAbils.Rows.AddRange(rows);
            SetHeightOfDGV();
        }

        public void SetHeightOfDGV()
        { 
            foreach (DataGridViewRow dgvr in mf.dgvSKZIAttackAbils.Rows)
            {
                int index = dgvr.Index;
                int d = mf.dgvSKZIAttackAbils.Rows[index].GetPreferredHeight(index, DataGridViewAutoSizeRowMode.AllCells, true);
                dgvr.Height = d;
            }
            mf.dgvSKZIAttackAbils.Height = mf.dgvSKZIAttackAbils.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + mf.dgvSKZIAttackAbils.ColumnHeadersHeight;
        }
    }
}
