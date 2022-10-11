using Domain.Models.Entities;

namespace ChatApi.Models.Interfaces
{
    public interface IUserService
    {
        public void AddUser(User user);
    }
}
