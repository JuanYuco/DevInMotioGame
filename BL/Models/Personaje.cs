using BL.Models.Interfaces;

namespace BL.Models
{
    public class Personaje : IPesonaje
    {     
        private Contextura? _contextura;
        private Arma? _arma;
        private double peso;

        IAccionAtaque _ataque;
        IAccionCorrer _correr;
        IAccionSalto _saltar;
        public Personaje(IAccionAtaque ataque, IAccionCorrer correr, IAccionSalto saltar)
        {
            _ataque = ataque;
            _correr = correr;
            _saltar = saltar;
        }

        private void CalcularAtributos()
        {
            if (_arma == null || _contextura == null)
            {
                return;
            }

            peso = _arma.Peso + _contextura.Peso;         
        }

        public void SetArma(Arma arma)
        {
            _arma = arma;
            CalcularAtributos();
        }

        public void SetContextura(Contextura contextura)
        {
            _contextura = contextura;
            CalcularAtributos();
        }

        public double[]? Ataque()
        {
            if ( _arma == null || _contextura == null )
            {
                return null;
            }

            return _ataque.Ejecutar(_arma.Daño, peso);
        }

        public double[]? Salto()
        {
            if (_arma == null || _contextura == null)
            {
                return null;
            }

            return _saltar.Ejecutar(peso);
        }

        public double[]? Correr()
        {
            if (_arma == null || _contextura == null)
            {
                return null;
            }

            return _correr.Ejecutar(peso);
        }

        public IObserver GetAtaque()
        {
            return _ataque;
        }

        public IObserver GetCorrer()
        {
            return _correr;
        }

        public IObserver GetSaltar()
        {
            return _saltar;
        }
    }
}
