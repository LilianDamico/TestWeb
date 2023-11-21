using System.Collections.Generic;
using TestWeb.Models;
using TestWeb.Repositories.Interfaces;

namespace TestWeb.Repositories
{
    public class MovimentationTypeRepository : IMovimentationTypeRepository
    {
        public IEnumerable<MovimentationType> MovimentationType =>
            // Implementação do método
            new List<MovimentationType>(); // Exemplo

        // Implementação de outros métodos conforme necessário
    }
}
