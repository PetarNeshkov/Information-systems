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
    public partial class FMEmployeescs : MetroForm
    {
        public FMEmployeescs()
        {
            InitializeComponent();
        }

        private void служителиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.служителиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.durvesinaDataSet);

        }

        private void служителиBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.служителиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.durvesinaDataSet);

        }

        private void FMEmployeescs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'durvesinaDataSet2.Длъжности' table. You can move, or remove it, as needed.
            this.длъжностиTableAdapter.Fill(this.durvesinaDataSet2.Длъжности);
            // TODO: This line of code loads data into the 'durvesinaDataSet2.Служители' table. You can move, or remove it, as needed.
            this.служителиTableAdapter.Fill(this.durvesinaDataSet2.Служители);
            // TODO: This line of code loads data into the 'durvesinaDataSet2.Длъжности' table. You can move, or remove it, as needed.
            this.длъжностиTableAdapter.Fill(this.durvesinaDataSet2.Длъжности);
            // TODO: This line of code loads data into the 'durvesinaDataSet2.Служители' table. You can move, or remove it, as needed.
            this.служителиTableAdapter.Fill(this.durvesinaDataSet2.Служители);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Длъжности' table. You can move, or remove it, as needed.
            this.длъжностиTableAdapter.Fill(this.durvesinaDataSet.Длъжности);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Длъжности' table. You can move, or remove it, as needed.
            this.длъжностиTableAdapter.Fill(this.durvesinaDataSet.Длъжности);
            // TODO: This line of code loads data into the 'durvesinaDataSet.Служители' table. You can move, or remove it, as needed.
            this.служителиTableAdapter.Fill(this.durvesinaDataSet.Служители);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.служителиTableAdapter.FillBy(this.durvesinaDataSet.Служители);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.служителиTableAdapter.FillBy(this.durvesinaDataSet.Служители);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
