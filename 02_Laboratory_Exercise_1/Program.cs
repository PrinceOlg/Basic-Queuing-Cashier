namespace _02_Laboratory_Exercise_1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            QueuingForm queuingForm = new QueuingForm();
            CashierWindowQueue cashierWindowQueue = new CashierWindowQueue();

            cashierWindowQueue.Show();

            Application.Run(queuingForm);
        }
    }
}