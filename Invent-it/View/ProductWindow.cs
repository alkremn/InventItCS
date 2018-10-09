using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;

namespace InventMS
{
    public partial class ProductWindow : Form
    {
        public event EventHandler<SaveProductEventArgs> SaveButtonClickedEvent;

        private const string ADD_PRODUCT_LABEL = "Add Product";

        private BindingList<Part> availableParts;

        private BindingList<Part> productParts;

        private Product _product;

        private int _id;

        bool _isInvNumber = false;
        bool _isPriceNumber = false;
        bool _isMaxNumber = false;
        bool _isMinNumber = false;

        public ProductWindow(Product product, int id, BindingList<Part> parts)
        {
            _product = product;
            _id = id;
            InitializeComponent();
            availableParts = ModifyAvailableParts(parts);
            availablePartsList.DataSource = availableParts;

            if (_product != null)
            {
                InitModifyProductFields();
                productParts = _product.AssociatedParts;
            }
            else
            {
                productParts = new BindingList<Part>();
                productLabel.Text = ADD_PRODUCT_LABEL;
                nameText.BackColor = Color.LightCoral;
                invText.BackColor = Color.LightCoral;
                priceText.BackColor = Color.LightCoral;
                maxText.BackColor = Color.LightCoral;
                minText.BackColor = Color.LightCoral;
            }
            productPartList.DataSource = productParts;
            availablePartsList.ClearSelection();
        }

        void InitModifyProductFields()
        {
            idText.Text = _product.ProductId.ToString();
            nameText.Text = _product.ProductName;
            nameText.ForeColor = SystemColors.ControlText;
            invText.Text = _product.InStock.ToString();
            invText.ForeColor = SystemColors.ControlText;
            priceText.Text = _product.Price.ToString();
            priceText.ForeColor = SystemColors.ControlText;
            maxText.Text = _product.Max.ToString();
            maxText.ForeColor = SystemColors.ControlText;
            minText.Text = _product.Min.ToString();
            minText.ForeColor = SystemColors.ControlText;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var errors = IsAllInputValid();
            if (errors.Length == 0)
            {
                string name = nameText.Text;
                int inv = int.Parse(invText.Text);
                double price = double.Parse(priceText.Text);
                int max = int.Parse(maxText.Text);
                int min = int.Parse(minText.Text);

                _product = new Product(_id, name, price, inv, min, max)
                {
                    AssociatedParts = productParts
                };
                SaveButtonClickedEvent?.Invoke(this, new SaveProductEventArgs(_product));
                Close();
            }
            else
            {
                MessageBox.Show(errors.ToString(), "Error", MessageBoxButtons.OK);
            }
        }

        StringBuilder IsAllInputValid()
        {
            StringBuilder errors = new StringBuilder();

            if (nameText.Text == "")
            {
                errors.Append("Invalid product name.\n");
            }
            if (!_isInvNumber)
            {
                errors.Append("Invalid inv.\n");
            }
            if (!_isPriceNumber)
            {
                errors.Append("Invalid price.\n");
            }
            if (!_isMaxNumber)
            {
                errors.Append("Invalid max.\n");
            }
            if (!_isMinNumber)
            {
                errors.Append("Invalid min.\n");
            }
            int.TryParse(maxText.Text, out int intMax);
            int.TryParse(minText.Text, out int intMin);

            if (intMin > intMax)
            {
                errors.Append("Your minimum exceeds you maximum.\n");
            }
            if (productParts == null || productParts.Count == 0)
            {
                errors.Append("Product must have parts.");
            }
            return errors;
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            if (availablePartsList.SelectedRows.Count == 1)
            {
                var selected = (int)availablePartsList.SelectedRows[0].Cells[0].Value;
                Part part = FindPartById(selected, availableParts);

                if (part != null)
                {
                    availableParts.Remove(part);
                    productParts.Add(part);
                    productParts = SortPartsList(productParts);
                    productPartList.DataSource = productParts;
                    availablePartsList.ClearSelection();
                    productPartList.ClearSelection();
                }
            }
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            if (productPartList.SelectedRows.Count == 1)
            {
                var selected = (int)productPartList.SelectedRows[0].Cells[0].Value;
                Part part = FindPartById(selected, productParts);

                if (part != null)
                {
                    productParts.Remove(part);
                    availableParts.Add(part);
                    availableParts = SortPartsList(availableParts);
                    availablePartsList.DataSource = availableParts;
                    productPartList.ClearSelection();
                    availablePartsList.ClearSelection();
                }
            }
        }

