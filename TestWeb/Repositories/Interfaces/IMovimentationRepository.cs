using TestWeb.Models;

namespace TestWeb.Repositories.Interfaces
{
    public interface IMovimentationRepository
    {
        IEnumerable<MovimentationRepository> Movimentations { get; }
    }
}
