 static int Dec(int num)
        {
            //Por algum motivo esse pedaço de código  faz o problema
            //dar erro:
            //if (num == 1)
                //return (num);


            if (num > 0)
            {
                Dec((int)num / 2);
                Console.Write(num % 2); 
            }
            return Convert.ToByte(num);
           
        }

        static void Main(string[] args)
        {
            Console.Write("Digite o número decimal que será convertido em binário: ");
            int num = int.Parse(Console.ReadLine());
            Dec(num);

        

        }
