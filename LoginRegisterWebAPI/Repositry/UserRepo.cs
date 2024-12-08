using LoginRegisterWebAPI.Data;
using LoginRegisterWebAPI.Model;

namespace LoginRegisterWebAPI.Repositry
{
    public class UserRepo : IUserRepo
    {
        ApplicationDbContext db;
        public UserRepo(ApplicationDbContext db)
        {
            this.db = db;   
        }
        public User Login(Login login)
        {
           var result = db.Users.Where(u => u.UserName == login.UserName && u.Password == login.Password).FirstOrDefault();
            return result;
        }

        public int Register(User user)
        {
            db.Users.Add(user);
            var result = db.SaveChanges();  
            return result;
        }
    }
}
