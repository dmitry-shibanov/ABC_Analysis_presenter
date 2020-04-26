using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
namespace ABC_Analysis_presenter
{
    public partial class ABCResultForm : Form
    {
        private MainWindow mainForm;
        public ABCResultForm(MainWindow mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            List<ServiceModel> list = getListFromGrid();
            if (list.Count > 1)
            {
                list = calcABC(list);
                setGroupsOnForm(list);
            }
        }

        private void GenerateDoc()
        {
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";

            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oWord.Visible = true;
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
            ref oMissing, ref oMissing);

            Word.Paragraph oPara1;
            oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara1.Range.Text = "Heading 1";
            oPara1.Range.Font.Bold = 1;
            oPara1.Format.SpaceAfter = 24;  
            oPara1.Range.InsertParagraphAfter();

            Word.Paragraph oPara2;
            object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara2 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara2.Range.Text = "Heading 2";
            oPara2.Format.SpaceAfter = 6;
            oPara2.Range.InsertParagraphAfter();

            Word.Paragraph oPara3;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara3 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara3.Range.Text = "This is a sentence of normal text. Now here is a table:";
            oPara3.Range.Font.Bold = 0;
            oPara3.Format.SpaceAfter = 24;
            oPara3.Range.InsertParagraphAfter();

            Word.Table oTable;
            Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = oDoc.Tables.Add(wrdRng, 3, 5, ref oMissing, ref oMissing);
            oTable.Range.ParagraphFormat.SpaceAfter = 6;
            int r, c;
            string strText;
            for (r = 1; r <= 3; r++)
                for (c = 1; c <= 5; c++)
                {
                    strText = "r" + r + "c" + c;
                    oTable.Cell(r, c).Range.Text = strText;
                }
            oTable.Rows[1].Range.Font.Bold = 1;
            oTable.Rows[1].Range.Font.Italic = 1;

            Word.Paragraph oPara4;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara4 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara4.Range.InsertParagraphBefore();
            oPara4.Range.Text = "And here's another table:";
            oPara4.Format.SpaceAfter = 24;
            oPara4.Range.InsertParagraphAfter();

            wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = oDoc.Tables.Add(wrdRng, 5, 2, ref oMissing, ref oMissing);
            oTable.Range.ParagraphFormat.SpaceAfter = 6;
            for (r = 1; r <= 5; r++)
                for (c = 1; c <= 2; c++)
                {
                    strText = "r" + r + "c" + c;
                    oTable.Cell(r, c).Range.Text = strText;
                }
            oTable.Columns[1].Width = oWord.InchesToPoints(2);
            oTable.Columns[2].Width = oWord.InchesToPoints(3);


            object oPos;
            double dPos = oWord.InchesToPoints(7);
            oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range.InsertParagraphAfter();
            do
            {
                wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                wrdRng.ParagraphFormat.SpaceAfter = 6;
                wrdRng.InsertAfter("A line of text");
                wrdRng.InsertParagraphAfter();
                oPos = wrdRng.get_Information
                                       (Word.WdInformation.wdVerticalPositionRelativeToPage);
            }
            while (dPos >= Convert.ToDouble(oPos));
            object oCollapseEnd = Word.WdCollapseDirection.wdCollapseEnd;
            object oPageBreak = Word.WdBreakType.wdPageBreak;
            wrdRng.Collapse(ref oCollapseEnd);
            wrdRng.InsertBreak(ref oPageBreak);
            wrdRng.Collapse(ref oCollapseEnd);
            wrdRng.InsertAfter("We're now on page 2. Here's my chart:");
            wrdRng.InsertParagraphAfter();

            Word.InlineShape oShape;
            object oClassType = "MSGraph.Chart.8";
            wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oShape = wrdRng.InlineShapes.AddOLEObject(ref oClassType, ref oMissing,
            ref oMissing, ref oMissing, ref oMissing,
            ref oMissing, ref oMissing, ref oMissing);


            object oChart;
            object oChartApp;
            oChart = oShape.OLEFormat.Object;
            oChartApp = oChart.GetType().InvokeMember("Application",
            BindingFlags.GetProperty, null, oChart, null);

            //Change the chart type to Line.
            object[] Parameters = new Object[1];
            Parameters[0] = 4; //xlLine = 4
            oChart.GetType().InvokeMember("ChartType", BindingFlags.SetProperty,
            null, oChart, Parameters);

            oChartApp.GetType().InvokeMember("Update",
            BindingFlags.InvokeMethod, null, oChartApp, null);
            oChartApp.GetType().InvokeMember("Quit",
            BindingFlags.InvokeMethod, null, oChartApp, null);

            oShape.Width = oWord.InchesToPoints(6.25f);
            oShape.Height = oWord.InchesToPoints(3.57f);

            wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            wrdRng.InsertParagraphAfter();
            wrdRng.InsertAfter("THE END.");

            this.Close();
        }

        public ABCResultForm()
        {
            InitializeComponent();
        }

        private List<ServiceModel> calcABC(List<ServiceModel> list)
        {
            int sumCount = 0;
            int sumEarn = 0;
            for (int i = 0; i < list.Count; sumCount += list[i].count, i++) ;
            for (int i = 0; i < list.Count; sumEarn += list[i].earn, i++) ;
            List<ServiceModel> listCount = new List<ServiceModel>(list);
            listCount.Sort(delegate (ServiceModel x, ServiceModel y)
                {
                    return y.count.CompareTo(x.count);
                }
            );
            List<ServiceModel> listEarn = new List<ServiceModel>(list);
            listEarn.Sort(delegate (ServiceModel x, ServiceModel y)
                {
                    return y.earn.CompareTo(x.earn);
                }
            );
            for (int i = 0; i < list.Count; i++)
            {
                ServiceModel item = listCount[i];
                ServiceModel item2 = listEarn[i];
                item.partCount = (float) item.count / sumCount;
                item2.partEarn = (float) item2.earn / sumEarn;
            }
            listCount[0].sumPartCount = listCount[0].partCount;
            listEarn[0].sumPartEarn = listEarn[0].partEarn;
            for (int i = 1; i < list.Count; i++)
            {
                listCount[i].sumPartCount = listCount[i - 1].sumPartCount + listCount[i].partCount;
                listEarn[i].sumPartEarn = listEarn[i - 1].sumPartEarn + listEarn[i].partEarn;
            }
            foreach (ServiceModel item in list)
            {
                if (item.sumPartCount < 0.8f) item.groups[0] = ServiceModel.Groups.A;
                else if (item.sumPartCount < 0.95f) item.groups[0] = ServiceModel.Groups.B;
                else item.groups[0] = ServiceModel.Groups.C;

                if (item.sumPartEarn < 0.8f) item.groups[1] = ServiceModel.Groups.X;
                else if (item.sumPartEarn < 0.95f) item.groups[1] = ServiceModel.Groups.Y;
                else item.groups[1] = ServiceModel.Groups.Z;
            }
            return list;
        }

        private void setGroupsOnForm(List<ServiceModel> list)
        {
            foreach (ServiceModel item in list)
            {
                switch(item.groups[0])
                {
                    case ServiceModel.Groups.A:
                        {
                            switch (item.groups[1])
                            {
                                case ServiceModel.Groups.X:
                                    {
                                        addRow(axGrid, item);
                                        break;
                                    }
                                case ServiceModel.Groups.Y:
                                    {
                                        addRow(ayGrid, item);
                                        break;
                                    }
                                case ServiceModel.Groups.Z:
                                    {
                                        addRow(azGrid, item);
                                        break;
                                    }
                            }
                            break;
                        }
                    case ServiceModel.Groups.B:
                        {
                            switch (item.groups[1])
                            {
                                case ServiceModel.Groups.X:
                                    {
                                        addRow(bxGrid, item);
                                        break;
                                    }
                                case ServiceModel.Groups.Y:
                                    {
                                        addRow(byGrid, item);
                                        break;
                                    }
                                case ServiceModel.Groups.Z:
                                    {
                                        addRow(bzGrid, item);
                                        break;
                                    }
                            }
                            break;
                        }
                    case ServiceModel.Groups.C:
                        {
                            switch (item.groups[1])
                            {
                                case ServiceModel.Groups.X:
                                    {
                                        addRow(cxGrid, item);
                                        break;
                                    }
                                case ServiceModel.Groups.Y:
                                    {
                                        addRow(cyGrid, item);
                                        break;
                                    }
                                case ServiceModel.Groups.Z:
                                    {
                                        addRow(czGrid, item);
                                        break;
                                    }
                            }
                            break;
                        }
                }
            }
        }

        private void addRow(DataGridView dataGrid, ServiceModel model)
        {
            dataGrid.Rows.Add();
            int i = dataGrid.Rows.Count - 1;
            dataGrid[0, i].Value = model.name;
        }

        private List<ServiceModel> getListFromGrid()
        {
            List<ServiceModel> list = new List<ServiceModel>();
            DataGridView dataGrid = mainForm.dataGrid;
            for (int i = 0; i < dataGrid.Rows.Count-1; i++)
            {
                ServiceModel model = new ServiceModel();
                model.name = dataGrid[0, i].Value.ToString();
                model.count = int.Parse(dataGrid[1, i].Value.ToString());
                model.cost = int.Parse(dataGrid[2, i].Value.ToString());
                model.earn = int.Parse(dataGrid[3, i].Value.ToString());
                list.Add(model);
            }
            return list;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            mainForm.Visible = true;
            Close();
        }
    }
}
