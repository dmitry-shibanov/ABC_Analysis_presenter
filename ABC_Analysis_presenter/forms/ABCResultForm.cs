using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using GemBox.Document;
using GemBox.Document.Tables;
using System.Reflection;
using System.Data;
using System.Linq;

namespace ABC_Analysis_presenter
{
    public partial class ABCResultForm : Form
    {
        private MainWindow mainForm;
        DataGridView[] tables;

        public ABCResultForm(MainWindow mainForm)
        {
            InitializeComponent();
            tables = new DataGridView[] { axGrid, bxGrid, cxGrid, ayGrid, byGrid, cyGrid, azGrid, bzGrid, czGrid };
            this.mainForm = mainForm;
            List<ServiceModel> list = getListFromGrid();
            if (list.Count > 1)
            {
                list = calcABC(list);
                setGroupsOnForm(list);
            }
        }
        //DataGridView DGV, Word._Document oDoc, int index, Word.Range wrdRng
        public void Export_Data_To_Word(DocumentModel document, int index)
        {
            int rowCount = tables[index].RowCount;
            int columnCount = tables[index].ColumnCount;

            var dataTable = new DataTable();
            for (int c = 0; c < columnCount; c++)
                dataTable.Columns.Add($"Column {c + 1}");
            for (int r = 0; r < rowCount; r++)
                dataTable.Rows.Add(Enumerable.Range(0, columnCount).Select(c => tables[index].Rows[r].Cells[c].Value.ToString()).ToArray());

            Table table = new Table(document, rowCount, columnCount,
    (int r, int c) => new TableCell(document, new Paragraph(document, dataTable.Rows[r][c].ToString())));

            // Insert first row as Table's header.
            table.Rows.Insert(0, new TableRow(document, dataTable.Columns.Cast<DataColumn>().Select(
                dataColumn => new TableCell(document, new Paragraph(document, dataColumn.ColumnName)))));

            table.TableFormat.PreferredWidth = new TableWidth(100, TableWidthUnit.Percentage);

            document.Sections.Add(new Section(document, table));
            /*
            if (DGV.Rows.Count != 0)
            {
                Microsoft.Office.Interop.Word.Table tableObj = oDoc.Tables.Add(wrdRng, DGV.Rows.Count+1, 2);
                tableObj.Range.ParagraphFormat.SpaceAfter = 8;
                tableObj.Cell(1, 2).Range.Text = "Назавние услуги";
                int count = oDoc.Tables.Count;
                tableObj = oDoc.Tables[index];
                for(int i = 2; i<= DGV.Rows.Count + 1; i++)
                {
                    tableObj.Cell(i, 1).Range.Text = (i - 1).ToString();
                    tableObj.Cell(i, 2).Range.Text = DGV.Rows[i-2].Cells[0].Value.ToString();
                }
                tableObj.Range.Borders.Enable = 1;
                tableObj.Rows[1].Range.Font.Bold = 1;
                oDoc.Paragraphs.Add(wrdRng);

                //save the file
                //oDoc.SaveAs2(filename);


            }
            */
        }

        private void GenerateDoc()
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            var document = new DocumentModel();

            int index = 0;

            foreach (DataGridView item in tables)
            {
                object myMissingValue = System.Reflection.Missing.Value;
                if (item.Rows.Count != 0)
                {
                }
                Export_Data_To_Word(document, index);
                index++;
            }
            document.Save("Insert DataTable.docx");
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
            GenerateDoc();
        }
    }
}
