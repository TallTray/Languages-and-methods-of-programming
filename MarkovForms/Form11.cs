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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        int[] arr = new int[20];
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            comboBox2.Visible = true;



            comboBox1.Enabled = false;
            comboBox2.Enabled = true;

            comboBox1.Text = "";
            comboBox2.Text = "";

            for (int i = 0; i < arr.Length; i++)
            {

                comboBox1.Text += String.Format("{0,5}", i);
                arr[i] = rnd.Next(0, 30);
                comboBox2.Text += String.Format("{0,5}", arr[i]);
            }

            button2.Visible = true;

            comboBox2.Enabled = false;
            comboBox1.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {



            comboBox3.Visible = true;
            comboBox3.Enabled = true;



            int minIndex = MinMax(arr, false), maxIndex = MinMax(arr, true);

            comboBox3.Text = "";
            if (minIndex < maxIndex) for (int i = arr[minIndex]; i < arr[maxIndex]; i++)
                {

                    if (!Existed(arr, i, 0, arr.Length-1)) comboBox3.Text += String.Format("{0,5}", i);


                }
            else
                for (int i = arr[minIndex]; i < arr[maxIndex]; i++)
                {

                    if (!Existed(arr, i, 0, arr.Length - 1)) comboBox3.Text += String.Format("{0,5}", i);


                }
            comboBox3.Text += "/ " + minIndex + "    " + maxIndex;

            comboBox3.Enabled = false;
        }
        static int MinMax(int[] arr, bool max)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((!max && arr[temp] > arr[i]) || (max && arr[temp] < arr[i])) temp = i;
            }
            return temp;
        }

        static bool Existed(int[] arr, int el, int startIndex, int endIndex)
        {
            if (endIndex >= arr.Length) throw new Exception();

            for (int i = startIndex; i <= endIndex; i++)
            {
                if (arr[i] == el) return true;
            }
            return false;
        }


    }
}
