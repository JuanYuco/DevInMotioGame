namespace BL.Models.Interfaces
{
    public interface ISubject
    {
        public void RegistrarOberserver(IObserver o);
        public void NotificarObservers();
    }
}
