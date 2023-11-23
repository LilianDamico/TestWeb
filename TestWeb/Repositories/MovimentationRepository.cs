using TestWeb.Context;
using TestWeb.Repositories.Interfaces;

namespace TestWeb.Repositories
{
    public class MovimentationRepository : IMovimentationRepository
    {
        private readonly Context.AppDbContext _context;

        public MovimentationRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<MovimentationRepository> Movimentations => throw new NotImplementedException();
    }
}
