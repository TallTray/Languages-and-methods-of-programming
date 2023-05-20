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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }
        int[,] arr;
        bool generated = false;
        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            try
            {
                a = Convert.ToInt32(textBox1.Text);
                
                if (a < 3) throw new Exception("Размерность должна быть больше двух");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            arr = new int[a, a];
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.RowCount = a;
            dataGridView1.ColumnCount = a;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = arr[j, i];
                }

            }
            generated = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(generated)
            {
                try
                {
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(0); j++)
                        {
                            arr[i, j] = Convert.ToInt32(dataGridView1.Rows[j].Cells[i].Value);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MainDiag(arr) && SecondaryDiag(arr))
                    label5.Text = "Матрица симметрична относительно обеих диагоналей";
                else if(MainDiag(arr) && !SecondaryDiag(arr))
                    label5.Text = "Матрица симметрична относительно главной диагонали";
                else if (!MainDiag(arr) && !SecondaryDiag(arr))
                    label5.Text = "Матрица симметрична относительно побочной диагонали";
                else
                    label5.Text = "Матрица не симметрична относительно обеих диагоналей";
            }
            else
            {
                MessageBox.Show("Сначала сгенерируйте массив", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static bool MainDiag(int[,] arr)
        {
            int a = arr.GetLength(0);
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (arr[a - i - 1, j] != arr[i,a-j-1]&& a - i - 1!=j) return false;
                }
            }
            return true;
        }
        static bool SecondaryDiag(int[,] arr)
        {
            int a = arr.GetLength(0);
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (arr[i, j] != arr[a-i-1,a-j-1] && i != a-j-1) return false;
                }
            }
            return true;
        }
    }
}
