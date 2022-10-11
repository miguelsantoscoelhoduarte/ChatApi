using ChatApi.Models.Interfaces;
using Domain.Context;
using Domain.Models.Entities;

namespace ChatApi.Models.Services
{
    public class UserService : IUserService
    {
        private readonly ChatContext _context;

        public UserService(ChatContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
