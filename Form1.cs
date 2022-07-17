using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; //Za serial port

namespace RacunalniSustaviProjekt
{
    public partial class Form1 : Form
    {
        
        private SerialPort newport;                                 //Serial port
        private string ReceivedData;                             //U slucaju da budem slao nešto sa arduina ovdje,sprema se u ovu varijablu.
        public Form1()
        {

            InitializeComponent();
            Motor.InitStp();
            AvailablePorts();
            this.FormClosed += new FormClosedEventHandler(FormClosing1);
            
         /*   if (newport == null)
            {
                newport = new SerialPort("COM3", 115200);// Automatska postavka Board-a
                newport.Open();
            }
        }
        */
        }
        void AvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();     //Dostupni COM ports.
            PortBox.Items.AddRange(ports);                  //PortBox je ComboBox di će se upisati svi dostupni portovi.
        }
        private void Connect_To_Port(object sender, EventArgs e)
        {
            MessageBox.Show("uslo u box!");
            if (newport == null)
            {
                MessageBox.Show("Proslo ovaj dio!");
                newport = new SerialPort();
                newport.BaudRate = 115200;
                newport.PortName = PortBox.Text;
                newport.DataReceived += newport_DataReceived;
                try
                {
                    newport.Open();
                    MessageBox.Show("Port je spojen!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error ..!");
                }
            }
        }

        private void newport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ReceivedData = newport.ReadLine();
            this.Invoke(new Action(ProcessingData));
        }

        private void ProcessingData()
        {
            ReceivedDataBox.Text += ReceivedData.ToString() + Environment.NewLine;
        }

        private void Vlažnost_Click(object sender, EventArgs e)
        {
            PortWrite("3");
        }
        private void Motor_Button_Click(object sender, EventArgs e)
        {
            PortWrite("1");
        }
        private void Button_Disconnect(object sender, EventArgs e)
        {
            PortWrite("4");
            try
            {
                if(newport!=null && newport.IsOpen)
                {
                    newport.Close();
                    MessageBox.Show("Port je uspjesno zatvoren!");
                    newport = null;
                }
                
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Error kod zatvaranja ...!");
            }
        }
        private void PortWrite(string message)
        {
            newport.Write(message);
        }
        private void FormClosing1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MotorManageForm2 form1 = new MotorManageForm2();
            const string message = "Ovo je dio za upravljanje stepper motorom.";
            const string caption = "Motor Form Opening";

            DialogResult result = MessageBox.Show(message,caption,
                                    MessageBoxButtons.OKCancel, 
                                    MessageBoxIcon.Warning);


            //try { }
                if (result == DialogResult.OK)

                {
                form1.Show();
                }
            
          /*  catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                form1.Close();
            }*/
        }
    }
}
