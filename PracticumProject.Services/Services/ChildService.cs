using AutoMapper;
using PracticumProject.Common.DTOs;
using PracticumProject.Repositories.Entities;
using PracticumProject.Repositories.Interfaces;
using PracticumProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticumProject.Services.Services
{
    public class ChildService : IGenericService<ChildDTO>
    {
        private readonly IGenericRepository<Child> _childRepository;

        private readonly IMapper _mapper;

        public ChildService(IGenericRepository<Child> childRepository,IMapper mapper)
        {
            _childRepository = childRepository;
            _mapper = mapper;
        }

        public async Task<ChildDTO> AddAsync(ChildDTO child)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.AddAsync(_mapper.Map<Child>(child)));
        }

        public async Task DeleteAsync(int id)
        {
            await _childRepository.DeleteAsync(id);
        }

        public async Task<List<ChildDTO>> GetAllAsync()
        {
            return _mapper.Map<List<ChildDTO>>(await _childRepository.GetAllAsync());
        }

        public async Task<ChildDTO> GetByIdAsync(int id)
        {
           return _mapper.Map<ChildDTO>(await _childRepository.GetByIdAsync(id));
        }

        public async Task<ChildDTO> UpdateAsync(ChildDTO child)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.UpdateAsync(_mapper.Map<Child>(child)));
        }
    }
}
