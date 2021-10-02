using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace idz8
{
    public partial class Form1 : Form
    {
        double[,]   A = new double[6,6],
                    B = new double[6, 6],
                    C = new double[6, 6];

        private void button1_Click(object sender, EventArgs e)
        {
            matrixFilling(A);
        }

        public Form1()
        {
            InitializeComponent();
        }
        void matrixFilling(double[,] A)
        {
            Random r = new Random();
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int z = 0; i < A.GetLength(1); i++)
                {
                    A[i, z] = r.NextDouble() * r.Next(-100, 100);
                    dataGridView1.Rows[i].Cells[z].Value = A[i, z].ToString();
                }
            }
        }
    }
}
