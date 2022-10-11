using Domain.Context;
using Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChatApi.Context
{
    public class DbInitializer
    {
        private readonly ChatContext _context;

        public DbInitializer(ChatContext context)
        {
            _context = context;
        }

        public void Run()
        {
            // TODO: Add initialisation logic.
        }
    }
}
