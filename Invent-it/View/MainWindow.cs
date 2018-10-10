using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
            PartWindow partWindow = new PartWindow(part, inventory, inventory.GetNewPartId);
            partWindow.ShowDialog();
            partsDataView.DataSource = inventory.Parts;
            partWindow.Dispose();
        }

        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
            if (partsDataView.SelectedRows.Count == 1)
            {
                var selected = (int)partsDataView.SelectedRows[0].Cells[0].Value;
                Part part = inventory.FindPartById(selected);
                PartWindow partWindow = new PartWindow(part, inventory, part.PartId);
                partWindow.ShowDialog();
                partsDataView.DataSource = inventory.Parts;
                partWindow.Dispose();
            }
            else
            {
                MessageBox.Show(SELECT_ITEM);
            }
        }

        void HandleSaveProductButtonClickedEvent(object sender, SaveProductEventArgs e)
        {
            inventory.AddProduct(e.SavedProudct);
            prodDataView.DataSource = inventory.Products;
        }

        void HandleSavePartButtonClickedEvent(object sender, SavePartEventArgs e)
        {
            inventory.AddPart(e.SavedPart);
            
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
                new BindingList<Part>(inventory.Parts.ToList()));
            productWindow.SaveButtonClickedEvent += HandleSaveProductButtonClickedEvent;
            productWindow.ShowDialog();
            productWindow.Dispose();
        }

        private void ModifyProductButton_Click(object sender, EventArgs e)
        {
            if (prodDataView.SelectedRows.Count == 1)
            {
                var selected = (int)prodDataView.SelectedRows[0].Cells[0].Value;
                Product product = inventory.FindProductById(selected);
                ProductWindow productWindow = new ProductWindow(product, product.ProductId,
                    new BindingList<Part>(inventory.Parts.ToList()));
                productWindow.SaveButtonClickedEvent += HandleSaveProductButtonClickedEvent;
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
            Environment.Exit(0);
        }

        private void SearchPartButton_Click(object sender, EventArgs e)
        {
            SearchPartInList(searchPartText.Text, inventory.Parts);
        }

        private void SearchProductButton_Click(object sender, EventArgs e)
        {
            SearchProductInList(searchProdText.Text, inventory.Products);
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
                    SearchPartInList(searchPartText.Text, inventory.Parts);
                    e.Handled = true;
                }
                if (searchProdText.Focused)
                {
                    SearchProductInList(searchProdText.Text, inventory.Products);
                    e.Handled = true;
                }
            }
        }

        private void SearchPartInList(string searchPhrase, BindingList<Part> parts)
        {
            partsDataView.ClearSelection();
            if (searchPhrase != "")
            {
                var foundParts = from part in parts
                                 where part.PartName.ToLower().Contains(searchPhrase.ToLower()) select part;
                if (foundParts.Any())
                {
                    foreach (Part foundPart in foundParts)
                    {
                        foreach (DataGridViewRow row in partsDataView.Rows)
                        {
                            string partName= row.Cells[1].Value.ToString();
                            if (partName.Equals(foundPart.PartName))
                            {
                                row.Selected = true;
                            }
                        }
                    }
                }
            }
        }

        private void SearchProductInList(string searchPhrase, BindingList<Product> products)
        {
            prodDataView.ClearSelection();
            if (searchPhrase != "")
            {
                var foundProducts = from product in products
                                 where product.ProductName.ToLower().Contains(searchPhrase.ToLower()) select product;
                if (foundProducts.Any())
                {
                    foreach (Product foundProduct in foundProducts)
                    {
                        foreach (DataGridViewRow row in prodDataView.Rows)
                        {
                            string productName = row.Cells[1].Value.ToString();
                            if (productName.Equals(foundProduct.ProductName))
                            {
                                row.Selected = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
