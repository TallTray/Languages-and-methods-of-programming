using System;
using System.Diagnostics;
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
    public partial class Form8 : Form
    {
       
        public Form8()
        {
            InitializeComponent();
        }

        int[] arr = new int[20000];
        int[] arr2 = new int[20000];
        int[] arr3 = new int[20000];
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            comboBox2.Visible = true;

            button2.Visible = true;

            comboBox1.Enabled = false;
            comboBox2.Enabled = true;

            comboBox1.Text = "";
            comboBox2.Text = "";

            for (int i = 0; i < arr.Length; i++)
            {

                //comboBox1.Text += String.Format("{0,5}", i);
            }


            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100, 101);
                arr2[i] = arr[i];
                arr3[i] = arr[i];
                //comboBox2.Text += String.Format("{0,5}", arr[i]);

            }
            comboBox2.Enabled = false;
            comboBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            

            comboBox3.Visible = true;
            comboBox3.Enabled = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            sw.Start();
            Buble(arr);
            sw.Stop();
            textBox3.Text = sw.ElapsedMilliseconds.ToString();
            sw.Restart();
            SortArray(arr2, 0, arr2.Length-1);
            sw.Stop();
            textBox4.Text = sw.ElapsedMilliseconds.ToString();
            sw.Restart();
            Array.Sort(arr3);
            sw.Stop();
            textBox5.Text = sw.ElapsedMilliseconds.ToString();
            for (int i = 0; i < arr.Length; i++)
            {


                //comboBox3.Text += String.Format("{0,5}", arr[i]);
                //textBox1.Text += String.Format("{0,5}", arr2[i]);
               // textBox2.Text += String.Format("{0,5}", arr3[i]);
            }
            
            //comboBox3.Text += "             " + sw.ElapsedMilliseconds;
            //comboBox3.Enabled = false;

        }
        public void SortArray(int[] arr, int left, int right)
        {
            int i = left;
            int j = right;

            int pivot = arr[left];
            while (i <= j)
            {
                while (arr[i] < pivot)
                {
                    i++;
                }

                while (arr[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];

                    arr[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                SortArray(arr, left, j);
            if (i < right)
                SortArray(arr, i, right);
            
        }
        public void Buble(int[] arr)
        {
            for (int g = 0; g < arr.Length; g++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;

                    }
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
