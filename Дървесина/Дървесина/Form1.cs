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
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            new FMClients().ShowDialog();
           
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            new FMEmployeescs().ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            new FMFirms().ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            new FMVehicles().ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            new FMObjects().ShowDialog();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            new FMWoods().ShowDialog();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            new FMZaqvkaZaPokupka().ShowDialog();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            new FMZaqvkaZaSech().ShowDialog();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            new FMFaktura().ShowDialog();
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            new FMPrevozenBilet().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
