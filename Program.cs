using System;

namespace TPAula02
{
    class Program
    {
        static void Main(string[] args)
        {


            ////Ex0
            //Console.Write("Digite a nota 1: ");
            //float n1 = float.Parse(Console.ReadLine());
            //Console.Write("Digite a nota 2: ");
            //float n2 = float.Parse(Console.ReadLine());

            //float m = (float)(n1 + n2) / 2;

            //Console.WriteLine("A média arítimética entre esses números é " + m);

            ////Ex 1---------------------------------------------------------------
            //Console.WriteLine("__________________________________________");
            //Console.WriteLine("");
            //float B, A, area;
            //Console.Write("Qual a base do retângulo(cm)? ");

            //B = float.Parse(Console.ReadLine());

            //Console.Write("Qual a altura do retângulo(cm?) ");
            //A = float.Parse(Console.ReadLine());

            //area = B * A;

            //Console.WriteLine("A área do retângulo é igual a {0} cm²", area);




            ////Ex 2---------------------------------------------------------------
            //Console.WriteLine("__________________________________________");
            //Console.WriteLine("");
            //double a;
            //double area;
            //Console.Write("Digite o valor da aresta do quadrado: ");
            //a = double.Parse(Console.ReadLine());
            //area = a * a;
            //Console.WriteLine(" A area do quadrado, com aresta igual a {0} é: {1}", a, area);

            ////Ex 3---------------------------------------------------------------
            //Console.WriteLine("__________________________________________");
            //Console.WriteLine("");

            //float diagonal, area;

            //Console.Write("Digite quanto mede a diagonal do quadrado em questão: ");
            //diagonal = float.Parse(Console.ReadLine());

            //area = (float)(diagonal * diagonal) / 2;

            //Console.WriteLine("A área do quadrado baseado na diagonal do mesmo é igual a {0}", area);

            ////Ex 4-----------------------------------------------------------------
            //Console.WriteLine("__________________________________________");
            //Console.WriteLine("");

            //float h, b, area;
            //Console.Write("Digite a altura do triângulo(cm): ");
            //h = float.Parse(Console.ReadLine());
            //Console.WriteLine("   ");
            //Console.Write("Digite a base do triângulo(cm): ");
            //b = float.Parse(Console.ReadLine());

            //area = (b * h) / 2;

            //Console.WriteLine("A área do triângulo é igual a {0}cm²", area);


            ////Ex 5--------------------------------------------------------------
            //Console.WriteLine("__________________________________________");
            //Console.WriteLine("");

            //double d, V, r;

            //Console.Write("Digite o diâmetro da esfera: ");
            //d = double.Parse(Console.ReadLine());

            //r = d / 2;
            //V = 3.14 * 4 * (r * r * r) / 3;

            //Console.Write("O volume da esfera é {0}", V);


            //// Ex 6--------------------------------------------------------------
            //Console.WriteLine("__________________________________________");
            //Console.WriteLine("");
            //float n1, n2, n3, n4, m;
            //Console.Write("Digite o primeiro número: ");
            //n1 = float.Parse(Console.ReadLine());
            //Console.Write("Digite o segundo número: ");
            //n2 = float.Parse(Console.ReadLine());
            //Console.Write("Digite o terceiro número: ");
            //n3 = float.Parse(Console.ReadLine());
            //Console.Write("Digite o quarto número: ");
            //n4 = float.Parse(Console.ReadLine());
            //Console.WriteLine("   ");

            //m = (n1 + n2 + n3 + n4) / 4;

            //Console.Write("A média artimética desses 4 números é {0}", m);


            //// Ex 7---------------------------------------------------------------
            //Console.WriteLine("__________________________________________");
            //Console.WriteLine("");

            //int num1, num2;
            //double mg;
            //Console.Write("Digite o número 1: ");
            //num1 = int.Parse(Console.ReadLine());
            //Console.Write("Digite o número 2: ");
            //num2 = int.Parse(Console.ReadLine());

            //mg = Math.Sqrt(num1 * num2);

            //Console.Write("A média geométrica entre {0} e {1} é {2}", num1, num2, mg);


            ////Ex 8---------------------------------------------------------------
            Console.WriteLine("__________________________________________");
            Console.WriteLine("");

            Console.Write("Quantas milhas marítimas deseja converter para quilômetros? ");
            float conv = float.Parse(Console.ReadLine());

            double resultado = (1.852 / 1.000) * conv;

            Console.WriteLine(conv + " milha(s) equivalem a " + resultado + " quilômetros");


            ////Ex9---------------------------------------------------------------
            //Console.WriteLine("__________________________________________");
            //Console.WriteLine("");
            ////Lei de Ohm :  V = I*R


            //Console.Write("Digite a corrente elétrica(A) do circuito: ");
            //float i = float.Parse(Console.ReadLine());
            //Console.WriteLine(" ");
            //Console.Write("Digite a resistência(Ω) do circuito: ");
            //float r = float.Parse(Console.ReadLine());

            //float v = i * r;

            //Console.WriteLine("A tensão do circuito eletrônico é igual a " + v + "V");

            //Console.WriteLine("   ");

            ////Ex 10---------------------------------------------------------------
            //Console.WriteLine("__________________________________________");
            //Console.WriteLine("");
            //Console.Write("Temperatura em graus Celsius: ");
            //float c = float.Parse(Console.ReadLine());

            //double f = c * 1.8 + 32;

            //Console.WriteLine(c + " graus Celsius equivalem a " + f + " graus Fahrenheit");

            ////Ex 11---------------------------------------------------------------
            //Console.WriteLine("__________________________________________");
            //Console.WriteLine("");

            //double A, d, r, pi;
            //Console.Write("Digite o diâmetro do círculo: ");
            //d = double.Parse(Console.ReadLine());
            //pi = Math.PI;
            //r = d / 2;

            //A = pi * r * r;

            //Console.WriteLine("A área do círculo é : {0}", A);


            ////Ex 12---------------------------------------------------------------
            //Console.WriteLine("__________________________________________")
            //Console.WriteLine("");

            //double V, R, h;

            //Console.Write("Digite a altura do cone: ");
            //h = double.Parse(Console.ReadLine());
            //Console.Write("Digite o raio da base do cone: ");
            //R = double.Parse(Console.ReadLine());

            //V = 3 * (R * R) * (h / 3);
            //Console.WriteLine("Um cone com {0}cm de altura e {1}cm de raio de base tem um volume total de {2}.", h, R, V);

            ////Ex 13---------------------------------------------------------------
            //Console.WriteLine("__________________________________________");
            //Console.WriteLine("");

            //double vf2, vf, vi, a, t;
            //Console.Write("Ditie a aceleração(m/s²): ");
            //a = double.Parse(Console.ReadLine());
            //Console.Write("Ditie a velocidade inicial): ");
            //vi = double.Parse(Console.ReadLine());
            //Console.Write("Ditie o tempo do percurso(s): ");
            //t = double.Parse(Console.ReadLine());

            //vf = vi + a * t;
            //vf2 = vf * 3.6;

            //Console.WriteLine("A velocidade final em Km/h é {0}", vf2);


            ////Ex 14---------------------------------------------------------------
            //Console.WriteLine("__________________________________________");
            //Console.WriteLine("");

            //double r, a, v, v2,vl;
            // Console.Write("Digite o valor da aresta: ");
            // a = float.Parse(Console.ReadLine());
            // Console.Write("Digite o valor do raio: ");
            // r = float.Parse(Console.ReadLine());

            // v = 4  * 3.14 * (r * r * r)/3;

            // v2 = a * a * a;

            // vl = v - v2;

            // Console.Write("O volume livre é de {0}m³ ",vl);


            //v = a * a * a;
            //FALTA ESSE

            ////Ex 15---------------------------------------------------------------
            //Console.WriteLine("__________________________________________");
            //Console.WriteLine("");
            //decimal dolar, cot, conv;

            //Console.Write("Digite a atual cotação do dolar para real: 1US$ = R$");
            //cot = decimal.Parse(Console.ReadLine());
            //Console.Write("Quantos doláres deseja converter para real? US$");
            //dolar = decimal.Parse(Console.ReadLine());

            //conv = dolar * cot;

            //Console.WriteLine("Atualmente, {0} dolár(es) equivalem a {1} reais.", dolar, conv);


            ////Ex 16---------------------------------------------------------------
            //Console.WriteLine("__________________________________________");
            //Console.WriteLine("");
            //double an_radiano, sen, cos, tan, an_graus, pi;
            //Console.Write("Qual ângulo você deseja: ");// O C# dá o angulo e faz as medidas em radiano
            //an_radiano = int.Parse(Console.ReadLine());
            //sen = Math.Sin(an_radiano);
            //cos = Math.Cos(an_radiano);
            //tan = Math.Tan(an_radiano);



            //Console.WriteLine("Os valores em radiano são :Seno de {0}: {1}  / Cosseno de {0}:{2}  /Tangente de {0}: {3}", an_radiano, sen, cos, tan);

            //double sen2, cos2, tan2;
            //pi = Math.PI;
            //an_graus = (an_radiano * pi) / 180; //Convertendo radiano para graus para extrair o seno, cosseno e tangente em graus. Fórmula : Graus = angulo x em radiano * PI / 180
            //sen2 = Math.Sin(an_graus);
            //cos2 = Math.Cos(an_graus);
            //tan2 = Math.Tan(an_graus);

            //Console.WriteLine("");

            //Console.WriteLine("Os valores em grau são :Seno de {0}: {1}  / Cosseno de {0}:{2}  /Tangente de {0}: {3}", an_radiano, sen2, cos2, tan2);


            ////Ex 17
            //Console.WriteLine("__________________________________________");
            //Console.WriteLine("");
            //double x, y, ex;
            //Console.Write("Insira a base da exponenciação: ");
            //x = double.Parse(Console.ReadLine());
            //Console.Write("Insira o expoente : ");
            //y = double.Parse(Console.ReadLine());

            //ex = Math.Pow(x, y);
            //Console.WriteLine("");

            //Console.Write("{0} elevado a {1} é igual a {2}", x, y, ex);
            ////Ex 18---------------------------------------------------------------
            //Console.WriteLine("__________________________________________");
            //Console.WriteLine("");
            //Console.WriteLine("________________");
            //Console.Write("Preço do produto 1: R$");
            //float p1 = float.Parse(Console.ReadLine());

            //Console.WriteLine("________________");
            //Console.Write("Preço do produto 2:R$ ");
            //float p2 = float.Parse(Console.ReadLine());

            //Console.WriteLine("________________");
            //Console.Write("Preço do produto 3: R$");
            //float p3 = float.Parse(Console.ReadLine());

            //Console.WriteLine("________________");
            //Console.Write("Preço do produto 4: R$");
            //float p4 = float.Parse(Console.ReadLine());

            //Console.WriteLine("________________");
            //Console.Write("Preço do produto 5: R$");
            //float p5 = float.Parse(Console.ReadLine());

            //float total = p1 + p2 + p3 + p4 + p5;

            //Console.WriteLine("   ");
            //Console.WriteLine("O valor total de sua compra é:R$ " + total);


            //Console.WriteLine("   ");
            //Console.Write("Valor recebido pelo caixa:R$ ");
            //float pag = float.Parse(Console.ReadLine());

            //var troco = (pag - total);

            //Console.WriteLine("   ");
            //Console.WriteLine("Valor do troco:R$" + troco);


        }
    }
}
