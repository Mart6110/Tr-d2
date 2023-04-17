using System;
using System.Threading;

namespace Tråd2
{
    class Program
    {
        static char ch = '*';
        static void Main(string[] args)
        {

            Thread p = new Thread(output);
            p.Name = "Printer";
            p.Start();

            Thread r = new Thread(input);
            r.Name = "Reader";
            r.Start();

            p.Join();
            r.Join();

            Console.ReadKey();


            static void input()
            {
                while (true)
                {
                    ch = Console.ReadKey().KeyChar;
                }
            }

            static void output()
            {
                while (true)
                {
                    Thread.Sleep(200);
                    Console.Write(ch);
                }
            }

        }
    }
}
