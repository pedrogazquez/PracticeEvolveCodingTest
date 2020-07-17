using System;
using System.Globalization;
using System.Windows.Forms;

namespace PracticeEvolveCodingTest
{
    public class DataGridHelper : IDataGridHelper
    {
        private const string ActiveStatus = "Active";
        private const string StateCol = "state";
        private const string TitleCol = "title";
        private const string TypeCol = "type";
        private const string DurationCol = "duration";
        private const string HourlyRateCol = "hourlyRate";

        public double CalculateTotalCharge(DateTime duration, double hourlyRate)
        {
            duration = TimeRoundUp(duration);
            double totalDuration = duration.Hour + Convert.ToDouble(duration.Minute, CultureInfo.InvariantCulture) / 60;

            return totalDuration * hourlyRate;
        }

        public void CancelAction(DataGridView dataGridView, int index)
        {
            if (!dataGridView.Rows[index].IsNewRow)
            {
                dataGridView.Rows.RemoveAt(index);
            }
        }

        public void EditAction(DataGridViewRow editedRow)
        {
            editedRow.Cells[TitleCol].ReadOnly = false;
            editedRow.Cells[TypeCol].ReadOnly = false;
            editedRow.Cells[DurationCol].ReadOnly = false;
            editedRow.Cells[HourlyRateCol].ReadOnly = false;
        }

        public void DeleteAction(DataGridView dataGridView, int index)
        {
            if (MessageBox.Show("Are you sure you want to delete this tmesheet entry?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!dataGridView.Rows[index].IsNewRow)
                {
                    dataGridView.Rows.RemoveAt(index);
                }
            }
        }

        private DateTime TimeRoundUp(DateTime duration)
        {
            return new DateTime(duration.Year, duration.Month, duration.Day, duration.Hour, duration.Minute, 0).AddMinutes(duration.Minute % 15 == 0 ? 0 : 15 - duration.Minute % 15);
        }

        public void SaveAction(DataGridViewRow savedRow)
        {
            savedRow.Cells[StateCol].Value = ActiveStatus;
        }
    }
}
