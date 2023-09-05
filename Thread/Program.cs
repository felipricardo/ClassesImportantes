using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Tarefa();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Principal");
            }

            Console.ReadKey();
        }

        static void Tarefa()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa Executada.");
            }
        }
    }
}
