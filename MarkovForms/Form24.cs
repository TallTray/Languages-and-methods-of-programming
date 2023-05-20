using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkovForms
{
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int m, n;
            try
            {
                m = Convert.ToInt32(textBox1.Text);
                n = Convert.ToInt32(textBox2.Text);
                if (m < 3 || n < 3) throw new Exception("Оба числа должны быть больше двух");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int[,] arr = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rnd.Next(0, 20);
                }
            }
            
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView1.Rows[j].Cells[i].Value = arr[i,j];
                }

            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (MaxRow(arr, j) == i && MinColomn(arr, i) == j) dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.Red;
                    if (MinRow(arr, j) == i && MaxColomn(arr, i) == j) dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.Green;
                }
            }
        }
        static int MinRow(int[,]arr, int row)
        {
            int min = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i, row] < arr[min, row]) min = i;
            }
            return min;
        }
        static int MaxRow(int[,] arr, int row)
        {
            int max = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i, row] > arr[max, row]) max = i;
            }
            return max;
        }
        static int MinColomn(int[,] arr, int colomn)
        {
            int min = 0;
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                if (arr[colomn,i] < arr[colomn, min]) min = i;
            }
            return min;
        }
        static int MaxColomn(int[,] arr, int colomn)
        {
            int max = 0;
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                if (arr[colomn, i] > arr[colomn, max]) max = i;
            }
            return max;
        }
    }
}
