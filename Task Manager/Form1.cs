using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class Form1 : Form
    {
        double s = 0;
        double s1 ;
        double cpu;
        PerformanceCounter cpuCounter;



        public Form1()
        {
            InitializeComponent();
            this.GenerateView();
        }

        public void GenerateView()
        {
            var wmiObject = new ManagementObjectSearcher("select * from Win32_OperatingSystem");

            var memoryValues = wmiObject.Get().Cast<ManagementObject>().Select(mo => new
            {
                FreePhysicalMemory = Double.Parse(mo["FreePhysicalMemory"].ToString()),
                TotalVisibleMemorySize = Double.Parse(mo["TotalVisibleMemorySize"].ToString())
            }).FirstOrDefault();

            if (memoryValues != null)
            {
                var percent = ((memoryValues.TotalVisibleMemorySize - memoryValues.FreePhysicalMemory) / memoryValues.TotalVisibleMemorySize) * 100;
                s1 = percent;
            }
           
           
            try
                {
               
                    panel1.Controls.Clear();
                    int x = 0;
                    foreach (var item in Process.GetProcesses())
                    {

                    cpuCounter = new PerformanceCounter("Process", "% Processor Time", item.ProcessName, true);
                    cpu = cpuCounter.NextValue()/(1000*1000);
                     ProcesControl tmp = new ProcesControl(item.ProcessName, cpu,item.PrivateMemorySize64/1024/1024);
                    tmp.Location = new Point(0, x);                
                    s += cpu;
                    panel1.Controls.Add(tmp);
                    x += tmp.Size.Height + 5;
                
                    }

                this.ProcCpuLB.Text = Convert.ToString(string.Format("{0:F1} %", s));
                this.ProcRamLB.Text = Convert.ToString(string.Format("{0:F1} %", s1));
                
            }
            catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void обновитьСейчасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.GenerateView();
          
        }

       
    }
}
