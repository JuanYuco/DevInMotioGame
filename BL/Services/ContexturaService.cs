using BL.Models;
using BL.Models.Interfaces;

namespace BL.Services
{
    public class ContexturaService : IContexturaService
    {
        private List<Contextura> contexturas;
        public ContexturaService()
        {
            contexturas = new List<Contextura>()
            {
                new Contextura()
                {
                    Id = 1,
                    Nombre = "Delgado",
                    Peso = 55
                },
                new Contextura()
                {
                    Id = 2,
                    Nombre = "Fornido",
                    Peso = 70
                },
                new Contextura()
                {
                    Id = 3,
                    Nombre = "Gordo",
                    Peso = 90
                }
            };
        }

        public List<Contextura> GetContexturas()
        {
            return contexturas;
        }

        public Contextura GetContexturaById(int id)
        {
            return contexturas.Find(contextura => contextura.Id == id);
        }
    }
}
