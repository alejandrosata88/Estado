using Estado.Servicio.Interfaz;
using Estado.Servicio;
using Estado.Servicio.Implementacion;
using System;

namespace Estado.Controller
{
    public class Cliente
    {
        public void Main()
        {
            string cMensaje = string.Empty, cAccion=string.Empty;
            var AlarmaInactiva = new AlarmaInactivar();
            Contexto Cotexto = new Contexto(AlarmaInactiva);
            AlarmaInactiva.AsignarContexto(Cotexto);
            Console.WriteLine("Se inicializa la Alarma Apagada realize lo siguiente:\n0-Apagar\n1-Encender\nx-Salir\n");
            while (cAccion != "x")
            {
                cAccion = Console.ReadLine();
                switch (cAccion)
                {
                    case "0":
                            cMensaje = Cotexto.InactivarAlarma();
                        break;
                    case "1":
                            cMensaje = Cotexto.ActivarAlarma();
                        break;
                    case "x":
                        cMensaje = "Cerrando...";
                        break;
                    default:
                        cMensaje = "Acción incorrecta";
                        break;

                }
                Console.WriteLine(cMensaje);
            }
        }
    }
}
