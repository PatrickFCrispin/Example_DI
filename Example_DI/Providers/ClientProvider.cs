using Example_DI.Models;
using Example_DI.Repositories;

namespace Example_DI.Providers
{
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