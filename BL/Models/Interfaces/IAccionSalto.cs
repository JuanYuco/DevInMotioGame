namespace BL.Models.Interfaces
{
    public interface IAccionSalto : IObserver
    {
        public double[]? Ejecutar(double peso);
    }
}
