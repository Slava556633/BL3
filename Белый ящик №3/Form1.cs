using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Белый_ящик__3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string[] lines = textBox1.Lines;
                    int[] nums = new int[lines.Length];
                    for (int i = 0; i < lines.Length; i++)
                    {
                        nums[i] = int.Parse(lines[i]);
                    }
                    int min1 = int.MaxValue;
                    int min2 = int.MaxValue;
                    {
                        foreach (int num in nums)
                        {
                            if (num < min1)
                            {
                                min2 = min1;
                                min1 = num;
                            }
                            else if (num < min2)
                            {
                                min2 = num;
                            }
                            textBox2.Text = $"наименьшее число: {min1}";
                            textBox3.Text = $"наименьшее число: {min2}";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка:" + ex.Message, "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
