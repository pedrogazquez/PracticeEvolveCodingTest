using System;
using System.Windows.Forms;

namespace PracticeEvolveCodingTest
{
    public interface IDataGridHelper
    {
        double CalculateTotalCharge(DateTime duration, double hourlyRate);
        void SaveAction(DataGridViewRow savedRow);
        void CancelAction(DataGridView dataGridView, int index);
        void EditAction(DataGridViewRow editedRow);
        void DeleteAction(DataGridView dataGridView, int index);
    }
}
