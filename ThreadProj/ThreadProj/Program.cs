using System;
using System.Threading;

namespace ThreadProj
{
    class Program
    {
        static void Main(string[] args)
        {
            // criando uma thread secundaria
            Thread t = new Thread(ThreadB);
            // iniciando a thread
            t.Start();

            for (int a = 0; a < 100; a++)
            {
                Console.Write("A");
            }

            Console.ReadKey();

        }

        // thread secundaria
        static void ThreadB()
        {
            for (int x = 0; x < 100; x++)
            {
                Console.Write("B");
            }
        }
    }
}
