using BasicThreadDemo;

namespace BasicThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "-Before starting thread-";
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.Clear();
            Console.WriteLine("-Before starting thread-");

  
            Thread threadA = new Thread(MyThreadClass.Thread1) { Name = "Thread A" };
            Thread threadB = new Thread(MyThreadClass.Thread1) { Name = "Thread B" };

            threadA.Start();
            threadB.Start();

      
            threadA.Join();
            threadB.Join();

      
            Console.WriteLine("-End of Thread-");
            label1.Text = "-End of Thread-";
        }
    }
}
