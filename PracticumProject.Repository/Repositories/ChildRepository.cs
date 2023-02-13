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
    public class ChildRepository : IGenericRepository<Child>
    {
        private readonly IContext _context;

        public ChildRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Child> AddAsync(Child child)
        {
            await _context.Children.AddAsync(child);
            await _context.SaveChangesAsync();
            return child;
        }

        public async Task DeleteAsync(int id)
        {
            var deleteChild=await GetByIdAsync(id);
            _context.Children.Remove(deleteChild);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.Children.ToListAsync();
        }

        public async Task<Child> GetByIdAsync(int id)
        {
            return await _context.Children.FindAsync(id);
        }

        public async Task<Child> UpdateAsync(Child child)
        {
            var updateChild=_context.Children.Update(child);
            await _context.SaveChangesAsync();
            return updateChild.Entity;
        }
    }
}
