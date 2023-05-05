﻿namespace Contabancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cb;

            Console.WriteLine("Entre com o nº de conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome do titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Deseja fazer um depósito inicial?");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Qual é o valor de depósito inicial?");
                double depositoInicial = double.Parse(Console.ReadLine());
                cb = new ContaBancaria(numero, titular, depositoInicial);
            }
            else {  cb = new ContaBancaria(numero, titular); }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(cb);
            Console.WriteLine();

            Console.WriteLine("Valor a depositar: ");
            double quantia = double.Parse(Console.ReadLine());
            cb.Deposito(quantia);
            Console.WriteLine("Dados atualizados da conta: ");
            Console.WriteLine(cb);

            Console.WriteLine();
            Console.WriteLine("Que valor pretende levantar? ");
            quantia = double.Parse(Console.ReadLine());
            cb.Levantamento(quantia);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados da conta: ");
            Console.WriteLine(cb);

            Console.WriteLine("onde está o guilho?");
            Console.WriteLine("tretas");
            Console.WriteLine("Bom feitio.");
            Console.WriteLine("nice");
            Console.WriteLine("Está de chuva.");
            Console.WriteLine("Esta sol");
            Console.WriteLine("Está um Porche lá fora.");
            cb.Titular = "Pedro";
           Console.WriteLine(cb);
        }
    }
}