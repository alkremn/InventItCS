﻿using System;
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
        public PartWindow(string title)
        {
            Label = title;
            InitializeComponent();
        }
     
    }
}
