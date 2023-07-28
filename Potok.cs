using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcodes
{
    internal class Potok
    {
        static object _lock = new object();
        static int[] ints = new int[Environment.ProcessorCount];
        static int i = 0;
        
        static List<Task> tasks = new List<Task>();
        public static async Task SumMassiv(int[] nums)
        {

            //Задача "Сумма элементов массива":
            //Создайте массив случайных чисел и разделите его на несколько частей. Затем создайте несколько потоков, 
            //каждый из которых будет вычислять сумму своей части массива, и затем суммируйте полученные результаты. Проверьте правильность результата.
            int c = Environment.ProcessorCount;
            int count = nums.Length / c;
            int summ = 0;
            for (int i = 0; i < c; i++)
            {
                tasks.Add(sum(nums, i * count, count));
            }
            Task.Delay(1000).Wait();
            foreach (var task in ints)
            {
                summ+=task;
            }
            Console.WriteLine("sum:"+summ);


        }
        public static async Task sum(int[] nums,int a,int count)
        {
            int summ = 0;
            await Task.Delay(100);
            lock (_lock)
            {
                for (int i = a;i < nums.Length && i-a!=count;i++) { 
                        summ+= nums[i];
                    }
                    ints[i] = summ;
                    i++;
            }
        }
    }
}
