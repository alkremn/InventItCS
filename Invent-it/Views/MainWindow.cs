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

        private const string DELETE_MESSAGE = "Are you sure you want to delete this item?";
        private const string WARNING = "Warning!";
        private const string SELECT_ITEM = "Please select item.";

        public MainWindow()
        {
            InitializeComponent();
            inventory.AddParts(new BindingList<Part>(Model.SimpleDataLoader.ReadSimplePartsFromCSV()));
            inventory.AddProducts(new BindingList<Product>(Model.SimpleDataLoader.ReadSimpleProductsFromCSV()));
            partsDataView.DataSource = inventory.Parts;
            prodDataView.DataSource = inventory.Products;
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            Part part = null;
            PartWindow partWindow = new PartWindow(part, inventory.GetNewPartId);
            partWindow.SaveButtonClickedEvent += HandleSaveButtonClickedEvent;
            partWindow.ShowDialog();
            partWindow.Dispose();
        }

        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
            if (partsDataView.SelectedRows.Count == 1)
            {
                var selected = (int)partsDataView.SelectedRows[0].Cells[0].Value;
                Part part = inventory.FindPartById(selected);

                PartWindow partWindow = new PartWindow(part, part.PartId);
                partWindow.SaveButtonClickedEvent += HandleSaveButtonClickedEvent;
                partWindow.ShowDialog();
                partWindow.Dispose();
            }
            else
            {
                MessageBox.Show(SELECT_ITEM);
            }
        }

        void HandleSaveButtonClickedEvent(object sender, SavePartEventArgs e)
        {
            inventory.AddPart(e.SavedPart);
            partsDataView.DataSource = inventory.Parts;
        }


        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            if (partsDataView.SelectedRows.Count == 1)
            {
                var result = MessageBox.Show(DELETE_MESSAGE, WARNING, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var selected = (int)partsDataView.SelectedRows[0].Cells[0].Value;
                    inventory.RemovePartByIndex(selected);
                }
            }
            else
            {
                MessageBox.Show(SELECT_ITEM);
            }
            
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            Product product = null;
            ProductWindow productWindow = new ProductWindow(product, inventory.GetNewProductId, 
                new BindingList<Part>(inventory.Parts));
            productWindow.ShowDialog();

        }

        private void ModifyProductButton_Click(object sender, EventArgs e)
        {
            if (prodDataView.SelectedRows.Count == 1)
            {
                var selected = (int)prodDataView.SelectedRows[0].Cells[0].Value;
                Product product = inventory.FindProductById(selected);

                ProductWindow productWindow = new ProductWindow(product, product.ProductId, 
                    new BindingList<Part>(inventory.Parts));
                productWindow.SaveButtonClickedEvent += HandleSaveButtonClickedEvent;
                productWindow.ShowDialog();
                productWindow.Dispose();
            }
            else
            {
                MessageBox.Show(SELECT_ITEM);
            }
        }

        private void DeleteProdButton_Click(object sender, EventArgs e)
        {
            if (prodDataView.SelectedRows.Count == 1)
            {
                var result = MessageBox.Show(DELETE_MESSAGE, WARNING, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var selected = (int)prodDataView.SelectedRows[0].Cells[0].Value;
                    inventory.RemoveProductByIndex(selected);
                    prodDataView.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show(SELECT_ITEM);
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Model.SimpleDataLoader.WriteSamplePartsToCSV(inventory.Parts);
            //Model.SimpleDataLoader.WriteSampleProductsToCSV(inventory.Products);
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
