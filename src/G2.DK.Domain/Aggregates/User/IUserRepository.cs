using System.Threading.Tasks;

namespace G2.DK.Domain.Aggregates.User
{
    public interface IUserRepository
    {
        Task<User> Get(string login);
    }
}