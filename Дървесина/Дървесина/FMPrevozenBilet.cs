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
    public partial class FMPrevozenBilet : MetroForm
    {
        public FMPrevozenBilet()
        {
            InitializeComponent();
        }

        private void превозен_билетBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.превозен_билетBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.durvesinaDataSet);

        }

        private void превозен_билетBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.превозен_билетBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.durvesinaDataSet);

        }

        private void FMPrevozenBilet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'durvesinaDataSet.Фактура' table. You can move, or remove it, as needed.
            this.фактураTableAdapter.Fill(this.durvesinaDataSet.Фактура);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Клиенти' table. You can move, or remove it, as needed.
            this.клиентиTableAdapter.Fill(this.durvesinaDataSet.Клиенти);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Служители' table. You can move, or remove it, as needed.
            this.служителиTableAdapter.Fill(this.durvesinaDataSet.Служители);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Превозен_билет' table. You can move, or remove it, as needed.
            this.превозен_билетTableAdapter.Fill(this.durvesinaDataSet.Превозен_билет);
            textBox1.Text = "В цената е включена доставка: 50лв.";
            textBox1.TextAlign = HorizontalAlignment.Center;

        }
    }
}
