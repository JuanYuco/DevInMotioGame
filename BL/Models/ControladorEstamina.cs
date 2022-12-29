using BL.Models.Interfaces;

namespace BL.Models
{
    public class ControladorEstamina : IControladorEstamina
    {
        private List<IObserver> _observers;
        private double _estamina;

        public ControladorEstamina()
        {
            _observers = new List<IObserver>();
            ActualizarEstamina(100);
        }

        public void RegistrarOberserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void NotificarObservers()
        {
            foreach(IObserver o in _observers)
            {
                o.Update(_estamina);
            }
        }

        public void ActualizarEstamina(double estamina)
        {
            _estamina = estamina;
            NotificarObservers();
        }

        public void ReduccionEstamina(double reduccion)
        {
            double estamina = _estamina - reduccion;
            estamina = estamina < 0 ? 0 : estamina;
            ActualizarEstamina(estamina);
        }

        public double GetEstamina()
        {
            return _estamina;
        }
    }
}
