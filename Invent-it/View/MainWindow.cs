﻿using System;
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
            inventory.Parts = Model.SimpleDataLoader.ReadSimplePartsFromCSV();
            inventory.Products = Model.SimpleDataLoader.ReadSimpleProductsFromCSV();
            PartsDataView.DataSource = inventory.Parts;
            ProdDataView.DataSource = inventory.Products;
            PartsDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProdDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
       
        private void AddPartButton_Click(object sender, EventArgs e)
        {

            PartWindow partWindow = new PartWindow("Add Part");
            partWindow.ShowDialog();
        }

        private void ModifyPartButton_Click(object sender, EventArgs e)
        {

        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            var selected = (int)PartsDataView.SelectedRows[0].Cells[0].Value;
            inventory.RemovePartByIndex(selected);
           
            var binding = PartsDataView.DataBindings;
            PartsDataView.Update();

        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            ProductWindow productWindow = new ProductWindow();
            productWindow.ShowDialog();

        }

        private void ModifyProductButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteProdButton_Click(object sender, EventArgs e)
        {

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Model.SimpleDataLoader.WriteSamplePartsToCSV(inventory.Parts);
            Model.SimpleDataLoader.WriteSampleProductsToCSV(inventory.Products);
            Environment.Exit(0);
        }

        private void SearchPartButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchProductButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void searchPartButton_Click(object sender, EventArgs e)
        {

        }
    }
}
