using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Conta
    {
        private double saldo;
        private int NumeroConta;
        private int numeroConta;

        public double Saldo { get => saldo; set => saldo = value; }
        public int NumeroConta1 { get => NumeroConta; set => NumeroConta = value; }
        public int NumeroConta2 { get => numeroConta; set => numeroConta = value; }
        public double Valor { get; internal set; }

        public double depositar(double valor)
        {
            this.saldo = this.Valor + Valor;

            return this.saldo;
        }
        public void sacar()
        {
        }
        public void transferir()
        {
        }
    }
}
