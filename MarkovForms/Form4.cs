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
    public partial class Form4 : Form
    {
        public Form4()
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

                comboBox1.Text += String.Format("{0}\t", i);
            }


            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 11);
                if (i % 2 != 0) arr[i] = -arr[i];
                comboBox2.Text += String.Format("{0}\t", arr[i]) ;

            }
            comboBox2.Enabled = false;
            comboBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox3.Visible = true;
            comboBox3.Enabled = true;
            int tmp = arr[0];
            arr[0] = arr[19];
            arr[19] = tmp;
            for (int i = 1; i < 18; i += 2)
            {
                int tmp_ = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = tmp_;
            }
            comboBox3.Text = "";
            for (int i = 0; i < 20; i++)
            {
                comboBox3.Text += String.Format("{0,4}", arr[i]);
            }
            comboBox3.Enabled = false;
        }
    }
}
