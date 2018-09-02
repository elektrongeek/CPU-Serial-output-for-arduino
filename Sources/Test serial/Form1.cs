using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using  System.IO.Ports;
using System.Diagnostics;
using System.Timers;

namespace Test_serial
{
    //This test program is intended to send CPU % usage over serial port as a string to be readed on an arduino or similar device

    public partial class Form1 : Form
    {

        // Creating and opening a serial port (here it is COM4)
        SerialPort Portserie = new SerialPort("COM4", 9800, Parity.None, 8, StopBits.One);


        // Creating CPU Counter to read CPU % Usage
        private PerformanceCounter CPUCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

    
        public Form1()
        {
            InitializeComponent();
           
            
        }


        private void Start_Click(object sender, EventArgs e)
        {
            Clock.Enabled = true;
            if (Output.Checked == true)
            {
                //Opening serial port
                Portserie.Open();
            }

        }

        // Using a timer to send data (configurated in the design view (default value 500ms)
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Creating new string to hold data
            String CPU;
            
            //Filling CPU String with DATA
            CPU = CPUCounter.NextValue().ToString();

            //Writing CPU usage into programm window
            Cpu_USAGE.Text = "CPU Usage " + CPU as string;
            if (Output.Checked == true)
            {
                if (Portserie.IsOpen == true)
                {
                    //Writing CPU String over serial 
                    Portserie.Write(CPU as string);
                }
                else
                {
                  //If serial port not oppened , open serial port
                    Portserie.Open();
                }
            }
        }

       
    }
}
