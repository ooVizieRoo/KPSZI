using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPSZI
{
    class StageHardware : Stage
    {
        List<RadioButton> listOfRB;
        Exception rbException = new Exception("");

        public StageHardware(TabPage stageTab, TreeNode stageNode, MainForm mainForm, InformationSystem IS)
            : base(stageTab, stageNode, mainForm, IS)
        {

        }

        public override void enterTabPage()
        {

        }

        public override void saveChanges()
        {

        }

        protected override void initTabPage()
        {
            // подпись обработчиков на кнопки
            mf.btnHWAdd.Click += new EventHandler(btnHWAdd_Click);
            mf.btnHWEdit.Click += new EventHandler(btnHWEdit_Click);
            mf.btnHWDel.Click += new EventHandler(btnHWDel_Click);
            mf.btnHWEdit.Enabled = false;
            mf.btnHWDel.Enabled = false;

            // подпись обработчиков на ComboBox
            mf.cbRAM.SelectedIndexChanged += new EventHandler(cbRAM_SelectedIndexChanged);
            
            // подпись обработчиков на клик DGV
            mf.dgvHardware.MouseDoubleClick += new MouseEventHandler(dgvHardware_MouseDoubleClick);
            mf.dgvHardware.MouseClick += new MouseEventHandler(dgvHardware_MouseClick);

            // подпись обработчиков поля ввода
            mf.tbPCNumber.GotFocus += new EventHandler(dgvHardware_LostFocusOnSelectionRow);
            mf.tbPCName.GotFocus += new EventHandler(dgvHardware_LostFocusOnSelectionRow);
            mf.cbOS.GotFocus += new EventHandler(dgvHardware_LostFocusOnSelectionRow);
            mf.tbCPU.GotFocus += new EventHandler(dgvHardware_LostFocusOnSelectionRow);
            mf.cbRAM.GotFocus += new EventHandler(dgvHardware_LostFocusOnSelectionRow);
            mf.tbMB.GotFocus += new EventHandler(dgvHardware_LostFocusOnSelectionRow);
            mf.tbVC.GotFocus += new EventHandler(dgvHardware_LostFocusOnSelectionRow);
            mf.tbHDD.GotFocus += new EventHandler(dgvHardware_LostFocusOnSelectionRow);
            mf.tbODD.GotFocus += new EventHandler(dgvHardware_LostFocusOnSelectionRow);
            mf.tbAC.GotFocus += new EventHandler(dgvHardware_LostFocusOnSelectionRow);
            mf.rbIsSecAdminPC.GotFocus += new EventHandler(dgvHardware_LostFocusOnSelectionRow);
            mf.rbIsServerPC.GotFocus += new EventHandler(dgvHardware_LostFocusOnSelectionRow);
            mf.rbIsSysAdminPC.GotFocus += new EventHandler(dgvHardware_LostFocusOnSelectionRow);
            mf.rbIsUserPC.GotFocus += new EventHandler(dgvHardware_LostFocusOnSelectionRow);
            mf.tbUIDHidden.GotFocus += new EventHandler(dgvHardware_LostFocusOnSelectionRow);
            mf.tbRAM.GotFocus += new EventHandler(dgvHardware_LostFocusOnSelectionRow);
            mf.tbRAM.KeyPress += new KeyPressEventHandler(tbRAM_KeyPress);

            listOfRB = new List<RadioButton>();
            listOfRB.AddRange(new List<RadioButton> { mf.rbIsSecAdminPC, mf.rbIsServerPC, mf.rbIsSysAdminPC, mf.rbIsUserPC });
        }

        private void clearFields()
        {
            try
            {
                mf.tbPCNumber.Text = "";
                mf.tbPCName.Text = "";
                mf.cbOS.SelectedItem = null;
                mf.tbCPU.Text = "";
                mf.cbRAM.SelectedItem = null;
                mf.tbMB.Text = "";
                mf.tbVC.Text = "";
                mf.tbHDD.Text = "";
                mf.tbODD.Text = "";
                mf.tbAC.Text = "";
                mf.rbIsSecAdminPC.Checked = false;
                mf.rbIsServerPC.Checked = false;
                mf.rbIsSysAdminPC.Checked = false;
                mf.rbIsUserPC.Checked = false;
                mf.tbUIDHidden.Text = "";
                mf.tbRAM.Text = "";
                mf.tbRAM.Visible = false;
                mf.lblRAMmb.Visible = false;

                mf.btnHWDel.Enabled = false;
                mf.btnHWEdit.Enabled = false;

            }
            catch
            {
                MessageBox.Show("Эксепшон при очистке полей формы!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        #region Обработчики
        /// <summary>
        /// Перехват ввода символов в поле оперативной памяти
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbRAM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        /// <summary>
        /// Клик по кнопке добавить
        /// </summary>
        private void btnHWAdd_Click(object sender, EventArgs e)
        {
            PC pc = new PC();

            try
            {
                pc.number = mf.tbPCNumber.Text;
                pc.userName = mf.tbPCName.Text;
                pc.OSName = mf.cbOS.SelectedItem.ToString();
                pc.CPU = mf.tbCPU.Text;
                pc.RAM = mf.cbRAM.SelectedItem.ToString();

                if (pc.RAM == "Другое...")
                {
                    if (mf.tbRAM.Text != "")
                        pc.RAM = mf.tbRAM.Text.Trim(' ') + " МБайт";
                    else
                        throw new Exception();
                }

                pc.motherBoard = mf.tbMB.Text;
                pc.videoCard = mf.tbVC.Text;
                pc.HDD = mf.tbHDD.Text;
                pc.ODD = mf.tbODD.Text;
                pc.audioCard = mf.tbAC.Text;
                var rb = listOfRB.Where(rbtn => rbtn.Checked).FirstOrDefault();

                switch (rb.Text)
                {
                    case "АРМ пользователя": { pc.PCGroup = 0; break; }
                    case "АРМ системного администратора": { pc.PCGroup = 1; break; }
                    case "АРМ администратора безопасности": { pc.PCGroup = 2; break; }
                    case "Сервер": { pc.PCGroup = 3; break; }
                    default: { throw new Exception("Эксепшон при парсинге gbHW1"); }
                }
            }
            catch
            {
                MessageBox.Show("Заполните все поля на форме!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                    IS.listOfPCs.Add(pc);
            }
            catch
            {
                MessageBox.Show("Эксепшон при добавлении объекта класса \"PC\" в список", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            mf.dgvHardware.DataSource = null;
            mf.dgvHardware.DataSource = IS.listOfPCs;

            clearFields();
            mf.dgvHardware.ClearSelection();
        }
        /// <summary>
        /// Клик по кнопке Редактировать
        /// </summary>
        private void btnHWEdit_Click(object sender, EventArgs e)
        {
            PC pc;

            try
            {
                pc = IS.listOfPCs.Where(p => p.UID == mf.tbUIDHidden.Text).First();
            }
            catch
            {
                MessageBox.Show("Эксепшон при получении объекта из списка по UID при выполнении операции редактирования!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            try
            {
                pc.number = mf.tbPCNumber.Text;
                pc.userName = mf.tbPCName.Text;
                pc.OSName = mf.cbOS.SelectedItem.ToString();
                pc.CPU = mf.tbCPU.Text;
                pc.RAM = mf.cbRAM.SelectedItem.ToString();

                if (pc.RAM == "Другое...")
                {
                    if (mf.tbRAM.Text != "")
                        pc.RAM = mf.tbRAM.Text.Trim(' ') + " МБайт";
                    else
                        throw new Exception();
                }

                pc.motherBoard = mf.tbMB.Text;
                pc.videoCard = mf.tbVC.Text;
                pc.HDD = mf.tbHDD.Text;
                pc.ODD = mf.tbODD.Text;
                pc.audioCard = mf.tbAC.Text;
            }
            catch
            {
                MessageBox.Show("Заполните все поля на форме!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                var rb = listOfRB.Where(rbtn => rbtn.Checked).FirstOrDefault();
                switch (rb.Text)
                {
                    case "АРМ пользователя": { pc.PCGroup = 0; break; }
                    case "АРМ системного администратора": { pc.PCGroup = 1; break; }
                    case "АРМ администратора безопасности": { pc.PCGroup = 2; break; }
                    case "Сервер": { pc.PCGroup = 3; break; }
                    default: { throw new Exception("Эксепшон при парсинге gbHW1 при редактировании записи!"); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            mf.dgvHardware.DataSource = null;
            mf.dgvHardware.DataSource = IS.listOfPCs;

            clearFields();
            mf.dgvHardware.ClearSelection();
        }
        /// <summary>
        /// Клик по кнопке Удалить
        /// </summary>
        private void btnHWDel_Click(object sender, EventArgs e)
        {
            PC pcToDelete;
            DataGridViewRow selectedRow;

            try
            {
                //pcToDelete = IS.listOfPCs.Where(pc => pc.UID == mf.tbUIDHidden.Text).First();
                selectedRow = mf.dgvHardware.SelectedRows[0];
                pcToDelete = IS.listOfPCs.Where(pc => pc.UID == (string)selectedRow.Cells["UID"].Value).First();
            }
            catch
            {
                MessageBox.Show("Эксепшон при получении объекта класса \"PC\" из списка при выполнении операции удаления!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            try
            {
                IS.listOfPCs.Remove(pcToDelete);
            }
            catch
            {
                MessageBox.Show("Эксепшон при удалении объекта класса \"PC\"!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            mf.dgvHardware.DataSource = null;
            mf.dgvHardware.DataSource = IS.listOfPCs;

            clearFields();
            mf.dgvHardware.ClearSelection();
        }

        /// <summary>
        /// Выбор объема ОЗУ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbRAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mf.cbRAM.SelectedItem == null)
                return;

            if (mf.cbRAM.SelectedItem.ToString() == "Другое...")
            {
                mf.tbRAM.Visible = true;
                mf.lblRAMmb.Visible = true;
            }
            else
            {
                mf.tbRAM.Visible = false;
                mf.lblRAMmb.Visible = false;
                mf.tbRAM.Text = "";
            }
        }

        /// <summary>
        /// Двойной клик по записи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvHardware_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (mf.dgvHardware.SelectedRows.Count == 0)
                return;

            // обнуление скрытого поля на форме
            mf.tbUIDHidden.Text = "";

            DataGridViewRow selectedRow;
            PC selectedPC;
            try
            {
                selectedRow = mf.dgvHardware.SelectedRows[0];
                selectedPC = IS.listOfPCs.Where(pc => pc.UID == (string)selectedRow.Cells["UID"].Value).First();
            }
            catch
            {
                MessageBox.Show("Эксепшон при получении объекта класса \"PC\" из списка!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            mf.tbPCNumber.Text = selectedPC.number;
            mf.tbPCName.Text = selectedPC.userName;
            mf.tbCPU.Text = selectedPC.CPU;
            mf.tbMB.Text = selectedPC.motherBoard;
            mf.tbVC.Text = selectedPC.videoCard;
            mf.tbHDD.Text = selectedPC.HDD;
            mf.tbODD.Text = selectedPC.ODD;
            mf.tbAC.Text = selectedPC.audioCard;
            mf.tbUIDHidden.Text = selectedPC.UID;

            try
            {
                mf.cbOS.SelectedItem = selectedPC.OSName;
                mf.cbRAM.SelectedItem = selectedPC.RAM;

                if (mf.cbRAM.SelectedItem == null)
                {
                    mf.cbRAM.SelectedItem = "Другое...";
                    mf.tbRAM.Visible = true;
                    mf.lblRAMmb.Visible = true;
                    mf.tbRAM.Text = selectedPC.RAM.Trim(" МБайт".ToCharArray());
                }
            }
            catch
            {
                MessageBox.Show("Эксепшон при установке ComboBox", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            try
            {
                switch (selectedPC.PCGroup)
                {
                    case 0: { mf.rbIsUserPC.Checked = true; break; }
                    case 1: { mf.rbIsSysAdminPC.Checked = true; break; }
                    case 2: { mf.rbIsSecAdminPC.Checked = true; break; }
                    case 3: { mf.rbIsServerPC.Checked = true; break; }
                    default: { throw new Exception(); }
                }
            }
            catch
            {
                MessageBox.Show("Эксепшон при установке RadioButton", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            mf.btnHWEdit.Enabled = true;
            mf.btnHWDel.Enabled = false;
            mf.dgvHardware.ClearSelection();
        }
        /// <summary>
        /// Одинарный клик по записи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvHardware_MouseClick(object sender, MouseEventArgs e)
        {
            if (mf.dgvHardware.SelectedRows.Count == 0)
                return;

            mf.btnHWDel.Enabled = true;
        }
        /// <summary>
        /// Потеря фокуса на выбранной строке в dgvHardware
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvHardware_LostFocusOnSelectionRow (object sender, EventArgs e)
        {
            mf.dgvHardware.ClearSelection();
            mf.btnHWDel.Enabled = false;
        }
        #endregion

    }
}
