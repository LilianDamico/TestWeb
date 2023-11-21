
using TestWeb.Models;

namespace TestWeb.Repositories.Interfaces
{
    public interface IMovimentationTypeRepository
    {
        IEnumerable<MovimentationType> MovimentationType { get; }
        // Outros métodos conforme necessário
    }
}
