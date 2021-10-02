using System;
using System.Windows.Forms;

namespace idz7
{
    public partial class Form1 : Form
    {
        double[]    z = new double[12],
                    d = new double[12];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < z.Length; i++)
            {
                if( i % 2 == 1)
                {
                    z[i] = i * i + 1;

                }
                else
                {
                    z[i] = 2 * i - 1;
                }
                if( z[i] > 2.5)
                {
                    d[i] = z[i] / 2.5;
                }
                else
                {
                    d[i] = 2.5 * z[i];
                }
                listBox2.Items.Add("d[" + i + "]= " + d[i]);
                listBox1.Items.Add("z[" + i + "]= " + z[i]);
            }
        }
    }
}
