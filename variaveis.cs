using System;

namespace TPAula02
{
    class Program
    {
        static void Main(string[] args)
        {


            /*//Ex0
            Console.Write("Digite a nota 1: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Digite a nota 2: ");
            float n2 = float.Parse(Console.ReadLine());

            float m = (float)(n1 + n2) / 2;

            Console.WriteLine("A média arítimética entre esses números é " + m);

            //Ex 1---------------------------------------------------------------
            1. Entrar via teclado com a base e a altura de um
            retângulo, calcular e exibir sua área.


            float B, A, area;
            Console.Write("Qual a base do retângulo(cm)? ");

            B = float.Parse(Console.ReadLine());

            Console.Write("Qual a altura do retângulo(cm?) ");
            A = float.Parse(Console.ReadLine());

            area = B * A;

            Console.WriteLine("A área do retângulo é igual a {0} cm²", area);




            //Ex 2---------------------------------------------------------------
            2.Calcular e exibir a área de um quadrado, a partir
do valor de sua aresta que será digitado. 


            double a;
            double area;
            Console.Write("Digite o valor da aresta do quadrado: ");
            a = double.Parse(Console.ReadLine());
            area = a * a;
            Console.WriteLine(" A area do quadrado, com aresta igual a {0} é: {1}", a, area);

            //Ex 3---------------------------------------------------------------
            3.Calcular e exibir a área de um quadrado a partir do
                valor de sua diagonal que será digitado

            float diagonal, area;

            Console.Write("Digite quanto mede a diagonal do quadrado em questão: ");
            diagonal = float.Parse(Console.ReadLine());

            area = (float)(diagonal * diagonal) / 2;

            Console.WriteLine("A área do quadrado baseado na diagonal do mesmo é igual a {0}", area);

            //Ex 4-----------------------------------------------------------------
            4.A partir dos valores da base e altura de um
triângulo, calcular e exibir sua área.

            float h, b, area;
            Console.Write("Digite a altura do triângulo(cm): ");
            h = float.Parse(Console.ReadLine());
            Console.WriteLine("   ");
            Console.Write("Digite a base do triângulo(cm): ");
            b = float.Parse(Console.ReadLine());

            area = (b * h) / 2;

            Console.WriteLine("A área do triângulo é igual a {0}cm²", area);


            //Ex 5--------------------------------------------------------------
            5.Calcular e exibir o volume de uma esfera a partir do
                valor de seu diâmetro que será digitado

            double d, V, r;

            Console.Write("Digite o diâmetro da esfera: ");
            d = double.Parse(Console.ReadLine());

            r = d / 2;
            V = 3.14 * 4 * (r * r * r) / 3;

            Console.Write("O volume da esfera é {0}", V);


            // Ex 6-------------------------------------------------------
            6.Calcular e exibir a média aritmética de quatro
valores quaisquer que serão digitados.

            float n1, n2, n3, n4, m;
            Console.Write("Digite o primeiro número: ");
            n1 = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            n2 = float.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            n3 = float.Parse(Console.ReadLine());
            Console.Write("Digite o quarto número: ");
            n4 = float.Parse(Console.ReadLine());
            Console.WriteLine("   ");

            m = (n1 + n2 + n3 + n4) / 4;

            Console.Write("A média artimética desses 4 números é {0}", m);


            // Ex 7-----------------------------------------------------------
            7.Calcular e exibir a média geométrica de dois
valores quaisquer que serão digitados. 

            int num1, num2;
            double mg;
            Console.Write("Digite o número 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o número 2: ");
            num2 = int.Parse(Console.ReadLine());

            mg = Math.Sqrt(num1 * num2);

            Console.Write("A média geométrica entre {0} e {1} é {2}", num1, num2, mg);


            //Ex 8---------------------------------------------------------------
            8.Sabendo que uma milha marítima equivale a um
mil, oitocentos e cinquenta e dois metros e que um
quilômetro possui mil metros, fazer um programa
para converter milhas marítimas em quilômetros. 

            Console.Write("Quantas milhas marítimas deseja converter para quilômetros? ");
            float conv = float.Parse(Console.ReadLine());

            double resultado = (1.852 / 1.000) * conv;

            Console.WriteLine(conv + " milha(s) equivalem a " + resultado + " quilômetros");


            //Ex9---------------------------------------------------------------

            9.Calcular e exibir a tensão de um determinado
circuito eletrônico a partir dos valores da resistência
e corrente elétrica que serão digitados.Utilize a lei
de Ohm. 
          //Lei de Ohm :  V = I*R


          Console.Write("Digite a corrente elétrica(A) do circuito: ");
            float i = float.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("Digite a resistência(Ω) do circuito: ");
            float r = float.Parse(Console.ReadLine());

            float v = i * r;

            Console.WriteLine("A tensão do circuito eletrônico é igual a " + v + "V");

            Console.WriteLine("   ");

            //Ex 10---------------------------------------------------------------
            10.Entrar via teclado com o valor de uma temperatura
em graus Celsius, calcular e exibir sua temperatura
equivalente em Fahrenheit. 

            Console.Write("Temperatura em graus Celsius: ");
            float c = float.Parse(Console.ReadLine());

            double f = c * 1.8 + 32;

            Console.WriteLine(c + " graus Celsius equivalem a " + f + " graus Fahrenheit");

            //Ex 11---------------------------------------------------------------
            11.A partir do diâmetro de um círculo que será
digitado, calcular e exibir sua área. 

            double A, d, r, pi;
            Console.Write("Digite o diâmetro do círculo: ");
            d = double.Parse(Console.ReadLine());
            pi = Math.PI;
            r = d / 2;

            A = pi * r * r;

            Console.WriteLine("A área do círculo é : {0}", A);


            //Ex 12---------------------------------------------------------------

            12.Calcular e exibir o volume de um cone a partir dos
valores da altura e do raio da base que serão
digitados.


            double V, R, h;

            Console.Write("Digite a altura do cone: ");
            h = double.Parse(Console.ReadLine());
            Console.Write("Digite o raio da base do cone: ");
            R = double.Parse(Console.ReadLine());

            V = 3 * (R * R) * (h / 3);
            Console.WriteLine("Um cone com {0}cm de altura e {1}cm de raio de base tem um volume total de {2}.", h, R, V);

            //Ex 13---------------------------------------------------------------
            13.Calcular e exibir a velocidade final(em km / h) de
um automóvel, a partir dos valores da velocidade
inicial(em m / s), da aceleração(m/ s²) e do tempo
 de percurso(em s) que serão digitados.

            double vf2, vf, vi, a, t;
            Console.Write("Ditie a aceleração(m/s²): ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Ditie a velocidade inicial): ");
            vi = double.Parse(Console.ReadLine());
            Console.Write("Ditie o tempo do percurso(s): ");
            t = double.Parse(Console.ReadLine());

            vf = vi + a * t;
            vf2 = vf * 3.6;

            Console.WriteLine("A velocidade final em Km/h é {0}", vf2);


            //Ex 14---------------------------------------------------------------
            14.Calcular e exibir o volume livre de um ambiente que
contém uma esfera de raio “r” inscrita em um cubo
perfeito de aresta “a”. Os valores de “r“ e “a” serão
digitados.

            double r, a, v, v2, vl;
            Console.Write("Digite o valor da aresta: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor do raio: ");
            r = float.Parse(Console.ReadLine());

            v = 4 * 3.14 * (r * r * r) / 3;

            v2 = a * a * a;

            vl = v - v2;

            Console.Write("O volume livre é de {0}m³ ", vl);


            //Ex 15---------------------------------------------------------------
            15.Entrar via teclado com o valor da cotação do dólar
e uma certa quantidade de dólares. Calcular e
exibir o valor correspondente em Reais(R$). 

            decimal dolar, cot, conv;

            Console.Write("Digite a atual cotação do dolar para real: 1US$ = R$");
            cot = decimal.Parse(Console.ReadLine());
            Console.Write("Quantos doláres deseja converter para real? US$");
            dolar = decimal.Parse(Console.ReadLine());

            conv = dolar * cot;

            Console.WriteLine("Com essa cotação, {0} dolár(es) equivalem a {1} reais.", dolar, conv);


            //Ex 16---------------------------------------------------------------
            16.Entrar via teclado com o valor de um ângulo em
graus, calcular e exibir as seguintes funções
trigonométricas: seno, coseno, tangente e secante
deste ângulo.Lembre - se que uma função
trigonométrica trabalha em radianos.


         double an_radiano, sen, cos, tan, an_graus, pi;
            Console.Write("Qual ângulo você deseja: "); // O C# dá o angulo e faz as medidas em radiano
            an_radiano = int.Parse(Console.ReadLine());
            sen = Math.Sin(an_radiano);
            cos = Math.Cos(an_radiano);
            tan = Math.Tan(an_radiano);
            Console.WriteLine("Os valores em radiano são :Seno de {0}: {1:f2}  / Cosseno de {0}:{2:f2}  /Tangente de {0}: {3:f2}", an_radiano, sen, cos, tan);
            double sen2, cos2, tan2;
            pi = Math.PI;
            an_graus = (an_radiano * pi) / 180; //Convertendo radiano para graus para extrair o seno, cosseno e tangente em graus. Fórmula : Graus = angulo (x) em radiano * PI / 180
            sen2 = Math.Sin(an_graus);
            cos2 = Math.Cos(an_graus);
            tan2 = Math.Tan(an_graus);
            Console.WriteLine("");
            Console.WriteLine("Os valores em grau são :Seno de {0}: {1:f2}  / Cosseno de {0}:{2:f2}  /Tangente de {0}: {3:f2}", an_radiano, sen2, cos2, tan2);



            //Ex 17
            17.Entrar via teclado com dois valores quaisquer “X” e
“X”. Calcular e exibir o cálculo XY(“X” elevado a
“Y”). Pesquisar as funções Exp e Ln.


            double x, y, ex;
            Console.Write("Insira a base da exponenciação: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Insira o expoente : ");
            y = double.Parse(Console.ReadLine());

            ex = Math.Pow(x, y);
            Console.WriteLine("");

            Console.Write("{0} elevado a {1} é igual a {2}", x, y, ex);

            //Ex 18---------------------------------------------------------------

            18.Entrar via teclado com o valor de cinco produtos.
Após as entradas, digitar um valor referente ao
pagamento da somatória destes valores. Calcular e
exibir o troco que deverá ser devolvido.


            Console.WriteLine("________________");
            Console.Write("Preço do produto 1: R$");
            float p1 = float.Parse(Console.ReadLine());

            Console.WriteLine("________________");
            Console.Write("Preço do produto 2:R$ ");
            float p2 = float.Parse(Console.ReadLine());

            Console.WriteLine("________________");
            Console.Write("Preço do produto 3: R$");
            float p3 = float.Parse(Console.ReadLine());

            Console.WriteLine("________________");
            Console.Write("Preço do produto 4: R$");
            float p4 = float.Parse(Console.ReadLine());

            Console.WriteLine("________________");
            Console.Write("Preço do produto 5: R$");
            float p5 = float.Parse(Console.ReadLine());

            float total = p1 + p2 + p3 + p4 + p5;

            Console.WriteLine("   ");
            Console.WriteLine("O valor total de sua compra é:R$ " + total);


            Console.WriteLine("   ");
            Console.Write("Valor recebido pelo caixa:R$ ");
            float pag = float.Parse(Console.ReadLine());

            var troco = (pag - total);

            Console.WriteLine("   ");
            Console.WriteLine("Valor do troco:R$" + troco);*/


        }
    }
}
