using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorGUI
{
	public class Helper
	{
		SpeechSynthesizer synth = new SpeechSynthesizer();

		public Helper(){}

		public Helper(TextBox textBox)
		{
			SpeakResult(textBox);
		}

		public void SpeakResult(TextBox textBox)
		{
			synth.Speak(textBox.Text);
		}
	}
}
