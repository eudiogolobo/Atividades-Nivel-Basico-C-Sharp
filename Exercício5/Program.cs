using System;

namespace UsandoDatas{


    class Program
    {

        public static byte indice, indice2;
        static void Main(string[] args)
        {
            while(true)
            {

            Iniciar();
            

            }



        }



    public static void Iniciar()
    {
        System.Console.WriteLine("\n\nDigite: \n\n1 para Utilizar minha configuração de sistema: 08/01/2021 20:48:13 (Este item deve apenas converter a data para string, deixar que o sistema use o formato dele) \n2 para eormato simples: 08-01-21 \n3 para formato longo sexta-feira, 8 de janeiro de 2021 \n4 para usar formato longo personalizado 08-01-2021 08:48:13 \n5 Formato RFC1123 pattern Fri, 08 Jan 2021 20:48:13 GMT\n0 para SAIR");
        indice = Convert.ToByte(Console.ReadLine());

        if (indice<0 || indice >5)
        {
            Console.WriteLine("\nDígito não identificado, por favor digite novamente\n");
            return;
        }

        if (indice == 0)
        {
            System.Environment.Exit(-1);
        }

        Eventos();

    }

    public static void Eventos()
    {
        System.Console.WriteLine("\n\nEscolha alguma opção:\n1- ENIAC 2- RFC1 3- Alan Turing");
        indice2 = Convert.ToByte(Console.ReadLine());

        if (indice2<1 || indice2 >3)
        {
            Console.WriteLine("\nDígito não identificado, por favor digite novamente\n");
            Eventos();
            
        }

         MostrarMenu1();

         MostrarMenu2();
    }

    public static void MostrarMenu2()
    {
        switch(indice2)
        {
            case 1: System.Console.WriteLine("(ENIAC) - 15 de agosto de 1946 No dia 15 de agosto de 1946 os norte-americanos John Eckert \ne John Mauchly apresentaram o ENIAC, o primeiro equipamento eletrônico chamado de computador no mundo.");

            {}break; 

            case 2: System.Console.WriteLine("(RFC1) - 17 de abril de 1969 Em 17 de abril de 1969 foi feita a publicação da RFC1, por esse\n motivo considera-se esse o dia da internet até hoje.");

            {}break;

            case 3: System.Console.WriteLine("(Alan Turing) - 23 de junho de 1912 Nascimento de Alan Turing, matemático e criptoanalista\n britânico que é considerado o 'pai da informática' por ter sido essencial na criação de máquinas que,\n mais tarde, dariam origem aos PCs que utilizamos hoje para trabalhar , estudar e realizar\n nossas atividades diárias. Sua genialidade e influência fundamental na história\n da humanidade, entretanto, foram ceifadas pelo preconceito de uma época que, felizmente, já ficou para trás.");

            {}break;


        }

        System.Environment.Exit(-1);
    }



    public static void MostrarMenu1()
    {
        DataConfiguracao dataConfig = new DataConfiguracao();

       switch (indice)
       {

         case 1:{ dataConfig.Modelo1();

         }{}break;

         case 2:{ dataConfig.Modelo2();

         }{}break;

         case 3:{ dataConfig.Modelo3();

         }{}break;

         case 4:{ dataConfig.Modelo4();

         }{}break;

         case 5:{ dataConfig.Modelo5();

         }{}break;


        
       }

    System.Console.WriteLine("-------------------------------------");
    }

    class DataConfiguracao()
    {
        private static DateTime data = DateTime.Now;

        private static string dataFormatada;

        public void Modelo1()
        {
            dataFormatada = data.ToString("dd/MM/yyyy HH:mm:ss");
            System.Console.WriteLine(dataFormatada);
        }

        public void Modelo2()
        {
            dataFormatada = data.ToString("dd-MM-yyyy"); 
            System.Console.WriteLine(dataFormatada);
        }

        public void Modelo3()
        {
           dataFormatada = data.ToString("dddddd, dd MMMM yyyy"); 
           System.Console.WriteLine(dataFormatada); 
        }

        public void Modelo4()
        {
          dataFormatada = data.ToString("dd-MM-yyy HH:mm:ss");  
          System.Console.WriteLine(dataFormatada);
        }

        public void Modelo5()
        {
            dataFormatada = data.ToString("ddd, dd MMM yyyy HH':'mm':'ss 'GMT'");
            System.Console.WriteLine(dataFormatada);
        }



    }

  

    }  

}
