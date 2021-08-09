  /* 1.O custo de um carro novo ao consumidor é a soma
            do custo de fábrica com a porcentagem do
                            distribuidor e dos impostos(aplicados ao custo de
                            fábrica).Supondo que o percentual do distribuidor
                           seja de 28 % e os impostos de 45 %, escrever um
            algoritmo para ler o custo de fábrica de um carro,
            calcular e escrever o custo final ao consumidor.*/


            float custo;
            float custo_final;
            float valor_distruibuidor = 0;
            float valor_imposto = 0;

            Console.WriteLine("Digite o custo de fábrica do carro : ");
            custo = float.Parse(Console.ReadLine());

            float porcentagem_distribuidor = 0.28F;
            float porcentagem_imposto = 0.45F;

            valor_distruibuidor = custo * porcentagem_distribuidor;

            valor_imposto = custo * porcentagem_imposto;

            custo_final = valor_distruibuidor + valor_imposto + custo;


            Console.Write("O custo final do carro é de : {0}", custo_final);


            2






            3.Exercício 1024(Strings) do Desafio URI JUDGE










            4.Exercício 1036(Iniciante) do Desafio URI JUDGE.

            float a, b, c, delta, x1, x2;
            Console.Clear();
            Console.Write("Coeficiente A : ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Coeficiente B : ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Coeficiente C : ");
            c = float.Parse(Console.ReadLine());
            delta = (float)Math.Pow(b, 2) - (4 * a * c);
            if (a == 0)
            {
                Console.WriteLine("Não forma equação do 2º grau");
            }
            else
            {
                if (delta < 0)
                {
                    Console.WriteLine("Não existem raízes reais");
                }
                else
                {
                    x1 = (float)(-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (float)(-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("x1 = {0:f}", x1);
                    Console.WriteLine("x2 = {0:f}", x2);
                }









                5.Exercício 1052(Iniciante) do Desafio URI JUDGE.

            int n = 0;

                while (n <= 0 || n > 12)
                {
                    Console.WriteLine("Digite um número para ver o mês equivalente: ");
                    n = int.Parse(Console.ReadLine());
                }


                if (n == 1)
                {
                    Console.WriteLine("Janeiro");
                }
                if (n == 2)
                {
                    Console.WriteLine("Fevereiro");
                }
                if (n == 3)
                {
                    Console.WriteLine("Março");
                }

                if (n == 4)
                {
                    Console.WriteLine("Abril");
                }
                if (n == 5)
                {
                    Console.WriteLine("Maio");
                }

                if (n == 6)
                {
                    Console.WriteLine("Junho");
                }
                if (n == 7)
                {
                    Console.WriteLine("Julho");
                }
                if (n == 8)
                {
                    Console.WriteLine("Agosto");
                }
                if (n == 9)
                {
                    Console.WriteLine("Setembro");
                }
                if (n == 10)
                {
                    Console.WriteLine("Outubro");
                }
                if (n == 11)
                {
                    Console.WriteLine("Novembro");
                }
                if (n == 12)
                {
                    Console.WriteLine("Dezembro");
                }








                6.Exercício 1176(Iniciante) do Desafio URI JUDGE.


            int[] Fibo = new int[64];

                int termo = 0;

                while (termo <= 0 || termo > 60)
                {
                    Console.WriteLine("Insira o termo no qual deseja-se saber o número correspondente: ");
                    termo = int.Parse(Console.ReadLine());

                }

                for (int i = 0; i <= termo; i++)
                {
                    if (i == 0)
                    {
                        Fibo[i] = 0;

                    }

                    if (i == 1 || i == 2)
                    {
                        Fibo[i] = 1;
                    }

                    if (i > 2)
                    {
                        Fibo[i] = (Fibo[i - 1]) + (Fibo[i - 2]);
                    }


                }
                Console.WriteLine(Fibo[termo]);









                7.Exercício 1177(Iniciante) do Desafio URI JUDGE.

            int[] N = new int[10];

                int t = 0;

                while (t <= 2 || t > 50)
                {
                    t = int.Parse(Console.ReadLine());
                }

                int cont = 0;
                for (int i = 0; i < N.Length; i++)
                {


                    N[i] = cont;

                    if ((N[i] + 1) == t)
                    {
                        cont = 0;
                    }

                    Console.WriteLine(N[i]);
                    cont++;

                }




                8.Exercício 1178(Iniciante)do Desafio URI JUDGE.

            int x = 0;
                while (x <= 0)
                {
                    x = int.Parse(Console.ReadLine());
                }
                int[] N = new int[100];

                for (int i = 0; i < N.Length; i++)
                {
                    if (i == 0)
                    {
                        N[i] = x;
                    }

                    if (i == 1)
                    {
                        N[i] = x / 2; vaga
                    }

                    if (i > 1)
                    {
                        N[i] = (N[i - 1] / 2);
                    }


                    if (N[i] != 0)
                    {
                        Console.WriteLine("N" + "(" + i + ")" + N[i]);
                    }


                }






                9.Exercício 1179(Iniciante)do Desafio URI JUDGE.

            int[] par = new int[5];
                int[] impar = new int[5];

                Console.WriteLine("Digite 15 números: ");
                int n = 0;
                int cont = 0;

                for (int i = 0; i <= 14; i++)
                {
                    n = int.Parse(Console.ReadLine());

                    if (n % 2 == 0)
                    {
                        par[cont] = n;
                    }
                    else
                    {
                        impar[cont] = n;
                    }
                    cont++;

                    if (cont == 4 && cont == 9 && cont == 14)
                    {
                        for (int e = 0; e <= 4; e++)
                        {
                            Console.WriteLine(par[e]);
                        }
                        for (int e = 0; e <= 4; e++)
                        {
                            Console.WriteLine(impar[e]);
                        }

                        cont = 0;

                    }

                }





                int n = 0;

                while (n <= 0)
                {
                    n = int.Parse(Console.ReadLine());

                }

                for (int i = n; n > 0; n--)
                {

                    Console.WriteLine(n);

                }
