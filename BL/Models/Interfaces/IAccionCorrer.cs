
namespace BL.Models.Interfaces
{
    public interface IAccionCorrer : IObserver
    {
        public double[]? Ejecutar(double peso);
    }
}
