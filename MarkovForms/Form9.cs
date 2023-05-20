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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        int[] arr = new int[20];
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

                comboBox1.Text += String.Format("{0,5}", i);
            }


            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-3, 4);

                comboBox2.Text += String.Format("{0,5}", arr[i]);

            }
            comboBox2.Enabled = false;
            comboBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            

            comboBox3.Visible = true;
            comboBox3.Enabled = true;
            




            comboBox3.Text = "(эл - кол-во повторений):  ";
            for (int i = 0; i < arr.Length; i++)
            {


                if (!Existed(arr,i)) comboBox3.Text += String.Format("{0} - {1},   ", arr[i],Unical(arr,arr[i]));

            }

            
            comboBox3.Enabled = false;
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
