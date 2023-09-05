using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma nova thread e associando-a à função Tarefa
            Thread t = new Thread(new ThreadStart(Tarefa));

            // Definindo a thread como um thread em segundo plano (background thread)
            t.IsBackground = true;

            // Iniciando a execução da thread
            t.Start();

            // Esperando até que a thread termine
            t.Join();

            // Loop para imprimir "Principal" 10 vezes
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Principal");
                Thread.Sleep(500); // Aguardando por meio segundo
            }

            Console.ReadKey();
        }

        static void Tarefa()
        {
            // Loop para imprimir "Tarefa Executada." 10 vezes
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa Executada.");
                Thread.Sleep(1000); // Aguardando por um segundo
            }
        }
    }
}
