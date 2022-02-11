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
    public partial class FMVehicles : MetroForm
    {
        public FMVehicles()
        {
            InitializeComponent();
        }

        private void превозни_средстваBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.превозни_средстваBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.durvesinaDataSet);

        }

        private void FMVehicles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'durvesinaDataSet.Превозни_средства' table. You can move, or remove it, as needed.
            this.превозни_средстваTableAdapter.Fill(this.durvesinaDataSet.Превозни_средства);

        }
    }
}
