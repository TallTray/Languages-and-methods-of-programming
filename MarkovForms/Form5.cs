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
    public partial class Form5 : Form
    {
        public Form5()
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

            int previous = arr[0], current = arr[0], count = 0;


            
            for (int i = 1; i < arr.Length; i++)
            {
                if (current != 0) previous = current;
                current = arr[i];
                if (current * previous < 0) count++;

            }
            comboBox3.Text = "Количество смен знака: " + count;
            comboBox3.Enabled = false;
        }
    }
}
