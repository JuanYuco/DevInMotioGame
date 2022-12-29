namespace BL.Models.Interfaces
{
    public interface IPesonaje
    {
        public void SetContextura(Contextura contextura);
        public void SetArma(Arma arma);
        public double[]? Salto();
        public double[]? Ataque();
        public double[]? Correr();

        public IObserver GetAtaque();
        public IObserver GetCorrer();
        public IObserver GetSaltar();
    }
}
