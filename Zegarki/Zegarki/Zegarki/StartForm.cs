using System;
using System.Windows.Forms;

namespace Zegarki
{
	public partial class StartForm : Form
	{
		private readonly Form1 _analogForm1 = new Form1();
		private readonly Digital _digitalForm = new Digital();

		public StartForm()
		{
			InitializeComponent();
		}


		private void button1_Click(object sender, EventArgs e)
		{
			Hide();
			_digitalForm.ShowDialog();
			Show();
		}

		private void AnalogButton_Click(object sender, EventArgs e)
		{
			Hide();
			_analogForm1.ShowDialog();
			Show();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}