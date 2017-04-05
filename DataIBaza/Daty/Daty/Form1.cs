using System;
using System.Windows.Forms;

namespace Daty
{
	public partial class Form1 : Form
	{
		private DateType _choosenDateType;
		private const string FormatDot = "Format: yyyy.MM.dd";
		private const string ForamtDash = "Format: yyyy-MM-dd";
		private const string FormatSlash = "Format: yyyy/MM/dd";

		public Form1()
		{
			InitializeComponent();
			comboBox1.DataSource = Enum.GetValues(typeof(DateType));
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var maker = new DiffrentMaker();
			try
			{
				textBox3.Text = maker.SubDate(textBox1.Text, textBox2.Text, _choosenDateType);
			}
			catch (Exception exception)
			{
				const string wrongFormat = "Wrong Format Date! should be - ";
				switch (_choosenDateType)
				{
					
					case DateType.Kropka:;
						label4.Text = wrongFormat + FormatDot;
						break;
					case DateType.Myslnik:
						label4.Text = wrongFormat + ForamtDash;
						break;
					case DateType.Ukosnik:
						label4.Text = wrongFormat + FormatSlash;
						break;
				}
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			Enum.TryParse(comboBox1.SelectedValue.ToString(), out _choosenDateType);
			switch (_choosenDateType)
			{
				case DateType.Kropka:
					label4.Text = FormatDot;
					break;
				case DateType.Myslnik:
					label4.Text = ForamtDash;
					break;
				case DateType.Ukosnik:
					label4.Text = FormatSlash;
					break;
			}
		}

		private void label4_Click(object sender, EventArgs e)
		{
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
	}
}