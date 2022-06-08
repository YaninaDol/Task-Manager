using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class ProcesControl : UserControl
    {
        public ProcesControl()
        {
            InitializeComponent();
        }

        public ProcesControl(string Name, double CPU,double Memory)
        {
            InitializeComponent();
            this.NameLB.Text = Name;
            this.CPULB.Text = Convert.ToString(string.Format("{0:F1} %", CPU));
            this.MemoryLB.Text = Convert.ToString(string.Format("{0:F1} МБ", Memory));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void снятьЗадачуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in Process.GetProcessesByName(this.NameLB.Text))
                {
                    item.Kill();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
           
        }
    }
}
