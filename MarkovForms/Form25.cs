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
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                
                textBox1.Text +=String.Format("{0,5}", i);
            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10, 11);
                textBox2.Text += String.Format("{0,5}", arr[i]);
            }
            
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!Existed(arr, i)) count++;

            }
            int[,] newArr = new int[count, 3];
            int b = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!Existed(arr, i))
                {
                    newArr[b, 0] = arr[i];
                    newArr[b, 1] = Unical(arr, arr[i]);
                    newArr[b, 2] = Point(arr, arr[i], arr[i] < 0);
                    b++;
                }

            }
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = count;
            dataGridView1.ColumnCount = 3;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = newArr[i,j];
                }
                
            }
        }
        static int Unical(int[] arr, int a)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == a) count++;
            }
            return count;
        }
        static int Point(int[] arr, int a, bool enter)
        {
            int b = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == a)
                {
                    b = i;
                    if (enter) break;
                }
            }
            return b;


        }
        static bool Existed(int[] arr, int index)
        {
            if (index >= arr.Length) throw new Exception();
            if (index == 0) return false;
            for (int i = 0; i < index; i++)
            {
                if (arr[i] == arr[index]) return true;
            }
            return false;
        }
        
        
    }
}
