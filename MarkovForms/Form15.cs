using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkovForms
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
        }


        int[] arr = new int[20];
        

        Random rnd = new Random();
        
        static bool Unical(int[] arr, int index)
        {

            for (int i = 0; i < index; i++)
            {
                if (arr[i] == arr[index]) return false;
            }
            return true;
        }
        
        
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;




            textBox1.Enabled = true;
            textBox2.Enabled = true;


            textBox1.Text = "";
            textBox2.Text = "";

            for (int i = 0; i < arr.Length; i++)
            {
                textBox1.Text += String.Format("{0,5}", i);

                arr[i] = rnd.Next(1, 10);
                textBox2.Text += String.Format("{0,5}", arr[i]);
            }


            button2.Visible = true;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            textBox3.Enabled = true;
            textBox3.Text = "";

            while (true)
            {
                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (!Unical(arr, i))
                    {
                        arr[i] *= i;
                        count++;
                    }
                }
                if (count == 0) break;

            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                
                textBox3.Text += String.Format("{0,5}", arr[i]);
            }
            textBox3.Enabled = false;
        }
    }
}
