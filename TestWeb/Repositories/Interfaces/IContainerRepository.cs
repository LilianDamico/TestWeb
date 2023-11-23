using System.ComponentModel;

namespace TestWeb.Repositories.Interfaces
{
    public interface IContainerRepository
    {
        IEnumerable<Container> Containers { get; }

        IEnumerable<Container> ContainerTopAccesseds { get; }

        Container GetContainerById (int id);
    }
}
