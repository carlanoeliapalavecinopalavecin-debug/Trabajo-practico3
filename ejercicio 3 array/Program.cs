namespace ejercicio_3_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_____Ejercicio 3: Uso de Length y Bucle FOR____");

            int[] edades = { 15, 22, 30, 18, 25 };
            int cantidadElementos = edades.Length;
            Console.WriteLine(" El arreglo tiene" + cantidadElementos + " Elementos ");
            Console.WriteLine("_____________________________________________________");
            for (int i = 0; i < edades.Length;i++)
            {
                Console.WriteLine(" Indice "+ i+" La edad es: "+ edades [i]);
            }
            Console.WriteLine("\n Presione enter para continuar_____");
            Console.ReadLine();


            //ejercicio 1


            Console.WriteLine("_____Ejercicio 4: Uso de Length y Bucle FOR____");

            int[] edades1 = { 15, 22, 30, 18, 25 ,80,90,75};
            int cantidadElementos1 = edades.Length;
            Console.WriteLine(" El arreglo tiene" + cantidadElementos1 + " Elementos ");
            Console.WriteLine("_____________________________________________________");
            for (int i = 0; i < edades1.Length; i++)
            {
                Console.WriteLine(" Indice " + i + " La edad es: " + edades1[i]);
            }
            Console.WriteLine("\n Presione enter para continuar_____");
            Console.ReadLine();


            //ejercicio 2


            Console.WriteLine("_____Ejercicio 5: Uso de Length y Bucle FOR____");

            int[] numeros = { 1, 2, 30, 20, 25, 80, 85, 75 };
            int cantidadNumeros = numeros.Length;
            Console.WriteLine(" El arreglo tiene" + cantidadNumeros + " Elementos ");
            Console.WriteLine("_____________________________________________________");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(" Indice " + i + " Los numeros son : " + numeros[i]);
            }
            Console.WriteLine("\n Presione enter para continuar_____");
            Console.ReadLine();


            //ejercicio 3


            Console.WriteLine("_____Ejercicio 6: Uso de Length y Bucle FOR____");

            int[] numeros1 = { 1, 2, 30, 20 };
            int cantidadNumeros1 = numeros1.Length;
            Console.WriteLine(" El arreglo tiene" + cantidadNumeros1 + " Elementos ");
            Console.WriteLine("_____________________________________________________");
            for (int i = 0; i < numeros1.Length; i++)
            {
                Console.WriteLine(" Indice " + i + " Los numeros son : " + numeros1[i]);
            }
            Console.WriteLine("\n Presione enter para continuar_____");
            Console.ReadLine();


            //ejercicio 4


            Console.WriteLine("_____Ejercicio 7: Uso de Length y Bucle FOR____");

            int[] datos = { 1, 2, 30, 20 ,40,50,60};
            int cantidadDatos = datos.Length;
            Console.WriteLine(" El arreglo tiene" + cantidadDatos + " Elementos ");
            Console.WriteLine("_____________________________________________________");
            for (int i = 0; i < datos.Length; i++)
            {
                Console.WriteLine(" Indice " + i + " Los Datos son : " + datos[i]);
            }
            Console.WriteLine("\n Presione enter para continuar_____");
            Console.ReadLine();


            //ejercicio 5


            Console.WriteLine("_____Ejercicio 8: Uso de Length y Bucle FOR____");

            int[] datos1 = { 1, 2, 30, 20, 40, 50, 60,70,80 };
            int cantidadDatos1 = datos1.Length;
            Console.WriteLine(" El arreglo tiene" + cantidadDatos1 + " Elementos ");
            Console.WriteLine("_____________________________________________________");
            for (int i = 0; i < datos1.Length; i++)
            {
                Console.WriteLine(" Indice " + i + " Los Datos son : " + datos1[i]);
            }
            Console.WriteLine("\n Presione enter para continuar_____");
            Console.ReadLine();
        }
    }
}
