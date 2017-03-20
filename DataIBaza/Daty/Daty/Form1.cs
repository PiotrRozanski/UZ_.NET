using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daty
{
	public partial class Form1 : Form
	{
		private DateTime date1;
		private DateTime date2;
		public Form1()
		{
			InitializeComponent();
		}
		

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			
			

		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox3.Text = "";
			if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
			{
				TimeSpan difference = date1.Date - date2.Date;
				int days = (int)difference.TotalDays;

				TimeSpan diff1 = date2.Subtract(date1);
				textBox3.AppendText(days.ToString());
			}
			else
			{
				textBox3.AppendText("Wrong date in fields");
			}
		}
	}
}
