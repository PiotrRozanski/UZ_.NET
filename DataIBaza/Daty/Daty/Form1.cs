using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Daty
{
	public partial class Form1 : Form
	{

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

			var maker = new DiffrentMaker();
			maker.SubDate(textBox1.Text, textBox2.Text, DateType.Dot);
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBox1.DataSource = Enum.GetValues(typeof(DateType));
		}
	}
}