        private void SearchPartButton_Click(object sender, EventArgs e)
        {
            availablePartsList.ClearSelection();
            if (searchBox.Text != "")
            {
                string searchWord = searchBox.Text;
                foreach (DataGridViewRow row in availablePartsList.Rows)
                {
                    string nameValue = row.Cells[1].Value.ToString();
                    if (nameValue.ToLower().Contains(searchWord))
                    {
                        row.Selected = true;
                    }
                }
            }
        }

        BindingList<Part> ModifyAvailableParts(BindingList<Part> parts)
        {
            if (_product != null)
            {
                BindingList<Part> associatedProductParts = _product.AssociatedParts;
                if (associatedProductParts != null && _product.AssociatedParts.Count != 0)
                {
                    foreach (Part prodPart in associatedProductParts)
                    {
                        Part foundPart = FindPartById(prodPart.PartId, parts);
                        if (foundPart != null)
                        {
                            parts.Remove(foundPart);
                        }
                    }
                }
            }
            return parts;
        }

        private Part FindPartById(int id, BindingList<Part> parts)
        {
            var partById = from part in parts where part.PartId == id select part;
            return partById.Any() ? partById.First() : null;
        }

        private BindingList<Part> SortPartsList(BindingList<Part> partsToSort)
        {
            List<Part> parts = new List<Part>(partsToSort);
            parts.Sort((first, second) => first.PartId.CompareTo(second.PartId));
            return new BindingList<Part>(parts);
        }

        private void NameText_Enter(object sender, EventArgs e)
        {
            nameText.BackColor = Color.White;
        }

        private void NameText_Leave(object sender, EventArgs e)
        {
            if (nameText.Text == "")
            {
                nameText.BackColor = Color.LightCoral;
            }
        }

        private void InvText_Enter(object sender, EventArgs e)
        {
            invText.BackColor = Color.White;
        }

        private void InvText_Leave(object sender, EventArgs e)
        {
            if (invText.Text == "" || !int.TryParse(invText.Text, out int intValue))
            {
                invText.BackColor = Color.LightCoral;
            }
        }

        private void PriceText_Enter(object sender, EventArgs e)
        {
            priceText.BackColor = Color.White;
        }

        private void PriceText_Leave(object sender, EventArgs e)
        {
            if (priceText.Text == "" || !double.TryParse(priceText.Text, out double intValue))
            {
                priceText.BackColor = Color.LightCoral;
            }
        }

        private void MaxText_Enter(object sender, EventArgs e)
        {
            maxText.BackColor = Color.White;
        }

        private void MaxText_Leave(object sender, EventArgs e)
        {
            if (maxText.Text == "" || !int.TryParse(maxText.Text, out int intValue))
            {
                maxText.BackColor = Color.LightCoral;
            }
        }

        private void MinText_Enter(object sender, EventArgs e)
        {
            minText.BackColor = Color.White;
        }

        private void MinText_Leave(object sender, EventArgs e)
        {
            if (minText.Text == "" || !int.TryParse(minText.Text, out int intValue))
            {
                minText.BackColor = Color.LightCoral;
            }
        }

        private void InvText_Changed(object sender, EventArgs e)
        {
            if (invText.Text != "" && !int.TryParse(invText.Text, out int inValue))
            {
                _isInvNumber = false;
                invText.BackColor = Color.LightCoral;
            }
            else
            {
                _isInvNumber = true;
                invText.BackColor = Color.White;
            }

        }

        private void PriceText_Changed(object sender, EventArgs e)
        {
            if (priceText.Text != "" && !double.TryParse(priceText.Text, out double intValue))
            {
                _isPriceNumber = false;
                priceText.BackColor = Color.LightCoral;
            }
            else
            {
                _isPriceNumber = true;
                priceText.BackColor = Color.White;
            }
        }

        private void MaxText_Changed(object sender, EventArgs e)
        {
            if (maxText.Text != "" && !int.TryParse(maxText.Text, out int intValue))
            {
                _isMaxNumber = false;
                maxText.BackColor = Color.LightCoral;
            }
            else
            {
                _isMaxNumber = true;
                maxText.BackColor = Color.White;
            }
        }

        private void MinText_Changed(object sender, EventArgs e)
        {
            if (minText.Text != "" && !int.TryParse(minText.Text, out int intValue))
            {
                _isMinNumber = false;
                minText.BackColor = Color.LightCoral;
            }
            else
            {
                _isMinNumber = true;
                minText.BackColor = Color.White;
            }
        }
    }

    public class SaveProductEventArgs : EventArgs
    {
        public Product SavedProudct { get; set; }

        public SaveProductEventArgs(Product savedProudct)
        {
            SavedProudct = savedProudct;
        }
    }
}
