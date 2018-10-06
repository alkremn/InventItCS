using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace InventMS
{
    public partial class MainWindow : Form
    {
        public Inventory inventory = new Inventory();

        public MainWindow()
        {
            InitializeComponent();
            inventory.Parts = new BindingList<Part>(Model.SimpleDataLoader.ReadSimplePartsFromCSV());
            inventory.Products = new BindingList<Product>(Model.SimpleDataLoader.ReadSimpleProductsFromCSV());
            partsDataView.DataSource = inventory.Parts;
            prodDataView.DataSource = inventory.Products;
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {

            PartWindow partWindow = new PartWindow("Add Part");
            partWindow.ShowDialog();
        }

        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
            if (partsDataView.SelectedRows.Count > 0)
            {
                PartWindow partWindow = new PartWindow("Modify Part");
                partWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select Part to modify");
            }
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            if (partsDataView.SelectedRows.Count == 1)
            {
                var result = MessageBox.Show("Are you sure you want to delete this part?", "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var selected = (int)partsDataView.SelectedRows[0].Cells[0].Value;
                    try
                    {
                        inventory.RemovePartByIndex(selected);
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show($"Invalid Id {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select part to delete.");
            }
            
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            productWindow productWindow = new productWindow();
            productWindow.ShowDialog();

        }

        private void ModifyProductButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteProdButton_Click(object sender, EventArgs e)
        {
            if (prodDataView.SelectedRows.Count == 1)
            {
                var result = MessageBox.Show("Are you sure you want to delete this product?", "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var selected = (int)prodDataView.SelectedRows[0].Cells[0].Value;
                    try
                    {
                        inventory.RemoveProductByIndex(selected);
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show($"Invalid product ID {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select product to delete.");
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Model.SimpleDataLoader.WriteSamplePartsToCSV(inventory.Parts);
            Model.SimpleDataLoader.WriteSampleProductsToCSV(inventory.Products);
            Environment.Exit(0);
        }

        private void SearchPartButton_Click(object sender, EventArgs e)
        {
            SearchItemInList(searchPartText, partsDataView);
        }

        private void SearchProductButton_Click(object sender, EventArgs e)
        {
            SearchItemInList(searchProdText, prodDataView);

        }

        private void DataBindingCompleted(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            partsDataView.ClearSelection();
            prodDataView.ClearSelection();
        }

        private void SearchEnterKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.ConsoleKey.Enter)
            {
                if (searchPartText.Focused)
                {
                    SearchItemInList(searchPartText, partsDataView);
                    e.Handled = true;
                }
                if(searchProdText.Focused)
                {
                    SearchItemInList(searchProdText, prodDataView);
                    e.Handled = true;
                }
            }
           
        }

        private void SearchItemInList(TextBox searchBox, DataGridView dataGridView)
        {
            dataGridView.ClearSelection();

            if (searchBox.Text != "")
            {
                string searchWord = searchBox.Text;

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    string nameValue = row.Cells[1].Value.ToString();

                    if (nameValue.ToLower().Contains(searchWord))
                    {
                        row.Selected = true;
                    }
                }

            }
        }
    }
}
