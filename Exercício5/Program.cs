using System;

namespace UsandoDatas{


    class Program
    {

        public static byte indice;
        static void Main(string[] args)
        {
            while(true)
            {

            Iniciar();
            
            Mostrar();

            }



        }



    public static void Iniciar()
    {
        System.Console.WriteLine("\n\nDigite \n1 para Utilizar minha configuração de sistema: 08/01/2021 20:48:13 (Este item deve apenas converter a data para string, deixar que o sistema use o formato dele) \n2 para eormato simples: 08-01-21 \n3 para formato longo sexta-feira, 8 de janeiro de 2021 \n4 para usar formato longo personalizado 08-01-2021 08:48:13 \n5 Formato RFC1123 pattern Fri, 08 Jan 2021 20:48:13 GMT\nDigite 0 para SAIR");
        indice = Convert.ToByte(Console.ReadLine());
        if (indice<0 || indice >5)
        {
            Console.WriteLine("\nDígito não identificado, por favor digite novamente\n");
            return;
        }
    }



    public static void Mostrar()
    {
        DataConfiguracao dataConfig = new DataConfiguracao();

       switch (indice)
       {
         case 0:{ System.Environment.Exit(-1);

         }{}break;

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
