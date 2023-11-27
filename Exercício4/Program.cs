using System;
using System.Runtime;

namespace ContaDeBanco
{
    class Program 
    {
        static void Main(string[] args)
        {
            Banco pessoa1 = new Banco("Diogo");
            

            while (true){

            System.Console.WriteLine("\nDigite 1 para sacar ou 2 para depositar ou 3 para ver seu saldo ou 0 para sair.");
            
            int digito = Convert.ToInt16(Console.ReadLine());
            

            switch (digito)
            {
                case 1: {
                System.Console.WriteLine("Muito bem, agora digite o valor:\n");
                pessoa1.Saque(Convert.ToDecimal(Console.ReadLine()));
                pessoa1.VerDetalhes();
                }

                {}break;

                case 2: {
                System.Console.WriteLine("Muito bem, agora digite o valor:\n");
                pessoa1.Deposito(Convert.ToDecimal(Console.ReadLine()));
                pessoa1.VerDetalhes();
                }

                {}break;

                case 3: pessoa1.VerDetalhes();
                
                {}break;

                case 0:System.Environment.Exit(-1); 
            
                {}break;
            

                
                
            

            } 
            }

        }
    }

    public class Banco
    {
        private decimal saldo = 100;
        private string nome;

        

        public Banco(string nome)
        {
            this.nome = nome;
        }

        //Para possibilitar a pessoa1 de ver o saldo caso queira não tendo a possibilidade de editar o mesmo
        public decimal Saldo => saldo;


        public void Deposito(decimal valor)
        {
            saldo+= valor;
        }

        public void Saque(decimal valor)
        {
            if(valor > saldo)
            {
                Console.WriteLine($"\nSaldo insuficiente.");
                return;
            }

            saldo -= valor;
        }

        public void VerDetalhes()
        {
            Console.WriteLine($"\n{nome} seu saldo é de R${saldo}");
        }
    }

}
