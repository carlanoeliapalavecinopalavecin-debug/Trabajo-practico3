namespace Sistema_Bancario_Seguro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta = new CuentaBancaria("Ahorro", 10000);

            cuenta.Depositar(5000);
            cuenta.Retirar(2000);
            cuenta.CalcularInteresMensual();

            Console.WriteLine("Saldo actual: $" + cuenta.Saldo);

            Console.WriteLine("\nHistorial de movimientos:");

            foreach (string movimiento in cuenta.Historial)
            {
                Console.WriteLine(movimiento);
            }
        }
    }
}
    

