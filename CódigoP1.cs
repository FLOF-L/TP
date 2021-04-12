using System;
namespace EX12
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario;
            double reajuste, salario_atual;
            int tempo;
            string cargo;

           
            Console.WriteLine("Tabela de cargos \r\n" +
                "Gerente = G \r\n" +
                "Engenheiro = E \r\n" +
                "Técnico = T");

            Console.WriteLine("Cso seu cargo não esteja na tabela, digite a qualquer outra letra ");
            Console.Write("Qual letra representa seu cargo? ");
            cargo = Console.ReadLine();

            Console.Write("Qual é o seu salário? R$ ");
            salario = float.Parse(Console.ReadLine());


            Console.Write("Tempo(anos) na empresa: ");
            tempo = int.Parse(Console.ReadLine());

            if (cargo == "G")
            {
                if (tempo >= 5)
                {
                    reajuste = salario * 0.10;
                    salario_atual = salario + reajuste;
                    Console.WriteLine("Salario atual: {0}, salario antigo: {1}, reajuste:  {2}", salario_atual, salario, reajuste);
                }

                else
                {
                    if (tempo >= 3 && tempo < 5)
                    {
                        reajuste = salario * 0.09;
                        salario_atual = salario + reajuste;
                        Console.WriteLine("Salario atual: {0}, salario antigo: {1}, reajuste:  {2}", salario_atual, salario, reajuste);
                    }
                    else
                    {
                        if (tempo < 3)
                        {
                            reajuste = salario * 0.08;
                            salario_atual = salario + reajuste;
                            Console.WriteLine("Salario atual: {0}, salario antigo: {1}, reajuste:  {2}", salario_atual, salario, reajuste);
                        }

                    }
                }

            }

            if (cargo == "E")
            {
                if (tempo >= 5)
                {
                    reajuste = salario * 0.11;
                    salario_atual = salario + reajuste;
                    Console.WriteLine("Salario atual: {0}, salario antigo: {1}, reajuste:  {2}", salario_atual, salario, reajuste);
                }
                else
                {
                    if (tempo >= 3 && tempo < 5)
                    {
                        reajuste = salario * 0.10;

                        salario_atual = salario + reajuste;
                        Console.WriteLine("Salario atual: {0}, salario antigo: {1}, reajuste:  {2}", salario_atual, salario, reajuste);
                    }
                    else
                    {
                        if (tempo < 3)
                        {
                            reajuste = salario * 0.9;
                            salario_atual = salario + reajuste;
                            Console.WriteLine("Salario atual: {0}, salario antigo: {1}, reajuste:  {2}", salario_atual, salario, reajuste);
                        }
                    }
                }
            }

            if (cargo == "T")
            {
                if (tempo >= 5)
                {
                    reajuste = salario * 0.12;
                    salario_atual = salario + reajuste;
                    Console.WriteLine("Salario atual: {0}, salario antigo: {1}, reajuste:  {2}", salario_atual, salario, reajuste);
                }
                else
                {
                    if (tempo >= 3 && tempo < 5)
                    {
                        reajuste = salario * 0.11;
                        salario_atual = salario + reajuste;
                        Console.WriteLine("Salario atual: {0}, salario antigo: {1}, reajuste:  {2}", salario_atual, salario, reajuste);
                    }
                    else
                    {
                        if (tempo < 3)
                        {
                            reajuste = salario * 0.10;

                            salario_atual = salario + reajuste;
                            Console.WriteLine("Salario atual: {0}, salario antigo: {1}, reajuste:  {2}", salario_atual, salario, reajuste);
                        }
                    }
                }
            }

            if(cargo!="G" && cargo != "T" && cargo != "E")
            {

                reajuste = salario * 0.08;
                salario_atual = salario + reajuste;
                Console.WriteLine("Salario atual: {0}, salario antigo: {1}, reajuste:  {2}", salario_atual, salario, reajuste);

            }






        }
        }
