using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task Parte 1
            // Criando uma tarefa usando Task construtor e, em seguida, iniciando-a
            //Task t1 = new Task(Tarefa);
            //t1.Start();

            // Criando uma tarefa usando Task.Run e iniciando-a (forma mais comum)
            //Task t2 = Task.Run(Tarefa);

            // Criando e iniciando uma tarefa diretamente com Task.Run
            //Task.Run(Tarefa);

            // Criando e iniciando uma tarefa usando Task.Factory.StartNew (menos comum)
            //Task.Factory.StartNew(Tarefa);

            // Criando e iniciando uma tarefa anônima com Task.Run
            //Task.Run(() =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("Tarefa anônima.");
            //    }
            //});

            // Loop principal
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Principal.");
            //}
            #endregion

            #region Task Parte 2
            //Task[] tasks =
            //{
            //    Task.Factory.StartNew(() =>
            //    {
            //        Console.WriteLine("Tarefa #1");
            //    }),

            //    Task.Factory.StartNew(() => 
            //    {
            //        Console.WriteLine("Tarefa #2");
            //    }),

            //    Task.Factory.StartNew(() => 
            //    {
            //        Console.WriteLine("Tarefa #3");
            //    })
            //};

            //Task.WaitAll(tasks);

            //#####
            //Task t1 = Task.Run(() => { Console.WriteLine("Comando #1"); });
            //Task t2 = Task.Run(() => { Console.WriteLine("Comando #2"); });
            //Task t3 = Task.Run(() => { Console.WriteLine("Comando #3"); });

            //Task.WaitAll(t1, t2, t3);

            //Console.WriteLine("Principal.");
            #endregion

            //Task<int> tarefa1 = Task.Factory.StartNew(() => Dobro(5)); // mostra como obter o retorno de uma tarefa
            //Console.WriteLine(tarefa1.Result);

            // Inicializa uma tarefa (Task) chamada tarefa1 que gera um número aleatório.
            Task<int> tarefa1 = Task.Factory.StartNew(() =>
            {
                return new Random().Next(10);
            });

            // Cria uma segunda tarefa (tarefa2) que continua a partir da primeira tarefa (tarefa1) e duplica o número resultante.
            Task<int> tarefa2 = tarefa1.ContinueWith((num) =>
            {
                return num.Result * 2;
            });

            // Cria uma terceira tarefa (tarefa3) que continua a partir da segunda tarefa (tarefa2) e cria uma string com o valor resultante.
            Task<string> tarefa3 = tarefa2.ContinueWith((num) =>
            {
                return "Valor Final " + num.Result;
            });

            // Aguarda a conclusão da terceira tarefa e imprime o resultado na tela.
            Console.WriteLine(tarefa3.Result);
            Console.ReadKey();
        }

        static int Dobro(int num)
        {
            return num * 2;
        }

        static private void Tarefa()
        {
            // Tarefa que imprime "Tarefa do task." 10 vezes
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa do task.");
            }
        }
    }
}
