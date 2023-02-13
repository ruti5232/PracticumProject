using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticumProject.Common.DTOs;
using PracticumProject.Services.Interfaces;
using PracticumProject.WebAPI.Models;

namespace PracticumProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IGenericService<UserDTO> _userService;

        public UserController(IGenericService<UserDTO> userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<List<UserDTO>> Get()
        {
            return await _userService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDTO>> Get(int id)
        {
            var user = await _userService.GetByIdAsync(id);
            if (user is null)
                return NotFound();
            return user;
        }

        [HttpPost]
        public async Task<ActionResult<UserDTO>> Post([FromBody] UserPostModel model)
        {
            List<ChildDTO> children = new List<ChildDTO>();
            foreach (var item in model.Children)
            {
                children.Add(new ChildDTO {IdentityNumber=item.IdentityNumber,FirstName=item.FirstName,DateOfBirth=item.DateOfBirth });
            }
            if (!ModelState.IsValid)
                return BadRequest();
            return await _userService.AddAsync(new UserDTO { IdentityNumber = model.IdentityNumber, FirstName = model.FirstName, UserLastName = model.LastName, DateOfBirth = model.DateOfBirth, GenderId = model.GenderId, HMOId = model.HMOId,Children=children });
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<UserDTO>> Put(int id, [FromBody] UserPostModel model)
        {
            List<ChildDTO> children = new List<ChildDTO>();
            foreach (var item in model.Children)
            {
                children.Add(new ChildDTO {IdentityNumber = item.IdentityNumber, FirstName = item.FirstName, DateOfBirth = item.DateOfBirth });
            }
            if (!ModelState.IsValid)
                return BadRequest();
            return await _userService.UpdateAsync(new UserDTO { Id = id, IdentityNumber = model.IdentityNumber, FirstName = model.FirstName, UserLastName = model.LastName, DateOfBirth = model.DateOfBirth, GenderId = model.GenderId, HMOId = model.HMOId,Children=children });
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _userService.DeleteAsync(id);
            return NoContent();
        }
    }
}
