using Estado.Servicio.Interfaz;

namespace Estado.Servicio.Implementacion
{
    class AlarmaActiva : IEstado
    {
        private Contexto Contexto;

        public string Activar()
        {
            return "La alarma ya se encuentra activa";
        }

        public string Inactivar()
        {
            CambiarEstado();
            return "la alarma se inactivo";
        }

        public void CambiarEstado()
        {
            var AlarmaInactivar = new AlarmaInactivar();
            this.Contexto.Transicion(AlarmaInactivar);
        }

        public void AsignarContexto(Contexto _Cotexto)
        {
            this.Contexto = _Cotexto;
        }
    }
}
