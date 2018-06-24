﻿using KPSZI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace KPSZI
{
    class StageSZI:Stage
    {
        protected override ImageList imageListForTabPage { get; set; }
        List<SZI> listOfSZIsFromDB;
        List<SZISort> listOfNeededSZISorts;
        List<RadioButton> radiobuttonsSZISorts;
        List<CheckBox> checkboxesSZISorts;

        public StageSZI(TabPage stageTab, TreeNode stageNode, MainForm mainForm, InformationSystem IS)
            : base(stageTab, stageNode, mainForm, IS)
        {
            mf.btnGetRequirm.Click += BtnGetRequirm_Click;
            mf.btnGetSZI.Click += BtnGetSZI_Click;
        }

        private void BtnGetSZI_Click(object sender, EventArgs e)
        {
            mf.wsm.Visible = true;
            mf.wsm.Update();

            mf.tabControlSZIs.TabPages.Clear();
            mf.tabControlSZIs.TabPages.Add(mf.tpSZItpReq);
            mf.tabControlSZIs.TabPages.Add(mf.tpSZItpSZIs);
            mf.tabControlSZIs.SelectedTab = mf.tpSZItpSZIs;
            mf.dgvSZI.Rows.Clear();

            using (KPSZIContext db = new KPSZIContext())
            {
                int i = 0;
                var listSZISorts = db.SZISorts.ToList();

                var listMeasues = db.GisMeasures.ToList().Intersect(IS.listOfAllNSDMeasures).ToList();

                foreach (GISMeasure gm in listMeasues)
                {
                    if (gm.SZISorts.Count == 0)
                        continue;

                    string szis = "";
                    List<SZI> _szis = new List<SZI>(); 
                    foreach (SZISort ss in gm.SZISorts)
                    {
                        _szis = ss.SZIs.ToList().Intersect(IS.listOfSZIs).ToList();
                        
                    }
                    _szis = _szis.Distinct().ToList();

                    foreach (SZI szi in _szis)
                    {
                        szis += szi.Name + "\n";
                    }
                    mf.dgvSZI.Rows.Add(++i, gm.ToString(), szis);
                }
            }
            mf.wsm.Visible = false;
        }

        private void BtnGetRequirm_Click(object sender, EventArgs e)
        {
            mf.tabControlSZIs.TabPages.Clear();

            switch (IS.GISClass)
            {
                case 1: { mf.tbtpSZISVT.Text = "не ниже 5-го класса"; mf.tbtpSZISZI.Text = "не ниже 4-го класса"; mf.tbtpSZINDV.Text = "4";  break; }
                case 2: { mf.tbtpSZISVT.Text = "не ниже 5-го класса"; mf.tbtpSZISZI.Text = "не ниже 5-го класса"; mf.tbtpSZINDV.Text = "4"; break; }
                case 3: { mf.tbtpSZISVT.Text = "не ниже 5-го класса"; mf.tbtpSZISZI.Text = "не ниже 6-го класса"; mf.tbtpSZINDV.Text = "не требуется"; break; }
                default:
                    {
                        if (MessageBox.Show("Не определен класс защищенности для дальнейшней работы. \nПерейти во вкладку \"Классификация\"?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            mf.treeView.SelectedNode = mf.returnTreeNode("tnClassification");
                            return;
                        }
                        else
                            return;
                    }
            }


            mf.tabControlSZIs.TabPages.Add(mf.tpSZItpReq);
            using (KPSZIContext db = new KPSZIContext())
            {
                listOfSZIsFromDB = db.SZIs.ToList();
                listOfNeededSZISorts = new List<SZISort>();
                var listOfAllNSDMeasuresTemporary = db.GisMeasures.ToList().Intersect(IS.listOfAllNSDMeasures).ToList();
                foreach (GISMeasure gm in listOfAllNSDMeasuresTemporary)
                {
                    foreach (SZISort ss in gm.SZISorts)
                    {
                        listOfNeededSZISorts.Add(ss);
                    }
                }

                listOfNeededSZISorts = listOfNeededSZISorts.Distinct().ToList();

                GroupBox gb;
                RadioButton rb;
                CheckBox cb;
                radiobuttonsSZISorts = new List<RadioButton>();
                checkboxesSZISorts = new List<CheckBox>();

                mf.ptpSZIforSZI.Controls.Clear();

                int i = 0;
                int j = 0;
                int gbY = 5;

                foreach (SZISort szisort in listOfNeededSZISorts)
                {
                    gb = new GroupBox();
                    gb.Location = new Point(7, gbY);
                    gb.Text = szisort.Name;

                    foreach (SZI szi in szisort.SZIs)
                    {
                        if (szisort.ShortName != "САВЗ")
                        {
                            rb = new RadioButton();
                            rb.Text = szi.Name;
                            rb.Margin = new Padding(10, 5, 5, 5);
                            rb.Location = new Point(10, 17 + (17 * j));
                            rb.Size = new Size(300, 17);
                            rb.CheckedChanged += Rb_CheckedChanged;
                            radiobuttonsSZISorts.Add(rb);
                            gb.Controls.Add(rb);
                            j++;
                        }
                        else
                        {
                            cb = new CheckBox();
                            cb.Text = szi.Name;
                            cb.Margin = new Padding(10, 5, 5, 5);
                            cb.Location = new Point(10, 17 + (17 * j));
                            cb.Size = new Size(300, 17);
                            cb.CheckedChanged += Rb_CheckedChanged;
                            checkboxesSZISorts.Add(cb);
                            gb.Controls.Add(cb);
                            j++;
                        }

                        //ставим птичку на первом добавленном СЗИ
                        if (gb.Controls.Count == 1)
                        {
                            var ctrl = gb.Controls[0];
                            if (ctrl is CheckBox)
                            {
                                var _cb = (CheckBox)ctrl;
                                _cb.Checked = true;
                            }

                            if (ctrl is RadioButton)
                            {
                                var _rb = (RadioButton)ctrl;
                                _rb.Checked = true;
                            }
                        }
                    }

                    gb.Size = new Size(300, 25 + j * 17);
                    gbY += 30 + j * 17;
                    j = 0;
                    //stageTab.Controls.Add(gb);

                    string description;
                    switch (szisort.ShortName)
                    {
                        case "СЗИ от НСД": { description = "Средство защиты информации от несанкционированного доступа. Может реализовывать функции средства контроля съемных машинных носителей"; break; }
                        case "СОВ": { description = "Средство обнаружения вторжений. Может реализовывать функции межсетевых экранов, поэтому не имеет смысла выбирать отличное от него, т.к. приведет к дополнительным затратам. Требования к СОВ утверждены Приказом ФСТЭК России от 6 декабря 2011 г. № 638."; break; }
                        case "МСЭ": { description = "Межсетевой экран. Может реализовывать функции средств обнаружения вторжений, поэтому не имеет смысла выбирать отличное от него, т.к. приведет к дополнительным затратам. Требования к Межсетевым экранам утверждены Приказом ФСТЭК России от 9 февраля 2016 г. № 9."; break; }
                        case "СДЗ": { description = "Средство доверенной загрузки. Обеспечивает доверенную загрузку СВТ. Требования к СДЗ утверждены Приказом ФСТЭК России от 27 сентября 2013 г. № 119."; break; }
                        case "САВЗ": { description = "Средство антивирусной защиты. Обеспечивает защиту от компьютерных вирусов. Требования к САВЗ утверждены Приказом ФСТЭК России от 20 марта 2012 г. № 28."; break; }
                        case "СКН": { description = "Средство контроля съемных машинных носителей информации. Обеспечивает защиту от компьютерных вирусов. Требования к СКН утверждены Приказом ФСТЭК России от 28 июля 2014 г. № 87."; break; }
                        case "САНЗ": { description = "Средство анализа (контроля) защищенности информационной системы. Предназначено для анализа защищенности информации в корпоративных сетях. Специальных требований, кроме наличия сертификата ФСТЭК России, к данному виду СЗИ не устанавливается."; break; }
                        case "СРСБ": { description = "Средство регистрации событий безопасности. Предназначено для управления событиями и информацией ИБ с целью выявления инцидентов в режиме реального времени. Специальных требований, кроме наличия сертификата ФСТЭК России, к данному виду СЗИ не устанавливается."; break; }
                        case "СЗСВ": { description = "Средство защиты среды виртуализации. Предназначено для защиты среды виртуальной инфраструктуры предприятия. Специальных требований, кроме наличия сертификата ФСТЭК России, к данному виду СЗИ не устанавливается."; break; }
                        case "СРК": { description = "Средство резервного копирования и восстановления информации. Предназначено для обеспечения целостности и доступности информации. Специальных требований, кроме наличия сертификата ФСТЭК России, к данному виду СЗИ не устанавливается."; break; }

                        default: { description = "Описание отсутствует"; break; }
                    }

                    TextBox tb = new TextBox();
                    tb.Text = description;
                    tb.Multiline = true;
                    tb.TextAlign = HorizontalAlignment.Left;
                    tb.Location = new Point(gb.Location.X + gb.Size.Width + 5, gb.Location.Y + 8);
                    tb.Size = new Size(stageTab.Size.Width - 7 - gb.Size.Width - 5 - 50, gb.Size.Height - 8);
                    tb.BackColor = SystemColors.Control;

                    
                    mf.ptpSZIforSZI.Controls.Add(tb);
                    mf.ptpSZIforSZI.Controls.Add(gb);
                    
                    i++;
                }
            }
        }

        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton rb in radiobuttonsSZISorts)
            {
                SZI szi = listOfSZIsFromDB.Where(s => s.Name == rb.Text).First();
                if (rb.Checked && !IS.listOfSZIs.Contains(szi))
                    IS.listOfSZIs.Add(szi);
                if (!rb.Checked && IS.listOfSZIs.Contains(szi))
                    IS.listOfSZIs.Remove(szi);
            }

            foreach (CheckBox cb in checkboxesSZISorts)
            {
                SZI szi = listOfSZIsFromDB.Where(s => s.Name == cb.Text).First();
                if (cb.Checked && !IS.listOfSZIs.Contains(szi))
                    IS.listOfSZIs.Add(szi);
                if (!cb.Checked && IS.listOfSZIs.Contains(szi))
                    IS.listOfSZIs.Remove(szi);
            }
        }

        protected override void initTabPage()
        {
            mf.tabControlSZIs.TabPages.Clear();

            mf.dgvSZI.Columns.Add("Count", "№");
            mf.dgvSZI.Columns.Add("Measure", "Наименование меры");
            mf.dgvSZI.Columns.Add("SZIs", "Техническое средство");
            mf.dgvSZI.Columns[0].Width = 15;//.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            mf.dgvSZI.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mf.dgvSZI.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public override void saveChanges()
        {

        }

        public override void enterTabPage()
        {

        }
    }
}
