using System;
namespace EX12
{
    class Program
    {
        static void Main(string[] args)
        {

            /*1.Entrar com o peso e a altura de uma determinada pessoa.
Após a digitação, exibir se esta pessoa está ou não com seu
peso ideal.Veja tabela da relação peso / altura².*/
                        //float peso, altura, R;
            //Console.Write("Digite sua altura: ");
            //altura = float.Parse(Console.ReadLine());
            //Console.Write("Digite seu peso: ");
            //peso = float.Parse(Console.ReadLine());

            //R = peso / (altura * altura);
            ////R = (float)(peso / (Math.Pow(altura, 2)));
            //Console.WriteLine("Seu IMC é de {0}", R);


            //if (R < 20)
            //{
            //    Console.WriteLine("Abaixo do peso");
            //}
            //else
            //{
            //    if (20 <= R && R < 25)
            //    {
            //        Console.WriteLine("Peso ideal");
            //    }
            //    else
            //    {
            //        if (R >= 25)
            //        {
            //            Console.WriteLine("Acima do peso");
            //        }
            //    }
            //}

            /*2. A partir de 3 (três) valores que serão digitados, verificar se
formam ou não um triângulo. Em caso positivo, exibir sua
classificação: “Isósceles, escaleno ou equilátero”. Um
triângulo escaleno possui todos os lados diferentes, o
triângulo isósceles, dois lados iguais e o equilátero, todos os
lados iguais. Para existir triângulo é necessário que a soma
de dois lados quaisquer seja maior que o outro, isto, para os
três lados. */
                        //int v1, v2, v3;
            //Console.Write("Digite o primeiro valor: ");
            //v1 = int.Parse(Console.ReadLine());
            //Console.Write("Digite o segundo valor: ");
            //v2 = int.Parse(Console.ReadLine());
            //Console.Write("Digite o terceiro valor: ");
            //v3 = int.Parse(Console.ReadLine());

            //if (v1 + v2 > v3 && v2 + v3 > v1 && v3 + v1 > v2)
            //{
            //    Console.WriteLine("Forma um triângulo");
            //    if (v1 == v2 && v2 == v3)
            //    {
            //        Console.WriteLine("Triangulo equilatero");
            //    }
            //    else
            //    {
            //        if (v1 != v2 && v2 != v3 && v3 != v1)
            //        {
            //            Console.WriteLine("Triangulo escaleno");
            //        }
            //        else
            //        {
            //            if (v1 == v2 && v1 != v3 || v3 == v1 && v3 != v2 || v2 == v3 && v2 != v1)
            //            {
            //                Console.WriteLine("Triângulo isóceles");
            //            }
            //        }
            //    }
            //}

            //else
            //{
            //    Console.WriteLine("Não forma um triãngulo");
            //}



            /*3. Verificar se três valores quaisquer (A,B, C) que serão
digitados formam ou não um triângulo retângulo. Lembre-se
que o quadrado da hipotenusa é igual à soma dos
quadrados dos catetos. */

         //   int a, b, c;
           
         //   Console.Write("Digite o valor de A: ");
         //   a = int.Parse(Console.ReadLine());
         //   Console.Write("Digite o valor de B: ");
         //   b = int.Parse(Console.ReadLine());
         //   Console.Write("Digite o valor de C: ");
         //   c = int.Parse(Console.ReadLine());

         //if (a + b > c && b + c > a && c + a > b) { 
         //   if (a > b && a > c)
         //       {
         //           int hipotenusa = (int)Math.Pow(a, 2);
         //           int cat1 = (int)Math.Pow(b, 2);
         //           int cat2 = (int)Math.Pow(c, 2);
         //           if (hipotenusa == cat1 + cat2)
         //           {
         //               Console.WriteLine("Forma triângulo retângulo");
         //           }
         //       }
         //       if (b > a && b > c)
         //       {
         //           int hipotenusa = (int)Math.Pow(b, 2);
         //           int cat1 = (int)Math.Pow(a, 2);
         //           int cat2 = (int)Math.Pow(c, 2);
         //           if (hipotenusa == cat1 + cat2)
         //           {
         //               Console.WriteLine("Forma triângulo retângulo");
         //           }
         //       }
         //       if (c > a && c > b)
         //       {
         //           int hipotenusa = (int)Math.Pow(c, 2);
         //           int cat1 = (int)Math.Pow(a, 2);
         //           int cat2 = (int)Math.Pow(b, 2);
         //           {
         //               Console.WriteLine("Forma triângulo retângulo");
         //           }
         //       }
         //   }
         //   else
         //   {
         //       Console.WriteLine("Não forma um triângulo retângulo");
         //   }





            /*4.Entrar com o peso, o sexo e a altura de uma determinada
            pessoa.Após a digitação, exibir se esta pessoa está ou não
            com seu peso ideal.Veja tabela da relação peso / altura2*/
                //    float peso, altura, R;
                //    string sexo;
                //    Console.Write("Digite seu sexo: ");
                //    sexo = Console.ReadLine();
                //    if (sexo == "Feminino" || sexo == "feminino")
                //    {
                //        Console.Write("Digite sua altura: ");
                //        altura = float.Parse(Console.ReadLine());
                //        Console.Write("Digite seu peso: ");
                //        peso = float.Parse(Console.ReadLine());

                //        R = peso / (altura * altura);


                //        if (R < 19)
                //        {
                //            Console.WriteLine("Abaixo do peso");
                //        }
                //        if (19 <= R && R < 24)
                //        {
                //            Console.WriteLine("Peso ideal");
                //        }
                //        if (R >= 24)
                //        {
                //            Console.WriteLine("Acima do peso");
                //        }
                //    }


                //    if (sexo == "masculino" || sexo == "Masculino")
                //    {
                //        Console.Write("Digite sua altura: ");
                //        altura = float.Parse(Console.ReadLine());
                //        Console.Write("Digite seu peso: ");
                //        peso = float.Parse(Console.ReadLine());

                //        R = peso / (altura * altura);


                //        if (R < 20)
                //        {
                //            Console.WriteLine("Abaixo do peso");
                //        }
                //        if (20 <= R && R < 25)
                //        {
                //            Console.WriteLine("Peso ideal");
                //        }
                //        if (R >= 25)
                //        {
                //            Console.WriteLine("Acima do peso");
                //        }
                //    }
                //}

                /* 5 . A partir dos valores da aceleração (a em m/s²), da
               velocidade inicial (v0 em m/s) e do tempo de percurso (t em
               s). Calcular e exibir a velocidade final de automóvel em
               km/h. Exibir mensagem de acordo com a tabela abaixo.
               Fórmula para o cálculo da velocidade em m/s: V = v0 + a. t.*/

               //float v0, a, t, v;
            //Console.Write("Digite a aceleração em m/s²: ");
            //a = float.Parse(Console.ReadLine());
            //Console.Write("Digite a velocidade inicial em m/s: ");
            //v0 = float.Parse(Console.ReadLine());
            //Console.Write("Digite o tempo do percurso em s: ");
            //t = float.Parse(Console.ReadLine());

            //v = v0 + (a * t);
            //double vf = v * 3.6;

            //Console.WriteLine("A velocidade em km/h é igual a {0}", vf);

            //if (vf <= 40)
            //{
            //    Console.WriteLine("Veículo muito lento");
            //}
            //else
            //{
            //    if (40 < vf && vf <= 60)
            //    {
            //        Console.WriteLine("Velocidade permitida");
            //    }
            //    else
            //    {
            //        if (60 < vf && vf <= 80)
            //        {
            //            Console.WriteLine("Velcoidade de cruzeiro");
            //        }
            //        else
            //        {
            //            if (80 < vf && vf <= 120)
            //            {
            //                Console.WriteLine("Veículo rápido");
            //            }
            //            else
            //            {
            //                if (vf >= 120)
            //                {
            //                    Console.WriteLine("Veículo muito rápido");
            //                }
            //            }
            //        }
            //    }
            //}

        }
                }

            }

 



