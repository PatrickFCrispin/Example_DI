using Example_DI.Models;

namespace Example_DI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IEnumerable<User> _users;

        public UserRepository()
        {
            _users = new List<User>
            {
                new User
                {
                    Name = "Patrick",
                    LastName = "da F. Crispin",
                    BirthDate = new DateTime(1995, 09, 23),
                    UserName = "pcrispin",
                },
                new User
                {
                    Name = "Mariane",
                    LastName = "C. do Nascimento",
                    BirthDate = new DateTime(1991, 12, 26),
                    UserName = "mnascimento",
                }
            };
        }

        public IEnumerable<User> GetUsers()
        {
            return _users;
        }
    }
}