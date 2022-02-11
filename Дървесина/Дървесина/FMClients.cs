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
    public partial class FMClients : MetroForm
    {
        public FMClients()
        {
            InitializeComponent();
        }

        private void клиентиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.durvesinaDataSet);

        }

        private void FMClients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'durvesinaDataSet.Клиенти' table. You can move, or remove it, as needed.
            this.клиентиTableAdapter.Fill(this.durvesinaDataSet.Клиенти);

        }
    }
}
