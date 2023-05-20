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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        int[] arr = {31,29,31,30,31,30,31,31,30,30,31, 30, 31 };
        private void button1_Click(object sender, EventArgs e)
        {
            int day = 0;
            try
            {
                day = Convert.ToInt32(textBox1.Text);
                if (comboBox1.SelectedIndex == -1) throw new Exception("Месяц не выбран");
                if (arr[comboBox1.SelectedIndex] < day || day <= 0) throw new Exception("Число введено некоректно");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            int sum = 0;
            for (int i = 0; i < comboBox1.SelectedIndex; i++)
            {
                sum+= arr[i];
            }
            sum += day;
            label3.Text = "День недели: " + ((DayOfWeek)(sum % 7)).ToString();
        }
        enum DayOfWeek
        {
            Воскресенье,Понедельник, Вторник,Среда,Четверг,Пятница,Суббота
        }
    }
}
