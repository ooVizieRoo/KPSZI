using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KPSZI.Model;

namespace KPSZI
{
    public partial class DamageDegreeControl : UserControl
    {
        //int[,,] damageForInfoType;
        List<string> listOfInfoTypes;
        DataGridView[] dgvDamage;
        Label[] lblInfoTypeName;
        public int currentThreatNumber;

        public DamageDegreeControl(List<InfoType> listOfInfoTypes)
        {
            InitializeComponent();
            
            this.listOfInfoTypes = new List<string>();
            for (int i = 0; i < listOfInfoTypes.Count; i++)
                this.listOfInfoTypes.Add(listOfInfoTypes[i].TypeName);
            dgvDamage = new DataGridView[listOfInfoTypes.Count()];
            lblInfoTypeName = new Label[listOfInfoTypes.Count()];
            initDGVs();
        }

        private void initDGVs()
        {
            int currentH = 0;
            for (int i = 0; i < dgvDamage.Count(); i++)
            {
                // 
                // lblDamageType
                //
                currentH += 9;
                lblInfoTypeName[i] = new Label();
                lblInfoTypeName[i].AutoSize = true;
                lblInfoTypeName[i].Location = new Point(120, currentH);
                lblInfoTypeName[i].Size = new Size(67, 13);
                lblInfoTypeName[i].TabIndex = 4;
                lblInfoTypeName[i].Text = listOfInfoTypes[i];

                DataGridViewTextBoxColumn damageType = new DataGridViewTextBoxColumn();
                DataGridViewComboBoxColumn columnC = new DataGridViewComboBoxColumn();
                DataGridViewComboBoxColumn columnI = new DataGridViewComboBoxColumn();
                DataGridViewComboBoxColumn columnA = new DataGridViewComboBoxColumn();
                // 
                // dgvDamage
                // 
                currentH += 26;
                dgvDamage[i] = new DataGridView();
                dgvDamage[i].AllowUserToAddRows = false;
                dgvDamage[i].AllowUserToDeleteRows = false;
                dgvDamage[i].AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDamage[i].AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvDamage[i].BackgroundColor = SystemColors.Window;
                dgvDamage[i].BorderStyle = BorderStyle.None;
                dgvDamage[i].ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgvDamage[i].Columns.AddRange(new DataGridViewColumn[] { damageType, columnC, columnI, columnA});
                dgvDamage[i].RowsAdded += new DataGridViewRowsAddedEventHandler(dgvDamage_RowsAdded);

                dgvDamage[i].Rows.Add("Экономический");
                dgvDamage[i].Rows.Add("Социальный");
                dgvDamage[i].Rows.Add("Политический");
                dgvDamage[i].Rows.Add("Репутационный");
                dgvDamage[i].Rows.Add("В области обороны.."); // , безопасности и правопорядка
                dgvDamage[i].Rows.Add("Субъекту ПДн");
                dgvDamage[i].Rows.Add("Технологический");

                dgvDamage[i].EditMode = DataGridViewEditMode.EditOnEnter;
                dgvDamage[i].Margin = new Padding(0);
                dgvDamage[i].Size = new Size(Width, dgvDamage[i].Size.Height);
                dgvDamage[i].Location = new Point(0, currentH);
                dgvDamage[i].RowHeadersVisible = false;  

                currentH += dgvDamage[i].Size.Height;
                // 
                // damageType
                // 
                damageType.HeaderText = "Вид ущерба";
                damageType.ReadOnly = true;
                // 
                // columnC
                // 
                columnC.HeaderText = "К";
                columnC.Items.AddRange(new object[] { "Высокий", "Средний", "Низкий", "–"});
                columnC.Name = "columnC";
                columnC.Resizable = DataGridViewTriState.True;
                columnC.SortMode = DataGridViewColumnSortMode.Automatic;
                columnC.ToolTipText = "Конфиденциальность";
                // 
                // columnI
                // 
                columnI.HeaderText = "Ц";
                columnI.Items.AddRange(new object[] { "Высокий", "Средний", "Низкий", "–"});
                columnI.Name = "columnI";
                columnI.Resizable = DataGridViewTriState.True;
                columnI.SortMode = DataGridViewColumnSortMode.Automatic;
                columnI.ToolTipText = "Целостность";
                // 
                // columnA
                // 
                columnA.HeaderText = "Д";
                columnA.Items.AddRange(new object[] { "Высокий", "Средний", "Низкий", "–"});
                columnA.Name = "columnA";
                columnA.Resizable = DataGridViewTriState.True;
                columnA.SortMode = DataGridViewColumnSortMode.Automatic;
                columnA.ToolTipText = "Доступность";
                
                Controls.Add(dgvDamage[i]);
                Controls.Add(lblInfoTypeName[i]);
                Height = currentH;
            }
        }

        private void dgvDamage_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // автоматическое вычисление высоты DGV
            ((Control)sender).Height = ((DataGridView)sender).Rows.GetRowsHeight(DataGridViewElementStates.Visible) + 
                ((DataGridView)sender).ColumnHeadersHeight;            
        }
    }
}
