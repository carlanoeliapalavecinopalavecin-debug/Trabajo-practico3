namespace Sistema_de_emplados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();

            empleados.Add(new EmpleadoTiempoCompleto("Noelia", 200, 120000));
            empleados.Add(new EmpleadoPartTime("Lorena", 150, 80, 1500));
            empleados.Add(new EmpleadoContratado("Sofía", 140, 90000, new DateTime(2026, 12, 31)));

            double totalNomina = 0;

            foreach (Empleado emp in empleados)
            {
                Console.WriteLine(" Empleados ");
                emp.MostrarInfo();
                totalNomina += emp.CalcularSueldo();
            }

            Console.WriteLine(" Sueldos");
            Console.WriteLine("Costo total de nómina: $" + totalNomina);
        }
    }
}
    

