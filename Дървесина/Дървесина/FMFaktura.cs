using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Дървесина
{
    public partial class FMFaktura : MetroForm
    {
        public FMFaktura()
        {
            InitializeComponent();
        }

        private void фактураBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.фактураBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.durvesinaDataSet);

        }
        private void TotalQuantity(MetroGrid mgr, TextBox tTotal, int quantityColumn)
        {
            double sum = 0;
            int cQty = 0;
            for (int i = 0; i < mgr.RowCount - 1; i++)
            {
                if (mgr[quantityColumn, i].Value is DBNull) cQty = 0;
                else cQty = Convert.ToInt32(mgr[quantityColumn, i].Value.ToString());
                sum += cQty;
            }
            tTotal.Text = sum.ToString("0.00 лв.");
        }
        private void FMFaktura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'durvesinaDataSet.Превозен_билет' table. You can move, or remove it, as needed.
            this.превозен_билетTableAdapter.Fill(this.durvesinaDataSet.Превозен_билет);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Дървесина' table. You can move, or remove it, as needed.
            this.дървесинаTableAdapter.Fill(this.durvesinaDataSet.Дървесина);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Обект_и_складове' table. You can move, or remove it, as needed.
            this.обект_и_складовеTableAdapter.Fill(this.durvesinaDataSet.Обект_и_складове);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Вид' table. You can move, or remove it, as needed.
            this.видTableAdapter.Fill(this.durvesinaDataSet.Вид);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Служители' table. You can move, or remove it, as needed.
            this.служителиTableAdapter.Fill(this.durvesinaDataSet.Служители);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Фактура' table. You can move, or remove it, as needed.
            this.фактураTableAdapter.Fill(this.durvesinaDataSet.Фактура);
            TotalQuantity(фактураMetroGrid, textBox1, 6);

        }

        private void фактураBindingSource_PositionChanged(object sender, EventArgs e)
        {
            TotalQuantity(фактураMetroGrid, textBox1, 6);
        }
    }
}
