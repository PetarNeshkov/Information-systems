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
    public partial class FMWoods : MetroForm
    {
        public FMWoods()
        {
            InitializeComponent();
        }

        private void видBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.видBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.durvesinaDataSet);

        }

        private void видBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.видBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.durvesinaDataSet);

        }

        private void FMWoods_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'durvesinaDataSet.Клиенти' table. You can move, or remove it, as needed.
            this.клиентиTableAdapter.Fill(this.durvesinaDataSet.Клиенти);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Дървесина' table. You can move, or remove it, as needed.
            this.дървесинаTableAdapter.Fill(this.durvesinaDataSet.Дървесина);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Сортимент' table. You can move, or remove it, as needed.
            this.сортиментTableAdapter.Fill(this.durvesinaDataSet.Сортимент);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Категория' table. You can move, or remove it, as needed.
            this.категорияTableAdapter.Fill(this.durvesinaDataSet.Категория);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Вид' table. You can move, or remove it, as needed.
            this.видTableAdapter.Fill(this.durvesinaDataSet.Вид);

        }
    }
}
