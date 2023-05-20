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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int m, n;
            try
            {
                m = Convert.ToInt32(textBox1.Text);
                n = Convert.ToInt32(textBox2.Text);
                if (m <3||n<3) throw new Exception("Оба числа должны быть больше двух");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int[,] arr = new int[m, n];
            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rnd.Next(0, 10);
                }
            }
            textBox3.Text = "";
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    textBox3.Text += (j == 0 || j == n - 1 || i == 0 || i == m - 1)?arr[i, j].ToString()+" ":" " + "  ";
                }
                textBox3.Text += "\r\n";
            }
        }
    }
}
