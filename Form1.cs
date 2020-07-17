using System;
using System.Globalization;
using System.Windows.Forms;

namespace PracticeEvolveCodingTest
{
    public partial class Form1 : Form
    {
        private const string SubmittedStatus = "Submitted";
        private const string StateCol = "state";
        private const string TitleCol = "title";
        private const string TypeCol = "type";
        private const string DurationCol = "duration";
        private const string HourlyRateCol = "hourlyRate";
        private const string TotalCol = "total";

        private readonly IDataGridHelper _dataGridHelper;


        public Form1()
        {
            InitializeComponent();
            _dataGridHelper = new DataGridHelper();
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[StateCol].ReadOnly = false;
            e.Row.Cells[HourlyRateCol].Value = this.defaultHourlyRateBox.Text;
            e.Row.Cells["leftButton"].Value = "Save";
            e.Row.Cells["rightButton"].Value = "Cancel";
        }

        private void newButtom_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Insert(0);
            this.dataGridView1.Rows[0].Cells[HourlyRateCol].Value = this.defaultHourlyRateBox.Text;
            this.dataGridView1.Rows[0].Cells["leftButton"].Value = "Save";
            this.dataGridView1.Rows[0].Cells["rightButton"].Value = "Cancel";
        }

        private void submitButtom_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow selectedRow in this.dataGridView1.SelectedRows)
                {
                    selectedRow.Cells[StateCol].Value = SubmittedStatus;
                    MakeAllRowReadOnly(selectedRow);
                }
            }
        }

        private void MakeAllRowReadOnly(DataGridViewRow selectedRow)
        {
            selectedRow.Cells[StateCol].ReadOnly = true;
            selectedRow.Cells[TitleCol].ReadOnly = true;
            selectedRow.Cells[TypeCol].ReadOnly = true;
            selectedRow.Cells[DurationCol].ReadOnly = true;
            selectedRow.Cells[HourlyRateCol].ReadOnly = true;
            selectedRow.Cells[TotalCol].ReadOnly = true;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && (e.ColumnIndex == 3 || e.ColumnIndex == 4))
            {
                DataGridViewRow viewRow = this.dataGridView1.Rows[e.RowIndex];
                var duration = viewRow.Cells[DurationCol].Value;
                var hourlyRate = viewRow.Cells[HourlyRateCol].Value;

                if(duration != null && hourlyRate != null)
                {
                    NumberFormatInfo nfi = new NumberFormatInfo();
                    nfi.NumberDecimalSeparator = ".";

                    viewRow.Cells[TotalCol].Value =
                        _dataGridHelper.CalculateTotalCharge(Convert.ToDateTime(duration), Convert.ToDouble(hourlyRate, CultureInfo.InvariantCulture)).ToString(nfi);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = this.dataGridView1.Rows[e.RowIndex];

            if(e.ColumnIndex == 6)
            {
                if (currentRow.Cells["leftButton"].Value.ToString() == "Save")
                {
                    _dataGridHelper.SaveAction(currentRow);
                    currentRow.Cells["leftButton"].Value = "Edit";
                    currentRow.Cells["rightButton"].Value = "Delete";
                }
                else if (currentRow.Cells["leftButton"].Value.ToString() == "Edit")
                {
                    _dataGridHelper.EditAction(currentRow);
                }
            }
            else if(e.ColumnIndex == 7)
            {
                if (currentRow.Cells["rightButton"].Value.ToString() == "Cancel")
                {
                    _dataGridHelper.CancelAction(this.dataGridView1, e.RowIndex);
                }
                else if (currentRow.Cells["rightButton"].Value.ToString() == "Delete")
                {
                    _dataGridHelper.DeleteAction(this.dataGridView1, e.RowIndex);
                }
            }


        }
    }
}
