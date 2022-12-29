using BL.Models.Interfaces;

namespace BL.Models
{
    public class Salto : IAccionSalto, IObserver
    {
        const double REDUCCION_ESTAMINA_BASE = 10;
        private const double ALURA_SALTO_BASE = 2;
        private double? estamina;
        public double[]? Ejecutar(double peso)
        {
            if ( estamina == null || estamina < 15 ) {
                return null;
            }

            double altura = ALURA_SALTO_BASE - (peso * 0.01);
            double reducionEstamina = REDUCCION_ESTAMINA_BASE + (peso * 0.028);
            return new double[2] { altura, reducionEstamina };
        }

        public void Update(object o)
        {
            estamina = (double)o;
        }
    }
}
