using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_emplados
{
    abstract class Empleado
    {
        public string Nombre { get; set; }
        public int Legajo { get; set; }
        public double SueldoBase { get; set; }

        // Constructor
        public Empleado(string nombre, int legajo, double sueldoBase)
        {
            Nombre = nombre;
            Legajo = legajo;
            SueldoBase = sueldoBase;
        }

        // Método abstracto (cada hijo lo hace distinto)
        public abstract double CalcularSueldo();

        // Método virtual (se puede reutilizar)
        public virtual void MostrarInfo()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Legajo: " + Legajo);
            Console.WriteLine("Sueldo Base: $" + SueldoBase);
        }
    }
    class EmpleadoTiempoCompleto : Empleado
    {
        public EmpleadoTiempoCompleto(string nombre, int legajo, double sueldoBase)
            : base(nombre, legajo, sueldoBase)
        {
        }

        public override double CalcularSueldo()
        {
            return SueldoBase + (50000 / 12.0);
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Tipo: Tiempo Completo");
            Console.WriteLine("Sueldo Total: $" + CalcularSueldo());
        }
    }
    class EmpleadoPartTime : Empleado
    {
        public int HorasTrabajadas { get; set; }
        public double PagoPorHora { get; set; }

        public EmpleadoPartTime(string nombre, int legajo, int horas, double pagoHora)
            : base(nombre, legajo, 0)
        {
            HorasTrabajadas = horas;
            PagoPorHora = pagoHora;
        }

        public override double CalcularSueldo()
        {
            return HorasTrabajadas * PagoPorHora;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Tipo: Part Time");
            Console.WriteLine("Horas: " + HorasTrabajadas);
            Console.WriteLine("Pago por Hora: $" + PagoPorHora);
            Console.WriteLine("Sueldo Total: $" + CalcularSueldo());
        }
    }
    class EmpleadoContratado : Empleado
    {
        public DateTime FechaVencimiento { get; set; }

        public EmpleadoContratado(string nombre, int legajo, double sueldoBase, DateTime fecha)
            : base(nombre, legajo, sueldoBase)
        {
            FechaVencimiento = fecha;
        }

        public override double CalcularSueldo()
        {
            return SueldoBase;
        }

        public int DiasRestantes()
        {
            return (FechaVencimiento - DateTime.Now).Days;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Tipo: Contratado");
            Console.WriteLine("Vence: " + FechaVencimiento.ToShortDateString());
            Console.WriteLine("Días restantes: " + DiasRestantes());
            Console.WriteLine("Sueldo Total: $" + CalcularSueldo());
        }
    }

}

