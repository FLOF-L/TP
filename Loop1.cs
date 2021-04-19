using System;
namespace EX12
{
    class Program
    {
        static void Main(string[] args)
        {

//            Loop While


//            Ex 1.Criar uma rotina de entrada que aceite somente um
//            valor positivo. 

//            int num = 0;

//            while (num <= 0)
//            {
//                Console.WriteLine("O valor deve ser positivo!");
//                Console.Write("Digite novamente: ");
//                num = int.Parse(Console.ReadLine());



//                Ex 2.Entrar com 2(dois) valores via teclado, onde o segundo
// deverá ser maior que o primeiro.Caso contrário solicitar
//novamente apenas o segundo valor. 
//            int n1, n2;
//                Console.Write("Valor 1: ");
//                n1 = int.Parse(Console.ReadLine());
//                n2 = 0;
//                n1 = n2;


//                while (n2 <= n1)
//                {
//                    Console.Write("Valor 2: ");
//                    n2 = int.Parse(Console.ReadLine());
//                }

//                Console.WriteLine("OK");


//                Ex 3 Entrar via teclado com o sexo de determinado usuário, 
//aceitar somente “F” ou “M” como respostas válidas.
//            char sexo;
//                Console.Write("Sexo: ");
//                sexo = char.Parse(Console.ReadLine());

//                while (sexo != 'M' && sexo != 'F')
//                {
//                    Console.Write("Sexo: ");
//                    sexo = char.Parse(Console.ReadLine());
//                }
//                Console.WriteLine("OK");



//                Ex 4  Exibir a tabuada do número 5(cinco) no intervalo de
//   um a dez.
//            int contador = 0;
//                int num = 5;

//                while (contador < 10)
//                {
//                    contador = contador + 1;
//                    Console.WriteLine("{0} x {1} = {2}", contador, num, contador * num);

//                }


//                Ex 5  Entrar via teclado com um valor qualquer.Travar a
//digitação, no sentido de aceitar somente valores
//positivos.Após a digitação, exibir a tabuada do valor
//solicitado, no intervalo de um a dez.


//            int n, contador;
//                Console.Write("Digite um valor: ");
//                n = int.Parse(Console.ReadLine());
//                contador = 0;
//                while (n <= 0)
//                {
//                    Console.Write("Digite um valor POSITIVO: ");
//                    n = int.Parse(Console.ReadLine());

//                }

//                while (contador < 10)
//                {
//                    contador++;
//                    Console.WriteLine("{0} x {1} = {2}", n, contador, n * contador);
//                }


//                Ex 6  Entrar via teclado com um valor(X) qualquer.Travar a
//digitação, no sentido de aceitar somente valores
//positivos.Solicitar o intervalo que o programa que
//deverá calcular a tabuada do valor digitado, sendo
//que o segundo valor(B), deverá ser maior que o
//primeiro(A), caso contrário, digitar novamente
//somente o segundo. Após a validação dos dados, 
//exibir a tabuada do valor digitado, no intervalo
//decrescente, ou seja, a tabuada de X no intervalo de
//B para A.

//            int x, a, b;

//                Console.Write("Digite um valor positivo: ");
//                x = int.Parse(Console.ReadLine());

//                while (x < 0)
//                {
//                    Console.Write("Digite um valor positivo: ");
//                    x = int.Parse(Console.ReadLine());
//                }

//                Console.WriteLine("Em qual intervalo a tabuada deve ser calculada?");
//                Console.Write("Valor de início: ");
//                a = int.Parse(Console.ReadLine());
//                Console.Write("Valor final: ");
//                b = int.Parse(Console.ReadLine());


//                while (a > b)
//                {
//                    Console.Write("Valor final: ");
//                    b = int.Parse(Console.ReadLine());
//                }


//                while (b > a)
//                {

//                    Console.WriteLine("{0} x {1} = {2}", x, b, x * b);
//                }





//                Ex 7 Exibir a tabuada dos valores de um a vinte, no intervalo
//de um a dez. Entre as tabuadas, solicitar que o usuário
//pressione uma tecla.

//            int n, contador;
//                contador = 0;
//                n = 0;

//                while (n <= 20)
//                {

//                    n = n + 1;



//                    Console.ReadKey();
//                    Console.WriteLine("____________________________");
//                    Console.WriteLine("Tabuada do {0}", n);

//                    contador = 0;
//                    while (contador < 10)
//                    {
//                        contador = contador + 1;
//                        Console.WriteLine("{0} x {1} = {2}", n, contador, n * contador);
//                    }

//                }




//                Ex 8  Exibir a soma dos números inteiros positivos do intervalo
//    de um a cem. 

//            int n, soma;

//                n = 0;
//                soma = 0;

//                while (n <= 99)
//                {
//                    n++;
//                    soma = soma + n;
//                }

//                Console.WriteLine("A soma dos números inteiros de 1 até 100 é {0}", soma);



//                Ex 9 Descreva um programa que receba via teclado 10
//    (dez)valores e que, ao final, exiba o maior e menor
//deles.



//            int contador, maior, menor, n;

//                Console.WriteLine("Digite 10 números");
//                contador = 0;
//                menor = 0;
//                maior = 0;


//                while (contador < 10)
//                {
//                    n = int.Parse(Console.ReadLine());
//                    contador++;

//                    if (contador == 1)
//                    {
//                        maior = n;
//                        menor = n;
//                    }



//                    if (n > maior)
//                    {
//                        maior = n;
//                    }
//                    else
//                    {
//                        if (n < menor)
//                        {
//                            menor = n;
//                        }
//                    }

//                }

//                Console.WriteLine("Maior número : {0}/ Menor número: {1}", maior, menor);


//                Ex 10  Exibir os 30(trinta) primeiros valores da série de
//Fibonacci.A série: 1, 1, 2, 3, 5, 8, ... 

//            int a, b, c, contador;
//                contador = 3;
//                a = 1;
//                b = 1;



//                Console.WriteLine(a);
//                Console.WriteLine(b);

//                while (contador <= 30)
//                {
//                    c = a + b;
//                    Console.WriteLine(c);

//                    a = b;
//                    b = c;
//                    contador++;


                }
    }
    }

