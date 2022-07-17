namespace RacunalniSustaviProjekt
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.PortBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConnectToPort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Motor_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ReceivedDataBox = new System.Windows.Forms.TextBox();
            this.HumidityBox = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM3";
            // 
            // PortBox
            // 
            this.PortBox.Location = new System.Drawing.Point(41, 66);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(184, 24);
            this.PortBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(67, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dostupni portovi";
            // 
            // ConnectToPort
            // 
            this.ConnectToPort.Location = new System.Drawing.Point(41, 96);
            this.ConnectToPort.Name = "ConnectToPort";
            this.ConnectToPort.Size = new System.Drawing.Size(75, 23);
            this.ConnectToPort.TabIndex = 3;
            this.ConnectToPort.Text = "Connect";
            this.ConnectToPort.UseVisualStyleBackColor = true;
            this.ConnectToPort.Click += new System.EventHandler(this.Connect_To_Port);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Servo-Motor :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Disconnect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Disconnect);
            // 
            // Motor_Button
            // 
            this.Motor_Button.Location = new System.Drawing.Point(70, 185);
            this.Motor_Button.Name = "Motor_Button";
            this.Motor_Button.Size = new System.Drawing.Size(131, 35);
            this.Motor_Button.TabIndex = 7;
            this.Motor_Button.Text = "Pali/Gasi ";
            this.Motor_Button.UseVisualStyleBackColor = true;
            this.Motor_Button.Click += new System.EventHandler(this.Motor_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vlažnost :";
            // 
            // ReceivedDataBox
            // 
            this.ReceivedDataBox.Location = new System.Drawing.Point(357, 95);
            this.ReceivedDataBox.Multiline = true;
            this.ReceivedDataBox.Name = "ReceivedDataBox";
            this.ReceivedDataBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReceivedDataBox.Size = new System.Drawing.Size(404, 229);
            this.ReceivedDataBox.TabIndex = 9;
            // 
            // HumidityBox
            // 
            this.HumidityBox.Location = new System.Drawing.Point(481, 56);
            this.HumidityBox.Name = "HumidityBox";
            this.HumidityBox.Size = new System.Drawing.Size(139, 33);
            this.HumidityBox.TabIndex = 10;
            this.HumidityBox.Text = "Učitaj Vrijednost";
            this.HumidityBox.UseVisualStyleBackColor = true;
            this.HumidityBox.Click += new System.EventHandler(this.Vlažnost_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = "Motor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.HumidityBox);
            this.Controls.Add(this.ReceivedDataBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Motor_Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConnectToPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox PortBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConnectToPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Motor_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ReceivedDataBox;
        private System.Windows.Forms.Button HumidityBox;
        private System.Windows.Forms.Button button2;
    }
}

