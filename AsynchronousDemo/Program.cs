using System.Threading.Tasks;

namespace AsynchronousDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example list of integers
            List<int> numbers = Enumerable.Range(1, 100).ToList(); // A list of numbers from 1 to 100

            int pageSize = 10; // Number of items per page
            int pageNumber = 1; // For example, we want to get the third page

            // Using Skip and Take for pagination
            var pagedNumbers = numbers.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            // Displaying the items on the third page
            foreach (var number in pagedNumbers)
            {
                Console.WriteLine(number);
            }
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
