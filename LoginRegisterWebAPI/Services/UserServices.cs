using LoginRegisterWebAPI.Model;
using LoginRegisterWebAPI.Repositry;

namespace LoginRegisterWebAPI.Services
{
    public class UserServices : IUserServices
    {
        IUserRepo repo;
        public UserServices(IUserRepo repo)
        {
            this.repo = repo;
        }

        public User Login(Login login)
        {
            return repo.Login(login);   
        }

        public int Register(User user)
        {
            return repo.Register(user);
        }
    }
}
