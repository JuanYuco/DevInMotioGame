using BL.Models;
using BL.Models.Interfaces;

namespace BL.Services
{
    public class ArmaService : IArmasService
    {
        private List<Arma> armas;
        public ArmaService()
        {
            armas = new List<Arma>()
            {
                new Arma()
                {
                    Id = 1,
                    Nombre = "Espada",
                    Daño = 50,
                    Peso = 30
                },
                new Arma()
                {
                    Id = 2,
                    Nombre = "Hacha",
                    Daño = 75,
                    Peso = 60
                },
                new Arma()
                {
                    Id = 3,
                    Nombre = "Cuchillos",
                    Daño = 30,
                    Peso = 20
                }
            };
        }

        public List<Arma> GetArmas()
        {
            return armas;
        }

        public Arma GetArmaById(int id)
        {
            return armas.Find(arma => arma.Id == id);
        }
    }
}
