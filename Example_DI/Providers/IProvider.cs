using Example_DI.Models;

namespace Example_DI.Providers
{
    // An example of a service that invokes "in an application of real world", a real client or a fake client - defined in appsettings
    public interface IProvider
    {
        IEnumerable<User> GetUsers();
    }
}