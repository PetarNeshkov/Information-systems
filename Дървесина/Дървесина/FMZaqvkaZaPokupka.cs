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
    public partial class FMZaqvkaZaPokupka : MetroForm
    {
        public FMZaqvkaZaPokupka()
        {
            InitializeComponent();
        }

        private void заявка_за_покупка_на_дървесинаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заявка_за_покупка_на_дървесинаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.durvesinaDataSet);

        }

        private void FMZaqvkaZaPokupka_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'durvesinaDataSet.Вид' table. You can move, or remove it, as needed.
            this.видTableAdapter.Fill(this.durvesinaDataSet.Вид);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Клиенти' table. You can move, or remove it, as needed.
            this.клиентиTableAdapter.Fill(this.durvesinaDataSet.Клиенти);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Заявка_за_покупка_на_дървесина' table. You can move, or remove it, as needed.
            this.заявка_за_покупка_на_дървесинаTableAdapter.Fill(this.durvesinaDataSet.Заявка_за_покупка_на_дървесина);

        }
    }
}
