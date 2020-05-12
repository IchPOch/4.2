using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._2F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void f(int n, int g)
        {
            Form1 a = new Form1();
            V.Text += Environment.NewLine;
            if (n == 1)
            {
                for (int i = n; i < g; i++, V.Text += " ")  ;
                for (int j = g - n; j < g; j++, V.Text += "*") ;
            }
            else
            {
                for (int i = n; i < g; i++, V.Text += " ") ;
                for (int j = g - n; j < g; j++, V.Text += "*") ;
                f(n - 1, g);
            }
        }
    
        private void j_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(N.Text);
            if (n < 0) V.Text ="Неккоректно введены данные";
            else
            {
                int g = n;
                f(n, g);
            }

        }
    }
}
