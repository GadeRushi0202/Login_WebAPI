using LoginRegisterWebAPI.Model;

namespace LoginRegisterWebAPI.Services
{
    public interface IUserServices
    {
        public int Register(User user);
        public User Login(Login login);
    }
}
