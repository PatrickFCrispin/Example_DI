using Example_DI.Models;
using Example_DI.Repositories;

namespace Example_DI.Providers
{
    // This is an example of a fake client that returns fake data from a fake repository (used to mock test)
    public class FakeProvider : IProvider
    {
        private readonly IUserRepository _userRepository;

        public FakeProvider(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetUsers();
        }
    }
}