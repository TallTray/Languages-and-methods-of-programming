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
    public partial class Form7 : Form
    {
        public Form7()
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
            Stopwatch sw = new Stopwatch();
            sw.Start();
            
            comboBox3.Visible = true;
            comboBox3.Enabled = true;
            for (int g = 0; g < arr.Length; g++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] == 0)
                    {
                        arr[i] = arr[i + 1];
                        arr[i + 1] = 0;

                    }
                }
            }
            comboBox3.Text = "";
            for (int i = 0; i < arr.Length; i++)
            {


                if(arr[i]!=0)comboBox3.Text += String.Format("{0,5}", arr[i]);

            }
            
            sw.Stop();
            comboBox3.Text += "             " + sw.ElapsedMilliseconds;
            comboBox3.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
