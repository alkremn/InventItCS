using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventMS
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            PartsDataView.DataSource = Model.SimpleDataLoader.GetSimpleParts();
            ProdDataView.DataSource = Model.SimpleDataLoader.GetSimpleProducts();
            PartsDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProdDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

 
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            PartWindow partWindow = new PartWindow("Modify Part");
            partWindow.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            PartWindow partWindow = new PartWindow("Add Part");
            partWindow.ShowDialog();
        }

        private void partBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
