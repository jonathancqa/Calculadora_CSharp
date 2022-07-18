using System;

namespace Calculadora 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, operacao = 1;

            Console.WriteLine("===== Calculadora ===== \n " +
                "Ligar - 1 \n " +
                "Desligar - 0 \n");
            Console.WriteLine("Digite sua opção: ");
            int Ligar = int.Parse(Console.ReadLine());
            if (Ligar == 1)
            {

                do
                {
                    Console.WriteLine("Digite a opção que deseja calcular: \n" +
                    " 1 - Adição\n" +
                    " 2 - Subtração\n" +
                    " 3 - Mulriplicação\n" +
                    " 4 - Divisão \n" +
                    " 0 - Desligar a Calculadora");

                    int menu = int.Parse(Console.ReadLine());

                    switch (menu)
                    {

                        case 0:
                            Console.WriteLine("Calculadora Desligada!");
                            return;

                        case 1:
                            Console.Write("Digite o primeiro número: ");
                            num1 = int.Parse(Console.ReadLine());
                            Console.Write("Digite o segundo número: ");
                            num2 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Resultado da Soma: " + Soma(num1, num2));
                            break;

                        case 2:
                            Console.Write("Digite o primeiro número: ");
                            num1 = int.Parse(Console.ReadLine());
                            Console.Write("Digite o segundo número: ");
                            num2 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Resultado da Subtração: " + Subtracao(num1, num2));
                            break;

                        case 3:
                            Console.Write("Digite o primeiro número: ");
                            num1 = int.Parse(Console.ReadLine());
                            Console.Write("Digite o segundo número: ");
                            num2 = int.Parse(Console.ReadLine());

                            Console.WriteLine(Multiplicacao(num1, num2));
                            break;

                        case 4:
                            Console.Write("Digite o primeiro número: ");
                            num1 = int.Parse(Console.ReadLine());
                            Console.Write("Digite o segundo número: ");
                            num2 = int.Parse(Console.ReadLine());

                            try
                            {
                                int resultD = Divisao(num1, num2);
                                Console.WriteLine($"Valor da Divisão é: {resultD}");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"ERRO:{e}");
                            }

                            break;


                        default:
                            Console.WriteLine("Você digitou uma opção errada.\n ");
                            break;
                    }
                    Console.WriteLine("Deseja Continuar : \n" +
                        " 1 - Sim \n" +
                        " 0 - Não");
                    operacao = int.Parse(Console.ReadLine());

                }while (operacao != 0);
                Console.WriteLine("Calculadora Desligada!");

            }
            else
            {
                Console.WriteLine("Calculadora Desligada!");
            }




            static int Soma(int num1, int num2)
            {
                return num1 + num2;
            }

            static int Subtracao(int num1, int num2)
            {
                return num1 - num2;
            }

            static int Multiplicacao(int num1, int num2)
            {
                return num1 * num2;
            }

            static int Divisao(int num1, int num2)
            {

                if (DiferenteDeZero(num1)) throw new Exception("Divisor não pode ser 0.");

                return num1 / num2;

                bool DiferenteDeZero(int num1)
                {
                    if (num1 == 0) return true;
                    return false;
                }


            }
        }
    }
}
