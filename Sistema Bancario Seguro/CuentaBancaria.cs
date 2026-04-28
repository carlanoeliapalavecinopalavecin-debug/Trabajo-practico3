using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancario_Seguro
{
    internal class CuentaBancaria
    {
        private decimal saldo;
        private string tipoCuenta;
        private List<string> historial;
        // Propiedades de solo lectura
        public decimal Saldo
        {
            get { return saldo; }
        }

        public string TipoCuenta
        {
            get { return tipoCuenta; }
        }

        public IReadOnlyList<string> Historial
        {
            get { return historial.AsReadOnly(); }
        }
        // Constructor
        public CuentaBancaria(string tipo, decimal saldoInicial)
        {
            if (saldoInicial < 0)
            {
                Console.WriteLine("El saldo inicial no puede ser negativo.");
                saldo = 0;
            }
            else
            {
                saldo = saldoInicial;
            }

            tipoCuenta = tipo;
            historial = new List<string>();

            historial.Add("Cuenta creada con saldo inicial: $" + saldo);
        }
        public void Depositar(decimal monto)
        {
            if (monto <= 0)
            {
                Console.WriteLine("El depósito debe ser mayor a cero.");
                return;
            }

            saldo += monto;
            historial.Add("Depósito de $" + monto);
        }
        public void Retirar(decimal monto)
        {
            if (monto <= 0)
            {
                Console.WriteLine("El retiro debe ser mayor a cero.");
                return;
            }

            if (monto > saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
                return;
            }

            saldo -= monto;
            historial.Add("Retiro de $" + monto);
        }
        public void CalcularInteresMensual()
        {
            decimal interes = 0;

            if (tipoCuenta.ToLower() == "ahorro")
            {
                interes = saldo * 0.03m;
                saldo += interes;
                historial.Add("Interés aplicado: $" + interes);
            }
            else if (tipoCuenta.ToLower() == "corriente")
            {
                historial.Add("Cuenta corriente: sin interés.");
            }
        }
    }
}
