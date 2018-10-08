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
    public delegate void SavePartEventHandler(ref Part part);

    public partial class PartWindow : Form
    {
        public event SavePartEventHandler SavePartEvent;

        public string Label { get; set; }

        private Part _part;

        private int _id;

        public PartWindow(string title, ref Part part, int id)
        {
            Label = title;
            _part = part;
            _id = id;

            InitializeComponent();

            nameLabel.Focus();

            if (_part != null)
            {
                InitFields();
            }
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
                if(compIdText.Text == "" || compIdText.Text == "Company Name")
                {
                    compIdText.Text = "Machine ID";
                }
            }
            else
            {
                compIdLabel.Text = "Company Name";
                if (compIdText.Text == "" || compIdText.Text == "Machine ID")
                {
                    compIdText.Text = "Company Name";
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (GatherInfoFromFields())
            {
                Part part = null;
                //Raise an event
                SavePartEvent(ref part);
                this.Close();
            }
        }

        bool GatherInfoFromFields()
        {
            StringBuilder error = new StringBuilder();
            string name;

            if (nameText.Text != "" && nameText.Text != "Name")
            {
                name = nameText.Text;
            }
            else
            {
                error.Append("Invalid Name!\n");
            }

            if (IsPriceFieldValid())
            {
                double.TryParse(priceText.Text, out double price);
            }

            if (invText.Text != "" && invText.Text != "Inv")
            {
                int.TryParse(invText.Text, out int inv);
            }
            else
            {
                error.Append("Invalid Inventory!\n");
            }

            if (maxText.Text != "" && maxText.Text != "Max")
            {
                int.TryParse(maxText.Text, out int max);
            }
            else
            {
                error.Append("Invalid Max value!\n");
            }

            if (minText.Text != "" && minText.Text != "MIn")
            {
                int.TryParse(minText.Text, out int min);
            }
            else
            {
                error.Append("Invalid Min value!\n");
            }

            if(inHouse.Checked)
            {
               
            }

            if(error.Length != 0)
            {
                MessageBox.Show(error.ToString(), "Error",MessageBoxButtons.OK);
            }



            return false;
        }

        void InitFields()
        {
           
            idText.Text = _part.PartId.ToString();
            nameText.Text = _part.PartName;
            nameText.ForeColor = SystemColors.ControlText;
            invText.Text = _part.InStock.ToString();
            invText.ForeColor = SystemColors.ControlText;
            priceText.Text = _part.Price.ToString();
            priceText.ForeColor = SystemColors.ControlText;
            maxText.Text = _part.Max.ToString();
            maxText.ForeColor = SystemColors.ControlText;
            minText.Text = _part.Min.ToString();
            minText.ForeColor = SystemColors.ControlText;
            compIdText.ForeColor = SystemColors.ControlText;

            if (_part is Inhouse)
            {
                inHouse.Select();
                compIdText.Text = ((Inhouse)_part).MachineId.ToString();
            }
            else
            {
                outsourced.Select();
                compIdText.Text = ((Outsourced)_part).CompanyName;
            }
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
            if (compIdText.Text == "Company Name" || compIdText.Text == "Machine ID")
                compIdText.Text = "";

            compIdText.ForeColor = Color.Black;
        }

        private void CompIDText_Leave(object sender, EventArgs e)
        {
            if (compIdText.Text == "")
            {
                if (inHouse.Checked)
                {
                    compIdText.Text = "Machine ID";
                }
                else
                {
                    compIdText.Text = "Company Name";
                }
                compIdText.ForeColor = SystemColors.ControlDark;
            }
        }

        private void PriceText_Changed(object sender, EventArgs e)
        {
            IsPriceFieldValid();
        }

        bool IsPriceFieldValid()
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
                        return true;
                    }
                }
            }
            else
            {
                priceText.BackColor = SystemColors.Window;
            }
            return false;
        }

       
    }
}
