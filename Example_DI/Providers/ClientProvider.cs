using Example_DI.Models;
using Example_DI.Repositories;

namespace Example_DI.Providers
{
    // This is an example of a real client that returns real data from a client repository (in an application of real world)
    public class ClientProvider : IProvider
    {
        private readonly IUserRepository _userRepository;

        public ClientProvider(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetUsers();
        }
    }
}