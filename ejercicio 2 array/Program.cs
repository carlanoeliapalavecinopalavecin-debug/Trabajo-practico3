namespace ejercicio_2_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Ejercicio 2: Inicialización Directa y Foreach___");
            string[]frutas = { "Manzanas", "Banana", "Uva", "Naranja" };
            Console.WriteLine(" Lista de Frutas usando foreach:");

            foreach (string fruta in frutas) 
            {
                Console.WriteLine("  "+ fruta);
        }
            Console.WriteLine("\n Presione enter para continuar...");
            Console.ReadLine();


            //ejercicio 1

            Console.WriteLine("-----Ejercicio 3: Inicialización Directa y Foreach___");

            string[] frutas1 = { "Manzanas", "Banana", "Uva", "Naranja","Anana" };
            Console.WriteLine(" Lista de Frutas usando foreach:");

            foreach (string fruta1 in frutas1)
            {
                Console.WriteLine("  " + fruta1);
            }
            Console.WriteLine("\n Presione enter para continuar...");
            Console.ReadLine();


            //ejercicio 2

            Console.WriteLine("-----Ejercicio 4: Inicialización Directa y Foreach___");

            string[] bebidas = { "coca", "Pepsi", "sevenup", "Fanta", "Mirinda" };
            Console.WriteLine(" Lista de Bebidas usando foreach:");

            foreach (string bebida in bebidas)
            {
                Console.WriteLine("  " + bebida);
            }
            Console.WriteLine("\n Presione enter para continuar...");
            Console.ReadLine();

            //ejercicio 3

            Console.WriteLine("-----Ejercicio 5: Inicialización Directa y Foreach___");

            string[] galletas = { "Oreo", "Sonrisa", "Pepas" };
            Console.WriteLine(" Lista de Galletas usando foreach:");

            foreach (string galleta in galletas)
            {
                Console.WriteLine("  " + galleta);
            }
            Console.WriteLine("\n Presione enter para continuar...");
            Console.ReadLine();

            //ejercicio 4

            Console.WriteLine("-----Ejercicio 6: Inicialización Directa y Foreach___");

            string[] nombres = { "Sofia", "Noelia", "Natalia", "Mayra", "Ana" };
            Console.WriteLine(" Lista de Nombre usando foreach:");

            foreach (string nombre in nombres)
            {
                Console.WriteLine("  " + nombre);
            }
            Console.WriteLine("\n Presione enter para continuar...");
            Console.ReadLine();

            //ejercicio 5

            Console.WriteLine("-----Ejercicio 7: Inicialización Directa y Foreach___");

            string[] objetos = { "Llave", "Mesa", "Tapa", "Botella", "Carpeta" };
            Console.WriteLine(" Lista de Frutasusando foreach:");

            foreach (string objeto in objetos)
            {
                Console.WriteLine("  " + objeto);
            }
            Console.WriteLine("\n Presione enter para continuar...");
            Console.ReadLine();
        }
    }
}
