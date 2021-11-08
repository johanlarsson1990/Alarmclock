
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Set Hour: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Set Minute: ";
            // 
            // clockhourinput
            // 
            this.clockHourInput.Location = new System.Drawing.Point(129, 66);
            this.clockHourInput.Name = "clockhourinput";
            this.clockHourInput.Size = new System.Drawing.Size(36, 20);
            this.clockHourInput.TabIndex = 3;
            this.clockHourInput.TextChanged += new System.EventHandler(this.ClockHourInput);
            this.clockHourInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HourOnlyNumbers);
            // 
            // clockminuteinput
            // 
            this.clockMinuteInput.Location = new System.Drawing.Point(129, 101);
            this.clockMinuteInput.Name = "clockminuteinput";
            this.clockMinuteInput.Size = new System.Drawing.Size(36, 20);
            this.clockMinuteInput.TabIndex = 4;
            this.clockMinuteInput.TextChanged += new System.EventHandler(this.ClockMinuteInput);
            this.clockMinuteInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinuteOnlyNumbers);
            // 
            // clockhour
            // 
            this.clockhour.AutoSize = true;
            this.clockhour.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockhour.Location = new System.Drawing.Point(86, 143);
            this.clockhour.Name = "clockhour";
            this.clockhour.Size = new System.Drawing.Size(49, 33);
            this.clockhour.TabIndex = 5;
            this.clockhour.Text = "00";
            this.clockhour.TextChanged += new System.EventHandler(this.RestartHourIf24);
            // 
            // clockminute
            // 
            this.clockminute.AutoSize = true;
            this.clockminute.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockminute.Location = new System.Drawing.Point(141, 143);
            this.clockminute.Name = "clockminute";
            this.clockminute.Size = new System.Drawing.Size(49, 33);
            this.clockminute.TabIndex = 6;
            this.clockminute.Text = "00";
            this.clockminute.TextChanged += new System.EventHandler(this.AddHourIfMin60);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 143);
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
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(73, 178);
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
            this.label4.Location = new System.Drawing.Point(106, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Alarm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Set Hour: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Set Minute: ";
            // 
            // alarmHinput
            // 
            this.alarmHinput.Location = new System.Drawing.Point(129, 289);
            this.alarmHinput.Name = "alarmHinput";
            this.alarmHinput.Size = new System.Drawing.Size(36, 20);
            this.alarmHinput.TabIndex = 13;
            this.alarmHinput.TextChanged += new System.EventHandler(this.alarmHourInput);
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
            this.alarmMinput.Location = new System.Drawing.Point(129, 320);
            this.alarmMinput.Name = "alarmMinput";
            this.alarmMinput.Size = new System.Drawing.Size(36, 20);
            this.alarmMinput.TabIndex = 16;
            this.alarmMinput.TextChanged += new System.EventHandler(this.alarmMinuteInput);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 422);
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
        private System.Windows.Forms.Label errormessage;
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
    }
}

