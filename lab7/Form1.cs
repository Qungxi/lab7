using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
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
                textBox5.Clear();

                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int c = int.Parse(textBox3.Text);
                int d = int.Parse(textBox4.Text);
                
                if (b / a <= 0)
                {
                    throw new Exception("log must be positive");
                }

                double result = ((Math.Log(b / a) + 4 + d) / (c - b + 1));

                textBox5.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Data entry error", "Error because of you", MessageBoxButtons.OK);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Division by zero", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
