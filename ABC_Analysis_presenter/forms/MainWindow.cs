﻿using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Collections.Generic;
using ABC_Analysis_presenter.models;

namespace ABC_Analysis_presenter
{
    public partial class MainWindow : Form
    {
        private List<Service> services = new List<Service>();
        public MainWindow()
        {
            InitializeComponent();
            Marketingovoe_agentstvoEntities1 marketingovoe_Agentstvo = new Marketingovoe_agentstvoEntities1();
            foreach(var item in marketingovoe_Agentstvo.Uslugies)
            {
                dataGrid.Rows.Add(new object[] { item.Naimenovanie, 12, item.Prise, 12 });
            }
        }

        private void UpdateList()
        {
            foreach (var item in services)
            {
                dataGrid.Rows.Add(new object[] { item.Name, item.Count, item.Price, item.TotalPrice });
            }
        }

        private void GenerateServices(string path)
        {
            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRng;
            int row = 2;
            int column = 1;

            try
            {
                //Start Excel and get Application object.
                oXL = new Excel.Application();
                //oXL.Visible = true;

                //Get a new workbook.
                oWB = oXL.Workbooks.Open(path);
                oSheet = (Excel._Worksheet)oWB.ActiveSheet;//0 - sheet

                while(oSheet.Cells[row, 1].Value2 != null)
                {
                    string name = oSheet.Cells[row, column].Value2;
                    column++;
                    double price = oSheet.Cells[row, column].Value2;
                    column++;
                    int count = (int)(oSheet.Cells[row, column].Value2);
                    column++;
                    double tottalPrice = oSheet.Cells[row, column].Value2;
                    Service service = new Service(name, count, price);
                    services.Add(service);
                    column = 1;
                    row++;
                }
                UpdateList();
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                for (int j = 0; j < dataGrid.Rows.Count - 1; j++)
                {
                    if ((dataGrid[i,j].Value == null) || (dataGrid[i,j].Value.ToString().Length <= 0))
                    {
                        MessageBox.Show("Заполните все поля в строчках", "Ошибка");
                        return;
                    } 
                }
            }
            ABCResultForm form = new ABCResultForm(this);
            form.Show();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int cellRow = e.RowIndex;
            int cellColumn = e.ColumnIndex;
            if (cellRow == -1) return;
            if ((cellColumn > 0) && (cellColumn < 3)) {
                try
                {
                    if ((dataGrid[2, cellRow].Value.ToString().Length > 0) && (dataGrid[1, cellRow].Value.ToString().Length > 0))
                    {
                        int count = int.Parse(dataGrid[1, cellRow].Value.ToString());
                        int cost = int.Parse(dataGrid[2, cellRow].Value.ToString());
                        int earning = count * cost;
                        dataGrid[3, cellRow].Value = earning;
                    } else dataGrid[3, cellRow].Value = "";
                } catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                    dataGrid[3, cellRow].Value = "";
                }
            }
        }

        private void dataGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress -= new KeyPressEventHandler(tb_KeyPress);
            if ((dataGrid.CurrentCell.ColumnIndex == 2) || (dataGrid.CurrentCell.ColumnIndex == 1))
            {
                tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
            }
        }

        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != '.'))
            {
                if (e.KeyChar != (char)Keys.Back)
                { e.Handled = true; }
            }
        }

        private void btnServiceChose_Click(object sender, EventArgs e)
        {
            int count = dataGrid.SelectedRows.Count;
            if (count > 1)
            {
                MessageBox.Show("Выберите лишь 1 услугу");
            }else if(count == 0)
            {
                MessageBox.Show("Ни одна услуга не выбрана");
            }
            else
            {
                
            }
        }

        private void btnChangeRelevance_Click(object sender, EventArgs e)
        {

        }

        private void btnChoseExcel_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    GenerateServices(filePath);
                    //System.Threading.Tasks.Task.Run(() => GenerateServices(filePath));
                }
            }
        }
    }
}
