using System;
using System.Windows.Forms;

namespace KalkulatorGUI
{
	public partial class Form1 : Form
	{
		private bool _isResult;
		private char _sign;
		private double _variable;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AddSignNumber("1");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			AddSignNumber("2");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			AddSignNumber("3");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			AddSignNumber("4");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			AddSignNumber("5");
		}

		private void button6_Click(object sender, EventArgs e)
		{
			AddSignNumber("6");
		}

		private void button7_Click(object sender, EventArgs e)
		{
			AddSignNumber("7");
		}

		private void button8_Click(object sender, EventArgs e)
		{
			AddSignNumber("8");
		}

		private void button9_Click(object sender, EventArgs e)
		{
			AddSignNumber("9");
		}

		private void button10_Click(object sender, EventArgs e)
		{
			AddSignNumber("0");
		}

		private void button11_Click(object sender, EventArgs e)
		{
			MakeSignAction('+');
		}

		private void button13_Click(object sender, EventArgs e)
		{
			MakeSignAction('/');
		}

		private void multipleButton_Click(object sender, EventArgs e)
		{
			MakeSignAction('*');
		}

		private void subtractButton_Click(object sender, EventArgs e)
		{
			MakeSignAction('-');
		}

		private void button13_Click_1(object sender, EventArgs e)
		{
			if (score.Text.Contains(",") && !string.IsNullOrEmpty(score.Text))
				return;

			if (!_isResult && !string.IsNullOrEmpty(score.Text) && score.Text.Substring(score.Text.Length - 1) != ",")
				score.AppendText(",");
		}

		private void button15_Click(object sender, EventArgs e)
		{
			switch (_sign)
			{
				case '+':
					score.Text = (_variable + double.Parse(score.Text)).ToString();

					break;
				case '-':
					score.Text = (_variable - double.Parse(score.Text)).ToString();

					break;
				case '/':

					if (score.TextLength == 1 && score.Text[0].Equals('0'))
					{
						ShowDivideByZeroMessage();
					}
					else
					{
						score.Text = (_variable / double.Parse(score.Text)).ToString();
					}

					break;
				case '*':
					score.Text = (_variable * double.Parse(score.Text)).ToString();
					break;
			}
			label2.Text = score.Text;
			label1.Text = string.Empty;
			label1.Text = @"=";
			_isResult = true;
			_sign = '\0';
			//Helper helper = new Helper(score);
			//backgroundWorker1.RunWorkerAsync(helper);
			ShowScore();
		}

		private void button11_Click_1(object sender, EventArgs e)
		{
			score.Text = "0";
			label1.Text = string.Empty;
			label2.Text = string.Empty;
			_isResult = false;
		}

		private void button12_Click(object sender, EventArgs e)
		{
			var textLength = score.Text.Length;
			if (textLength > 0 && !_isResult)
			{
				score.Text = score.Text.Substring(0, textLength - 1);
			}	
		}

		private void button14_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(score.Text))
			{
				score.Text = Math.Sqrt(double.Parse(score.Text)).ToString();
			}
			_isResult = true;
			label2.Text = score.Text;
			label1.Text = string.Empty;
			label1.Text = @"√";
		}

		private void RemoveZero()
		{
			if (score.Text.StartsWith("0") && !score.Text.Contains(","))
			{
				score.Text = score.Text.Replace("0", string.Empty);
			}
		}

		private void button15_Click_1(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(score.Text))
			{
				var temp = double.Parse(score.Text) * _variable;
				temp /= 100;
				score.Text = temp.ToString();
			}
			_isResult = false;
			label2.Text = score.Text;
			label1.Text = string.Empty;
			label1.Text = @"%";
			score.Text = "0";
		}

		private void AddSignNumber(string sign)
		{
			if (_isResult) return;
			RemoveZero();
			score.AppendText(sign);
		}

		private void MakeSignAction(char sign)
		{
			_variable = double.Parse(score.Text);
			_sign = sign;
			_isResult = false;
			label2.Text = score.Text;
			score.Text = "";
			label1.Text = string.Empty;
			label1.Text = sign.ToString();
		}

		private void ShowScore()
		{
			var buttons = MessageBoxButtons.OK;
			var message = "Twoj wynik to: " + score.Text;
			var caption = "Score";
			MessageBox.Show(message, caption, buttons);
		}

		private void ShowDivideByZeroMessage()
		{
			var tempScore = _variable.ToString();
			score.Text = @"Nie wolno dzielic przez 0";
			var Dividerbyzero = MessageBoxButtons.OK;
			var messageDivide = "Nie wolno dzielic przez 0";
			var captionDivide = "Score";
			MessageBox.Show(messageDivide, captionDivide, Dividerbyzero);
			if (Dividerbyzero == MessageBoxButtons.OK)
			{
				score.Text = tempScore;
			}
		}
	}
}