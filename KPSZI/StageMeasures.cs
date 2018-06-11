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
        Button btn = new Button();
        Button btnExportOpenXML = new Button();
        Button btnExportInterop = new Button();


        public StageMeasures(TabPage stageTab, TreeNode stageNode, MainForm mainForm, InformationSystem IS)
            : base(stageTab, stageNode, mainForm, IS)
        {
            
        }

        protected override void initTabPage()
        {
            btn.Location = new System.Drawing.Point(100, 100);
            btn.Text = "В консоль";
            btn.Click += Btn_Click;
            mf.tabControl.TabPages[stageTab.Name].Controls.Add(btn);

            btnExportOpenXML.Location = new System.Drawing.Point(300, 100);
            btnExportOpenXML.Text = "OpenXML";
            btnExportOpenXML.Click += BtnExport_Click;
            mf.tabControl.TabPages[stageTab.Name].Controls.Add(btnExportOpenXML);

            btnExportInterop.Location = new System.Drawing.Point(500, 100);
            btnExportInterop.Text = "Interop";
            btnExportInterop.Click += BtnExportInterop_Click;
            mf.tabControl.TabPages[stageTab.Name].Controls.Add(btnExportInterop);
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

        private void Btn_Click(object sender, EventArgs e)
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
