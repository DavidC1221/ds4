using CalcWinForms.Data;
using System.Windows.Forms;

namespace CalcWinForms.Forms
{
    public class HistoryForm : Form
    {
        public HistoryForm()
        {
            Text = "Historial de Cálculos";
            Width = 520;
            Height = 420;
            var grid = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            Controls.Add(grid);

            var repo = new CalculosRepository();
            grid.DataSource = repo.GetAll();
        }
    }
}