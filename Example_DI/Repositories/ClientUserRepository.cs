using Example_DI.Models;

namespace Example_DI.Repositories
{
    // Here we return client data
    public class ClientUserRepository : IUserRepository
    {
        private readonly IEnumerable<User> _users;

        public ClientUserRepository()
        {
            _users = new List<User>();
        }

        public IEnumerable<User> GetUsers()
        {
            return _users;
        }
    }
}