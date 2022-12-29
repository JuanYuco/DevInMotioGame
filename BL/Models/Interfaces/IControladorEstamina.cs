namespace BL.Models.Interfaces
{
    public interface IControladorEstamina : ISubject
    {
        public void ActualizarEstamina(double estamina);

        public void ReduccionEstamina(double reduccion);

        public double GetEstamina();
    }
}
