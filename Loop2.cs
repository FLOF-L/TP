using System;
namespace EX12
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Loop 

            //Ex 11
            /*Calcular e exibir a soma dos “N” primeiros valores da
sequência abaixo.O valor “N” será digitado, deverá ser
positivo, mas menor que cinquenta.Caso o valor não
satisfaça a restrição, enviar mensagem de erro e
solicitar o valor novamente.*/
            //Sequência : 1/2, 2/3, 3/4

            //double n, x;
            //int contador;
            //Console.Write("Número de vezes que a sequência deve se repetir: ");
            //n = int.Parse(Console.ReadLine());

            //contador = 0;
            //double conta, soma, resultado, y;
            //x = 1.0;
            //conta = 0;
            //soma = 0;
            //resultado = 0;

            //while (n <= 0 || n >= 50)
            //{
            //    Console.WriteLine("ERRO");
            //    Console.WriteLine("Digite um número para a sequência: ");
            //    n = int.Parse(Console.ReadLine());
            //}
            //while (contador < n)
            //{

            //    conta = x / (x+1);
            //    soma = soma + conta;
            //    conta = 0;
            //    x++;
            //    contador++;

            //}

         //Console.WriteLine("A soma é {0,4:F2}",soma);








            //Ex12
            /* Descreva um programa que receba via teclado 10 
(dez) valores e que, ao final, exiba o maior e menor 
deles.*/

            //int a, contador;
            //int maior, menor;

            //maior = 0;
            //menor = 0;
            //contador = 1;
            //Console.WriteLine("Digite 10 valores: ");

            //while (contador <= 10)
            //{
            //    Console.Write("Valor {0}: ", contador);
            //    a = int.Parse(Console.ReadLine());
            //    contador++;
            //    if (contador == 2)
            //    {
            //        maior = a;
            //        menor = a;
            //    }

            //    if (a > maior)
            //    {
            //        maior = a;
            //    }
            //    else
            //    {
            //        if (a < menor)
            //        {
            //            menor = a;
            //        }
            //    }

            //}
            //Console.WriteLine("Maior:{0} e menor:{1}", maior, menor);






            //Ex13
            /*Descreva um programa que calcule o resto da divisão 
de dois números A e B (A>B) utilizando somente 
subtrações. Faça todas as proteções necessárias.*/
            //int a, b, resto;

            //Console.Write("Digite o valor de A: ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("Digite o valor de B: ");
            //b = int.Parse(Console.ReadLine());
            //resto = 0;


            //while (b >= a)
            //{
            //    Console.Write("Digite os valores novamente.O valor de A deve ser maior que o de B");
            //    Console.Write("Digite o valor de A: ");
            //    a = int.Parse(Console.ReadLine());
            //    Console.Write("Digite o valor de B: ");
            //    b = int.Parse(Console.ReadLine());
            //}

            //if (a > b)
            //{
            //    Console.Write("{0} divido por {1} tem resto = ", a, b);
            //}


            //while (a >= b)
            //{
            //    a = a - b;
            //    resto = a;


            //}

            //Console.WriteLine(resto);




            //Ex14
            /*Descreva um programa que solicita que sejam 
digitados o peso e o sexo de um grupo de 100 (cem) 
pessoas. No final, o programa deverá mostrar na tela a 
média do peso dos homens e a média do peso das 
mulheres.*/
            //float peso, soma_peso_m, soma_peso_f;
            //int qtd_homens = 0;
            //int qtd_mulheres = 0;
            //string sexo;
            //int contador = 0;
            //soma_peso_m = 0;
            //soma_peso_f = 0;
            //float media_homens = 0;
            //float media_mulheres = 0;

            //while (contador < 4)
            //{
            //    sexo = " ";
            //    while (sexo != "M" && sexo != "F")
            //    {
            //        Console.Write("Digite o SEXO(M/F) : ");
            //        sexo = (Console.ReadLine().ToUpper());
            //    }

            //    peso = 0;
            //    while (peso <= 0)
            //    {
            //        Console.Write("Digite o PESO da pessoa: ");
            //        peso = float.Parse(Console.ReadLine());
            //        Console.WriteLine("_________________");
            //    }
            //    if (sexo == "M")
            //    {

            //        soma_peso_m = soma_peso_m + peso;
            //        qtd_homens++;
            //    }

            //    else
            //    {

            //        soma_peso_f = soma_peso_f + peso;
            //        qtd_mulheres++;

            //    }
            //    contador++;
            //}


            //media_homens = soma_peso_m / qtd_homens;
            //media_mulheres = soma_peso_f / qtd_mulheres;

            //Console.WriteLine("A média do peso dos homens é : {0:f2}Kg", media_homens);
            //Console.WriteLine("A média do peso das mulheres é: {0:f2}Kg", media_mulheres);




            ////Ex15
            /*Entrar via teclado com “N” valores quaisquer. O valor 
“N” (que representa a quantidade de números) será 
digitado, deverá ser positivo, mas menor que vinte. 
Caso a quantidade não satisfaça a restrição, enviar 
mensagem de erro e solicitar o valor novamente. Após 
a digitação dos “N” valores, exibir:*/
            /* a) O maior valor;
               b) O menor valor;
               c) A soma dos valores;
               d) A média aritmética dos valores;
               e) A porcentagem de valores que são positivos;
               f) A porcentagem de valores negativos.  */


            //int n, valor, soma;
            //int contador = 0;
            //int maior = 0;
            //int menor = 0;
            //n = 0;
            //valor = 0;
            //int n_positivos = 0;
            //int n_negativos = 0;
            //soma = 0;
            //float media = 0;
            //float porcentagem_p = 0;
            //float porcentagem_n = 0;


            //while (n <= 0 || n >= 20)
            //{
            //    Console.WriteLine("O número deve ser positivo e menor que 20");
            //    Console.Write("Digite a quantidade de números a serem digitados: ");
            //    n = int.Parse(Console.ReadLine());
            //}



            //while (contador < n)
            //{
            //    Console.Write("Digite um valor: ");
            //    valor = int.Parse(Console.ReadLine());
            //    contador++;

            //    //Descobrindo o menor e o maior.
            //    if (contador == 1)
            //    {
            //        maior = valor;
            //        menor = valor;

            //    }

            //    if (valor > maior)
            //    {
            //        maior = valor;
            //    }
            //    else
            //    {
            //        if (valor < menor)
            //        {
            //            menor = valor;
            //        }
            //    }

            //    //Descobrindo a soma;
            //    soma = soma + valor;

            //    //Marcando a entrada de numeros positivos e de numeros negativos;
            //    if (valor > 0)
            //    {
            //        n_positivos++;
            //    }
            //    if (valor < 0)
            //    {
            //        n_negativos++;
            //    }


            //}

            ////Calculando a porcentagem de positivos e negativos 

            //porcentagem_n = n_negativos / (float)n * 100;
            //porcentagem_p = n_positivos / (float)n * 100;

            ////Calculando a média
            //media = (float)soma / (float)n;

            //Console.WriteLine("1 - O maior valor é: {0}", maior);
            //Console.WriteLine("2 - O menor valor é: {0}", menor);
            //Console.WriteLine("3 - A soma de todos os números é {0}", soma);
            //Console.WriteLine("4 - A média aritmética dos valores é {0}", media); ;
            //Console.WriteLine("5 - A porcentagem de valores que são positivos é {0}", porcentagem_p);
            //Console.WriteLine("6 - A porcentagem de valores que são negativos é {0}", porcentagem_n);








        }

    }
            }
        
    

   
    



    


    
            
            


         
        
 








