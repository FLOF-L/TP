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


            //Ex8
            Console.WriteLine("JOGO DA VELHA");
            string nome1, nome2;
            Console.Write("Digite o nome dos jogadores a seguir.");
            Console.WriteLine("O Jogador 1 ficará com  o  X  e o jogador 2 com a bolinha (O)");
            Console.Write("Jogador 1: ");
            nome1 = Console.ReadLine();
            Console.Write("Jogador 2: ");
            nome2 = Console.ReadLine();

            int[,] matriz = new int[3, 3];
            string[,] resposta = new string[3, 3];

            int linha, linha2, coluna, coluna2;
            int resto;
            bool vencedor = false;
            string res = "S" ;

            while (res == "S")
            {
                if(vencedor == true)
                {
                   
                    Console.WriteLine("Quer jogar novamente? Digite S para jogar novamente ou N para sair do jogo. ");
                    res = Console.ReadLine();

                    Console.Clear();
                    matriz[0, 0] = 0; matriz[0, 1] = 0; matriz[0, 2] = 0;
                    matriz[1, 0] = 0; matriz[1, 1] = 0; matriz[1,2 ] = 0;
                    matriz[2, 0] = 0; matriz[2, 1] = 0; matriz[2, 2] = 0;

                    resposta[0, 0] = null; resposta[0, 1] = null; resposta[0, 2] = null;
                    resposta[1, 0] = null; resposta[1, 1] = null; resposta[1, 2] = null;
                    resposta[2, 0] = null; resposta[2, 1] = null; resposta[2, 2] = null;
                }

                for (int i = 1; i <= 9; i++)
                {
                    vencedor = false;
                    resto = i % 2;
                  

                    
                    
                    if (resto == 0)
                    {

                        Console.WriteLine("Sua vez de jogar, {0}.Onde voce desejar posicionar seu X?", nome1);
                        Console.Write("Linha : ");
                        linha = int.Parse(Console.ReadLine());
                        Console.Write("Coluna : ");
                        coluna = int.Parse(Console.ReadLine());
                        while (linha > 3 || coluna > 3)
                        {
                            Console.WriteLine("Posição inexistente, digite novamente.");
                            Console.Write("Linha : ");
                            linha = int.Parse(Console.ReadLine());
                            Console.Write("Coluna : ");
                            coluna = int.Parse(Console.ReadLine());
                        }
                        linha2 = linha - 1;
                        coluna2 = coluna - 1;
                        while (resposta[linha2, coluna2] != null)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Posição já ocupada, digite outra: ");
                            Console.Write("Linha : ");
                            linha = int.Parse(Console.ReadLine());
                            Console.Write("Coluna : ");
                            coluna = int.Parse(Console.ReadLine());
                            while (linha > 3 || coluna > 3)
                            {
                                Console.WriteLine("Posição inexistente, digite novamente.");
                                Console.Write("Linha : ");
                                linha = int.Parse(Console.ReadLine());
                                Console.Write("Coluna : ");
                                coluna = int.Parse(Console.ReadLine());
                            }
                            linha2 = linha - 1;
                            coluna2 = coluna - 1;
                        }

                        if (resposta[linha2, coluna2] == null)
                        {
                            resposta[linha2, coluna2] = "X";
                        }

                        if (linha2 == 0 && coluna2 == 0)
                        {
                            matriz[0, 0] = 2;
                        }
                        if (linha2 == 0 && coluna2 == 1)
                        {
                            matriz[0, 1] = 9;
                        }
                        if (linha2 == 0 && coluna2 == 2)
                        {
                            matriz[0, 2] = 4;
                        }

                        if (linha2 == 1 && coluna2 == 0)
                        {
                            matriz[1, 0] = 7;
                        }
                        if (linha2 == 1 && coluna2 == 1)
                        {
                            matriz[1, 1] = 5;
                        }
                        if (linha2 == 1 && coluna2 == 2)
                        {
                            matriz[1, 2] = 3;
                        }

                        if (linha2 == 2 && coluna2 == 0)
                        {
                            matriz[2, 0] = 6;
                        }
                        if (linha2 == 2 && coluna2 == 1)

                        {
                            matriz[2, 1] = 1;
                        }
                        if (linha2 == 2 && coluna2 == 2)
                        {
                            matriz[2, 2] = 8;
                        }




                        for (int e = 0; e < 3; e++)
                        {
                            for (int j = 0; j < 3; j++)
                            {

                                if (resposta[e, j] == null)
                                {
                                    Console.Write("  ");
                                }

                                if (resposta[e, j] != null)
                                {
                                    Console.Write("{0} ", resposta[e, j]);
                                }


                            }
                            Console.WriteLine(" ");
                        }




                    }

                    if (resto != 0)
                    {
                        Console.WriteLine("Sua vez de jogar, {0}.Onde voce desejar posicionar seu O?", nome2);
                        Console.Write("Linha : ");
                        linha = int.Parse(Console.ReadLine());
                        Console.Write("Coluna : ");
                        coluna = int.Parse(Console.ReadLine());
                        while (linha > 3 || coluna > 3)
                        {
                            Console.WriteLine("Posição inexistente, digite novamente.");
                            Console.Write("Linha : ");
                            linha = int.Parse(Console.ReadLine());
                            Console.Write("Coluna : ");
                            coluna = int.Parse(Console.ReadLine());
                        }
                        linha2 = linha - 1;
                        coluna2 = coluna - 1;
                        while (resposta[linha2, coluna2] != null)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Posição já ocupada, digite outra: ");
                            Console.Write("Linha : ");
                            linha = int.Parse(Console.ReadLine());
                            Console.Write("Coluna : ");
                            coluna = int.Parse(Console.ReadLine());
                            while (linha > 3 || coluna > 3)
                            {
                                Console.WriteLine("Posição inexistente, digite novamente.");
                                Console.Write("Linha : ");
                                linha = int.Parse(Console.ReadLine());
                                Console.Write("Coluna : ");
                                coluna = int.Parse(Console.ReadLine());
                            }
                            linha2 = linha - 1;
                            coluna2 = coluna - 1;
                        }

                        if (resposta[linha2, coluna2] == null)
                        {
                            resposta[linha2, coluna2] = "O";
                        }

                        if (linha2 == 0 && coluna2 == 0)
                        {
                            matriz[0, 0] = 2;
                        }
                        if (linha2 == 0 && coluna2 == 1)
                        {
                            matriz[0, 1] = 9;
                        }
                        if (linha2 == 0 && coluna2 == 2)
                        {
                            matriz[0, 2] = 4;
                        }

                        if (linha2 == 1 && coluna2 == 0)
                        {
                            matriz[1, 0] = 7;
                        }
                        if (linha2 == 1 && coluna2 == 1)
                        {
                            matriz[1, 1] = 5;
                        }
                        if (linha2 == 1 && coluna2 == 2)
                        {
                            matriz[1, 2] = 3;
                        }

                        if (linha2 == 2 && coluna2 == 0)
                        {
                            matriz[2, 0] = 6;
                        }
                        if (linha2 == 2 && coluna2 == 1)

                        {
                            matriz[2, 1] = 1;
                        }
                        if (linha2 == 2 && coluna2 == 2)
                        {
                            matriz[2, 2] = 8;
                        }


                        for (int e = 0; e < 3; e++)
                        {
                            for (int j = 0; j < 3; j++)
                            {

                                if (resposta[e, j] == null)
                                {
                                    Console.Write("  ");
                                }

                                if (resposta[e, j] != null)
                                {
                                    Console.Write("{0} ", resposta[e, j]);
                                }

                            }
                            Console.WriteLine(" ");
                        }


                    }

                    if ((resposta[0, 0] == "X" && resposta[0, 1] == "X" && resposta[0, 2] == "X") || (resposta[0, 0] == "O" && resposta[0, 1] == "O" && resposta[0, 2] == "O"))
                    {
                        if (matriz[0, 0] + matriz[0, 1] + matriz[0, 2] == 15)
                        {
                            if (resto == 0)
                            {
                                Console.WriteLine("O vencedor é {0} ", nome1);
                            }

                            if (resto != 0)
                            {
                                Console.WriteLine("O vencedor é {0} ", nome2);
                            }
                            vencedor = true;
                            i = 10;
                        }
                    }

                    if ((resposta[1, 0] == "X" && resposta[1, 1] == "X" && resposta[1, 2] == "X") || (resposta[1, 0] == "O" && resposta[1, 1] == "O" && resposta[1, 2] == "O"))
                    {
                        if (matriz[1, 0] + matriz[1, 1] + matriz[1, 2] == 15)
                        {
                            if (resto == 0)
                            {
                                Console.WriteLine("O vencedor é {0} ", nome1);
                            }

                            if (resto != 0)
                            {
                                Console.WriteLine("O vencedor é {0} ", nome2);
                            }
                            vencedor = true;
                            i = 10;
                        }


                    }

                    if ((resposta[2, 0] == "X" && resposta[2, 1] == "X" && resposta[2, 2] == "X") || (resposta[2, 0] == "O" && resposta[2, 1] == "O" && resposta[2, 2] == "O"))
                    {
                        if (matriz[2, 0] + matriz[2, 1] + matriz[2, 2] == 15)
                        {
                            if (resto == 0)
                            {
                                Console.WriteLine("O vencedor é {0} ", nome1);
                            }

                            if (resto != 0)
                            {
                                Console.WriteLine("O vencedor é {0} ", nome2);
                            }
                            vencedor = true;
                            i = 10;
                        }

                    }

                    if ((resposta[0, 0] == "X" && resposta[1, 0] == "X" && resposta[2, 0] == "X") || (resposta[0, 0] == "O" && resposta[1, 0] == "O" && resposta[2, 0] == "O"))
                    {
                        if (matriz[0, 0] + matriz[1, 0] + matriz[2, 0] == 15)
                        {
                            if (resto == 0)
                            {
                                Console.WriteLine("O vencedor é {0} ", nome1);
                            }

                            if (resto != 0)
                            {
                                Console.WriteLine("O vencedor é {0} ", nome2);
                            }
                            vencedor = true;
                            i = 10;
                        }
                    }

                    if ((resposta[0, 1] == "X" && resposta[1, 1] == "X" && resposta[2, 1] == "X") || (resposta[0, 1] == "O" && resposta[1, 1] == "O" && resposta[2, 1] == "O"))
                    {
                        if (matriz[0, 1] + matriz[1, 1] + matriz[2, 1] == 15)
                        {
                            if (resto == 0)
                            {
                                Console.WriteLine("O vencedor é {0} ", nome1);
                            }

                            if (resto != 0)
                            {
                                Console.WriteLine("O vencedor é {0} ", nome2);
                            }
                            vencedor = true;
                            i = 10;
                        }
                    }

                    if ((resposta[0, 2] == "X" && resposta[1, 2] == "X" && resposta[2, 2] == "X") || (resposta[0, 2] == "O" && resposta[1, 2] == "O" && resposta[2, 2] == "O"))
                    {
                        if (matriz[0, 2] + matriz[1, 2] + matriz[2, 2] == 15)
                        {
                            if (resto == 0)
                            {
                                Console.WriteLine("O vencedor é {0} ", nome1);
                            }

                            if (resto != 0)
                            {
                                Console.WriteLine("O vencedor é {0} ", nome2);
                            }
                            vencedor = true;
                            i = 10;
                        }
                    }

                    if ((resposta[0, 2] == "X" && resposta[1, 1] == "X" && resposta[2, 0] == "X") || (resposta[0, 2] == "O" && resposta[1, 1] == "O" && resposta[2, 0] == "O"))
                    {
                        if (matriz[0, 2] + matriz[1, 1] + matriz[2, 0] == 15)
                        {
                            if (resto == 0)
                            {
                                Console.WriteLine("O vencedor é {0} ", nome1);
                            }

                            if (resto != 0)
                            {
                                Console.WriteLine("O vencedor é {0} ", nome2);
                            }
                            vencedor = true;
                            i = 10;
                        }
                    }


                    if ((resposta[0, 0] == "X" && resposta[1, 1] == "X" && resposta[2, 2] == "X") || (resposta[0, 0] == "O" && resposta[1, 1] == "O" && resposta[2, 2] == "O"))
                    {
                        if (matriz[0, 0] + matriz[1, 1] + matriz[2, 2] == 15)
                        {
                            if (resto == 0)
                            {
                                Console.WriteLine("O vencedor é {0} ", nome1);
                            }

                            if (resto != 0)
                            {
                                Console.WriteLine("O vencedor é {0} ", nome2);
                            }
                            vencedor = true;
                            i = 10;
                        }
                    }





                }

            }






        }


    }
}


