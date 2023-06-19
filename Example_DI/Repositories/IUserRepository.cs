using Example_DI.Models;

namespace Example_DI.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
    }
}