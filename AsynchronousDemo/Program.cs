using System.Threading.Tasks;

namespace AsynchronousDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ThreadDemo();
            Console.WriteLine("Main thread exits.");
        }

        private static void ThreadDemo()
        {
            // Khởi tạo hai luồng
            Thread thread1 = new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sleep for 2 seconds.");
                    Thread.Sleep(2000);
                }
            }));
            Thread thread2 = new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Sleep for 2 seconds.");
                    Thread.Sleep(2000);
                }
            }));

            // Bắt đầu thực hiện hai luồng
            thread2.Start();
            thread1.Start();

            // Đợi cho đến khi cả hai luồng hoàn thành
            thread1.Join();
            thread2.Join();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
