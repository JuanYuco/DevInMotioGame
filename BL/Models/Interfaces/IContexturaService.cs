namespace BL.Models.Interfaces
{
    public interface IContexturaService
    {
        public List<Contextura> GetContexturas();
        public Contextura GetContexturaById(int id);
    }
}
