/* I stole this code from ElektronGeek, but i love him so it doesn't matter, also i made some improvements */
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
using System.Management;
using System.Timers;

namespace Test_serial
{
    //This test program is intended to send CPU % usage over serial port as a string to be readed on an arduino or similar device

    public partial class Form1 : Form
    {

        // Creating and opening a serial port (here it is COM4)
        SerialPort Portserie = new SerialPort("COM3", 9800, Parity.None, 8, StopBits.One);


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
        private void Timer1_Tick(object sender, EventArgs e)
        {
            long MaxRam = 4294967296 * 2;


            String CPU = "CPU : " + Math.Round(CPUCounter.NextValue(), 1).ToString() + "%";
                Process[] processes = Process.GetProcesses();
                long UsedRam = 0;
                foreach (Process process in processes)
                {
                UsedRam += process.WorkingSet64;
                }
            String RAM = ("RAM : " + ((UsedRam*100)/MaxRam).ToString() + "%");
            String NetBios = Environment.MachineName;
            String NTver  = Environment.OSVersion.ToString();
                if (Equals(NTver.Substring(0, 9),"Microsoft")) NTver = NTver.Substring(18, NTver.Length-18);
            String OS;
                var name = (from x in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().Cast<ManagementObject>()
                select x.GetPropertyValue("Caption")).FirstOrDefault();
                OS = name != null ? name.ToString() : "Unknown";
                if (Equals(OS.Substring(0, 9), "Microsoft")) OS = OS.Substring(10, OS.Length - 10);
            String User = Environment.UserName;
            String UpTime = "Uptime : " + TimeSpan.FromMilliseconds(Environment.TickCount).ToString(@"dd\:hh\:mm\:ss");

           
            Cpu_USAGE.Text = CPU;
            label2.Text = OS;
            label1.Text = NetBios;
            label3.Text = NTver;
            label4.Text = UpTime;
            label5.Text = RAM;
            label6.Text = User;
            //Sending data over the port
            if (Output.Checked == true)
            {
                if (Portserie.IsOpen == true)
                {
                    //for now i wait bewteen every information since i use a small lcd that can only display a few characters at a time
                    //Writing CPU String over serial 
                    Portserie.Write(CPU);
                    System.Threading.Thread.Sleep(2000);
                    Portserie.Write(User + "@" + NetBios);
                    System.Threading.Thread.Sleep(2000);
                    Portserie.Write(RAM);
                    System.Threading.Thread.Sleep(2000);
                    Portserie.Write(OS);
                    System.Threading.Thread.Sleep(2000);
                    Portserie.Write(NTver);
                    System.Threading.Thread.Sleep(2000);
                    Portserie.Write(UpTime);
                    System.Threading.Thread.Sleep(2000);
                    


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
