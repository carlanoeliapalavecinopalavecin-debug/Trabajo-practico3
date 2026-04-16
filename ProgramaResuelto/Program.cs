namespace ProgramaResuelto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombresClientes = new string[20];
            int[] edades = new int[20];
            for (int i = 0; i < nombresClientes.Length; i++)
            {
                Console.WriteLine(" Nombre del Cliente: " + (i + 1) + ",");
                nombresClientes[i] = Console.ReadLine();
                Console.WriteLine("Edad de: " + nombresClientes[i]);
                edades[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(" Lista de Clientes...");
                for (i = 0; i < nombresClientes.Length - 1; i++)
                {
                    Console.WriteLine("Nombres:" + nombresClientes[i] + "  Edad: " + edades[i]);
                 

                    for (i = 0; i < nombresClientes.Length; i++)
                    {
                        if (edades[i] >= 30)
                        {

                            Console.WriteLine("\n Bienvenidos Al Boliche..." + nombresClientes[i]);
                            Console.ReadLine();
                            
                        }
                        else
                        {
                            Console.WriteLine("Acceso no Permitido");
                            Console.ReadLine();
                        }

                    }

                }

            }
        }
      }
}





