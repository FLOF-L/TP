using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FiboRecursivo
{
    class Program
    {
        //Ex1
        //static int Fatorial(int num,int i,int multiplica,int fatorial)
        //{     
        //    do
        //    {
        //        Console.Write("Digite um número positivo: ");
        //        num = int.Parse(Console.ReadLine());
        //    } while (num <= 0);

        //    i = num;
        // while( i > 0)
        //    {
        //        fatorial = fatorial * i;
        //        i--;
        //    }

        //    return (fatorial);

        //}
        //static void Main(string[] args)
        //{

        //    int multiplica = 0; ;
        //    int num = 0;
        //    int i = 0;
        //    int fatorial = 1;



        //    ;
        //    Console.WriteLine("{0}", Fatorial(num, i, multiplica, fatorial));

        //}






        //Ex2
        /*
        static bool VerificaPrimos(int numero)
        {
            


            bool primos = false;//controla quantos números primos o programa irá exibir.
            int resto = 0; // variável resto para encontrar o resto da divisão.
            
            int teste; // se o resto for igual a 0, incrementar teste.
            int contador;// irá funcionar como um divisor para acharmos o resto;

                contador = 2;

                teste = 0;
                while (numero > contador) // n > contador para não ocorrer o risco de realizar a operação 3/3 por exemplo.
                {

                    resto = numero % contador; // resto entre n e contador

                    if (resto == 0)
                    {
                        teste++; //incrementa teste caso resto seja 0.

                    }
                    contador = contador + 1; // incrementamos contador para realizar a divisão - enquanto n for maior que contador

                }

                if (teste == 0)
                {
                    

                    primos = true;
                    //se teste for = 0 quer dizer que o número é primo pois nenhum número entre 2 e o próprio número,
                    // ao realizarmos a divisão, deu resto 0;
                }

            return (primos);


          

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número e verificaremos se é primo.");
            int numero = int.Parse(Console.ReadLine());

                Console.Write(VerificaPrimos(numero));


        }
        */






        //Ex3
        //static int IdadeDias(int dias,int meses,int anos)
        // {
        //     int idade = (anos * 365) + (meses * 30) + dias;
        //     return (idade);
        // }

        // static void Main(string[] args)
        // {
        //     Console.Write("Digite quantos anos completos uma pessoa tem :  ");
        //     int anos = int.Parse(Console.ReadLine());
        //     Console.Write("Digite quantos meses completos uma pessoa tem :  ");
        //     int meses = int.Parse(Console.ReadLine());
        //     Console.Write("Digite quantos dias completos uma pessoa tem :  ");
        //     int dias = int.Parse(Console.ReadLine());

        //     Console.WriteLine(IdadeDias(dias, meses, anos));

        // }





        //Ex4
        //static void Array(ref int[] vetor)
        //{
        //    for (int i = 0; i < 20; i++)
        //    {
        //        Console.Write("Digite o {0}° número: ", i + 1);
        //        do
        //        {
        //            vetor[i] = int.Parse(Console.ReadLine());

        //        } while (vetor[i] < 0);

        //    }
        //}

        //static int soma(int[] vetor)
        //{
        //    int soma = 0;
        //    for (int i = 0; i < 20; i++)
        //    {
        //        if (vetor[i] % 2 == 0)
        //        {
        //            soma = soma + vetor[i];
        //        }
        //    }
        //    return (soma);
        //}

        //static int Maior(int[] vetor)
        //{
        //    int maior = 0;

        //    for (int i = 0; i < 20; i++)
        //    {
        //        if (i == 0)
        //        {
        //            maior = vetor[0];
        //        }
        //        if (vetor[i] > maior)
        //        {
        //            maior = vetor[i];
        //        }
        //    }
        //    return (maior);

        //}


        //static void Main(string[] args)
        //{
        //    int[] vetor = new int[20];
        //    int escolha;
        //    bool criou_array = false;

        //    do
        //    {
        //        Console.Clear();
        //        Console.WriteLine("1 ­ Digitação dos valores no ARRAY");
        //        Console.WriteLine("2 ­ Cálculo da soma dos números pares");
        //        Console.WriteLine("3 ­ Determinar maior número do ARRAY");
        //        Console.WriteLine("4 ­ Para SAIR");
        //        escolha = int.Parse(Console.ReadLine());

        //        if (escolha == 1)
        //        {
        //            if (criou_array == false)
        //            {
        //                Array(ref vetor);
        //                criou_array = true;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Array já criado!");
        //            }
        //        }

        //        if (escolha == 2)
        //        {
        //            if (criou_array == true)
        //            {
        //                Console.Write("A soma dos elementos pares do Array é {0}", soma(vetor)); 
        //            }
        //            else
        //            {
        //                Console.WriteLine("Primeiro crie o array!");
        //                escolha = 1;
        //            }
        //            Console.ReadKey();
        //        }


        //        if (escolha == 3)
        //        {
        //            if (criou_array == true)
        //            {
        //                Console.Write("O maior número do Array é {0}", Maior(vetor));
        //            }
        //            else
        //            {
        //                Console.WriteLine("Primeiro crie o array!");
        //                escolha = 1;
        //            }
        //            Console.ReadKey();
        //        }


        //        if (escolha == 4)
        //        {
        //            Console.WriteLine("Fim de serviço! ");
        //        }
        //    } while (escolha != 4);


        //}






        //Ex5

        //static void InsereCPF(ref int[] cpf)
        //{
           
        //    for (int i = 0; i < 11; i++)
        //    {
        //        cpf[i] = int.Parse(Console.ReadLine());
        //    }

        //}

        //static int PrimeiroNum(ref int[] cpf)
        //{
        //    int primeiro_num = 0;
        //    int contagem = 10;
        //    int aux = 0;
        //    int soma = 0;
        //    for (int i = 0; i < 9; i++)
        //    {
        //        aux = cpf[i] * contagem;
        //        soma = soma + aux;
        //        contagem--;
        //    }

        //    int resto = 0;
        //    resto = soma % 11;
        //    primeiro_num = 11 - resto;
        //    //Console.WriteLine("O primeiro digito é: {0}", primeiro_num);

        //    return (primeiro_num);
        //}

        //static int SegundoNum(ref int[] cpf)
        //{
        //    int segundo_num = 0;
        //    int contagem = 11;
        //    int aux = 0;
        //    int soma = 0;
        //    for (int i = 0; i < 10; i++)
        //    {
        //        if(i < 9)
        //        {
        //            aux = cpf[i] * contagem;
        //            soma = soma + aux;
        //            contagem--;
        //        }
               
        //        if(i == 9)
        //        {
        //            aux = PrimeiroNum(ref cpf) * contagem;
        //            soma = soma + aux;
        //        }
        //    }
        //    int resto = 0;
        //    resto = soma % 11;
        //    segundo_num = 11 - resto;
        //    //Console.WriteLine("O segundo digito é: {0}", segundo_num);
        //    return (segundo_num);

        //}

        //static string ValidaCPF(ref int[] cpf)
        //{
        //    int[] verifica_cpf = new int[11];
        //    int validando = 0;
        //    string resposta = "";
        //    for (int i = 0; i < 11; i++)
        //    {
        //        if(i < 9)
        //        {
        //            verifica_cpf[i] = cpf[i];
        //        }
        //        if(i == 9)
        //        {
        //            verifica_cpf[i] = PrimeiroNum(ref cpf);
        //        }
        //        if (i ==10)
        //        {
        //            verifica_cpf[i] = SegundoNum(ref cpf);
        //        }
        //    }

        //    for (int i = 0; i < 11; i++)
        //    {
        //        if(verifica_cpf[i] == cpf[i])
        //        {
        //            validando++;
        //        }
        //        else
        //        {
        //            validando = 0;
        //        }
        //    }
        //    if(validando == 11)
        //    {
        //         resposta = "O CPF inserido é VÁLIDO.";
        //        Console.WriteLine(resposta);
        //    }
        //   else
        //    {
        //        resposta = "O CPF inserido é INVALIDO.";
        //        Console.WriteLine(resposta);
        //    }
        //    return (resposta);
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Digite um CPF para validarmos: ");
        //    int[] cpf = new int[11];
        //   InsereCPF(ref cpf);
        //   PrimeiroNum(ref cpf);
        //    SegundoNum(ref cpf);
        //    ValidaCPF(ref cpf);


        //}
    }
}






