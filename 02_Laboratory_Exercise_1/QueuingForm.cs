namespace _02_Laboratory_Exercise_1
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier; 

        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();  
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}

