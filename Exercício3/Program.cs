using System;
namespace JogarDados
{

 class Program
 {
    public static string verificaNome;
    public static string Jogador1;
    public static string Jogador2;
    public static int resultado1 = 0, resultado2 = 0;
    public static int[] placar = new int[2];
    public static Random dado = new Random();

    static void Main(string[] args){
        CriarJogadores();
        IniciarRodadas();
    }


public static void CriarJogadores()
{
        
Console.WriteLine("Digite o nome do primeiro jogador:");
 Jogador1 = Console.ReadLine();

Console.WriteLine("Digite o nome do segundo jogador:");
verificaNome = Console.ReadLine();

Jogador2 = verificaNome;


 while(verificaNome == Jogador1)
     {
        Console.WriteLine("\nERRO: o nome do segundo jogador não pode ser o mesmo que do prmeiro jogador!");
        Console.WriteLine("\nDigite o nome do segundo jogador:");
        verificaNome = Console.ReadLine();
        Jogador2 = verificaNome;
     }
}



public static void IniciarRodadas(){
for (int i = 1; i <= 3; i++){
Console.WriteLine($"\nRodada {i}");

resultado1 = dado.Next(1,7);

Console.WriteLine($"\n{Jogador1} tirou o número {resultado1}.");

resultado2 = dado.Next(1,7);
Console.WriteLine($"\n{Jogador2} tirou o número {resultado2}.");

if (resultado1 != resultado2){

    if (resultado1 > resultado2){

        Console.WriteLine($"\n{Jogador1} tirou o número {resultado1} e {Jogador2} o número {resultado2}. {Jogador1} venceu a rodada {i}.");
        placar[0] += 1;

    }else{

        Console.WriteLine($"\n{Jogador1} tirou o número {resultado1} e {Jogador2} o número {resultado2}. {Jogador2} venceu a rodada {i}.");
        placar[1] += 1;

    }

}else
{
    Console.WriteLine("Empate! Nenhum jogador pontuou.");
}


Console.WriteLine($"\n\nO placar está: jogador {Jogador1} com {placar[0]} pontos e jogador {Jogador2} com {placar[1]} pontos");
}

GerarResultado();

}

public static void GerarResultado()
   {
    if (placar[0] != placar[1]){

        if (placar[0]>placar[1]){

        Console.WriteLine($"\nO ganhador foi {Jogador1} com {placar[0]} pontos");
        
        }else{

            Console.WriteLine($"\nO ganhador foi {Jogador2} com {placar[1]} pontos");

        }

    }else
        {

        Console.WriteLine($"Empate! jogador {Jogador1} com {placar[0]} pontos e jogador {Jogador2} com {placar[1]} pontos"); 

        }
 
    }

 }
}