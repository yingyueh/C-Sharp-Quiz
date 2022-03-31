using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex0319
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment payment;
            if (txtPrice.Text == "50off")
            {
                payment = Discount50off;
            }
            else
            {
                payment = Discount20off;
            }
            double total = payment(double.Parse(txtPrice.Text));
            MessageBox.Show(total.ToString());
        }

        delegate double Payment(double money);
        double Discount50off(double money)
        {
            return money * 0.5;
        }

        double Discount20off(double money)
        {
            return money * 0.8;
        }

        
    }
}
