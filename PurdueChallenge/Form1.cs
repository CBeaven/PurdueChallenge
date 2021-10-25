using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurdueChallenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        long n = 20;
        int m = 20;
        long s = 0;
        int a = 0;
        string t;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            for (int i = m - 1; i > 0; i--)
            {
                n *= i;
            }
            string t = n.ToString();
            lblFactorial.Text = t;
            s = 0;
            while (n != 0)
            {
                s += n % 10;
                n /= 10;
            }
            lblSum.Text = s.ToString();
        }
    }
}
