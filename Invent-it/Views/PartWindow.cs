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
    }
}
