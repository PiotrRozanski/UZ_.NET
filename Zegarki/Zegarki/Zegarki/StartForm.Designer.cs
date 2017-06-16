namespace Zegarki
{
	partial class StartForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.DigitalButton = new System.Windows.Forms.Button();
			this.AnalogButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.clock1 = new Zegarki.Clock();
			this.SuspendLayout();
			// 
			// DigitalButton
			// 
			this.DigitalButton.Location = new System.Drawing.Point(12, 22);
			this.DigitalButton.Name = "DigitalButton";
			this.DigitalButton.Size = new System.Drawing.Size(75, 23);
			this.DigitalButton.TabIndex = 0;
			this.DigitalButton.Text = "Digital";
			this.DigitalButton.UseVisualStyleBackColor = true;
			this.DigitalButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// AnalogButton
			// 
			this.AnalogButton.Location = new System.Drawing.Point(173, 22);
			this.AnalogButton.Name = "AnalogButton";
			this.AnalogButton.Size = new System.Drawing.Size(75, 23);
			this.AnalogButton.TabIndex = 1;
			this.AnalogButton.Text = "Analog";
			this.AnalogButton.UseVisualStyleBackColor = true;
			this.AnalogButton.Click += new System.EventHandler(this.AnalogButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(103, 167);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(75, 23);
			this.ExitButton.TabIndex = 2;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// clock1
			// 
			this.clock1.BackColor = System.Drawing.Color.White;
			this.clock1.Location = new System.Drawing.Point(321, 35);
			this.clock1.Name = "clock1";
			this.clock1.Size = new System.Drawing.Size(673, 314);
			this.clock1.TabIndex = 3;
			// 
			// StartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1056, 413);
			this.Controls.Add(this.clock1);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.AnalogButton);
			this.Controls.Add(this.DigitalButton);
			this.Name = "StartForm";
			this.Text = "StartForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button DigitalButton;
		private System.Windows.Forms.Button AnalogButton;
		private System.Windows.Forms.Button ExitButton;
		private Clock clock1;
	}
}