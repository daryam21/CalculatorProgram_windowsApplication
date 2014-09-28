using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phase1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double item1, item2;
                double item3 = 0;
                item1 = Double.Parse(textBox1.Text);
                item2 = Double.Parse(textBox2.Text);
               
                if (comboBox1.SelectedItem.ToString() == "Addition")
                {
                   item3 = (item1 + item2);
                }
                else if (comboBox1.SelectedItem.ToString() == "Subtraction")
                {
                item3 = (item1 - item2);
                }
                else if (comboBox1.SelectedItem.ToString() == "Division")
                {
                    try
                    {
                        if (item2== 0)
                        {
                            throw new System.DivideByZeroException();
                        }


                       item3 = (item1 / item2);
                    }
                    catch (DivideByZeroException)
                    {
                        MessageBox.Show("Denominator cannot be zero.Please enter the valid integer.");
                        
                    }

                }
                else if (comboBox1.SelectedItem.ToString() == "Multiplication")
                {
                    item3 = (item1 * item2);
                }

                label1.Text = item3.ToString();

            }
              
            catch(Exception)
            {
                MessageBox.Show("Enter a valid number");
            }
        }
    }
}
