using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace POO_TP02_01
{
    class Program
    {


        /*.1 - Faça um programa que calcule a área de uma 
figura geométrica. Aceite quatro tipos de figura 
geométrica: quadrado, retângulo, triângulo e 
círculo. Use herança. */
        //class FiguraGeometrica
        //{
        //    public float area;
        //    public float b, h, raio;
        //}

        //class quadrado_retangulo : FiguraGeometrica
        //{
        //    public void quadrado_retang(float b, float h)
        //    {
        //        area = b * h;
        //        Console.WriteLine(area);
        //    }

        //}

        //class triangulo : FiguraGeometrica
        //{
        //    public void triang(float b, float h)
        //    {
        //        area = (b * h) / 2;
        //        Console.WriteLine(area);
        //    }

        //}
        //class circulo : FiguraGeometrica
        //{

        //    public void Info_Circulo()
        //    {
        //        Console.Write("Qual o raio do círulo? ");
        //        raio = float.Parse(Console.ReadLine());

        //    }

        //    public float Calcula_Circulo()
        //    {
        //        area = (raio * raio) * (float)Math.PI;

        //        return area;
        //    }
        //}



        //static void Main(string[] args)
        //{
        //    FiguraGeometrica fig = new FiguraGeometrica();
        //    quadrado_retangulo qr = new quadrado_retangulo();
        //    triangulo triangulo = new triangulo();
        //    circulo circ = new circulo();

        //    Console.WriteLine("Deseja calcular a área de qual figura?");
        //    Console.WriteLine("1-Quadrado    2-Retângulo    3-Triângulo    4-Círculo");
        //    int resposta = int.Parse(Console.ReadLine());

        //    if (resposta != 4)
        //    {
        //        Console.Write("Qual a base da figura? ");
        //        fig.b = float.Parse(Console.ReadLine());
        //        Console.Write("Qual a altura da figura? ");
        //        fig.h = float.Parse(Console.ReadLine());
        //        if (resposta == 1 || resposta == 2)
        //        {
        //            Console.WriteLine(" ");
        //            qr.quadrado_retang(fig.b, fig.h);
        //        }
        //        if (resposta == 3)
        //        {
        //            Console.WriteLine(" ");
        //            triangulo.triang(fig.b, fig.h);
        //        }
        //    }
        //    if (resposta == 4)
        //    {
        //        Console.WriteLine(" ");
        //        circ.Info_Circulo();

        //        Console.WriteLine(circ.Calcula_Circulo());
        //    }


        //}





        /*2. Crie uma classe Calculadora que faça as quatro 
operações básicas (soma, subtração, multiplicação 
e divisão). Crie uma classe derivada 
“CalculadoraCientifica” que, além das operações 
básicas, faça extração de raízes .*/

        //  class Calculadora
        //{
        //    public Calculadora()
        //    {
        //        //x = y = 0; 
        //    }
        //    public float x { get; set; }
        //    public float y { get; set; }

        //     public float resultado { get; set; }
        //}




        //class CalculadoraCientifica : Calculadora
        //{
        //    public void Extrai_Raízes()
        //    {
        //        Console.WriteLine("Equação do segundo grau");
        //        float a, b, c, delta, x1, x2;
        //        Console.Clear();
        //        Console.Write("Coeficiente A : ");
        //        a = float.Parse(Console.ReadLine());
        //        Console.Write("Coeficiente B : ");
        //        b = float.Parse(Console.ReadLine());
        //        Console.Write("Coeficiente C : ");
        //        c = float.Parse(Console.ReadLine());
        //        delta = (float)Math.Pow(b, 2) - (4 * a * c);
        //        if (a == 0)
        //        {
        //            Console.WriteLine("Não forma equação do 2º grau");
        //        }
        //        else
        //        {
        //            if (delta < 0)
        //            {
        //                Console.WriteLine("Não existem raízes reais");
        //            }
        //            else
        //            {
        //                x1 = (float)(-b + Math.Sqrt(delta)) / (2 * a);
        //                x2 = (float)(-b - Math.Sqrt(delta)) / (2 * a);
        //                Console.WriteLine("x1 = {0:f}", x1);
        //                Console.WriteLine("x2 = {0:f}", x2);
        //            }

        //        }
        //    }
        //}


        //static void Main(string[] args)
        //{

        //    CalculadoraCientifica Calc = new CalculadoraCientifica();

        //    int resposta = 0;

        //    do
        //    {
        //        Console.WriteLine(" ");
        //        Console.WriteLine("1 - Somar" +
        //                    " 2 - Subtrair" +
        //                    " 3 - Dividir" +
        //                    " 4 - Multiplicar" +
        //                    " 5 - Equação do segundo grau" +
        //                    " 6 - Sair do programa");

        //        resposta = int.Parse(Console.ReadLine());

        //        if(resposta != 6)
        //        {
        //            Console.Write("Número X: ");
        //            Calc.x = int.Parse(Console.ReadLine());
        //            Console.Write("Número Y: ");
        //            Calc.y = int.Parse(Console.ReadLine());
        //        }
        //        switch (resposta)
        //        {
        //            case 1:
        //                Calc.resultado = Calc.x + Calc.y;
        //                Console.WriteLine(Calc.resultado);
        //                break;

        //            case 2:
        //                Calc.resultado = Calc.x - Calc.y;
        //                Console.WriteLine(Calc.resultado);
        //                break;

        //            case 3:
        //                Calc.resultado = Calc.x / Calc.y;
        //                Console.WriteLine(Calc.resultado);
        //                break;

        //            case 4:
        //                Calc.resultado = Calc.x * Calc.y;
        //                Console.WriteLine(Calc.resultado);
        //                break;

        //            case 5:
        //                Calc.Extrai_Raízes();
        //                break;

        //            default:
        //                Console.Write("Insira uma resposta válida: ");
        //                resposta = int.Parse(Console.ReadLine());
        //                break;
        //        }
        //    } while (resposta <= 5);






        /*3. Crie uma classe chamada Ingresso que possui um
valor em reais e um método imprimeValor().
        a) crie uma classe VIP, que herda Ingresso e possui
um valor adicional.Crie um método que retorne
o valor do ingresso VIP(com o adicional
incluído);
        b) crie uma classe Normal, que herda Ingresso e
        possui um método que imprime: "Ingresso 
Normal". 
        c) Crie uma classe CamaroteInferior(que possui a
localização do ingresso e métodos para acessar
e imprimir esta localização) e uma classe
CamaroteSuperior, que é mais cara(possui valor
adicional). Esta última possui um método para
retornar o valor do ingresso.Ambas as classes
herdam a classe VIP.*/


        //class Ingresso
        //{
        //    public float valor { get; set; }

        //    public void ImprimeValor()
        //    {
        //        Console.Write("O valor do ingresso é: R${0}", valor);
        //    }
        //}

        //class VIP : Ingresso
        //{
        //   public float valor_adicional { get; set; }

        //    public float Retorna_Valor_VIP()
        //    {
        //        return valor + valor_adicional;
        //    }
        //}

        //class Normal : Ingresso
        //{
        //    public void Valor_Normal()
        //    {
        //        Console.WriteLine("Ingresso Normal custa R${0}",valor);
        //    }
        //}

        //class CamaroteInferior : VIP
        //{
        //    public string local { get; set; }
        //}
        //class CamaroteSuperior : VIP
        //{
        //    public string local { get; set; }
        //    public float valor_adicional_superior { get; set; }
        //}


        //static void Main(string[] args)
        //{
        //    Normal normal = new Normal();
        //    CamaroteInferior c_inferior = new CamaroteInferior();
        //    CamaroteSuperior c_superior = new CamaroteSuperior();

        //    Console.Write(" O valor do ingresso normal é : R$");
        //    normal.valor = float.Parse(Console.ReadLine());

        //    Console.Write("O valor adicional do ingresso VIP é: R$");
        //    c_inferior.valor_adicional = float.Parse(Console.ReadLine());
        //    c_inferior.valor = normal.valor + c_inferior.valor_adicional;

        //    Console.Write("O valor adicional do ingresso VIP - Camarote Superior é : R$");
        //    c_superior.valor_adicional_superior = float.Parse(Console.ReadLine());
        //    c_superior.valor = c_superior.valor_adicional_superior + normal.valor;

        //    Console.Clear();
        //    //Localização dos camarotes

        //    Console.Write("Digite a localização do camarote inferior: ");
        //    c_inferior.local = Console.ReadLine();

        //    Console.Write("Digite a localização do camarote superior: ");
        //    c_superior.local = Console.ReadLine();
        //    Console.Clear();
        //    //Exibindo na tela;
        //    normal.ImprimeValor();
        //    Console.WriteLine(" ");
        //    Console.WriteLine("Valor do camarote inferior : R${0}", c_inferior.valor);
        //    Console.WriteLine("Local do camarote inferior : {0}", c_inferior.local);
        //    Console.WriteLine(" ");
        //    Console.WriteLine("Valor do camarote superior : R${0}", c_superior.valor);
        //    Console.WriteLine("Local do camarote superior : {0}", c_superior.local);
        //}










        /*4. Crie a classe Imovel, que possui um endereço e um 
    preço.
    a) Crie uma classe Novo, que herda Imovel e possui 
    um adicional no preço. Crie métodos de acesso 
    e impressão deste valor adicional;
    b) Crie uma classe Velho, que herda Imovel e 
    possui um desconto no preço. Crie métodos de 
    acesso e impressão para este desconto*/

        //class Imovel
        //{
        //    public string endereço { get; set; }
        //    public float preço { get; set; }

        //}

        //class Novo : Imovel
        //{

        //    public float Valor_adicional { get; set; }

        //}

        //class Velho : Imovel
        //{
        //    public float Desconto { get; set; }

        //}

        //static void Main(string[] args)
        //{
        //    Novo imovel_novo = new Novo();
        //    Velho imovel_velho = new Velho();



        //    Console.Write("Esse imóvel é novo (N)  ou   Esse imóvel é velho(V)? ");
        //    string resposta = Console.ReadLine();


        //    switch (resposta)
        //    {
        //        case "N":
        //            Console.Write("Preço do imovel novo: R$");
        //            imovel_novo.preço = float.Parse(Console.ReadLine());
        //            Console.Write("Valor adcional do imovel novo: R$");
        //            imovel_novo.Valor_adicional = float.Parse(Console.ReadLine());
        //            Console.WriteLine("Valor final do imovel novo : {0}", imovel_novo.preço + imovel_novo.Valor_adicional);
        //            Console.Write("Endreço do Imovel Novo: ");
        //            imovel_novo.endereço = Console.ReadLine();
        //            break;
        //        case "V":
        //            Console.Write("Preço do imovel velho: R$");
        //            imovel_velho.preço = float.Parse(Console.ReadLine());
        //            Console.Write("Valor de desconto do imovel velho: R$");
        //            imovel_velho.Desconto = float.Parse(Console.ReadLine());
        //            Console.WriteLine("Valor final do imovel velho : {0}", imovel_velho.preço + imovel_velho.Desconto);
        //            Console.Write("Endreço do Imovel Velho: ");
        //            imovel_velho.endereço = Console.ReadLine();
        //            break;
        //        default:

        //            break;
        //    }





        //}
    }
}


