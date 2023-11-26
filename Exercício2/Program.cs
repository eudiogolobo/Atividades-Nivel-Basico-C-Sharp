// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Net.Http.Headers;

while (true){

Console.WriteLine("Digite uma quntia de números entre 3 e 10. Para sair digite (SAIR)");
String captura = (Console.ReadLine());

if (captura == "SAIR"){
    System.Environment.Exit(-1);
}

Double quantia = Convert.ToDouble(captura), media = 0, soma = 0;

ArrayList numeros = new ArrayList();

if (quantia >3 && quantia < 10){
    for(int i = 0; i != quantia; i++){
        Console.WriteLine("Digite o número de nº "+(i+1));
        numeros.Add(Convert.ToDouble(Console.ReadLine()));
        soma += Convert.ToDouble(numeros[i]);

    }
    
    media = soma/ numeros.Count;

    Console.WriteLine("A média de é: " +media);
} else{
    Console.WriteLine("Número negado! Digite uma quantia entre 3 e 10.");
}

}