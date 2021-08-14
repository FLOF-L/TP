     //desafio
            //string[] prof = new string[6]; 

            //for(int i = 0; i < prof.Length; i++)
            //{
            //    prof[i] = Console.ReadLine();
            //    //Console.WriteLine(prof[i]);
            //}




            /*1. Desenvolva um programa que armazene em um vetor 
os 30 primeiros termos da série abaixo:
            1/2
            2/3
            3/4
             
             */


            //double[] serie = new double[30];

            //int n = 1;

            //for (int i = 0; i < serie.Length; i++)
            //{
            //    serie[i] = n / (n + 1);
            //    n++;
            //}
            //Console.WriteLine(serie[1]);





            /*2. Armazenar vinte valores na memória. Após a digitação, 
entrar com uma constante multiplicativa que deverá 
multiplicar cada um dos valores do vetor e armazenar 
o resultado em outro vetor, porém em posições 
equivalentes. Exibir os vetores na tela.*/


            //int[] antes = new int[20];
            //int[] depois = new int[20];

            //Console.WriteLine("Digite o valor da constante: ");
            //int k = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite 20 números :");

            //for(int i = 0; i < antes.Length; i++)
            //{
            //    antes[i] = int.Parse(Console.ReadLine());
            //}

            //for(int i = 0; i < depois.Length; i++)
            //{
            //    depois[i] = antes[i] * k;
            //    Console.WriteLine(depois[i]);
            //}







            /*3. Crie um programa que armazene na memória do 
computador, os 100 primeiros números inteiros, múltiplos 
de 5.*/
            //int[] sequencia = new int[101];

            //for (int i = 1; i < sequencia.Length; i++)
            //{
            //    sequencia[i] = i * 5;
            //    Console.WriteLine(sequencia[i]);
            //}






            /*4. Descreva um programa que armazene em um vetor
100 números inteiros e positivos que são digitados, e
que em seguida leia esse vetor calculando a média
aritmética dos números que são ímpares.*/

            // int[] n = new int[4];
            // int i = 0;
            // int impares = 0;
            // int soma_impares = 0;
            //float media_impares = 0;
            // int qnt_impares = 0;


            // Console.WriteLine("Comece a digitar os números: ");

            // while (i < n.Length)
            // {

            //     n[i] = int.Parse(Console.ReadLine());

            //     while (n[i] < 0)
            //     {
            //         Console.WriteLine("Os números devem ser positivos. Digite novamente:  ");
            //         n[i] = int.Parse(Console.ReadLine());

            //     }
            //     i++;
            // }

            // for(int e = 0; e < n.Length; e++)
            // {

            //     if (n[e] % 2 != 0)
            //     {
            //       soma_impares = soma_impares + n[e];

            //         qnt_impares++;
            //     }

            // }

            // media_impares = (float)soma_impares / (float)qnt_impares;

            // Console.WriteLine("A média dos números impares é : {0}", media_impares);








            /*.5 - Armazenar um máximo de 20 valores em um vetor. A
quantidade de valores a serem armazenados será
escolhida pelo usuário.Enviar mensagem de erro, caso
a quantidade de valores escolhida esteja fora da faixa
possível e solicitar a quantidade novamente.Após a
digitação dos valores, criar uma rotina de consulta, 
onde o usuário digita um número e o programa exibe
em qual posição do vetor este número está localizado. 
Se o número não for encontrado, enviar mensagem 
“Valor não encontrado!”.*/


            //Console.WriteLine("Digite a quantidade de valores a serem armazenados: ");
            //int quantidade = int.Parse(Console.ReadLine());

            //int achou = 0;

            //while (quantidade > 20 || quantidade <= 0)
            //{
            //    Console.WriteLine("Erro, digite novamente. Deve ser uma quantidade de no máximo 20.");
            //    quantidade = int.Parse(Console.ReadLine());
            //}

            //int[] vet = new int[quantidade];

            //Console.WriteLine("Certo, agora digite os valores");

            //for (int i = 0; i < vet.Length; i++)
            //{
            //    vet[i] = int.Parse(Console.ReadLine());
            //}

            //int manter = 5;

            //while (manter == 5)
            //{
            //    Console.WriteLine("_____________________________________________   ");
            //    Console.WriteLine("Deseja entrar na rotina? 1 - Sim / 2 - Não ");
            //    int resposta = int.Parse(Console.ReadLine());

            //    if (resposta == 1)
            //    {
            //        Console.WriteLine("Digite qual número você quer saber a posição:");
            //        int number = int.Parse(Console.ReadLine());

            //        for (int i = 0; i < vet.Length; i++)
            //        {
            //            if (vet[i] == number)
            //            {
            //                Console.WriteLine("O número {0} está na posição {1}", number, i + 1);
            //                achou = 1;
            //            }

            //        }

            //        if (achou == 0)
            //        {
            //            Console.WriteLine("Valor não encontrado !");
            //        }

            //        achou = 0;
            
            //    }

            //    if (resposta == 2)
            //    {
            //        Console.WriteLine("Ok, encerrando o programa.");
            //        manter = 0;
            //    }

            //}

            /*6. Armazenar o nome, sexo e idade de cem pessoas. 
Consistir as entradas no sentido de aceitar apenas “F” 
ou “M” para o sexo e valores positivos para a idade. 
Após a digitação dos dados, exibir os dados (nome, 
sexo e idade) de todas as pessoas do sexo feminino.*/

            //    int qtd_pessoas = 3;
            //    string[] nome = new string[qtd_pessoas];
            //    int[] idade = new int[qtd_pessoas];
            //    char[] sexo = new char[qtd_pessoas]; 
            
            //for(int i = 0; i < qtd_pessoas ; i++)
            //{
            //    Console.WriteLine("____________________________________________");
            //    Console.WriteLine("Digite as informações da {0}° pessoa ", i + 1);
            //    Console.Write("Nome: ");
            //    nome[i] = Console.ReadLine();
            //    Console.Write("Idade: ");
            //    idade[i] = int.Parse(Console.ReadLine());
            //    while (idade[i] <= 0)
            //    {
            //        Console.Write("A idade deve ser positiva, digite novamente: ");
            //        idade[i] = int.Parse(Console.ReadLine());
            //    }
            //    Console.Write("Sexo(F/M):  ");
            //    sexo[i] = char.Parse(Console.ReadLine());
            //    if(sexo[i] != 'F' && sexo[i] != 'M')
            //    {
            //        Console.WriteLine("Só aceitamos F ou M para sexo. Digite novamente: ");
            //        sexo[i] = char.Parse(Console.ReadLine());
            //    }

            //}

            //for (int i = 0; i < qtd_pessoas; i++)
            //{
            //    if( sexo[i] == 'F')

            //    {
                    
            //        Console.WriteLine("-------------------");
            //        Console.WriteLine("Informações sexo feminino: ");

            //        Console.WriteLine("Nome: {0}",nome[i]) ;
            //        Console.WriteLine("Idade : {0}",idade[i]);
            //        Console.WriteLine("Sexo: {0} ", sexo[i]);

            //    }
            //}





        /*7. Desenvolva um programa que receba uma palavra via 
teclado e verifique se a mesma é palíndroma. Uma 
palavra é palíndroma se é idêntica quando lida de trás 
para diante. Por exemplo, "ovo" é um palíndromo.*/

                //Console.Write("Digite uma palavra: ");
                //string palavra = Console.ReadLine();

                //int tam = palavra.Length;

                //if(tam > 0)
                //{
                //    if (palavra[0] == palavra[tam - 1] && tam == 3)
                //    {
                //        Console.Write("É palíndroma!");
                //    }

                //    if (palavra[0] == palavra[tam - 1] && palavra[1] == palavra[tam - 2] && tam == 5)
                //    {
                //        Console.Write("É palíndroma!");

                //    }

                //    if (palavra[0] == palavra[tam - 1] && palavra[1] == palavra[tam - 2] && palavra[2] == palavra[tam - 3] && tam == 7)
                //    {
                //        Console.Write("É palíndroma!");
                //    }


                //}

                //else
                //{
                //    Console.WriteLine("Não é palíndroma");
                //}









                /*8. Armazenar vinte valores em um vetor. Após a 
    digitação, exibir os valores em ordem crescente.*/

                //int[] n = new int[5];

                //Console.WriteLine("Digite os 20 valores : ");
                //for (int i = 0; i < n.Length; i++)
                //{
                //    n[i] = int.Parse(Console.ReadLine());
                //}

                //int aux;
                //Console.WriteLine("_____________");

                //for (int i = 0; i < n.Length; i++)//começa em 0
                //{
                //    //Aqui, na posição 0, vamos verificar nesse outro for
                //    //se há algum valor maior que o da posição 0
                //    //Vamos percorrer todo o vetor e compará-lo com a posição 0 do for anterior.
                //    for(int j = i + 1; j < n.Length; j++)//começa em 1.
                //    {
                //        if (n[i] > n[j])//comparando a posição 0 com todas as outras
                //        {//imagine que n[0] é 4 e n[j] é 2

                //            aux = n[i]; //aux = 4
                //            n[i] = n[j]; //n[0] = 2
                //            n[j] = aux; //n[j] =  4
                //        }
                //        //como comparo 1 posição com todas as outras em seguida
                //        //e digo que n[i] = n[j] quando n[i] for maior que n[j]
                //        // estou organizando o vetor n em ordem crescente, depois basta
                //        // escreve-lo na tela.
                //    }
                //}

                //for(int i = 0; i < n.Length; i++)
                //{
                //    Console.WriteLine(n[i]);
                //}
