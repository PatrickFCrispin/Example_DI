using Example_DI.Models;

namespace Example_DI.Providers
{
    public interface IProvider
    {
        IEnumerable<User> GetUsers();
    }
}