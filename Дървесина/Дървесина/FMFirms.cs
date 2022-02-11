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
    public partial class FMFirms : MetroForm
    {
        public FMFirms()
        {
            InitializeComponent();
        }

        private void фирмиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.фирмиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.durvesinaDataSet);

        }

        private void FMFirms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'durvesinaDataSet.Фирми' table. You can move, or remove it, as needed.
            this.фирмиTableAdapter.Fill(this.durvesinaDataSet.Фирми);

        }
    }
}
