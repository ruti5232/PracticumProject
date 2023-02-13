using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticumProject.Common.DTOs;
using PracticumProject.Services.Interfaces;
using PracticumProject.WebAPI.Models;

namespace PracticumProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        private readonly IGenericService<ChildDTO> _childService;

        public ChildController(IGenericService<ChildDTO> userService)
        {
            _childService = userService;
        }

        [HttpGet]
        public async Task<List<ChildDTO>> Get()
        {
            return await _childService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ChildDTO>> Get(int id)
        {
            var user = await _childService.GetByIdAsync(id);
            if (user is null)
                return NotFound();
            return user;
        }

        [HttpPost]
        public async Task<ActionResult<ChildDTO>> Post([FromBody] ChildPostModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            return await _childService.AddAsync(new ChildDTO { IdentityNumber = model.IdentityNumber,FirstName = model.FirstName, DateOfBirth = model.DateOfBirth});
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<ChildDTO>> Put(int id, [FromBody] ChildPostModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            return await _childService.UpdateAsync(new ChildDTO { Id = id, IdentityNumber = model.IdentityNumber,FirstName = model.FirstName, DateOfBirth = model.DateOfBirth });
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _childService.DeleteAsync(id);
            return NoContent();

        }

    }
}
