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
    public partial class ProductWindow : Form
    {
        public event EventHandler<SavePartEventArgs> SaveButtonClickedEvent;

        private const string ADD_PRODUCT_LABEL = "Add Product";

        private BindingList<Part> availableParts;

        private BindingList<Part> productParts;

        Product _product;

        int _id;

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
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {

        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {

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
                        var samePart = from part in parts where part.PartId == prodPart.PartId select part;
                        if (samePart.Any())
                        {
                            parts.Remove(samePart.First());
                        }
                    }
                }
            }
            return parts;
        }
    }

    public class SaveProductEventArgs : EventArgs
    {

        public Part SavedProudct { get; set; }

        public SaveProductEventArgs(Part savedProudct)
        {
            SavedProudct = savedProudct;
        }

    }


}
