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
    public partial class Form1 : Form
    {
        int[] arr = new int[20];
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            button2.Visible = true;
            
            comboBox1.Enabled = true;
            comboBox1.Text = "";
            comboBox3.Text = "";
            comboBox3.Visible = true;
            for (int i = 0; i < arr.Length; i++)
            {
                
                comboBox3.Text += String.Format("{0,5}",i);
            }
            comboBox3.Enabled = false;
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-3, 4);
                comboBox1.Text += String.Format("{0,5}", arr[i]);
                
            }
            comboBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
            comboBox2.Enabled = true;
            comboBox2.Text = "Индексы нулевых элементов: ";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    comboBox2.Text += String.Format("[{0}]",i) + " ";
            }
            comboBox2.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
