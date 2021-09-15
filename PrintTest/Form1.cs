using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ArrayList lists = new ArrayList(PrinterSettings.InstalledPrinters);            
            foreach(object list in lists)
            {
                comboBox1.Items.Add(list.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrinterSettings.PrinterName = comboBox1.SelectedItem.ToString();
            pd.PrinterSettings.FromPage = 1;
            pd.PrinterSettings.ToPage = 1;
            pd.Print();
        }
    }
}
