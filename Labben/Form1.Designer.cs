
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
            this.clockhourinput = new System.Windows.Forms.TextBox();
            this.clockminuteinput = new System.Windows.Forms.TextBox();
            this.clockhour = new System.Windows.Forms.Label();
            this.clockminute = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errormessage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Set Hour: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Set Minute: ";
            // 
            // clockhourinput
            // 
            this.clockhourinput.Location = new System.Drawing.Point(142, 66);
            this.clockhourinput.Name = "clockhourinput";
            this.clockhourinput.Size = new System.Drawing.Size(36, 20);
            this.clockhourinput.TabIndex = 3;
            this.clockhourinput.TextChanged += new System.EventHandler(this.ClockHourInput);
            this.clockhourinput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HourOnlyNumbers);
            // 
            // clockminuteinput
            // 
            this.clockminuteinput.Location = new System.Drawing.Point(142, 97);
            this.clockminuteinput.Name = "clockminuteinput";
            this.clockminuteinput.Size = new System.Drawing.Size(36, 20);
            this.clockminuteinput.TabIndex = 4;
            this.clockminuteinput.TextChanged += new System.EventHandler(this.MinuteHourInput);
            this.clockminuteinput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinuteOnlyNumbers);
            // 
            // clockhour
            // 
            this.clockhour.AutoSize = true;
            this.clockhour.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockhour.Location = new System.Drawing.Point(96, 141);
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
            this.clockminute.Location = new System.Drawing.Point(168, 141);
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
            this.label6.Location = new System.Drawing.Point(147, 140);
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
            this.button1.Location = new System.Drawing.Point(91, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Start Clock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.startButton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.errormessage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clockminute);
            this.Controls.Add(this.clockhour);
            this.Controls.Add(this.clockminuteinput);
            this.Controls.Add(this.clockhourinput);
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
        private System.Windows.Forms.TextBox clockminuteinput;
        private System.Windows.Forms.Label clockhour;
        public System.Windows.Forms.Label clockminute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label errormessage;
        private System.Windows.Forms.TextBox clockhourinput;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

