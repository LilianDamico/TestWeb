 
using TestWeb.Context;
using TestWeb.Models; 
using TestWeb.Repositories.Interfaces;

namespace TestWeb.Repositories
{
    public class ContainerRepository : IContainerRepository
    {
        private readonly AppDbContext _context;

        public ContainerRepository(AppDbContext context)
        {
            _context = context;
        }

        // Retorna todos os containers.
        public IEnumerable<Container> Containers
        {
            get { return (IEnumerable<Container>)_context.Containers; }
        }

        // Retorna os containers "mais acessados". A lógica específica precisa ser implementada.
        public IEnumerable<Container> ContainerTopAccesseds
        {
            get { return (IEnumerable<Container>)_context.Containers; /* Implemente a lógica aqui. */ }
        }

        IEnumerable<System.ComponentModel.Container> IContainerRepository.Containers => throw new NotImplementedException();

        IEnumerable<System.ComponentModel.Container> IContainerRepository.ContainerTopAccesseds => throw new NotImplementedException();

        // Retorna um container pelo seu ID.
        public Container GetContainerById(int id)
        {
            return _context.Containers.FirstOrDefault(c => c.ContainerID == id);
        }

        System.ComponentModel.Container IContainerRepository.GetContainerById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
