using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FiboRecursivo
{
    class Program
    {
        static void Main(string[] args)
        {


            //Ex 1
            //int i, j, contador = 1;
            //string[,] matriz = new string[2, 3];
            //Entrada de dados via teclado e armazenamento na MATRIZ
            //for (i = 0; i < 2; i++)
            //{
            // for (j = 0; j < 3; j++)
            // {
            // Console.Write("Digite o {0} nome : ", contador);
            // matriz[i, j] = Console.ReadLine();
            // contador++;
            // }
            //}
            //Exibição dos valores armazenados na MATRIZ
            //for (i = 0; i < 2; i++)
            //{
            // for (j = 0; j < 3; j++)
            // {
            // Console.WriteLine("O valor da posição posicao {0},{1} é {2}", i, j, matriz[i, j]);
            // }
            //}
            //Console.ReadKey();




            //Ex 2
            //int i, j, contador = 1;
            //string[,] matriz = new string[3, 2];
            //// Entrada de dados via teclado e armazenamento na MATRIZ
            //for (i = 0; i < 3; i++)
            //{
            // for (j = 0; j < 2; j++)
            // {
            // Console.Write("Digite o {0} nome : ", contador);
            // matriz[i, j] = Console.ReadLine();
            // contador++;
            // }
            //}
            ////Exibição dos valores armazenados na MATRIZ
            //for (i = 0; i < 3; i++)
            //{
            // for (j = 0; j < 2; j++)
            // {
            // Console.WriteLine("O valor da posição posicao {0},{1} é {2}", i, j, matriz[i, j]);
            // }
            //}
            //Console.ReadKey();




            //Ex 3
            //int i, j, contador = 1;
            //string[,] matriz = new string[3, 2];
            //// Entrada de dados via teclado e armazenamento na MATRIZ
            //for (i = 0; i < 3; i++)
            //{
            // for (j = 0; j < 2; j++)
            // {
            // Console.Write("Digite o {0} nome : ", contador);
            // matriz[i, j] = Console.ReadLine();
            // contador++;
            // }
            //}
            ////Exibição dos valores armazenados na MATRIZ
            //for (i = 0; i < 3; i++)
            //{
            // for (j = 0; j < 2; j++)
            // {
            // Console.WriteLine("O valor da posição posicao {0},{1} é {2} ", i, j, matriz[i, j]);
            // }
            //}
            //Console.ReadKey();




            //Ex 4
            //int[,] n = new int[3, 4];
            //int i, j;
            //for (i = 0; i < 3; i++)
            //{
            // for(j = 0;j < 4; j++)
            // {
            // Console.Write("Digite o valor da posição {0},{1} :  ",i,j);
            // n[i, j] = int.Parse(Console.ReadLine());
            // }
            //}
            //Console.WriteLine("_________________________________________");
            //Console.WriteLine(" ");
            //Console.Write("Digite a constante mutiplicativa: ");
            //int k = int.Parse(Console.ReadLine());
            //Console.WriteLine(" ");
            //Console.WriteLine(" ");
            //for (i = 0; i < 3; i++)
            //{
            // for (j = 0; j < 4; j++)
            // {
            // n[i, j] = n[i, j] * k;
            // Console.WriteLine("Novo valor da posição {0},{1} :{2} ", i, j, n[i, j]);
            // }
            //}
            //Console.ReadKey();





            //Ex 5
            //int[,] antes = new int[3, 4];
            //int[,] depois = new int[3, 4];
            //int i, j;
            //for (i = 0; i < 3; i++)
            //{
            //    for (j = 0; j < 4; j++)
            //    {
            //        Console.Write("Digite o valor da posição {0},{1} : ", i, j);
            //        antes[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("_________________________________________");
            //Console.WriteLine(" ");
            //Console.Write("Digite a constante mutiplicativa: ");
            //int k = int.Parse(Console.ReadLine());
            //Console.WriteLine(" ");
            //Console.WriteLine(" ");

            //for (i = 0; i < 3; i++)
            //{
            //    for (j = 0; j < 4; j++)
            //    {
            //        depois[i, j] = antes[i, j] * k;
            //        Console.Write("{0}  ",depois[i, j]);


            //    }
            //    Console.WriteLine(" ");

            //}
            //Console.ReadKey();






            //Ex 6
            //int i, j;
            //Console.Write("Digite quantas linhas devem haver na matriz: ");
            //int linhas = int.Parse(Console.ReadLine());
            //Console.Write("Digite quantas colunas devem haver na matriz: ");
            //int colunas = int.Parse(Console.ReadLine());
            //Console.WriteLine(" ");

            //while (colunas > 10)
            //{
            //    Console.WriteLine("Por favor, digite novamente.O número de  colunas não pode ser maior do que 10: ");

            //    colunas = int.Parse(Console.ReadLine());
            //}
            //while (linhas > 10)
            //{
            //    Console.WriteLine("Por favor, digite novamente.O número de linhas não pode ser maior do que 10: ");

            //    linhas = int.Parse(Console.ReadLine());
            //}
            //int[,] matriz = new int[linhas, colunas];
            //for (i = 0; i < linhas; i++)
            //{
            //    for (j = 0; j < colunas; j++)
            //    {
            //        Console.Write("Digite a posição {0},{1}: ", i, j);
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("MATRIZ DIGITADA: ");
            //for (i = 0; i < linhas; i++)
            //{
            //    for (j = 0; j < colunas; j++)
            //    {
            //        Console.Write("{0}  ",matriz[i, j]);

            //    }
            //    Console.WriteLine(" ");
            //}
            //int[,] mt = new int[colunas, linhas];
            //for (i = 0; i < colunas; i++)
            //{
            //    for (j = 0; j < linhas; j++)
            //    {
            //        mt[i, j] = matriz[j,i];

            //    }

            //}
            //Console.WriteLine("MATRIZ TRANSPOSTA: ");

            //for (i = 0; i < colunas; i++)
            //{
            //    for (j = 0; j < linhas; j++)
            //    {

            //        Console.Write("{0} ", mt[i, j]);
            //    }
            //    Console.WriteLine(" ");
            //}



            //Console.ReadKey();









            //Ex 7
            //Console.Write("Digite a quantidade de setores: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine(" ");

            //Console.Write("Digite a quantidade de fileiras: ");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine(" ");

            //Console.Write("Digite a quantidade de cadeiras: ");
            //int z = int.Parse(Console.ReadLine());
            //Console.Clear();

            //Console.WriteLine("Total de {0} setores, {1} fileiras e {2} cadeiras em cada fileira. ", x, y, z);

            //int capacidade = (x * y) * z;
            //int recomendado = (capacidade / 5) * 4;
            //string nome = "";


            //string[,,] reservas = new string[x, y, z];

            //string resposta = "S";
            //int qtd_nomes = 0 ;

            //while (resposta == "S" || resposta == "s")
            //{
            //    Console.WriteLine(" ");
            //    Console.WriteLine("Digite S para reservar tickets. Caso queira encerrar o processo aqui, digite N. ");
            //    resposta = Console.ReadLine();

            //    if (resposta == "S" || resposta == "s")
            //    {


            //        Console.WriteLine(" ");
            //        Console.Write("Digite seu nome: ");
            //         nome = Console.ReadLine();
            //        Console.WriteLine(" ");
            //        Console.Write("Qual sessão você gostaria de ocupar? ");
            //        int section = int.Parse(Console.ReadLine());

            //        while (section > x)
            //        {
            //            Console.Write("Essa sessão não existe, por favor digite uma sessão válida: ");
            //            section = int.Parse(Console.ReadLine());


            //        }
            //        Console.WriteLine(" ");

            //        Console.Write("Em qual fileira ? ");
            //        int fileira = int.Parse(Console.ReadLine());
            //        while (fileira > y)
            //        {
            //            Console.Write("Essa fileira não existe, por favor digite uma fileira válida: ");
            //            fileira = int.Parse(Console.ReadLine());


            //        }

            //        Console.WriteLine(" ");

            //        Console.Write("E em qual assento? ");
            //        int cadeira = int.Parse(Console.ReadLine());

            //        while (cadeira > z)
            //        {
            //            Console.Write("Esse assento não existe, por favor digite um assento válido: ");
            //            cadeira = int.Parse(Console.ReadLine());


            //        }


            //        if (reservas[section - 1, fileira - 1, cadeira - 1] == null)
            //        {
            //            reservas[section - 1, fileira - 1, cadeira - 1] = nome;
            //            qtd_nomes++;
            //            Console.WriteLine("   ");
            //            Console.WriteLine("Lugar reservado para {0}. ", nome);
            //            Console.Write("Lembrando que sua sessão é {0}, sua fileira é {1}  e seu assento é o de número {2}", section, fileira, cadeira);
            //        }

            //        else
            //        {
            //            Console.WriteLine(" Infelizmente esse asento já está reservado. Por favor escolha outro a seguir.");
            //        }


            //        Console.WriteLine(" ");
            //    }

            //    if (qtd_nomes == recomendado)
            //    {
            //        Console.WriteLine("Infelizmente atingimos a capacidade suportada e não será possível reservar mais.Fique de olho nos próximos eventos! ");
            //        resposta = "N";
            //    }


            //    if (resposta == "n" || resposta == "N")
            //    {
            //        Console.WriteLine("Obrigado pelo acesso! Volte sempre");
            //    }



            //}


            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        for (int q = 0; q < z; q++)
            //        {
            //            if (reservas[i, j, q] == null)
            //            {
            //                Console.Write (" Livre ");
            //            }

            //            if (reservas[i, j, q] != null)
            //            {
            //                Console.Write(nome);
            //            }

            //        }
            //        Console.WriteLine("  ");
            //    }
            //    Console.WriteLine("  ");
            //}







           



        }


    }
}











