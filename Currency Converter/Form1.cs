using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Currency_Converter
{
    public partial class Form1 : Form
    {
        int a = 0;
        string c1 = "GEL";
        string c2 = "GEL";
        double usdToGel = 3;
        double euToGel = 3.4;
        
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1 = comboBox1.Text; 
            c2 = comboBox2.Text;

            if (c1 == "GEL")
            {
                label1.Text = c2 == "EU" ? Convert.ToString(Convert.ToDouble(textBox1.Text) * euToGel) :
                    c2 == "USD" ? Convert.ToString(Convert.ToDouble(textBox1.Text) * usdToGel) : textBox1.Text;
            }
            if (c1 == "USD")
            {
                label1.Text = c2 == "EU" ? Convert.ToString(Convert.ToDouble(textBox1.Text) / euToGel * usdToGel) :
                    c2 == "GEL" ? Convert.ToString(Convert.ToDouble(textBox1.Text) / usdToGel) : textBox1.Text;
            }
            if (c1 == "EU")
            {
                label1.Text = c2 == "USD" ? Convert.ToString(Convert.ToDouble(textBox1.Text) / usdToGel * euToGel) :
                    c2 == "GEL" ? Convert.ToString(Convert.ToDouble(textBox1.Text) / euToGel) : textBox1.Text;
            }
        }
    }
}
