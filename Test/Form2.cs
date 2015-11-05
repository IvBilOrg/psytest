using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            labelResult.Text += " " + BackEnd.compareResults(BackEnd.answ, BackEnd.txtKeys.keys).ToString();
            
        }

        
    }
}