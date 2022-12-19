using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб1
{
    public partial class mainForm : Form
    {
        int step = 0;
        List<int> intRomain = new List<int>();
        string[] romain = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        bool colorIsActive = false;
        bool again = false;

        public mainForm()
        {
            InitializeComponent();
            checkBtn.Enabled = false;
            labelTime.Enabled = false;
            tbTime.Enabled = false;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            int count = 0;
            int value;
            MessageBox.Show("Дорогой друг. Тебе тебе будет дано 15 секунд, чтобы запомнить цифры.");
            labelCheck.Text = "";

            Random rnd = new Random();
            intRomain.Clear();
            tbTime.Text = "15";

            while(count < 7)
            {
                value = rnd.Next(1, 9);
                if (!intRomain.Contains(value))
                {
                    intRomain.Add(value);
                    count++;
                }
            }

            if (step == 0)
            {
                foreach (int i in intRomain)
                {
                    if (colorIsActive && i % 2 == 0)
                        richTB.SelectionColor = Color.Red;
                    richTB.AppendText(romain[i] + "\n");
                    richTB.SelectionColor = richTB.SelectionColor = richTB.ForeColor;
                }
            }
            else if(step == 1)
            {
                string s;
                foreach (int i in intRomain)
                {
                    s = "";
                    for(int j = i; 0 < j; j--)
                    {
                        s += "*";
                    }
                    richTB.AppendText(s + "\n");
                }
            }
            startBtn.Enabled = false;
            labelTime.Enabled = true;
            tbTime.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(tbTime.Text);
            if (time == 0)
            {
                timer1.Stop();
                labelTime.Enabled = false;
                tbTime.Enabled = false;
                richTB.Text = "";
                labelCheck.Visible = true;
                checkBtn.Enabled = true;
                labelCheck.Text = "Выберите числа, которые вы запомнили";
                if (step == 0)
                {
                    for (int i = 1; i <= 9; i++)
                    {
                        listBox.Items.Add(romain[i]);
                    }
                }
                else if( step == 1)
                {
                    string s;
                    for (int i = 1; i <= 9; i++)
                    {
                        s = "";
                        for(int j = i; 0 < j; j--)
                        {
                            s += "*";
                        }
                        listBox.Items.Add(s);
                    }
                }
            }
            else
            {
                tbTime.Text = (time - 1).ToString();
            }
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            int countOfRight = 0;
            if(listBox.SelectedItems.Count == 7)
            {
                foreach(string s in listBox.SelectedItems)
                {
                    if (step == 0)
                    {
                        if (intRomain.Contains(Array.IndexOf(romain, s)))
                        {
                            countOfRight++;
                        }
                    }
                    else if(step == 1)
                    {
                        if (intRomain.Contains(s.Length))
                        {
                            countOfRight++;
                        }
                    }

                }
                MessageBox.Show("Правильных ответов: " + countOfRight.ToString() + "\n" + "Неправильных ответов: " + (7 - countOfRight).ToString());
                listBox.Items.Clear();
                step++;
                startBtn.Text = "Шаг " + (step + 1);
                startBtn.Enabled = true;
                checkBtn.Enabled = false;
                if(colorIsActive)
                {
                    startBtn.Text = "Начать";
                    colorIsActive = false;
                    step = 0;
                    again = false;
                }
                if (again)
                {
                    startBtn.Text = "Шаг " + 4;
                    colorIsActive = true;
                    step = 0;
                }

                if(step == 2)
                {
                    step = 0;
                    again = true;
                }
                    

            }
            else
            {
                labelCheck.Text = "Выберите ровно 7 элементов!";
            }
        }
    }
}
