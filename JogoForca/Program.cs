using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace JogoDaForca{
        
   class Program
    {
        private static ArrayList ListaDePalavras = new ArrayList();
        private static ArrayList ListaDeLetrasDigitadas = new ArrayList();
            public static Random sorteio = new Random();

            private static int indiceSorteado1 = sorteio.Next(0,3), contador = 0, placar, tentativas, count3=0,letraExistente=0;
            public static String line,chute, indice, palavra, contrutorPalavra, PalavraOculta, letraDigitada, letraUtilizadas;
            
            public static Boolean tem, jogo = true, isLetra = false, chutouCerto= false;
        static void Main(string[] args)
        {
            
            Iniciar();
            VerificaLetra();
            
        }
            
           
        


        public static void Iniciar()
        {

            

            StreamReader sr = new StreamReader("E:\\DIOGO\\AtividadesC#\\JogoDaForca\\lista.txt");
            
            line = sr.ReadLine();

            // Le todas as linhas do arquivo
            while (line != null)
            {
                contador = 0;
                for(int i=0; i< line.Length;i++)
                {
                
                    // Pega a categoria de todas as linhas e compara 
                    if (line[i] == ';' && contador == 0 )
                    {
                        indice = Convert.ToString(line[i+1]);
                        contrutorPalavra = "";

                        // Se é igual ao índice sorteado pelo sistema ele adiciona na lista de palavras
                    
                        if (indiceSorteado1 == Convert.ToInt16(indice))
                        {
                            for(int j = 0; Convert.ToString(line[j]) != ";"; j++)
                            {
                                contrutorPalavra += Convert.ToString(line[j]);
                            }
                           ListaDePalavras.Add(contrutorPalavra);
                           //Console.WriteLine(line);

                        }
                        contador += 1;
                    }
                }
                // lê a próxima linha
                line = sr.ReadLine();
            }



            //fecha o arquivo
            sr.Close();


            int indiceSorteado2 = sorteio.Next(0, ListaDePalavras.Count);

           // Console.WriteLine($"{indiceSorteado1} {ListaDePalavras[indiceSorteado2]} {indiceSorteado2}");

            palavra = Convert.ToString(ListaDePalavras[indiceSorteado2]);

            tentativas = palavra.Length * 2;

            switch(indiceSorteado1)
                {
                    case 0: Console.WriteLine($"Categoria: Filme        Quantidade de letras: {palavra.Length}\n\n\n\n");
                    {}break;

                    case 1: Console.WriteLine($"Categoria: Jogo        Quantidade de letras: {palavra.Length}\n\n\n\n");
                    {}break;

                    case 2:Console.WriteLine($"Categoria: País        Quantidade de letras: {palavra.Length}\n\n\n\n");
                    {}break;
                }


            for (int x = 0; x != palavra.Length;x++)
            {
                if(Convert.ToString(palavra[x]) == "-")
                {
                   PalavraOculta += " - "; 

                }else
                {
                    PalavraOculta += " _ ";

                }
                


            }

            System.Console.WriteLine(PalavraOculta);


        }

        public static void Chutar()
        {
            Console.WriteLine("Digite seu chute:");
                chute = Console.ReadLine().ToUpper();

                if(chute == Convert.ToString(palavra))
                {
                    chutouCerto = true;
                     
                }
                else
                {
                    tentativas=0;

                }

                EndGame();
                 

        }




        

        public static void VerificaLetra()
        {



            while(jogo==true){
            tem = false;

            Console.WriteLine("Digite uma letra:");
            letraDigitada = Console.ReadLine().ToUpper();

            if ( ListaDeLetrasDigitadas.Count==0)
             {
                 ListaDeLetrasDigitadas.Add(" Letras já digitadas ");
             }

            for(int s = 0; s < ListaDeLetrasDigitadas.Count;s++)
             {
                if(letraDigitada == Convert.ToString(ListaDeLetrasDigitadas[s]))
                {
                    Console.WriteLine("\nLetra já digitada, tente outra letra!\n");
                    letraExistente += 1;
                }
                
             }

                

            if(letraDigitada=="1")
            {
                Chutar();
            }
            else
            {

            if(letraDigitada == "" || letraDigitada.Length!=1 || letraExistente != 0 || letraDigitada.All(char.IsDigit))
            {
                isLetra=false;

                while (isLetra==false)
                {
                    letraExistente = 0;
                     Console.WriteLine("Dígito incorreto, tente novamente:");
                     Console.WriteLine("Digite uma letra:");
                     letraDigitada = Console.ReadLine().ToUpper();
                            
                    if(letraDigitada=="1")
                    {
                        
                        Chutar();
                        return;
                        
                    }
                    else
                    {


                      for(int t = 0; t < ListaDeLetrasDigitadas.Count;t++)
                       {
                            if(letraDigitada == Convert.ToString(ListaDeLetrasDigitadas[t]))
                            {
                                Console.WriteLine("\nLetra já digitada, tente outra letra!\n");
                                letraExistente += 1;
                            }
                           
                       }
                       

                            if(letraDigitada != "" && letraDigitada.Length==1 && letraExistente == 0 && letraDigitada.All(char.IsDigit) == false)
                            {
                                isLetra = true;
                            }
                    }

                     
                
            }
            }

            letraExistente = 0;

           

             tentativas -= 1;

             

                    ListaDeLetrasDigitadas.Add(letraDigitada);

                    letraUtilizadas = "";

                    for(int h = 0; h!=ListaDeLetrasDigitadas.Count;h++)
                    {
                        if( h == ListaDeLetrasDigitadas.Count-1)
                        {
                            letraUtilizadas += Convert.ToString(ListaDeLetrasDigitadas[h]);

                        }else
                        {
                            letraUtilizadas += Convert.ToString(ListaDeLetrasDigitadas[h])+" - ";
                        }
                        
                    }




                    for(int z = 0; z != palavra.Length;z++)
                    {
                        if(letraDigitada == Convert.ToString(palavra[z]))
                        {
                            tem = true; 
                            
                            
                        }
                    }


                    switch(indiceSorteado1)
                        {
                            case 0: Console.WriteLine($"Categoria: Filme        Quantidade de letras: {palavra.Length}");
                            {}break;

                            case 1: Console.WriteLine($"Categoria: Jogo        Quantidade de letras: {palavra.Length}");
                            {}break;

                            case 2:Console.WriteLine($"Categoria: País        Quantidade de letras: {palavra.Length}");
                            {}break;
                        }

                    
                    if(tem == true)
                    {
                        placar += 1; 
                        PalavraOculta = "";
                        

                        for(int y = 0; y < palavra.Length;y++)
                        {
                            count3 = 0;
                            

                            for(int e = 0; e < ListaDeLetrasDigitadas.Count;e++)
                            {
                                if(Convert.ToString(ListaDeLetrasDigitadas[e]) == Convert.ToString(palavra[y]))
                                {
                                    
                                    PalavraOculta += ($" {ListaDeLetrasDigitadas[e]} ");
                                    count3 +=1;
                                    

                                }
                                

                            
                            }

                            if(count3 == 0)
                                {
                                    if(Convert.ToString(palavra[y]) == "-")
                                        {
                                        PalavraOculta += " - "; 

                                        }else
                                        {
                                            PalavraOculta += " _ ";

                                        }
                                }    
                        }

                    }
                    
                    Console.WriteLine($"Acertos: {placar}        Tentativas Restantes: {tentativas}     Para chutar digite '1'\n {letraUtilizadas}\n\n\n\n");
                    Console.WriteLine(PalavraOculta);
                    
                    
                
               
             }
             

            

            EndGame();

             
            
            }
            

            }

            public static void EndGame()
            {
                Boolean verificaPalavra = false;
                int contador = 0;
                


                

                for(int w = 0; w != PalavraOculta.Length; w++)
                {
                    if( Convert.ToString(PalavraOculta[w])=="_" )
                    {
                        contador += 1;

                    }
                }


                if (contador==0 || chutouCerto == true)
                {
                    jogo = false;
                    Console.WriteLine("Fim de jogo, você venceu!");
        
                }
                else
                {
                    if(tentativas == 0)
                    {
                        jogo = false;
                        Console.WriteLine("Fim de jogo, você perdeu!");

                    }
                }

                

            }


        }




  


    }


    

    

