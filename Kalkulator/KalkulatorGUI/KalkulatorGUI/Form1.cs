﻿using System;
using System.Globalization;
using System.Windows.Forms;

namespace KalkulatorGUI
{
	public partial class Form1 : Form
	{
		private char _sign;
		private double _variable;
		private bool isResult;
		
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!isResult)
			{
				score.AppendText("1");
			}
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (!isResult)
			{
				score.AppendText("2");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (!isResult)
			{
				score.AppendText("3");
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (!isResult)
			{
				score.AppendText("4");
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (!isResult)
			{
				score.AppendText("5");
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (!isResult)
			{
				score.AppendText("6");
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (!isResult)
			{
				score.AppendText("7");
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (!isResult)
			{
				score.AppendText("8");
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (!isResult)
			{
				score.AppendText("9");
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			if (!isResult)
			{
				score.AppendText("0");
			}
		}

		private void button11_Click(object sender, EventArgs e)
		{
			_variable = double.Parse(score.Text);
			_sign = '+';
			isResult = false;
			score.Text = "";
		}

		private void button13_Click(object sender, EventArgs e)
		{
			_variable = double.Parse(score.Text);
			_sign = '/';
			isResult = false;
			score.Text = "";
		}

		private void button15_Click(object sender, EventArgs e)
		{
			switch (_sign)
			{
				case '+':

					score.Text = (_variable + double.Parse(score.Text)).ToString(CultureInfo.InvariantCulture);
					break;
				case '-':
					score.Text = (_variable - double.Parse(score.Text)).ToString(CultureInfo.InvariantCulture);
					break;
				case '/':

					if ((score.TextLength == 1) && score.Text[0].Equals('0'))
					{
						var tempScore = _variable.ToString(CultureInfo.InvariantCulture);
						score.Text = @"Nie wolno dzielic przez 0";
						MessageBoxButtons Dividerbyzero = MessageBoxButtons.OK;
						var messageDivide = "Nie wolno dzielic przez 0";
						var captionDivide = "Score";
						MessageBox.Show(messageDivide, captionDivide, Dividerbyzero);
						
						if (Dividerbyzero == MessageBoxButtons.OK)
						{
							score.Text = tempScore;
						}
					}
					else
					{
						score.Text = (_variable / double.Parse(score.Text)).ToString(CultureInfo.InvariantCulture);
					}
					break;
				case '*':
					score.Text = (_variable*double.Parse(score.Text)).ToString(CultureInfo.InvariantCulture);
					break;
			}
			isResult = true;
			_sign = '\0';
			MessageBoxButtons buttons = MessageBoxButtons.OK;
			var message = "Twoj wynik to: " + score.Text;
			var caption = "Score";
			MessageBox.Show(message, caption, buttons);
			
		
		}

		private void multipleButton_Click(object sender, EventArgs e)
		{
			_variable = double.Parse(score.Text);
			_sign = '*';
			isResult = false;
			score.Text = "";
		}

		private void subtractButton_Click(object sender, EventArgs e)
		{
			_variable = double.Parse(score.Text);
			_sign = '-';
			isResult = false;
			score.Text = "";
		}

		private void button11_Click_1(object sender, EventArgs e)
		{
			score.Text = "";
		}

		private void button12_Click(object sender, EventArgs e)
		{
			var textLength = score.Text.Length;
			if (textLength > 0 && !isResult)

				score.Text = score.Text.Substring(0, textLength - 1);
		}
	}
}