using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly MilaoDbContext _milaoDbContext;
        public UsersController(MilaoDbContext milaoDbContext)
        {
            _milaoDbContext = milaoDbContext;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _milaoDbContext.User.ToListAsync();
            return users;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            var user = await _milaoDbContext.User.Where(i => i.Id == id).SingleOrDefaultAsync();
            return user;
        }
        //
    }
}