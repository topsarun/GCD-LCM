using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TEST
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			double x = double.Parse(textBox1.Text) , y = double.Parse(textBox2.Text);
			if (x < y)
			{
				textBox3.Text = Convert.ToString(GCD(x,y));
				textBox4.Text = Convert.ToString((x*y)/GCD(x,y));
			}
			else
			{
				textBox3.Text = Convert.ToString(GCD(y,x));
				textBox4.Text = Convert.ToString((x*y)/GCD(y,x));
			}
		}
		
		public static double GCD (double x, double y)
		{
			if (y%x == 0)
				return x ;
			else 
				return GCD(y%x,x);
		}
	}
}
