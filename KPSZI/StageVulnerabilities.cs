using KPSZI.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPSZI
{
    class StageVulnerabilities : Stage
    {
        List<Vulnerability> listVuls;

        public StageVulnerabilities(TabPage stageTab, TreeNode stageNode, MainForm mainForm, InformationSystem IS)
            : base(stageTab, stageNode, mainForm, IS)
        {

        }

        public override void enterTabPage()
        {
            // Если вкладка открывается впервые, и еще нет данных об уязвимостях в IS, выходим из метода
            if (IS.listOfVulnerabilities.Count == 0) return;
            
            //mf.dgvVulnerabilities.ClearSelection();

            // Заполняем чекбоксы уязвимостей сохраненной инфой из IS
            foreach (DataGridViewRow row in mf.dgvVulnerabilities.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                Vulnerability v = listVuls.Where(v1 => v1.VulnerabilityId == (int) row.Cells[1].Value).First();
                if (IS.listOfVulnerabilities.Contains(v))
                    chk.Value = chk.TrueValue;
                else
                    chk.Value = null;

            }
        }

        public override void saveChanges()
        {
            // очищаем список уязвимовстей в IS
            IS.listOfVulnerabilities.Clear();
            // добавляем выбранные уязвимости в IS
            foreach (DataGridViewRow row in mf.dgvVulnerabilities.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                if (chk.Value == chk.TrueValue)
                    IS.listOfVulnerabilities.Add(listVuls.Where(v => v.VulnerabilityNumber == (int) row.Cells[2].Value).First());
                    
            }
            
        }

        protected override void initTabPage()
        {
            using (KPSZIContext db = new KPSZIContext())
            {
                // Инициализация списка уязвимостей

                listVuls = db.Vulnerabilities.ToList();
                mf.dgvVulnerabilities.DataSource = listVuls;

                mf.dgvVulnerabilities.Columns["Threats"].Visible = false;
                mf.dgvVulnerabilities.Columns["VulnerabilityId"].Visible = false;                
                mf.dgvVulnerabilities.Columns["CheckVulnerability"].Width = 30;
                mf.dgvVulnerabilities.Columns["CheckVulnerability"].MinimumWidth = 30;
                mf.dgvVulnerabilities.Columns["VulnerabilityName"].Width = 300;
                mf.dgvVulnerabilities.Columns["VulnerabilityName"].HeaderText = "Уязвимость";
                mf.dgvVulnerabilities.Columns["VulnerabilityDescription"].HeaderText = "Описание";

                // Разрешаем редактировать только первый столбец (чекбоксы)
                foreach (DataGridViewColumn column in mf.dgvVulnerabilities.Columns)
                    column.ReadOnly = true;
                mf.dgvVulnerabilities.Columns["CheckVulnerability"].ReadOnly = false;

                // true = true, false = false. Ахуеть, да?
                ((DataGridViewCheckBoxColumn) mf.dgvVulnerabilities.Columns["CheckVulnerability"]).TrueValue = true;
                ((DataGridViewCheckBoxColumn) mf.dgvVulnerabilities.Columns["CheckVulnerability"]).FalseValue = false;

                mf.dgvVulnerabilities.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(234, 240, 255);
                mf.dgvVulnerabilities.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(28, 32, 57);
                mf.dgvVulnerabilities.EnableHeadersVisualStyles = false;

                mf.dgvVulnerabilities.SelectionChanged += new System.EventHandler(dgvVulnerabilities_SelectionChanged);
            }
        }

        private void dgvVulnerabilities_SelectionChanged(object sender, EventArgs e)
        {
            if (mf.dgvVulnerabilities.SelectedCells.Count > 0)
                mf.dgvVulnerabilities.SelectedCells[0].Selected = false;
        }
    }
}
