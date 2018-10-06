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
    public partial class PartWindow : Form
    {
        public string Label { get; set; }

        public PartWindow(string title)
        {
            Label = title;
            InitializeComponent();
            outsourced.Select();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RadButtonCheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Name.Equals(nameof(inHouse)))
            {
                compIdLabel.Text = "Machine ID";
            }
            else
            {
                compIdLabel.Text = "Company Name";
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void NameText_Enter(object sender, EventArgs e)
        {
            if(nameText.Text == "Name")
                nameText.Text = "";

            nameText.ForeColor = Color.Black;
        }

        private void NameText_Leave(object sender, EventArgs e)
        {
            if (nameText.Text == "")
            {
                nameText.Text = "Name";
                nameText.ForeColor = SystemColors.ControlDark;
            }
        }

        private void InvText_Enter(object sender, EventArgs e)
        {
            if (invText.Text == "Inv")
                invText.Text = "";

            invText.ForeColor = Color.Black;

        }

        private void InvText_Leave(object sender, EventArgs e)
        {
            if (invText.Text == "")
            {
                invText.Text = "Inv";
                invText.ForeColor = SystemColors.ControlDark;
            }

        }

        private void PriceText_Enter(object sender, EventArgs e)
        {
            if (priceText.Text == "Price")
                priceText.Text = "";

            priceText.ForeColor = Color.Black;

        }

        private void PriceText_Leave(object sender, EventArgs e)
        {
            if (priceText.Text == "")
            {
                priceText.Text = "Price";
                priceText.ForeColor = SystemColors.ControlDark;
            }
        }

        private void MaxText_Enter(object sender, EventArgs e)
        {
            if (maxText.Text == "Max")
                maxText.Text = "";

            maxText.ForeColor = Color.Black;
        }

        private void MaxText_Leave(object sender, EventArgs e)
        {
            if (maxText.Text == "")
            {
                maxText.Text = "Max";
                maxText.ForeColor = SystemColors.ControlDark;
            }
        }

        private void MinText_Enter(object sender, EventArgs e)
        {
            if (minText.Text == "Min")
                minText.Text = "";

            minText.ForeColor = Color.Black;
        }

        private void MinText_Leave(object sender, EventArgs e)
        {
            if (minText.Text == "")
            {
                minText.Text = "Min";
                minText.ForeColor = SystemColors.ControlDark;
            }
        }

        private void CompIDText_Enter(object sender, EventArgs e)
        {
            if (compIdText.Text == "Company Name")
                compIdText.Text = "";

            compIdText.ForeColor = Color.Black;
        }

        private void CompIDText_Leave(object sender, EventArgs e)
        {
            if (compIdText.Text == "")
            {
                compIdText.Text = "Company Name";
                compIdText.ForeColor = SystemColors.ControlDark;
            }
        }

        private void PriceText_Changed(object sender, EventArgs e)
        {
            if (priceText.Text != "")
            {
                if (priceText.Text != "Price")
                {
                    if (!double.TryParse(priceText.Text, out double tempValue))
                    {
                        priceText.BackColor = Color.Red;
                    }
                    else
                    {
                        priceText.BackColor = SystemColors.Window;
                    }
                }
            }
            else
            {
                priceText.BackColor = SystemColors.Window;
            }
            
        }

       
    }
}
