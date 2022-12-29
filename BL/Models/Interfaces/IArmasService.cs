namespace BL.Models.Interfaces
{
    public interface IArmasService
    {
        public List<Arma> GetArmas();
        public Arma GetArmaById(int id);
    }
}
