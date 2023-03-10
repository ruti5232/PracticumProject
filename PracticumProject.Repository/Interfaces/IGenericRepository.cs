using PracticumProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticumProject.Repositories.Interfaces
{
    public interface IGenericRepository<T>
    {
        Task<List<T>> GetAllAsync();

        Task<T>GetByIdAsync(int id);

        Task<T>AddAsync(T item);

        Task<T>UpdateAsync(T item); 

        Task DeleteAsync(int id);

    }
}
