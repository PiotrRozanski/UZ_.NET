using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zegarki
{
	public partial class Clock : UserControl
	{
		public Clock()
		{
			InitializeComponent();
		}

		private readonly Timer t = new Timer();
		private readonly Timer _timer = new Timer();

		private Bitmap bmp;

		private int cx, cy;
		private Graphics g;
		private readonly int HEIGHT = 300;
		private readonly int hrHAND = 80;
		private readonly int minHAND = 110;
		private readonly int secHAND = 140;

		private readonly int WIDTH = 300;

		private void Clock_Load(object sender, EventArgs e)
		{
			//for digital
			t.Interval = 1000;
			t.Tick += t_Tick;
			t.Start();
			
			//for analog
			bmp = new Bitmap(WIDTH + 1, HEIGHT + 1);

			cx = WIDTH / 2;
			cy = HEIGHT / 2;

			BackColor = Color.White;

			_timer.Interval = 1000;
			_timer.Tick += t_Tick2;
			_timer.Start();
		}
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
		private void t_Tick2(object sender, EventArgs e)
		{
			g = Graphics.FromImage(bmp);

			var ss = DateTime.Now.Second;
			var mm = DateTime.Now.Minute;
			var hh = DateTime.Now.Hour;

			g.Clear(Color.White);
			g.DrawEllipse(new Pen(Color.Black, 1f), 0, 0, WIDTH, HEIGHT);

			g.DrawString("12", new Font("Arial", 12), Brushes.Black, new PointF(140, 2));
			g.DrawString("3", new Font("Arial", 12), Brushes.Black, new PointF(286, 140));
			g.DrawString("6", new Font("Arial", 12), Brushes.Black, new PointF(142, 282));
			g.DrawString("9", new Font("Arial", 12), Brushes.Black, new PointF(0, 140));

			//second hand
			var handCoord = MsCoord(ss, secHAND);
			g.DrawLine(new Pen(Color.Red, 1f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

			//minute hand
			handCoord = MsCoord(mm, minHAND);
			g.DrawLine(new Pen(Color.Black, 2f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

			//hour hand
			handCoord = HrCoord(hh % 12, mm, hrHAND);
			g.DrawLine(new Pen(Color.Gray, 3f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

			//load bmp in picturebox1
			pictureBox1.Image = bmp;

			//disp time
			Text = @"Analog Clock -  " + hh + ":" + mm + ":" + ss;

			//dispose
			g.Dispose();
		}

		//coord for minute and second hand
		private int[] MsCoord(int val, int hlen)
		{
			var coord = new int[2];
			val *= 6; //each minute and second make 6 degree

			if (val >= 0 && val <= 180)
			{
				coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
				coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
			}
			else
			{
				coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
				coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
			}
			return coord;
		}

		//coord for hour hand
		private int[] HrCoord(int hval, int mval, int hlen)
		{
			var coord = new int[2];

			//each hour makes 30 degree
			//each min makes 0.5 degree
			var val = (int)(hval * 30 + mval * 0.5);

			if (val >= 0 && val <= 180)
			{
				coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
				coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
			}
			else
			{
				coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
				coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
			}
			return coord;
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}
	}
}
