
namespace Labben
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clockHourInput = new System.Windows.Forms.TextBox();
            this.clockMinuteInput = new System.Windows.Forms.TextBox();
            this.clockhour = new System.Windows.Forms.Label();
            this.clockminute = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errormessage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.alarmHinput = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.alarmMinput = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button3 = new System.Windows.Forms.Button();
            this.alarm2Minput = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.alarm2Hinput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Alarm1message = new System.Windows.Forms.Label();
            this.alarm2message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Set Hour: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Set Minute: ";
            // 
            // clockHourInput
            // 
            this.clockHourInput.Location = new System.Drawing.Point(266, 72);
            this.clockHourInput.MaxLength = 2;
            this.clockHourInput.Name = "clockHourInput";
            this.clockHourInput.Size = new System.Drawing.Size(36, 20);
            this.clockHourInput.TabIndex = 3;
            this.clockHourInput.TextChanged += new System.EventHandler(this.ClockHourInput);
            this.clockHourInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // clockMinuteInput
            // 
            this.clockMinuteInput.Location = new System.Drawing.Point(266, 107);
            this.clockMinuteInput.MaxLength = 2;
            this.clockMinuteInput.Name = "clockMinuteInput";
            this.clockMinuteInput.Size = new System.Drawing.Size(36, 20);
            this.clockMinuteInput.TabIndex = 4;
            this.clockMinuteInput.TextChanged += new System.EventHandler(this.ClockMinuteInput);
            this.clockMinuteInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // clockhour
            // 
            this.clockhour.AutoSize = true;
            this.clockhour.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockhour.Location = new System.Drawing.Point(223, 149);
            this.clockhour.Name = "clockhour";
            this.clockhour.Size = new System.Drawing.Size(49, 33);
            this.clockhour.TabIndex = 5;
            this.clockhour.Text = "00";
            this.clockhour.TextChanged += new System.EventHandler(this.RestartHourIf24);
            this.clockhour.Click += new System.EventHandler(this.clockhour_Click);
            // 
            // clockminute
            // 
            this.clockminute.AutoSize = true;
            this.clockminute.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockminute.Location = new System.Drawing.Point(281, 149);
            this.clockminute.Name = "clockminute";
            this.clockminute.Size = new System.Drawing.Size(49, 33);
            this.clockminute.TabIndex = 6;
            this.clockminute.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(262, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 33);
            this.label6.TabIndex = 7;
            this.label6.Text = ":";
            // 
            // errormessage
            // 
            this.errormessage.AutoSize = true;
            this.errormessage.Location = new System.Drawing.Point(40, 48);
            this.errormessage.Name = "errormessage";
            this.errormessage.Size = new System.Drawing.Size(0, 13);
            this.errormessage.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(210, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Start Clock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.startButton);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Alarm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Set Hour: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Set Minute: ";
            // 
            // alarmHinput
            // 
            this.alarmHinput.Location = new System.Drawing.Point(175, 289);
            this.alarmHinput.MaxLength = 2;
            this.alarmHinput.Name = "alarmHinput";
            this.alarmHinput.Size = new System.Drawing.Size(36, 20);
            this.alarmHinput.TabIndex = 13;
            this.alarmHinput.TextChanged += new System.EventHandler(this.AlarmHourInput);
            this.alarmHinput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(73, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 32);
            this.button2.TabIndex = 15;
            this.button2.Text = "Set Alarm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SetAlarm);
            // 
            // alarmMinput
            // 
            this.alarmMinput.Location = new System.Drawing.Point(175, 320);
            this.alarmMinput.MaxLength = 2;
            this.alarmMinput.Name = "alarmMinput";
            this.alarmMinput.Size = new System.Drawing.Size(36, 20);
            this.alarmMinput.TabIndex = 16;
            this.alarmMinput.TextChanged += new System.EventHandler(this.AlarmMinuteInput);
            this.alarmMinput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(2, 404);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(289, 24);
            this.webBrowser1.TabIndex = 17;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(2, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(16, 16);
            this.button3.TabIndex = 18;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // alarm2Minput
            // 
            this.alarm2Minput.Location = new System.Drawing.Point(418, 320);
            this.alarm2Minput.MaxLength = 2;
            this.alarm2Minput.Name = "alarm2Minput";
            this.alarm2Minput.Size = new System.Drawing.Size(36, 20);
            this.alarm2Minput.TabIndex = 23;
            this.alarm2Minput.TextChanged += new System.EventHandler(this.Alarm2MinuteInput);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(313, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 32);
            this.button4.TabIndex = 22;
            this.button4.Text = "Set Alarm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SetAlarm2);
            // 
            // alarm2Hinput
            // 
            this.alarm2Hinput.Location = new System.Drawing.Point(418, 289);
            this.alarm2Hinput.MaxLength = 2;
            this.alarm2Hinput.Name = "alarm2Hinput";
            this.alarm2Hinput.Size = new System.Drawing.Size(36, 20);
            this.alarm2Hinput.TabIndex = 21;
            this.alarm2Hinput.TextChanged += new System.EventHandler(this.Alarm2HourInput);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(301, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Set Minute: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(301, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Set Hour: ";
            // 
            // Alarm1message
            // 
            this.Alarm1message.AutoSize = true;
            this.Alarm1message.Location = new System.Drawing.Point(80, 250);
            this.Alarm1message.Name = "Alarm1message";
            this.Alarm1message.Size = new System.Drawing.Size(0, 13);
            this.Alarm1message.TabIndex = 24;
            // 
            // alarm2message
            // 
            this.alarm2message.AutoSize = true;
            this.alarm2message.Location = new System.Drawing.Point(382, 250);
            this.alarm2message.Name = "alarm2message";
            this.alarm2message.Size = new System.Drawing.Size(0, 13);
            this.alarm2message.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 422);
            this.Controls.Add(this.alarm2message);
            this.Controls.Add(this.Alarm1message);
            this.Controls.Add(this.alarm2Minput);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.alarm2Hinput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.alarmMinput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.alarmHinput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.errormessage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clockminute);
            this.Controls.Add(this.clockhour);
            this.Controls.Add(this.clockMinuteInput);
            this.Controls.Add(this.clockHourInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Clock & Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clockMinuteInput;
        private System.Windows.Forms.Label clockhour;
        public System.Windows.Forms.Label clockminute;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label errormessage;
        private System.Windows.Forms.TextBox clockHourInput;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox alarmHinput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox alarmMinput;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox alarm2Minput;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox alarm2Hinput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Alarm1message;
        private System.Windows.Forms.Label alarm2message;
    }
}

