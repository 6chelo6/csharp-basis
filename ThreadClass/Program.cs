using System;
using System.Threading;

namespace ThreadClass
{
    class Program
    {
        [ThreadStatic]
        static int _fieldSample;

        static void Main(string[] args)
        {
            // ThreadOne();
            // ThreadTwo();
            // ThreadThree();
            ThreadSix();
        }


        public static void ThreadSix()
        {
            ThreadLocal<int> _field =
                    new ThreadLocal<int>(() =>
                    {
                        return Thread.CurrentThread.ManagedThreadId;
                    });
            new Thread(() =>
                        {
                            for (int x = 0; x < _field.Value; x++)
                            {
                                Console.WriteLine("Thread A: {0}", x);
                            }
                        }).Start();
            new Thread(() =>
                        {
                            for (int x = 0; x < _field.Value; x++)
                            {
                                Console.WriteLine("Thread B: {0}", x);
                            }
                        }).Start();
            Console.ReadKey();
        }

        /// Using the ThreadStaticAttribute.
        public static void ThreadThree()
        {
            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _fieldSample++;
                    Console.WriteLine("Thread A: {0}", _fieldSample);
                }
            }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _fieldSample++;
                    Console.WriteLine("Thread B: {0}", _fieldSample);
                }
            }).Start();
            Console.ReadKey();
        }

        /// Stopping a thread
        public static void ThreadTwo()
        {
            bool stopped = false;
            Thread t = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));

            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            stopped = true;
            // t.Join();
        }

        /// A method to run two threads with priorities.
        public static void ThreadOne()
        {

            Thread a = new Thread(mythread1);
            a.Name = "Thread A";
            a.Start();
            a.Priority = ThreadPriority.Highest;
            // a.Join();
            Thread b = new Thread(mythread2);
            b.Name = "Thread B";
            b.Priority = ThreadPriority.Lowest;
            b.Start();
        }

        public static void mythread1()
        {
            Console.WriteLine("My Thread1");
            for (int z = 0; z < 3; z++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} [{z}] Thread");
                // Thread.Sleep(200);
            }
        }

        public static void mythread2()
        {
            Console.WriteLine("My Thread2");
            for (int z = 0; z < 3; z++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} [{z}] Thread");
                // Thread.Sleep(200);
            }
        }
    }
}
