namespace motor_de_notificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var motor = new MotorNotificaciones(new INotificador[]
           {
            new NotificadorEmail(),
            new NotificadorSMS(),
            new NotificadorPush()
           });

            motor.NotificarATodos("noe@example.com", "¡Hola Noe!");
            motor.NotificarATodos("Noe@example.com", "Segundo mensaje.");

            motor.Reporte();
        }
    }
}


