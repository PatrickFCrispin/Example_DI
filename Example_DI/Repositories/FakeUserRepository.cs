using Example_DI.Models;

namespace Example_DI.Repositories
{
    public class FakeUserRepository : IUserRepository
    {
        private readonly IEnumerable<User> _users;

        public FakeUserRepository()
        {
            _users = new List<User>
            {
                new User
                {
                    Name = "Fake",
                    LastName = "1",
                    BirthDate = new DateTime(1995, 09, 23),
                    UserName = "fake1",
                },
                new User
                {
                    Name = "Fake",
                    LastName = "2",
                    BirthDate = new DateTime(1991, 12, 26),
                    UserName = "fake2",
                }
            };
        }

        public IEnumerable<User> GetUsers()
        {
            return _users;
        }
    }
}