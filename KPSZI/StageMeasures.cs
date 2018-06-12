using KPSZI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.IO;

namespace KPSZI
{
    class StageMeasures:Stage
    {
        protected override ImageList imageListForTabPage { get; set; }
        Button btnExportConsole = new Button();
        Button btnExportOpenXML = new Button();
        Button btnExportInterop = new Button();
        Button btnExprotSFHInterop = new Button();
        Button btnExportSFHConsole = new Button();

        public StageMeasures(TabPage stageTab, TreeNode stageNode, MainForm mainForm, InformationSystem IS)
            : base(stageTab, stageNode, mainForm, IS)
        {
            
        }

        protected override void initTabPage()
        {
            btnExportConsole.Location = new System.Drawing.Point(100, 100);
            btnExportConsole.Text = "В консоль";
            btnExportConsole.Click += btnExportConsole_Click;
            mf.tabControl.TabPages[stageTab.Name].Controls.Add(btnExportConsole);

            btnExportOpenXML.Location = new System.Drawing.Point(300, 100);
            btnExportOpenXML.Text = "OpenXML";
            btnExportOpenXML.Click += BtnExport_Click;
            mf.tabControl.TabPages[stageTab.Name].Controls.Add(btnExportOpenXML);

            btnExportInterop.Location = new System.Drawing.Point(500, 100);
            btnExportInterop.Text = "Interop";
            btnExportInterop.Click += BtnExportInterop_Click;
            mf.tabControl.TabPages[stageTab.Name].Controls.Add(btnExportInterop);

            btnExportSFHConsole.Location = new System.Drawing.Point(100, 200);
            btnExportSFHConsole.Text = "В консоль";
            btnExportSFHConsole.Click += BtnExportSFHConsole_Click;
            mf.tabControl.TabPages[stageTab.Name].Controls.Add(btnExportSFHConsole);

            btnExprotSFHInterop.Location = new System.Drawing.Point(500, 200);
            btnExprotSFHInterop.Text = "Interop";
            btnExprotSFHInterop.Click += BtnExprotSFHInterop_Click;
            mf.tabControl.TabPages[stageTab.Name].Controls.Add(btnExprotSFHInterop);
        }

        private void BtnExportSFHConsole_Click(object sender, EventArgs e)
        {
            int i = 0;
            using (KPSZIContext db = new KPSZIContext())
            {
                var sfhs = db.SFHs.OrderBy(s => s.SFHNumber).ToList();

                foreach (SFH sfh in sfhs)
                {
                    Console.WriteLine("===={0}====", sfh.Name);
                    foreach (GISMeasure gm in sfh.GISMeasures.OrderBy(m => m.GISMeasureId))
                    {
                        Console.WriteLine("\t {0}.{1} {2}", gm.MeasureGroup.ShortName, gm.Number, gm.Description);
                    }
                }
            }
        }

        private void BtnExprotSFHInterop_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document wordDoc;
            Microsoft.Office.Interop.Word.Paragraph wordParag;
            Microsoft.Office.Interop.Word.Table wordTable;

            //создаём новый документ Word и задаём параметры листа
            wordDoc = wordApp.Documents.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing); //создаём документ Word

            // первый параграф
            wordParag = wordDoc.Paragraphs.Add(Type.Missing);
            //wordParag.Range.Font.Name = "Times New Roman";
            //wordParag.Range.Font.Size = 16;
            //wordParag.Range.Font.Bold = 1;
            //wordParag.Range.Text = "Заголовок";
            //wordParag.Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;


            // второй параграф, таблица из n строк и 2 колонок
            //wordDoc.Paragraphs.Add(Type.Missing);
            wordParag.Range.Tables.Add(wordParag.Range, 45, 2, Type.Missing, Type.Missing);
            wordTable = wordDoc.Tables[1];
            wordTable.Range.Font.Bold = 0;
            wordParag.Range.Font.Name = "Times New Roman";
            wordTable.Range.Font.Size = 14;


            //задаём ширину колонок и высоту строк
            wordTable.Columns.PreferredWidthType = Microsoft.Office.Interop.Word.WdPreferredWidthType.wdPreferredWidthPoints;
            wordTable.Columns[1].SetWidth(200f, Microsoft.Office.Interop.Word.WdRulerStyle.wdAdjustNone);
            wordTable.Rows.SetHeight(20f, Microsoft.Office.Interop.Word.WdRowHeightRule.wdRowHeightAuto);
            wordTable.Rows.Alignment = Microsoft.Office.Interop.Word.WdRowAlignment.wdAlignRowCenter;
            wordTable.Range.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            wordTable.Range.Select();

            //заполнение шапки таблицы
            wordTable.Cell(1, 1).Range.Text = "Структурно–функциональная характеристика информационной системы";
            wordTable.Cell(1, 2).Range.Text = "Мера защиты информации, которая может применяться в информационной системе с данной характеристикой";

            //заполняем таблицу 

