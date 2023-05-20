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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }
        Random rnd = new Random();
        bool generated = false;

        int[,] arr;

        private void button1_Click(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex + 2;

            if (!generated||arr.GetLength(0) !=a)
            {
                arr = new int[a, a];
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        arr[i, j] = rnd.Next(1, 10);
                    }
                }
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.RowCount = a;
                dataGridView1.ColumnCount = a;
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        dataGridView1.Rows[j].Cells[i].Value = arr[j, i];
                    }

                }
                generated = true;
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    dataGridView1.Rows[j].Cells[i].Value = arr[j, i];
                }

            }
            Sort(arr, radioButton2.Checked, radioButton3.Checked);
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView2.RowCount = a;
            dataGridView2.ColumnCount = a;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    dataGridView2.Rows[j].Cells[i].Value = arr[j, i];
                }

            }
        }
        static void Sort(int[,] arr,bool rows,bool up)
        {
            if(rows && up)
            {
                for (int g = 0; g < arr.GetLength(0); g++)
                    for (int i = 0; i < arr.GetLength(0) - 1; i++)
                    {
                        for (int j = 0; j < arr.GetLength(0); j++)
                        {
                            if (arr[i, j] > arr[i + 1, j])
                            {
                                int t = arr[i, j];
                                arr[i,j] = arr[i + 1, j];
                                arr[i + 1, j] = t;
                            }
                        }
                    }
            }
            else if (rows && !up)
            {
                for (int g = 0; g < arr.GetLength(0); g++)
                    for (int i = 0; i < arr.GetLength(0) - 1; i++)
                    {
                        for (int j = 0; j < arr.GetLength(0); j++)
                        {
                            if (arr[i, j] < arr[i + 1, j])
                            {
                                int t = arr[i, j];
                                arr[i, j] = arr[i + 1, j];
                                arr[i + 1, j] = t;
                            }
                        }
                    }
            }
            else if(!rows && up)
            {
                for (int g = 0; g < arr.GetLength(0); g++)
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(0)-1; j++)
                        {
                            if (arr[i, j] > arr[i, j+1])
                            {
                                int t = arr[i, j];
                                arr[i, j] = arr[i, j+1];
                                arr[i, j+1] = t;
                            }
                        }
                    }
            }
            else if (!rows && !up)
            {
                for (int g = 0; g < arr.GetLength(0); g++)
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(0) - 1; j++)
                        {
                            if (arr[i, j] < arr[i, j + 1])
                            {
                                int t = arr[i, j];
                                arr[i, j] = arr[i, j + 1];
                                arr[i, j + 1] = t;
                            }
                        }
                    }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex + 2;
            arr = new int[a, a];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    arr[i, j] = rnd.Next(1, 10);
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.RowCount = a;
            dataGridView1.ColumnCount = a;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    dataGridView1.Rows[j].Cells[i].Value = arr[j, i];
                }

            }
            generated = true;
        }
    }
}
