using System;
using System.Threading;

namespace Timer
{
    class Timer
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("TIMER");
            Console.WriteLine("---------------------");
            Start();
        }
        static void Start()
        {
            Console.WriteLine("Digite abaixo os minutos e segundos!");
            Console.Write("Minutos: ");
            int minutos = int.Parse(Console.ReadLine());
            Console.Write("Segundos: ");
            int segundos = int.Parse(Console.ReadLine());

            for (; minutos != -1; minutos--) // CONTANDO OS MINUTOS
            {
                for (; segundos != -1; segundos--) // CONTANDO OS SEGUNDOS
                {
                    if (minutos <= 9) //Formatando a saída para os minutos
                    {
                        if (segundos <= 9) //Formatando a saída para os segundos
                        {
                            Console.Clear();
                            Console.Write("Tempo: 00:0{0}:0{1}", minutos, segundos);
                            Thread.Sleep(1000);
                        }
                        if (segundos >= 10 && segundos <= 59) //Formatando a saída para os segundos
                        {
                            Console.Clear();
                            Console.Write("Tempo: 00:0{0}:{1}", minutos, segundos);
                            Thread.Sleep(1000);
                        }
                    }
                    else if (minutos >= 10 && segundos <= 59) //Formatando a saída para os minutos
                    {
                        if (segundos <= 9) //Formatando a saída para os segundos
                        {
                            Console.Clear();
                            Console.Write("Tempo: 00:{0}:0{1}", minutos, segundos);
                            Thread.Sleep(1000);
                        }
                        if (segundos >= 10 && segundos <= 59) //Formatando a saída para os segundos
                        {
                            Console.Clear();
                            Console.Write("Tempo: 00:{0}:{1}", minutos, segundos);
                            Thread.Sleep(1000);
                        }
                    }
                }
                segundos = 60; // Após sair das estruturas de repetição define novamente o valor de segundos
            }
            Finalizacao();
        }
        static void Finalizacao()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("TEMPO ESGOTADO!");
            System.Console.WriteLine("Deseja fazer outra contagem regressiva? Digite 1 para SIM ou outro número para encerrar.");
            int resposta = int.Parse(Console.ReadLine());

            if (resposta == 1)
            {
                Start();
            }
        }
    }
}
