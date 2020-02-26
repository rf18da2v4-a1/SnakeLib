using System;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            SnakeWorker worker = new SnakeWorker();
            worker.Start();

            Console.ReadLine();
        }
    }
}
