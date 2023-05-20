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
    public partial class Form21 : Form
    {
        public Form21()
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
            int count = 0,spiralCount = 0;
            bool t = true;

            while (t )
            {

                for (int i = spiralCount; i < m-spiralCount; i++)
                {
                    if (spiralCount<m&&arr[i, spiralCount] == 0) arr[i, spiralCount] = count++;
                    else
                    {
                        t = false;
                        break;
                    }
                }
                for (int i = spiralCount+1; i < n-spiralCount; i++)
                {
                    if (spiralCount<m&&arr[m - 1 - spiralCount, i] == 0) arr[m-1-spiralCount,i] = count++;
                    else
                    {
                        t = false;
                        break;
                    }
                }
                for (int i = spiralCount+1; i < m - spiralCount; i++)
                {
                    if (spiralCount<n&&arr[m - i - 1, n - 1 - spiralCount] == 0) arr[m-i-1, n-1-spiralCount] = count++;
                    else
                    {
                        t = false;
                        break;
                    }
                }
                for (int i = spiralCount + 1; i < n - spiralCount-1; i++)
                {
                    if (spiralCount < n && arr[spiralCount, n - i - 1] == 0) arr[spiralCount, n-i-1] = count++;
                    else
                    {
                        t = false;
                        break;
                    }
                }
                spiralCount++;
                
            }
            
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = arr[j,i];
                }
                
            }
        }
    }
}
