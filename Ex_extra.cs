//Exercícios do URI JUGDE para treino

            /*Leia 6 valores que podem ser números de ponto flutuante. Depois imprima quantos deles foram positivos. 
             * Na próxima linha, imprima a média de todos os valores positivos digitados, com um dígito após a vírgula decimal.*/


            //float n,porcentagem_pos;

            //n = 0;
            //int contador = 0;
            //float soma = 0;
            //int qtd_positivos;
            //qtd_positivos = 0;
            //float media = 0;

            //do
            //{
            //    Console.Write("Digite um número: ");
            //    n = float.Parse(Console.ReadLine());

            //    if (n > 0)
            //    {
            //        qtd_positivos = qtd_positivos + 1;
            //    }

            //    soma = soma + n;
            //    contador++;

            //} while (contador < 6);


            //media = soma / 6;


            //porcentagem_pos = (qtd_positivos / (float)6)* 100 ;

            //Console.WriteLine("A média é {0:f3}", media);
            //Console.WriteLine("A porcentagem de positivos é {0:f1}%", porcentagem_pos);





            //Exercício URI JUDGE
            //Leia um inteiro N e calcule todos os seus divisores.

            //int n;
            //Console.Write("Digite um número: ");
            //n = int.Parse(Console.ReadLine());

            //int divisor = 1;
            //int resto = 0;

            //do
            //{
            //    resto = n % divisor;

            //    if (resto == 0)
            //    {
            //        Console.WriteLine(divisor);
            //    }


            //    divisor++;



            //} while (divisor <= n);









            //Exercício URI JUDGE
            /*O programa deve ler um número inteiro X indefinidamente (parar quando X = 0 ). 
             * Para cada X , imprima a soma de cinco números pares consecutivos de X , incluindo se X for par. 
             * Se o número de entrada for 4, por exemplo,
             * a saída deve ser 40, esse é o resultado da operação: 4 + 6 + 8 + 10 + 12. 
             * Se o número de entrada for 11, por exemplo, a saída deve ser 80, que é o resultado de 12 + 14 + 16 + 18 + 20.*/

            //int x, soma, contador;
            //contador = 5;
            //soma = 0;
            //int num_par;


            //Console.Write("Digite o Número:");
            //x = int.Parse(Console.ReadLine());
            //while (contador > 0)
            //{
            //    num_par = x;
            //    if (num_par % 2 == (int)0)
            //    {

            //        soma = num_par + soma;
            //        x = x + 2;


            //    }

            //    if (x % 2 != (int)0)
            //    {
            //        if (contador == 5)
            //        {
            //            x = x + 1;
            //        }

            //        soma = x + soma;
            //        x = x + 2;


            //    }

            //    contador--;
            //}
            //Console.WriteLine(soma);



  //Exercícios URI JUDGE


            //Número: 1132
            /*Escreva um programa que leia dois números inteiros X e Y e calcule a soma de 
              todos os números não divisíveis por 13 entre eles, incluindo ambos.*/



            //int x, y;
            //int soma = 0;
            //int teste = 13;
            //int resto = 0;

            //Console.Write("Digite um valor: ");
            //x = int.Parse(Console.ReadLine());
            //Console.Write("Digite um valor: ");
            //y = int.Parse(Console.ReadLine());

            //if (x < y)
            //{
            //    while (x <= y)
            //    {
            //        resto = x % teste;

            //        if (resto != 0)
            //        {
            //            soma = soma + x;
            //        }

            //        x++;
            //    }

            //    Console.WriteLine(soma);

            //}

            //else
            //{
            //    while (y <= x)
            //    {
            //        resto = y % teste;

            //        if (resto != 0)
            //        {
            //            soma = soma + y;
            //        }

            //        y++;
            //    }

            //    Console.WriteLine(soma);
            //}










            //Número: 1144
            /*Escreva um programa que leia um número inteiro N. 
              N * 2 linhas devem ser impressas por este programa de acordo com o exemplo abaixo. 
              Para números com mais de 6 dígitos, todos os dígitos devem ser impressos (sem notação científica permitida).*/



            //int n;
            //n = 0;
            //int aux = 1;


            //while (n <= 1 || n >= 1000)
            //{
            //    Console.Write("Digite um número: ");
            //    n = int.Parse(Console.ReadLine());
            //}


            //while (aux <= n)
            //{

            //    Console.WriteLine("{0} {1} {2}", aux, Math.Pow(aux, 2), Math.Pow(aux, 3));
            //    Console.WriteLine("{0} {1} {2}", aux, Math.Pow(aux, 2) + 1, Math.Pow(aux, 3) + 1);
            //    aux++;
            //}









            //Número:1159

            /*O programa deve ler um número inteiro X indefinidamente (parar quando X = 0 ). 
             Para cada X , imprima a soma de cinco números pares consecutivos de X , incluindo se X for par. Se o número de entrada for 4, por exemplo, 
             a saída deve ser 40, esse é o resultado da operação: 4 + 6 + 8 + 10 + 12. 
            Se o número de entrada for 11, por exemplo, a saída deve ser 80, que é o resultado de 12 + 14 + 16 + 18 + 20.*/

            //int x, soma, contador;
            //contador = 5;
            //soma = 0;
            //int num_par;
            //x = 1;

            //while (x != 0)
            //{


            //    Console.Write("Digite o Número:");
            //    x = int.Parse(Console.ReadLine());



            //    while (contador > 0 && x != 0)
            //    {

            //        num_par = x;

            //        if (num_par % 2 == (int)0)
            //        {
            //            soma = num_par + soma;
            //            x = x + 2;
            //        }

            //        if (x % 2 != (int)0)
            //        {
            //            if (contador == 5)
            //            {
            //                x = x + 1;
            //            }
            //            soma = x + soma;
            //            x = x + 2;
            //        }

            //        contador--;
            //    }

            //    if (x != 0)
            //    {
            //        Console.WriteLine(soma);
            //        soma = 0;
            //        contador = 5;
            //    }


            //    if (x == 0)
            //    {
            //        Console.WriteLine("O programa se encerrou! ");
            //    }
            //}


















