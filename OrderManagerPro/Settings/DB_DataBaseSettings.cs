using OrderManagerPro.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagerPro
{
    public partial class DB_DataBaseSettings : Form
    {
        public DB_DataBaseSettings()
        {
            InitializeComponent();
        }

        private void DB_DataBaseSettings_Load(object sender, EventArgs e)
        {
            //CurrentFileLocationLabel.Text = Properties.Resources.DataBaseConnectionString;
            CurrentFileLocationLabel.Text = Settings.Default.DataBaseLocationString;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Settings.Default.DataBaseLocationString = SetNewLocationTextBox.Text;
            Settings.Default.Save();
        }


        string mmmTest = "Ok";
        #region ImportDataButton_Click
        private void ImportDataButton_Click(object sender, EventArgs e)
        {
            GetClipboardDataToDataTable();



            //TotalTimebutton.Visible = true;


            //if (Tstttdd == "NotOk")
            //{
            //    return;
            //}
            //if (mmmTest == "NotOk")
            //{
            //    ImportedDataTable = new DataTable();
            //    HeaderNames = new List<string>();
            //    WorkerNames = new List<string>();
            //    return;
            //}
            //SetGridViewHeaderStyle();
            //SetGridviewColumnWitdh();
            //SetGridviewRowColor();
            //MarkCountDifference();
            //ImportDataButton.Click -= ImportDataButton_Click;
            //HeaderButton.Click -= HeaderButton_Click;
            //AnalyzeButton.PerformClick();
            //TotalRowsLabel.Text = Convert.ToString(ImportedDataGridView.Rows.Count - 1) + " Counts";
            //TotalRowsLabel.Visible = Visible;
        }
        #endregion




        List<string> HeaderNames = new List<string>();
        //List<string> WorkerNames = new List<string>();

        DataTable ImportedDataTable = new DataTable();
        DataColumn DataTableColumn;
        DataRow DataTableRow;
        DataView DataTableView;

        Boolean CreateDataTableHeader = true;


        #region Get Clipboard Data To DataTable and show in GridView
        private void GetClipboardDataToDataTable()
        {

            try
            {
                string CopiedContent = Clipboard.GetText();

                foreach (string row in CopiedContent.Split('\n'))
                {
                    string RowFix = row.Replace("\r", "");
                    string NewRowFix = row.Replace("\"", "");
                    //string NewRowFix = RowFix.Replace('"', ' ');


                    #region CreateDataTableHeader
                    if (CreateDataTableHeader.Equals(true))
                    {
                        string[] CopiedRowCells = NewRowFix.Split('\t');
                        //int i = 0;
                        foreach (string item in CopiedRowCells)
                        {
                            HeaderNames.Add(item);
                            DataTableColumn = new DataColumn();
                            DataTableColumn.DataType = System.Type.GetType("System.String");
                            DataTableColumn.ColumnName = item;
                            ImportedDataTable.Columns.Add(DataTableColumn);
                        }
                        //ImportedDataTable.Columns.Add("TimeDiff", typeof(string));
                        CreateDataTableHeader = false;
                    }
                    #endregion

                    #region CreateDataTableRows
                    else
                    {
                        //string EmptyRowTest = row.Replace("\t", "");
                        //EmptyRowTest = EmptyRowTest.Replace("\r", "");

                        //if (!string.IsNullOrEmpty(EmptyRowTest))
                        if (row != null)
                        {
                            string[] CopiedCells = row.Split('\t');

                            DataTableRow = ImportedDataTable.NewRow();
                            //if (CopiedCells.Length.Equals(15)) // fix row lenght ////////////////////////////////////////////////////////////////
                            //{
                                for (int i = 0; i < CopiedCells.Length; i++)
                                {
                                    string CleanCopiedCells = CopiedCells[i].Replace("\"", "");
                                    DataTableRow[HeaderNames[i]] = CleanCopiedCells;
                                }
                            //}
                            ImportedDataTable.Rows.Add(DataTableRow);

                            //#region Create Worker names List
                            //if (!WorkerNames.Contains(DataTableRow["Zähler"].ToString()) && DataTableRow["Zähler"].ToString() != string.Empty && DataTableRow["Zähler"].ToString() != null)
                            //{
                            //    WorkerNames.Add(DataTableRow["Zähler"].ToString());
                            //    WorkerNameComboBox.Items.Add(DataTableRow["Zähler"].ToString());
                            //}
                            //#endregion
                        }
                    }
                    #endregion
                }
                #region Show Data in GridView
                //DataTableView = new DataView(ImportedDataTable);
                //ImportedDataGridView.DataSource = DataTableView;
                DataTableView = new DataView(ImportedDataTable);
                //DataTableView.Sort = "Zähler Asc, Zählzeit Asc";
                ImportedDataGridView.DataSource = DataTableView;
                #endregion
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                mmmTest = "NotOk";
                //return;
                //ImportDataButton.Click -= ImportDataButton_Click;
                //if()
                //{

                //}
            }

        }

















        #endregion

        #region Insert Data Into DataBase


        private void InsertDataIntoDataBaseButton_Click(object sender, EventArgs e)
        {

        }



        #endregion






        #region Insert Header
        private void InsertHeaderButton_Click(object sender, EventArgs e)
        {

        }




        #endregion


    }
}
