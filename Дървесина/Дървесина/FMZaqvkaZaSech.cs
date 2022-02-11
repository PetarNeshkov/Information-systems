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
    public partial class FMZaqvkaZaSech : MetroForm
    {
        public FMZaqvkaZaSech()
        {
            InitializeComponent();
        }

        private void заявка_за_сеч_на_дървесинаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заявка_за_сеч_на_дървесинаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.durvesinaDataSet);

        }

        private void FMZaqvkaZaSech_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'durvesinaDataSet.Длъжности' table. You can move, or remove it, as needed.
            this.длъжностиTableAdapter.Fill(this.durvesinaDataSet.Длъжности);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Дървесина' table. You can move, or remove it, as needed.
            this.дървесинаTableAdapter.Fill(this.durvesinaDataSet.Дървесина);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Обект_и_складове' table. You can move, or remove it, as needed.
            this.обект_и_складовеTableAdapter.Fill(this.durvesinaDataSet.Обект_и_складове);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Вид' table. You can move, or remove it, as needed.
            this.видTableAdapter.Fill(this.durvesinaDataSet.Вид);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Фирми' table. You can move, or remove it, as needed.
            this.фирмиTableAdapter.Fill(this.durvesinaDataSet.Фирми);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Служители' table. You can move, or remove it, as needed.
            this.служителиTableAdapter.Fill(this.durvesinaDataSet.Служители);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Заявка_за_сеч_на_дървесина' table. You can move, or remove it, as needed.
            this.заявка_за_сеч_на_дървесинаTableAdapter.Fill(this.durvesinaDataSet.Заявка_за_сеч_на_дървесина);

        }
    }
}
