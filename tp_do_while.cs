 //Ex1
            //Exibir a soma dos números inteiros maiores que 1 e menores que 100.
            //int n, soma;
            //n = 1;
            //soma = 0;
            //do
            //{
            //    soma = n + soma;
            //    n++;

            //} while (n < 100);
            //Console.WriteLine(soma);





            //Ex 2 Descreva um programa que exiba no monitor os 100 
            //primeiros números inteiros múltiplos de 5.
            //int n, contador;

            //n = 5;
            //contador = 0;

            //do
            //{

            //    contador++;
            //    n = 5 * contador;

            //    Console.Write(n); Console.Write(" ");
            //} while (contador <= 99);





            //Ex3  Descreva um programa que a calcule a soma de: 1 + 
            //3 + 5 + 7 + … +121.

            //int n;
            //n = 1;
            //int soma = 0;

            //do
            //{
            //    soma = n + soma;
            //    n = n + 2;


            //} while (n <= 121);

            //Console.Write(soma);




            //Ex4. Descreva um programa que exiba no monitor a 
            //sequência de números: 10, 8, 6, 4, 2,0

            //int num;
            //num = 10;


            //do
            //{
            //    Console.Write(num); Console.Write("   ");
            //    num = num - 2;


            //} while (num >= 0);






            //Ex5 Calcule e exiba no monitor a soma e o produto dos 5
            //primeiros termos da série:
            // 1/1   1/4    1/9    1/16    1/25

            //float conta;
            //float x;
            //x = 1;
            //int contador = 1;
            //float soma, produto;
            //soma = 0;
            //produto = 1;

            //do
            //{
            //    conta = 1 / (float)(x * x);//denominador = termo ao quadrado

            //    soma = soma + conta;
            //    produto = produto * (float)conta;

            //    contador++;
            //    x++;
            //} while (contador <= 5);

            //Console.WriteLine("A soma dos primeiros 5 números da série é: {0:f10}", soma);
            //Console.WriteLine("O produto dos primeiros 5 números da série é: {0:f10}", produto);





            /*Ex6 Desenvolva um programa que multiplique dois números 
            inteiros A e B, que são digitados via teclado, utilizando
            somente somas. Proteja para que a digitação garanta
            que A seja maior que B bem como A e B sejam inteiros.*/

            //float a, b;

            //int contador = 0;
            //float multiplica_soma = 0;

            //do
            //{
            //    do
            //    {
            //        Console.Write("Digite o valor de A: ");
            //        a = float.Parse(Console.ReadLine());
            //    } while ((int)a != a);



            //    do
            //    {
            //        Console.Write("Digite o valor de B: ");
            //        b = float.Parse(Console.ReadLine());
            //    } while ((int)b != b);

            //} while (a <= b);



            //do
            //{

            //    multiplica_soma = a + multiplica_soma;

            //    contador++;

            //} while (contador < b);

            //Console.WriteLine("A multiplicação destes números é: {0} ", multiplica_soma);




            //Ex7
            //Analise o tempo de execução do problema anterior e
            //determine uma solução na qual a multiplicação ocorra
            //num tempo mínimo

            //float a, b;

            //int contador = 0;
            //float multiplica_soma = 0;
            //do
            //{
            //    do
            //    {
            //        Console.Write("Digite o valor de A: ");
            //        a = float.Parse(Console.ReadLine());


            //    } while ((int)a != a);

            //    do
            //    {
            //        Console.Write("Digite o valor de B: ");
            //        b = float.Parse(Console.ReadLine());
            //    } while ((int)b != b);
            //} while (a <= b);



            //do
            //{

            //    multiplica_soma = a + multiplica_soma;

            //    contador++;

            //} while (contador < b);

            //Console.WriteLine("A multiplicação destes números é: {0} ", multiplica_soma);






            //Ex8 . Desenvolva um programa que exiba no vídeo os 20 
            //primeiros números primos.Um número é, por definição,
            //primo se ele não tem divisores, exceto 1 e ele próprio.


            //int primos = 0;//controla quantos números primos o programa irá exibir.
            //int resto = 0; // variável resto para encontrar o resto da divisão.
            //int n = 2; // n =2. O primo número primo é 2 então começamos com 2.
            //int teste; // se o resto for igual a 0, incrementar teste.
            //int contador;// irá funcionar como um divisor para acharmos o resto;

            //do
            //{
            //    contador = 2;

            //    teste = 0;
            //    while (n > contador) // n > contador para não ocorrer o risco de realizar a operação 3/3 por exemplo.
            //    {

            //        resto = n % contador; // resto entre n e contador

            //        if (resto == 0)
            //        {
            //            teste++; //incrementa teste caso resto seja 0.

            //        }
            //        contador = contador + 1; // incrementamos contador para realizar a divisão - enquanto n for maior que contador

            //    }

            //    if (teste == 0)
            //    {
            //        Console.WriteLine(n);
            //        primos++;
            //        //se teste for = 0 quer dizer que o número é primo pois nenhum número entre 2 e o próprio número,
            //        // ao realizarmos a divisão, deu resto 0;
            //    }
            //    n++;// incrementamos número a fim de continuar testando;


            //} while (primos < 20);//condição para exibir os 20 primeiros números primos;








            //Ex9 Desenvolva um programa que calcule a soma dos 
            //algarismos de um número inteiro “N” digitado via
            //teclado

            //int algarismo, resto;

            //Console.Write("Digite um número, o programa fará a soma dos algarismos deste número:  ");
            //algarismo = int.Parse(Console.ReadLine());
            //resto = 0;
            //int soma_resto = 0;

            ////do
            ////{
            ////    Console.Write("Digite um número, o programa fará a soma dos algarismos deste número:  ");
            ////    algarismo = int.Parse(Console.ReadLine());
            ////} while (algarismo != (int)algarismo);


            //do
            //{

            //    resto = algarismo % 10;//Caula os restos da divisão, que será somado depois.
            //    algarismo = (algarismo - resto) / 10;//atualizando o valor de algarismo, para poder calcular um novo resto.
            //    soma_resto = resto + soma_resto;//somando o resto

            //} while (resto > 0);//loop para repetir as instruções sempre que o resto for maior que 0.

            //Console.WriteLine(soma_resto);

            ///* Exemplo : 43  => resto de 43/10 = 3;
            //* resto = 3
            //* soma_resto = 3 + 0; => soma_resto = 3;

            //* algarismo = 43-3 /10   => algarismo = 4
            //* resto = 4 % 10; => resto = 4;
            //* soma_resto = 3 + 4; */






            //Ex10 Descreva um programa que calcule a potência inteira 
            // N qualquer de um número positivo B utilizando somente
            //produtos.Prever a possibilidade de N ser maior, menor
            //ou igual a zero.


            //int num_positivo, potencia;


            //Console.Write("Digite o número que será a base da potência:  ");
            //num_positivo = int.Parse(Console.ReadLine());

            //Console.Write("Digite o número que será potência:  ");
            //potencia = int.Parse(Console.ReadLine());


            //int calculo_potencia = 0;

            //int aux = 1;

            //if (potencia == 0)
            //{
            //    Console.WriteLine("O resultado é 1");
            //}

            //if(potencia > 0)
            //{
            //    do
            //    {
            //        calculo_potencia = num_positivo * aux;
            //        aux = calculo_potencia;
            //        potencia--;


            //    } while (potencia > 0);

            //    Console.Write(calculo_potencia);
            //}
