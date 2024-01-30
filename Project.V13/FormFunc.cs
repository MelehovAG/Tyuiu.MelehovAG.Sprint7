using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ComponentFactory.Krypton.Toolkit;

using Project.V13.Lib;

namespace Project.V13
{
    public partial class FormFunc : KryptonForm
    {
        public FormFunc()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        public string filePath { get; set; }
        private bool deleterows = false;

        private void DynamicSearch(string searchText)
        {
            StringBuilder filterExpression = new StringBuilder();

            var columnNames = DataGridView_MAG.Columns.Cast<DataGridViewColumn>().Select(c => c.Name).ToArray();

            foreach (var columnName in columnNames)
            {
                if (filterExpression.Length > 0)
                    filterExpression.Append(" OR ");

                filterExpression.AppendFormat("[{0}] LIKE '%{1}%'", columnName, searchText);
            }

            (DataGridView_MAG.DataSource as DataTable).DefaultView.RowFilter = filterExpression.ToString();
        }

        private void ShowSuccessMessage(string message)
        {
            textBoxSuccessSave_MAG.Text = message;

            Timer timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += (sender, e) =>
            {
                textBoxSuccessSave_MAG.Text = "";
                timer.Stop();
            };
            timer.Start();
        }

        private void AddDataToChart(string busNumber, double value)
        {
            if (chartAverage_MAG.Series.FindByName(busNumber) == null)
            {
                chartAverage_MAG.Series.Add(busNumber);
                chartAverage_MAG.Series[busNumber].ChartType = SeriesChartType.Column;

                if (chartAverage_MAG.Series.Count > 1)
                {
                    chartAverage_MAG.Series[busNumber].IsValueShownAsLabel = true;
                }
            }

            DataPoint dataPoint = new DataPoint();
            dataPoint.SetValueXY(busNumber, value);
            dataPoint.Label = busNumber;

            chartAverage_MAG.Series[busNumber].Points.Add(dataPoint);
        }

        private void FormFunc_Load(object sender, EventArgs e)
        {
            DataTable dataTable = LoadDataFromFile(filePath);
            DataGridView_MAG.DataSource = dataTable;

            DataGridView_MAG.Columns[2].Width = 150;
            DataGridView_MAG.Columns[3].Width = 150;
            DataGridView_MAG.Columns[5].Width = 150;

            this.Text = "Файл: " + System.IO.Path.GetFileName(filePath);

            textBoxCountRows_MAG.Text = "Кол-во строк: " + Convert.ToString(ds.СountRows(filePath)) + " шт.";
            textBoxCountColumn_MAG.Text = "Кол-во столбцев: " + Convert.ToString(ds.CountColumns(filePath)) + " шт.";
            textBoxMin_MAG.Text = "Минимальное кол-во населения: " + Convert.ToString(ds.MinTime(filePath)) + " чел.";
            textBoxMax_MAG.Text = "Максимальное кол-во населения: " + Convert.ToString(ds.MaxTime(filePath)) + " чел.";
            textBoxAverage_MAG.Text = "В среднем в одной стране живет: " + Convert.ToString(ds.AverageTime(filePath)) + " чел.";

            int busNumberColumnIndex = DataGridView_MAG.Columns["Площадь территории (кв. км.)"].Index;
            int valueColumnIndex = DataGridView_MAG.Columns["Количество населения (чел.)"].Index;
            chartAverage_MAG.Titles.Add("Сравнение площади территорий:");

            chartAverage_MAG.ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
            chartAverage_MAG.ChartAreas[0].AxisY.MajorTickMark.Enabled = false;
            chartAverage_MAG.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chartAverage_MAG.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
            chartAverage_MAG.ChartAreas[0].AxisX.MajorGrid.Enabled = false; 
            chartAverage_MAG.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            foreach (DataGridViewRow row in DataGridView_MAG.Rows)
            {
                if (row.Cells[busNumberColumnIndex].Value != null && row.Cells[valueColumnIndex].Value != null)
                {
                    string busNumber = row.Cells[busNumberColumnIndex].Value.ToString();
                    double value = Convert.ToDouble(row.Cells[valueColumnIndex].Value);

                    AddDataToChart(busNumber, value);
                }
            }
            DataGridView_MAG.AllowUserToDeleteRows = false;
        }

        private DataTable LoadDataFromFile(string filePath)
        {
            DataTable dataTable = new DataTable();

            List<string[]> rows = new List<string[]>();

            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] values = line.Split(';');
                    rows.Add(values);
                }
            }

            foreach (var header in rows.First())
            {
                dataTable.Columns.Add(header);
            }

            foreach (var row in rows.Skip(1))
            {
                if (row.All(string.IsNullOrWhiteSpace))
                    continue;
                dataTable.Rows.Add(row);
            }


            return dataTable;
        }

        private void ButtonSaveFile_MAG_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)DataGridView_MAG.DataSource;

            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                writer.WriteLine(string.Join(";", dataTable.Columns.Cast<DataColumn>().Select(col => col.ColumnName)));

                foreach (DataRow row in dataTable.Rows)
                {
                    writer.WriteLine(string.Join(";", row.ItemArray));
                }
            }
            ShowSuccessMessage("Содержимое успешно сохранено по следующему пути: " + filePath);
        }

        private void ButtonRedact_MAG_Click(object sender, EventArgs e)
        {

            DataGridView_MAG.AllowUserToDeleteRows = true;
            ButtonRedact_MAG.Enabled = false;
            ButtonApply_MAG.Enabled = true;
            DataGridView_MAG.ReadOnly = false;
        }

        private void ButtonApply_MAG_Click(object sender, EventArgs e)
        {
            DataGridView_MAG.AllowUserToDeleteRows = false;
            ButtonRedact_MAG.Enabled = true;
            ButtonApply_MAG.Enabled = false;
            DataGridView_MAG.ReadOnly = true;
            textBoxCountRows_MAG.Text = "Кол-во строк: " + (DataGridView_MAG.RowCount - 1);
            textBoxCountColumn_MAG.Text = "Кол-во столбцев: " + DataGridView_MAG.ColumnCount;
        }


        private void ButtonSearch_MAG_Click(object sender, EventArgs e)
        {
            DynamicSearch(TextBoxSearch_MAG.Text);
        }

        private void chartAverage_MAG_Click(object sender, EventArgs e)
        {

        }
    }
}
