using System;

namespace Igor_Program_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atividade 1");
            Console.Write("01 " + "02 " + "03 " + "04 " + "05 " + "06 " + "07 " + "08 " + "09 " + "10 \n");
            Console.Write("11 " + "12 " + "13 " + "14 " + "15 " + "16 " + "17 " + "18 " + "19 " + "20 \n");
            Console.Write("21 " + "22 " + "23 " + "24 " + "25 " + "26 " + "27 " + "28 " + "29 " + "30 \n");
            Console.Write("31 " + "32 " + "33 " + "34 " + "35 " + "36 " + "37 " + "38 " + "39 " + "40 ");
            Console.ReadKey();
            
            Console.WriteLine("Atividade 2");

            int x = 2;
            int y = 3;

            Console.WriteLine("x = " + x);
            Console.WriteLine("O valor de x + x é = " + (x + x));
            Console.WriteLine("x = " + x);
            Console.WriteLine((x + y) + " = " + (y + x));
            Console.ReadKey();
            
            Console.WriteLine("Atividade 3");

            Console.Write("*\n**\n***\n****\n*****");
            Console.ReadKey();
            
            Console.WriteLine("Atividade 4");

            Console.Write("*");
            Console.Write("***");
            Console.WriteLine("*****");
            Console.Write("****");
            Console.WriteLine("**");
            Console.ReadKey();
            
            Console.WriteLine("Atividade 5");
            
            Console.WriteLine("Qual é o seu RA?");
            var mat = Console.ReadLine();

            Console.WriteLine("Qual é o seu Nome?");
            var nam = Console.ReadLine();

            Console.WriteLine("Qual é o seu Sobrenome?");
            var sub = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write($"{mat} ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"\n{nam} {sub}");
            Console.ResetColor();
            Console.ReadKey();
            
            Console.WriteLine("Atividade 6");

            int a;
            int b;
            int soma;
            int subtracao;
            int divisao;
            int multiplicacao;

            Console.WriteLine("Digite o numero A");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o numero A");
            b = Convert.ToInt32(Console.ReadLine());

            soma = a + b;
            subtracao = a - b;
            divisao = a / b;
            multiplicacao = a * b;

            Console.WriteLine("A soma deles é igual a: " + soma);
            Console.WriteLine("A subtração deles é igual a: " + subtracao);
            Console.WriteLine("A dividisão deles é igual a: " + divisao);
            Console.WriteLine("A multiplicação deles é igual a: " + multiplicacao);
            Console.ReadKey();
            
            Console.WriteLine("Atividade 7");
                        
            double PI = 3.14D;
            double raio = 0;
            double area = 0;
            double diam = 0;
            double circun = 0;

            Console.WriteLine("Digite o valor do Raio: ");
            raio = double.Parse(Console.ReadLine());

            area = PI * raio * raio;
            diam = 2 * raio;
            circun = PI * diam;

            Console.WriteLine("A aréa do circulo é: " + area);
            Console.WriteLine("O diamentro do circulo é: " + diam);
            Console.WriteLine("A circunferencia do circulo é: " + circun);
            Console.ReadKey();
            
            Console.WriteLine("Atividade 8");
            
            int o;
            int j;
            int resto;

            Console.WriteLine("Informe o valor de A");
            o = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o valor de B");
            j = Convert.ToInt32(Console.ReadLine());

            resto = o % j;
            if (resto == 0)
            {
                Console.Write($"{o} é multiplo de {j}");
                Console.ReadKey();
            }
            else
            {
                Console.Write($"{o} não é multiplo de {j}");
                Console.ReadKey();
                
            }


        }
    }
}
