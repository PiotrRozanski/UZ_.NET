using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zegar_Alarm
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        SoundPlayer player = new SoundPlayer();
        DateTime alarm = new DateTime();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += new EventHandler(this.t_Tick);
            timer.Tick += t_Tick;
            timer.Start(); 
        }

        private void t_Tick(object sender, EventArgs e)
        {
            
            String actualDate = DateTime.Today.ToString("dd-MM-yyyy");
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            label1.Text = time + " " + actualDate;

            button1.Click += new EventHandler(this.button1_Click);

            if (alarm.Hour == hh && alarm.Minute == mm && alarm.Second == ss)
            {
                try
                {
                    player.SoundLocation = @"C:\Windows\Media\Alarm01.wav";
                    player.PlayLooping();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            alarm = dateTimePicker1.Value;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
    }
}

