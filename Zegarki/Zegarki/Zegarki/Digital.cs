using System;
using System.Windows.Forms;

namespace Zegarki
{
	public partial class Digital : Form
	{
		private readonly Timer t = new Timer();

		public Digital()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//timer interval
			t.Interval = 1000; 

			t.Tick += t_Tick;

			//start timer when form loads
			t.Start();
		}

		//timer eventhandler
		private void t_Tick(object sender, EventArgs e)
		{
			//get current time
			var hh = DateTime.Now.Hour;
			var mm = DateTime.Now.Minute;
			var ss = DateTime.Now.Second;

			//time
			var time = "";

			//padding leading zero
			if (hh < 10)
				time += "0" + hh;
			else
				time += hh;
			time += ":";

			if (mm < 10)
				time += "0" + mm;
			else
				time += mm;
			time += ":";

			if (ss < 10)
				time += "0" + ss;
			else
				time += ss;

			label1.Text = time;
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}
	}
}