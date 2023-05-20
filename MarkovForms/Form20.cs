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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }
        Random rnd = new Random(9);
        private void button1_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[3, 3];
            int count = 0;
            do
            {
                arr = new int[3, 3];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        while (true)
                        {
                            int b = rnd.Next(1, 10);
                            if (!Contains(arr, b))
                            {
                                arr[i, j] = b;
                                break;
                            }
                        }

                    }
                }
                count++;
            }
            while (!IsMagical(arr));



            textBox3.Text = "";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    textBox3.Text += arr[i, j].ToString() + " ";
                }
                textBox3.Text += "\r\n";
            }
            textBox3.Text += "Количество попыток: " + count;
        }
        static bool IsMagical(int[,] arr)
        {
            return arr[0, 0] + arr[1, 0] + arr[2, 0] == arr[0, 1] + arr[1, 1] + arr[2, 1] &&
                arr[0, 1] + arr[1, 1] + arr[2, 1] == arr[0, 2] + arr[1, 2] + arr[2, 2] &&

                arr[0, 0] + arr[0, 1] + arr[0, 2] == arr[1, 0] + arr[1, 1] + arr[1, 2] &&
                arr[1, 0] + arr[1, 1] + arr[1, 2] == arr[2, 0] + arr[2, 1] + arr[2, 2] &&
                arr[0, 0] + arr[2, 2] == arr[2, 0] + arr[0, 2] &&
                arr[0, 0] + arr[2, 2] + arr[1, 1] == arr[2, 0] + arr[2, 1] + arr[2, 2];

        }
        static bool Contains(int[,] arr,int a)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (arr[i,j]==a)return true;
                }
            }
            return false;
        }
    }
}
