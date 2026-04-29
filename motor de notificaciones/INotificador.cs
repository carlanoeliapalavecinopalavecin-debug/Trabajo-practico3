using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motor_de_notificaciones
{
    public interface INotificador
    {
        void Enviar(string destinatario, string mensaje);
        int CantidadEnviados { get; }
    }

    // Notificador Email
    public class NotificadorEmail : INotificador
    {
        public int CantidadEnviados { get; private set; } = 0;

        public void Enviar(string destinatario, string mensaje)
        {
            Console.WriteLine($"[EMAIL] A {destinatario}: {mensaje}");
            CantidadEnviados++;
        }
    }

    // Notificador SMS
    public class NotificadorSMS : INotificador
    {
        public int CantidadEnviados { get; private set; } = 0;

        public void Enviar(string destinatario, string mensaje)
        {
            Console.WriteLine($"[SMS] A {destinatario}: {mensaje}");
            CantidadEnviados++;
        }
    }

    // Notificador Push
    public class NotificadorPush : INotificador
    {
        public int CantidadEnviados { get; private set; } = 0;

        public void Enviar(string destinatario, string mensaje)
        {
            Console.WriteLine($"[PUSH] A {destinatario}: {mensaje}");
            CantidadEnviados++;
        }
    }

    // Motor de Notificaciones
    public class MotorNotificaciones
    {
        private readonly List<INotificador> notificadores;

        public MotorNotificaciones(IEnumerable<INotificador> notificadores)
        {
            this.notificadores =new List<INotificador>(notificadores);
       }
        
        public void NotificarATodos(string destinatario, string mensaje)
        {
            foreach (var notificador in notificadores)
            {
                notificador.Enviar(destinatario, mensaje);
            }
        }

        public void Reporte()
        {
            Console.WriteLine("\n--- Reporte ---");
            foreach (var notificador in notificadores)
            {
                Console.WriteLine($"{notificador.GetType().Name} envió {notificador.CantidadEnviados} mensajes.");
            }
        }
    }
}
