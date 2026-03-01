
using WPF_Layout.Data;
using WPF_Layout.Models;

namespace WPF_Layout.Repositories
{
    public class UserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository() {
            _context = new AppDbContext();
        }

        public void AddNew(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public bool ExistsByUsername(string email)
        {
            return _context.Users.Any(u => u.Email == email);
        }
        public User? FindByUsername(string email)
        {
            return _context.Users.FirstOrDefault(u => u.Email == email);
        }
    }
}
