/* I stole this code from ElektronGeek, but i love him so it doesn't matter, also i made some improvements */
/* I dont care that you stole my code , i love my Fox <3 */
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
            // Check if serial port is open (to prevent errors)
            if (Output.Checked == true)
            {
                //Opening serial port
                Portserie.Open();
            }

        }
            #region Collecting and processing some data
        // Using a timer to read data and to send it over serial (configurated in the design view (default value 500ms)
        private void Timer1_Tick(object sender, EventArgs e)
        {
            long MaxRam = 4294967296 * 2;

        // Collecting CPU load
            String CPU = "CPU : " + Math.Round(CPUCounter.NextValue(), 1).ToString() + "%";

        // Collecting RAM load
                Process[] processes = Process.GetProcesses();
                long UsedRam = 0;
                foreach (Process process in processes)
                {
                UsedRam += process.WorkingSet64;
                }
            String RAM = ("RAM : " + ((UsedRam*100)/MaxRam).ToString() + "%");

        // Collecting Netbios Name
            String NetBios = Environment.MachineName;

        // Collecting Build number
            String NTver  = Environment.OSVersion.ToString();
                if (Equals(NTver.Substring(0, 9),"Microsoft")) NTver = NTver.Substring(18, NTver.Length-18);

        // Collecting OS type
            String OS;
                var name = (from x in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().Cast<ManagementObject>()
                select x.GetPropertyValue("Caption")).FirstOrDefault();
                OS = name != null ? name.ToString() : "Unknown";
                if (Equals(OS.Substring(0, 9), "Microsoft")) OS = OS.Substring(10, OS.Length - 10);

        // Collecting Username
            String User = Environment.UserName;

        // Collecting Uptime
            String UpTime = "Uptime : " + TimeSpan.FromMilliseconds(Environment.TickCount).ToString(@"dd\:hh\:mm\:ss");
#endregion

            // Updating user interface 
            #region User Interface Display
            Cpu_USAGE.Text = CPU;
            Os_Type.Text = OS;
            Netbios_Name.Text = NetBios;
            Os_Version.Text = NTver;
            Machine_Uptime.Text = UpTime;
            Ram_USAGE.Text = RAM;
            Username.Text = User;
            #endregion

            //Sending data over Serial port
            #region Sending Data
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

#endregion
        }
    }
}
