using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invent_it
{
    public partial class PartWindow : Form
    {
        private int number;

        public PartWindow()
        {
            InitializeComponent();
        }

        public void setNumber(int num)
        {
            number = num;
            label1.Text = number.ToString();
        }

     
    }
}
