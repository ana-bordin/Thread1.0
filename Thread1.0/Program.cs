﻿namespace Thread1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Thread thread1 = new Thread(() => ThreadMethod1());
            Thread thread2 = new Thread(() => ThreadMethod2());
            Thread thread31 = new Thread(() => ThreadMethod3(10));


            ThreadStart ts = new ThreadStart(ThreadMethod1);
            Thread thread3 = new Thread(ts);

            Thread thread4 = new Thread(new ThreadStart(ThreadMethod1));
            Thread thread5 = new Thread(new ParameterizedThreadStart(ThreadMethod3));

            thread5.Start(10);

            //inicia
            thread1.Start();
            thread2.Start();

            //espera threads
            thread1.Join();
            thread2.Join();

            Console.WriteLine("Fim");
        }

        static void ThreadMethod1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread 1: " + i);
                // Thread.Sleep(1000);
            }
        }

        static void ThreadMethod2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread 2: " + i);
            }
        }

        static void ThreadMethod3(object qtd)
        {
            Console.WriteLine("Teste: " + (int)qtd);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread 2: " + i);
            }
        }
    }
}
