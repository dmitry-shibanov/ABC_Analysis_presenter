using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using GemBox.Document;
using GemBox.Document.Tables;
using System.Reflection;
using System.Data;
using System.Linq;
using System.IO;
using Microsoft.Office.Interop.Word;

namespace ABC_Analysis_presenter
{
    public partial class ABCResultForm : Form
    {
        private MainWindow mainForm;
        Dictionary<string, DataGridView> tables;
        string htmlDoc = "";

        public ABCResultForm(MainWindow mainForm)
        {
            InitializeComponent();
            tables = new Dictionary<string, DataGridView> { { "ax", axGrid }, { "bx", bxGrid }, { "cx", cxGrid }, { "ay", ayGrid },
                { "by", byGrid }, { "cy", cyGrid }, { "az", azGrid }, { "bz", bzGrid }, { "cz", czGrid } };
            this.mainForm = mainForm;
            List<ServiceModel> list = getListFromGrid();
            if (list.Count > 1)
            {
                list = calcABC(list);
                setGroupsOnForm(list);
            }
        }
        //DataGridView DGV, Word._Document oDoc, int index, Word.Range wrdRng
        public void Export_Data_To_Word(DataGridView dataGridView, string key)
        {
            htmlDoc += key;
            htmlDoc += "<br/><br/>";
            htmlDoc += "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:arial'>";

            htmlDoc += "<tr>";
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                htmlDoc += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" + column.HeaderText + "</th>";
            }
            htmlDoc += "</tr>";

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                htmlDoc += "<tr>";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    htmlDoc += "<td style='width:120px;border: 1px solid #ccc'>" + cell.Value.ToString() + "</td>";
                }
                htmlDoc += "</tr>";
            }

            htmlDoc += "</table>";
            htmlDoc += "</br></br></br>";
        }

        private void GenerateDoc()
        {
            
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            var document = new DocumentModel();
            //document.

            int index = 0;

            foreach (string key in tables.Keys)
            {
                DataGridView dataGridView = tables[key];
                if (dataGridView.Rows.Count != 0)
                {
                    Export_Data_To_Word(dataGridView, key);
                }
                index++;
            }

            string htmlFilePath = @"C:\Users\123\DataGridView.htm";
            File.WriteAllText(htmlFilePath, htmlDoc);

            //Convert the HTML File to Word document.
            _Application word = new Microsoft.Office.Interop.Word.Application();
            _Document wordDoc = word.Documents.Open(FileName: htmlFilePath, ReadOnly: false);
            wordDoc.Application.Visible = true;
            /*
            wordDoc.SaveAs(FileName: @"E:\Files\DataGridView.doc", FileFormat: WdSaveFormat.wdFormatRTF);
            ((_Document)wordDoc).Close();
            ((_Application)word).Quit();
            
            //Delete the HTML File.
            File.Delete(htmlFilePath);
            //document.Save("Insert DataTable.docx");
            //this.Close();
            */
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
