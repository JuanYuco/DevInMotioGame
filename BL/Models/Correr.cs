using BL.Models.Interfaces;

namespace BL.Models
{
    public class Correr : IAccionCorrer, IObserver
    {
        private const int VELOCIDAD_BASE = 25;
        const double REDUCCION_ESTAMINA_BASE = 7;

        private double? estamina;
        public double[]? Ejecutar(double peso)
        {
            if (estamina == null || estamina < 15)
            {
                return null;
            }

            double velocidad = VELOCIDAD_BASE - (peso * 0.15);
            double reduccionEstamina = REDUCCION_ESTAMINA_BASE + (peso * 0.025);
            return new double[2] { velocidad, 2 };
        }

        public void Update(object o)
        {
            estamina = (double)o;
        }
    }
}
