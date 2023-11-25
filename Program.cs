// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Xml.Schema;


while (true){

Console.WriteLine("Digite 1 para somar ou 2 para subtarir ou 3 para multiplicar ou 4 para dividir ou 5 para ver o resto da divisão ou 6 para ver o resultado da potência ou 0 para sair.");

var indice = int.Parse(Console.ReadLine());

if (indice==0){
    System.Environment.Exit(-1);
}

var numero1 = double.Parse(Console.ReadLine());

var numero2 = double.Parse(Console.ReadLine());

double resultado = 0;



switch (indice) {
    case 1:
    switch (resultado = numero1 + numero2)
    {}break;

    case 2:
    switch (resultado = numero1 - numero2)
    {}break;
        
        
    case 3:
    switch (resultado = numero1 * numero2)
    {}break;

    case 4:
    switch (resultado = numero1 / numero2)
    {}break;

    case 6:
    switch (resultado = Math.Pow(numero1,numero2))
    {}break;

    case 0:
    System.Environment.Exit(-1);
    {}break;  

    case 5:
    switch (resultado = numero1 % numero2)
    {}break; 




}
Console.WriteLine(Convert.ToString(resultado));

}


 
