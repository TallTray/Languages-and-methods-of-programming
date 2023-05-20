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
    public partial class Form10 : Form
    {
        public Form10()
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
            }


            for (int i = 0; i < arr.Length; i++)
            {
                while (true)
                {
                    arr[i] = rnd.Next(0, 20);
                    if (!Existed(arr, i)) break;
                }

                comboBox2.Text += String.Format("{0,5}", arr[i]);

            }
            comboBox2.Enabled = false;
            comboBox1.Enabled = false;
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
