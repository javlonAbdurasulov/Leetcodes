using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Leetcodes
{
    internal class Mutex
    {
        static Mutex mutexx = new Mutex();
        static int x = 0;
        public static void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(start);
                thread.Name = $"Thread: {i}";
                thread.Start();
            }

            Console.ReadLine();


        }
        public static void start()
        {
            //mutexx.WaitOne();
            x = 1;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name}:{x}");
                x++;
                Thread.Sleep(100);
            }
            //mutexx.ReleaseMutex();

        }
    }

}
