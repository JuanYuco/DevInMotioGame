using BL.Models.Interfaces;

namespace BL.Models
{
    public class Ataque : IAccionAtaque, IObserver
    {
        private const double VELOCIDAD_ATAQUE_BASE = 4;
        private const double REDUCCION_ESTAMINA_BASE = 5;
        private double? estamina;
        public double[]? Ejecutar(double dañoArma, double peso)
        {
            if ( estamina == null || estamina <= 10 )
            {
                return null;
            }

            double daño = dañoArma + (peso * 0.5);
            double velocidadAtaque = VELOCIDAD_ATAQUE_BASE - (int)(peso * 0.025);
            double reducionEstamina = REDUCCION_ESTAMINA_BASE + (peso * 0.02);
            return new double[3] { daño, velocidadAtaque, reducionEstamina };
        }

        public void Update(object o)
        {
            estamina = (double) o;
        }
    }
}
