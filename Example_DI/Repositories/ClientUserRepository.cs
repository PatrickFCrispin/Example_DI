using Example_DI.Models;

namespace Example_DI.Repositories
{
    public class ClientUserRepository : IUserRepository
    {
        private readonly IEnumerable<User> _users;

        public ClientUserRepository()
        {
            _users = new List<User>
            {
                new User
                {
                    Name = "Client",
                    LastName = "1",
                    BirthDate = new DateTime(1995, 09, 23),
                    UserName = "client1",
                },
                new User
                {
                    Name = "Client",
                    LastName = "2",
                    BirthDate = new DateTime(1991, 12, 26),
                    UserName = "client2",
                }
            };
        }

        public IEnumerable<User> GetUsers()
        {
            return _users;
        }
    }
}