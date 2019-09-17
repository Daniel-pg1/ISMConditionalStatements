using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            

        }

        private void ButtonCount_Click(object sender, EventArgs e)
        {
            double x, y, z, r;
            if (double.TryParse(textBoxХ.Text, out x) &&
                double.TryParse(textBoxY.Text, out y) &&
                double.TryParse(textBoxZ.Text, out z))
            {
                r = (2.0 * Math.Cos(x * x) - 1.0 / 2.0) 
                    / (1.0 / 2.0 + Math.Sin(Math.Pow(y, 2.0 - z))) 
                    + (Math.Pow(z, 2) / (7.0 - z / 3.0));
                textBoxResult.Text = r.ToString("F2");
            }
            else if(double.TryParse(textBoxХ.Text, out x) == false)
                MessageBox.Show("Помилка введення значення х!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (double.TryParse(textBoxY.Text, out x) == false)
                MessageBox.Show("Помилка введення значення y!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Помилка введення значення z!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    } 
}
