 /*Ex1  Calcular e exibir a soma dos “N” primeiros valores da
            sequência abaixo. O valor “N” será digitado, deverá ser
            positivo, mas menor ou igual a 20(vinte).Caso o valor
não satisfaça a restrição, enviar mensagem de erro e
solicitar o valor novamente 
            1/2   2/3   3/4   4/5...*/


            //int n, i;
            //Console.Write("Quantas valores da sequência devem ser somados: ");
            //n = int.Parse(Console.ReadLine());
            //double conta, soma;
            //double x = 1.0;
            //soma = 0;

            //for (i = 1; i <= n; i++)
            //{
            //    while (n < 0 || n > 20)
            //    {
            //        Console.Write("Quantas valores da sequência devem ser somados: ");
            //        n = int.Parse(Console.ReadLine());

            //    }
            //    conta = x / (x + 1);
            //    soma = conta + soma;
            //    conta = 0;
            //    x++;
            //}

            //Console.Write("A soma dos {0} primeiros números da série é {1,4:F2}", n, soma);











            /*Ex 2 - Calcular e exibir a soma dos “N” primeiros valores da 
sequência abaixo. O valor “N” será digitado, deverá ser 
positivo, mas menor ou igual a 50 (cinquenta). Caso o 
valor não satisfaça a restrição, enviar mensagem de 
erro e solicitar o valor novamente. 
            2/1   5/8    10/27    17/64              */


            //numerador = quadrado do termo + 1;
            //denominador = termo ao cubo;


            //double conta;
            //int n;
            //Console.Write("Quantos valores da sequência devem ser somados: ");
            //n = int.Parse(Console.ReadLine());
            //double soma = 0;



            //for(int i = 1; i <= n; i++)
            //{
            //    conta = (Math.Pow(i, 2) + 1) / (Math.Pow(i, 3));
            //    soma = soma + conta;
            //    conta = 0;

            //}


            //Console.WriteLine("A soma dos {0} primeiros números é {1}", n, soma);





            //ou



            //int n, i;

            //Console.Write("Quantas valores da sequência devem ser somados: ");
            //n = int.Parse(Console.ReadLine());
            //double conta, soma;
            //int x = 2;
            //soma = 0;
            //int primo = 0;
            //int contador = 2;
            //double resto;
            //int teste = 0;
            //int soma_primos = 0;

            //while (n < 0 || n > 49)
            //{
            //    Console.Write("Quantas valores da sequência devem ser somados: ");
            //    n = int.Parse(Console.ReadLine());
            //}

            //for (i = 1; i <= n; i++)
            //{
            //    while (primo == 0)
            //    {
            //        while (x > contador)
            //        {
            //            resto = x % contador;

            //            if (resto == 0)
            //            {
            //                teste = 1;
            //            }
            //            contador++;
            //        }

            //        if (teste == 0)
            //        {
            //            soma_primos = soma_primos + x;
            //            conta = soma_primos / Math.Pow(i, 3);
            //            soma = soma + conta;
            //            primo = 1;
            //        }

            //        teste = 0;
            //        contador = 2;
            //        x++;
            //    }
            //    primo = 0;

            //}

            //Console.WriteLine("A soma dos primeiros {0} números é {1}", n, soma);












            /* Ex 3 A prefeitura de uma cidade fez uma pesquisa entre
   seus 500(quinhentos) habitantes, coletando dados
 sobre o salário e o número de filhos. A prefeitura deseja
 saber:
 a) a média dos salários da população;
             b) a média dos números de filhos;
             c) o maior salário;
             d) a porcentagem de pessoas com salários até
             R$ 1.000,00.  */


            //int habitantes = 500;

            //double salario, soma_salario = 0;
            //double media_salarios = 0;


            //int num_filhos, soma_filhos = 0;
            //float media_filhos = 0;


            //double maior_salario = 0;


            //int qtd_salario_min = 0;
            //float porcent_salario_min;

            //for (int i = 1; i <= habitantes; i++)
            //{
            //    Console.Write("Salário da pessoa {0}: R$ ", i);
            //    salario = double.Parse(Console.ReadLine());
            //    Console.Write("Quantidade de filhos da pessoa {0}:  ", i);
            //    num_filhos = int.Parse(Console.ReadLine());
            //    Console.WriteLine("__________________________________________________");

            //    // a , b
            //    soma_salario = salario + soma_salario;
            //    soma_filhos = num_filhos + soma_filhos;

            //    media_salarios = soma_salario / (double)habitantes;

            //    media_filhos = soma_filhos / (float)habitantes;

            //    // c
            //    if (i == 1)
            //    {
            //        maior_salario = salario;
            //    }

            //    if (salario > maior_salario)
            //    {
            //        maior_salario = salario;
            //    }

            //    //d

            //    if (salario <= 1000)
            //    {
            //        qtd_salario_min++;
            //    }

            //}

            //Console.WriteLine("A média salárial dessa cidade é R$ {0}", media_salarios);

            //Console.WriteLine("A média do número de filhos dessa cidade é {0}", media_filhos);

            //Console.WriteLine("O maior salário é R$ {0}", maior_salario);

            //porcent_salario_min = (qtd_salario_min / (float)habitantes) * 100;

            //Console.WriteLine("A porcentagem de pessoas com salário menor ou igual a R$ 1000 é de {0}%", porcent_salario_min);











            /*Ex 4 - Um supermercado deseja facilitar o trabalho de seus 
        caixas utilizando um computador para calcular 
        quantas moedas de cada espécie (0,01, 0,05, 0,10, 
        0,25, 0,50 e 1,00)devem ser devolvidas como troco. 
        Desenvolva um programa para que o caixa digite o 
        valor da compra, a quantia dada para pagamento e 
        que após o processamento exiba no monitor o número 
        de moedas a ser devolvida de cada espécie.*/


            //double valor_compra, pagamento, troco;

            //Console.Write(" Valor total da compra: R$");
            //valor_compra = double.Parse(Console.ReadLine());

            //Console.Write(" Valor recebido para pagamento: R$");
            //pagamento = double.Parse(Console.ReadLine());

            //troco = pagamento - valor_compra;

            //double moeda_1, moeda_050, moeda_025, moeda_010, moeda_05, moeda_01;

            //moeda_1 = moeda_050 = moeda_025 = moeda_010 = moeda_05 = moeda_01 = 0;



            //for (int i = 1; i <= (int)troco; i++)
            //{

            //    while (pagamento < valor_compra)
            //    {
            //        Console.WriteLine("O valor de pagamento foi MENOR do que o valor da compra");

            //        Console.WriteLine("Inira novamente: ");

            //        Console.Write(" Valor total da compra: R$");
            //        valor_compra = double.Parse(Console.ReadLine());

            //        Console.Write(" Valor recebido para pagamento: R$");
            //        pagamento = double.Parse(Console.ReadLine());

            //        troco = pagamento - valor_compra;

            //    }

            //    Console.WriteLine("TROCO : R$ {0,4:F2}", troco);

            //    while (troco >= 1)
            //    {
            //        moeda_1++;
            //        troco = troco - 1;

            //    }
            //    while (troco < 1 && troco >= 0.50)
            //    {
            //        moeda_050++;
            //        troco = troco - 0.50;

            //    }
            //    while (troco < 0.50 && troco >= 0.25)
            //    {
            //        moeda_025++;
            //        troco = troco - 0.25;

            //    }
            //    while (troco < 0.25 && troco >= 0.10)
            //    {
            //        moeda_010++;
            //        troco = troco - 0.10;

            //    }
            //    while (troco < 0.10 && troco >= 0.05)
            //    {
            //        moeda_05++;
            //        troco = troco - 0.05;


            //    }
            //    while (troco < 0.05 && troco >= 0.01)
            //    {
            //        moeda_01++;
            //        troco = troco - 0.01;
            //    }


            //}


            //Console.WriteLine("Moedas de R$ 1.00 : {0} ", moeda_1);
            //Console.WriteLine("Moedas de R$ 0.50 : {0} ", moeda_050);
            //Console.WriteLine("Moedas de R$ 0.25 : {0} ", moeda_025);
            //Console.WriteLine("Moedas de R$ 0.10 : {0} ", moeda_010);
            //Console.WriteLine("Moedas de R$ 0.05 : {0} ", moeda_05);
            //Console.WriteLine("Moedas de R$ 0.01 : {0} ", moeda_01);











            /* Ex 5
            Uma pessoa faz uma aplicação no valor digitado pelo
usuário, durante 11 meses, a uma taxa de juros
compostos de 5 % a.m., capitalizados mensalmente.
Calcular o montante no final do prazo*/


            //int meses;
            //double valor, montante, soma_montante;
            //double juros;

            //Console.Write("Digite o valor aplicado: R$ ");
            //valor = int.Parse(Console.ReadLine());
            //juros = 0.05;
            //montante = 0;
            //soma_montante = 0;


            //for (meses = 1; meses <= 11; meses++)
            //{
            //    montante = valor * juros;
            //    soma_montante = montante + valor;
            //    valor = soma_montante;
            //}


            //Console.WriteLine("Após os {0} meses o rendimento foi de {1 :f2}", meses - 1, valor);


