using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TPS
{
    /*1. Declare uma classe “Funcionario” que possui 2 
(dois) campos(nome do funcionário e salário). Em
seguida realize o instanciamento de um objeto da
respectiva classe*/

    //class Funcionario
    //{
    //    public string nome;
    //    public float salario;
    //}
    //class Program
    //{

    //    static void Main(string[] args)
    //    {
    //        Funcionario x = new Funcionario();
    //    }
    //}





    /*2. Altere a classe do exercício anterior de tal a forma
a implementar um método construtor que realizar a
atribuição inicial para os campos da classe*/

    //class Funcionario
    //{
    //    private string nome;
    //    private int idade;
    //    public Funcionario()
    //    {
    //         nome = " ";
    //         idade = 0;
    //    }

    //}
    //class Program
    //{

    //    static void Main(string[] args)
    //    {
    //        Funcionario x = new Funcionario();

    //    }
    //}






    /*3. Crie uma classe chamada “Nota Fiscal” que possa 
ser utilizado por uma loja de suprimentos de 
tecnologia para representar uma fatura de um item 
vendido na loja. Uma Nota fiscal deve incluir as 
seguintes informações como atributos: o número do 
item faturado; a descrição do item; a quantidade 
comprada do item; o preço unitário do item.

Esta classe deve ter um construtor que inicialize os 
quatro atributos. Além disso, forneça um método 
chamado “getInvoiceAmount” que calcula o valor 
da fatura (isso é, multiplica a quantidade pelo 
preço por item) e depois retorna o valor como um 
double. */



    //class NotaFiscal
    //{
    //    private int Num_Item;
    //    private string descricao_item;
    //    private int qtd_item;
    //    private int preco_item;

    //    public NotaFiscal()
    //    {
    //        Num_Item = 0;
    //        descricao_item = "";
    //        qtd_item = 0;
    //        preco_item = 0;
    //    }

    //    public double getInvoiceAmount()
    //    {
    //        return (qtd_item * preco_item);
    //    }

    //}
    //class Program
    //{

    //    //static void Main(string[] args)
    //    //{
    //    //    NotaFiscal produtos = new NotaFiscal();
    //    //    Console.WriteLine(produtos.getInvoiceAmount());
    //    //}
    //}






    /*4. Implemente uma classe “Pessoa” que possua como 
atributos nome, idade, peso (em quilogramas) e 
altura (em metros). Faça com que os dados sejam 
inicializados através do construtor da classe. 
Adicione métodos para ler e alterar cada um dos 
atributos em separado.*/


    //class Pessoa
    //{
    //    private string nome;
    //    private int idade;
    //    private float peso;
    //    private float altura;

    //    public Pessoa()
    //    {
    //        nome = "";
    //        idade = 0;
    //        peso = 0;
    //        altura = 0;
    //    }

    //    public string AlteraNome()
    //    {
    //        nome = Console.ReadLine();
    //        return (nome);
    //    }

    //    public int AlteraIdade()
    //    {
    //        idade = int.Parse(Console.ReadLine());
    //        return (idade);
    //    }

    //    public float AlteraPeso()
    //    {
    //       peso = float.Parse(Console.ReadLine());
    //        return (peso);
    //    }

    //    public float AlteraAltura()
    //    {
    //        altura = float.Parse(Console.ReadLine());
    //        return (altura);
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Pessoa x = new Pessoa();
    //        string nome = x.AlteraNome();
    //        int idade = x.AlteraIdade();
    //        float peso = x.AlteraPeso();
    //        float altura = x.AlteraAltura();
    //    }







    /*5. Altere a classe “Pessoa” do exercício anterior de 
modo que ela seja capaz de calcular o Índice de 
Massa Corporal (IMC). O cálculo é feito através da 
fórmula IMC = peso/altura2
. Adicionalmente, 
implemente um método que informa a faixa de 
categoria do IMC que a pessoa se encontra, 
utilizando a seguinte tabela.*/





    //class Pessoa
    //    {
    //        private string nome;
    //        private int idade;
    //        private float peso;
    //        private float altura;

    //        public Pessoa()
    //        {
    //            nome = "";
    //            idade = 0;
    //            peso = 0;
    //            altura = 0;
    //        }

    //        public string AlteraNome()
    //        {
    //            nome = Console.ReadLine();
    //            return (nome);
    //        }

    //        public int AlteraIdade()
    //        {
    //            idade = int.Parse(Console.ReadLine());
    //            return (idade);
    //        }

    //        public float AlteraPeso()
    //        {
    //            peso = float.Parse(Console.ReadLine());
    //            return (peso);
    //        }

    //        public float AlteraAltura()
    //        {
    //            altura = float.Parse(Console.ReadLine());
    //            return (altura);
    //        }

    //        public float imc;
    //        public float Calculo_IMC()
    //        {
    //            imc = peso / (altura * altura);
    //            return (imc);
    //        }

    //        public void Categoria_IMC()
    //        {
    //            if (imc < 20)
    //            {
    //                Console.WriteLine("Abaixo do peso");
    //            }

    //            if (imc > 20 && imc <= 25)
    //            {
    //                Console.WriteLine("Peso normal");
    //            }

    //            if (imc > 25 && imc <= 30)
    //            {
    //                Console.WriteLine("Sobrepeso");
    //            }

    //            if (imc > 30 && imc <= 35)
    //            {
    //                Console.WriteLine("Obesidade grau I");
    //            }

    //            if (imc > 35 && imc <= 40)
    //            {
    //                Console.WriteLine("Obesidade grau II");
    //            }

    //            if (imc > 40)
    //            {
    //                Console.WriteLine("Obesidade grau III");
    //            }

    //        }

    //    }
    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            Pessoa x = new Pessoa();
    //            Console.WriteLine("Preencha com suas informações.");

    //            Console.Write("Nome: ");
    //            string nome = x.AlteraNome();

    //            Console.Write("Idade: ");
    //            int idade = x.AlteraIdade();

    //            Console.Write("Peso: ");
    //            float peso = x.AlteraPeso();

    //            Console.Write("Altura: ");
    //            float altura = x.AlteraAltura();

    //            Console.Write("Seu IMC é: ");
    //            float imc = x.Calculo_IMC();
    //            Console.WriteLine(imc);

    //            Console.Write("Sua categoria na tabela do IMC é: ");
    //            x.Categoria_IMC();
    //        }

    //    }
}







