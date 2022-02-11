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
    public partial class FMObjects : MetroForm
    {
        public FMObjects()
        {
            InitializeComponent();
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
            tTotal.Text = sum.ToString("0.00 т.");
        }

        private void обект_Склад___дървесинаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.обект_Склад___дървесинаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.durvesinaDataSet);

        }

        private void обект_Склад___дървесинаBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.обект_Склад___дървесинаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.durvesinaDataSet);

        }

        private void FMObjects_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'durvesinaDataSet.Вид' table. You can move, or remove it, as needed.
            this.видTableAdapter.Fill(this.durvesinaDataSet.Вид);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Дървесина' table. You can move, or remove it, as needed.
            this.дървесинаTableAdapter.Fill(this.durvesinaDataSet.Дървесина);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Обект_Склад___дървесина' table. You can move, or remove it, as needed.
            this.обект_Склад___дървесинаTableAdapter.Fill(this.durvesinaDataSet.Обект_Склад___дървесина);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Обект_и_складове' table. You can move, or remove it, as needed.
            this.обект_и_складовеTableAdapter.Fill(this.durvesinaDataSet.Обект_и_складове);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Обект_и_складове' table. You can move, or remove it, as needed.
            this.обект_и_складовеTableAdapter.Fill(this.durvesinaDataSet.Обект_и_складове);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Обект_и_складове' table. You can move, or remove it, as needed.
            this.обект_и_складовеTableAdapter.Fill(this.durvesinaDataSet.Обект_и_складове);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Сортимент' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'durvesinaDataSet.Обект_Склад___дървесина' table. You can move, or remove it, as needed.
            this.обект_Склад___дървесинаTableAdapter.Fill(this.durvesinaDataSet.Обект_Склад___дървесина);
            TotalQuantity(обект_Склад___дървесинаMetroGrid, textBox1, 1);

        }


        private void обект_и_складовеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.обект_и_складовеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.durvesinaDataSet);

        }

        private void обект_и_складовеBindingSource_PositionChanged(object sender, EventArgs e)
        {

            TotalQuantity(обект_Склад___дървесинаMetroGrid, textBox1, 1);
        }
    }
}