            int row = 2;
            using (KPSZIContext db = new KPSZIContext())
            {
                var sfhs = db.SFHs.OrderBy(t => t.SFHNumber).ToList();

                foreach (SFH sfh in sfhs)
                {
                    string measuresSFH = "";
                    foreach (GISMeasure gm in sfh.GISMeasures.OrderBy(m => m.GISMeasureId))
                    {
                        measuresSFH += gm.MeasureGroup.ShortName + "." + gm.Number + ". " + gm.Description + ";\n";
                    }
                    measuresSFH.TrimEnd('\n');
                    measuresSFH.TrimEnd(';');
                    wordTable.Cell(row, 1).Range.Text = sfh.Name;
                    wordTable.Cell(row++, 2).Range.Text = measuresSFH;
                }
            }

            //сохраняем документ, закрываем документ, выходим из Word
            wordDoc.SaveAs(Directory.GetCurrentDirectory() + @"\СФХ-меры.docx");
            wordApp.ActiveDocument.Close();
            wordApp.Quit();
        }

        private void BtnExportInterop_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document wordDoc;
            Microsoft.Office.Interop.Word.Paragraph wordParag;
            Microsoft.Office.Interop.Word.Table wordTable;

            //создаём новый документ Word и задаём параметры листа
            wordDoc = wordApp.Documents.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing); //создаём документ Word

            // первый параграф
            wordParag = wordDoc.Paragraphs.Add(Type.Missing);
            //wordParag.Range.Font.Name = "Times New Roman";
            //wordParag.Range.Font.Size = 16;
            //wordParag.Range.Font.Bold = 1;
            //wordParag.Range.Text = "Заголовок";
            //wordParag.Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;


            // второй параграф, таблица из n строк и 2 колонок
            //wordDoc.Paragraphs.Add(Type.Missing);
            wordParag.Range.Tables.Add(wordParag.Range, 209, 3, Type.Missing, Type.Missing);
            wordTable = wordDoc.Tables[1];
            wordTable.Range.Font.Bold = 0;
            wordParag.Range.Font.Name = "Times New Roman";
            wordTable.Range.Font.Size = 14;

            //задаём ширину колонок и высоту строк
            wordTable.Columns.PreferredWidthType = Microsoft.Office.Interop.Word.WdPreferredWidthType.wdPreferredWidthPoints;
            wordTable.Columns[1].SetWidth(200f, Microsoft.Office.Interop.Word.WdRulerStyle.wdAdjustNone);
            wordTable.Rows.SetHeight(20f, Microsoft.Office.Interop.Word.WdRowHeightRule.wdRowHeightAuto);
            wordTable.Rows.Alignment = Microsoft.Office.Interop.Word.WdRowAlignment.wdAlignRowCenter;
            wordTable.Range.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            wordTable.Range.Select();

            //заполнение шапки таблицы
            wordTable.Cell(1, 1).Range.Text = "Номер УБИ";
            wordTable.Cell(1, 2).Range.Text = "Наименование УБИ";
            wordTable.Cell(1, 3).Range.Text = "Мера";

            //заполняем таблицу 

            int row = 2;
            using (KPSZIContext db = new KPSZIContext())
            {
                var threats = db.Threats.OrderBy(t => t.ThreatNumber).ToList();

                foreach (Threat thr in threats)
                {
                    string threatName = thr.ThreatNumber + "." + thr.Name;
                    string measuresThreat = "";
                    foreach (GISMeasure gm in thr.GISMeasures.OrderBy(m => m.GISMeasureId))
                    {
                        measuresThreat += gm.MeasureGroup.ShortName + "." + gm.Number + ". " + gm.Description+";\n";
                    }
                    measuresThreat.TrimEnd('\n');
                    measuresThreat.TrimEnd(';');
                    wordTable.Cell(row, 1).Range.Text = "УБИ." + thr.ThreatNumber.ToString("000");
                    wordTable.Cell(row, 2).Range.Text = thr.Name;
                    wordTable.Cell(row++, 3).Range.Text = measuresThreat;
                }
            }

            //сохраняем документ, закрываем документ, выходим из Word
            wordDoc.SaveAs(Directory.GetCurrentDirectory() + @"\меры.docx");
            wordApp.ActiveDocument.Close();
            wordApp.Quit();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            //new GeneratedClass().CreatePackage("Output.docx");
        }

        private void btnExportConsole_Click(object sender, EventArgs e)
        {
            using (KPSZIContext db = new KPSZIContext())
            {
                var threats = db.Threats.OrderBy(t => t.ThreatNumber).ToList();

                foreach (Threat thr in threats)
                {
                    Console.WriteLine("{0}. {1}", thr.ThreatNumber, thr.Name);
                    foreach (GISMeasure gm in thr.GISMeasures.OrderBy(m => m.GISMeasureId))
                    {
                        Console.WriteLine("\t {0}.{1} {2}", gm.MeasureGroup.ShortName, gm.Number, gm.Description);
                    }
                }
            }
        }

        public override void saveChanges()
        {

        }

        public override void enterTabPage()
        {

        }



    }
}
