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
    public partial class PartWindow : Form
    {
        public event EventHandler<SavePartEventArgs> SaveButtonClickedEvent;

        public string Title { get; set; }

        Part _part;

        int _id;

        bool _isInvNumber = false;
        bool _isPriceNumber = false;
        bool _isMaxNumber = false;
        bool _isMinNumber = false;
        bool _isMachIdNumber = false;

        public PartWindow(string title, Part part, int id)
        {
            Title = title;
            _part = part;
            _id = id;

            InitializeComponent();

            if (_part != null)
            {
                InitModifyPartFields();
            }
            else
            {
                nameText.BackColor = Color.LightCoral;
                invText.BackColor = Color.LightCoral;
                priceText.BackColor = Color.LightCoral;
                maxText.BackColor = Color.LightCoral;
                minText.BackColor = Color.LightCoral;
                compIdText.BackColor = Color.LightCoral;
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
                compIdToolTip.SetToolTip(compIdText, "Machine ID number is required");
                if(!int.TryParse(compIdText.Text, out int intValue))
                {
                    compIdText.BackColor = Color.LightCoral;
                    _isMachIdNumber = false;
                }
              
            }
            else
            {
                compIdLabel.Text = "Company Name";
                compIdToolTip.SetToolTip(compIdText, "Company name is required");
                if (compIdText.Text != "")
                {
                    compIdText.BackColor = Color.White;
                    _isMachIdNumber = true;
                }
            }
          
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
                
                if(inHouse.Checked)
                {
                    int machId = int.Parse(compIdText.Text);
                    _part = new Inhouse(_id, name, price, inv, min, max, machId);
                }
                else
                {
                    string compName = compIdText.Text;
                    _part = new Outsourced(_id, name, price, inv, min, max, compName);
                }
                SaveButtonClickedEvent?.Invoke(this, new SavePartEventArgs(_part));
                this.Close();
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
                errors.Append("Invalid part name.\n");
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
            if (!_isMachIdNumber)
            {
                errors.Append("Invalid Machine ID.\n");
            }

            return errors;

        }

        void InitModifyPartFields()
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

        private void CompIDText_Enter(object sender, EventArgs e)
        {
            compIdText.BackColor = Color.White;
        }

        private void CompIDText_Leave(object sender, EventArgs e)
        {
            if (compIdText.Text != "")
            {
                if(inHouse.Checked)
                {
                    if(!int.TryParse(compIdText.Text, out int intValues))
                    {
                        compIdText.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        compIdText.BackColor = Color.White;
                    }
                }
            }
            else
            {
                compIdText.BackColor = Color.LightCoral;
            }
        }

        private void InvText_Changed(object sender, EventArgs e)
        {
            if(invText.Text != "" && !int.TryParse(invText.Text, out int inValue))
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

        private void CompIdText_Changed(object sender, EventArgs e)
        {
            if(inHouse.Checked)
            {
                if (compIdText.Text != "" && !int.TryParse(compIdText.Text, out int intValue))
                {
                    _isMachIdNumber = false;
                    compIdText.BackColor = Color.LightCoral;
                }
                else
                {
                    _isMachIdNumber = true;
                    compIdText.BackColor = Color.White;
                }
            }
            else
            {
                _isMachIdNumber = true;
            }
        }
     
    }

    public class SavePartEventArgs : EventArgs
    {

        public Part SavedPart { get; set; }

        public SavePartEventArgs(Part savedPart)
        {
            SavedPart = savedPart;
        }

    }

}
