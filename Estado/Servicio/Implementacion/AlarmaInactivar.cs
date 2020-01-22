using Estado.Servicio.Interfaz;

namespace Estado.Servicio.Implementacion
{
    class AlarmaInactivar : IEstado
    {
        private Contexto Contexto;

        public string Activar()
        {
            CambiarEstado();
            return "La alarma se activo";
        }

        public string Inactivar()
        {
            return "La alarma ya se encuentra inactiva";
        }

        public void CambiarEstado()
        {
            var AlarmaInactivar = new AlarmaActiva();
            this.Contexto.Transicion(AlarmaInactivar);
        }

        public void AsignarContexto(Contexto _Cotexto)
        {
            this.Contexto = _Cotexto;
        }
    }
}
