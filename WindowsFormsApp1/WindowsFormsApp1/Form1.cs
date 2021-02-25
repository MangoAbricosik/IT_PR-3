using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {
      double x = Convert.ToDouble(textBox1.Text);

      textBox4.Text = "Работу выполнил Гвоздков Е.Д." + Environment.NewLine;

      textBox4.Text += "При X = " + textBox1.Text + Environment.NewLine;
      
      int n = 0;
      if (radioButton2.Checked) n = 1;
      else if (radioButton3.Checked) n = 2;

      double u = 0;
      switch (n)
      {
        case 0:
          if (x <= 0)
          {
            u = 2 * x;
          }
          else if (0 < x && x < 5)
          {
            u = 2 * x - 1.0;
          }
          else if(x>=5)
          {
            u = -2 * x + 1;
          }
          textBox4.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
          break;
        case 1:
          if (x<0)
          {
            u = -1;
          }
          else if (0<=x && x<5)
          {
            u = 2 * x;
          }
          else if (x>=5)
          {
            u = x;
          }
          textBox4.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
          break;
        case 2:
          if (x<2)
          {
            u = 2 + x;
          }
          else if (2<= x && x <= 4)
          {
            u = Math.Pow(x, 2);
          }
          else if (x > 4)
          {
            u = 1 + 0.5 * x;
          }
          textBox4.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
          break;
        default:
          textBox4.Text += "Решение не найдено" + Environment.NewLine;
          break;
      }
      {

      }
    }
    }
}
