using Estado.Servicio.Interfaz;

namespace Estado.Servicio
{
    public class Contexto
    {
        private IEstado IEstado = null;

        public Contexto(IEstado _IEstado)
        {
            this.Transicion(_IEstado);
        }

        public void Transicion(IEstado _IEstado)
        {
            this.IEstado = _IEstado;
            IEstado.AsignarContexto(this);
        }

        public string ActivarAlarma()
        {
            return this.IEstado.Activar();
        }

        public string InactivarAlarma()
        {
            return this.IEstado.Inactivar();
        }
    }
}
