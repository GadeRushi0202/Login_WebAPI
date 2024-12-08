using LoginRegisterWebAPI.Model;
using System.Runtime.CompilerServices;

namespace LoginRegisterWebAPI.Repositry
{
    public interface IUserRepo
    {
        public int Register(User user);

        public User Login(Login login);
    }
}
