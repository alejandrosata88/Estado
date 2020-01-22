namespace Estado.Servicio.Interfaz
{
    public interface IEstado
    {
        void AsignarContexto(Contexto _Cotexto);
        string Activar();
        string Inactivar();
    }
}
