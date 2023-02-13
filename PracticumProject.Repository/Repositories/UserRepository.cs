using Microsoft.EntityFrameworkCore;
using PracticumProject.Repositories.Entities;
using PracticumProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticumProject.Repositories.Repositories
{
    public class UserRepository : IGenericRepository<User>
    {
        private readonly IContext _context;

        public UserRepository(IContext context)
        {
            _context = context;
        }

        public async Task<User> AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task DeleteAsync(int id)
        {
            var deleteUser=await GetByIdAsync(id);
            _context.Users.Remove(deleteUser);    
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> UpdateAsync(User user)
        {
            var updateUser=_context.Users.Update(user);
            await _context.SaveChangesAsync();
            return updateUser.Entity;
        }
    }
}
