using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabancaria
{
    internal class ContaBancaria
    {
        //Definição de propriedades
        public int Numero { get; }
        public string Titular { get; set; }

        public double Saldo {  get; private set; }

        //Construtores

        //este construtor permite instanciar contas bancárias apenas com o nº de conta e o seu titular
        public ContaBancaria(int numero, string titular) 
        {
            Numero = numero;
            Titular = titular;
        }

        //Este construtor permite instanciar uma conta a partir do seu nº de conta
        //titular e tb do seu saldo inicial)
        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        } 

        // Secção de Métodos

        //Este é o método que permite depositar dinheiro na conta
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        //Este é o método que permite fazer o levantamento de dinheiro
        public void Levantamento (double quantia)
        {
            Saldo -= quantia + 5.00;
        }

        public override string ToString()
        {
            return "Conta Bancária número "
                + Numero
                + ", Titular da conta: "
                + Titular
                + ", Saldo "
                + Saldo. ToString("F2")
                + " euros.";
        }
    }
}
