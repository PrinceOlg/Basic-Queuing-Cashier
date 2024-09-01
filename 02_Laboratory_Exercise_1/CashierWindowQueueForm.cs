using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Laboratory_Exercise_1
{
    public partial class CashierWindowQueue : Form
    {
        private System.Windows.Forms.Timer timer;

        public CashierWindowQueue()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = (1 * 1000); 
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                CashierClass.CashierQueue.Dequeue(); // Remove the first item in the queue
                DisplayCashierQueue(CashierClass.CashierQueue); // Message when there are no longer numbers left in t he queue
            }
            else
            {
                MessageBox.Show("No more numbers in the queue.");
            }
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
    }
}
