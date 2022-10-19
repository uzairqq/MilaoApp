using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            var users = _milaoDbContext.User.ToList();
            return users;
        }

        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser(int id)
        {
            var user = _milaoDbContext.User.Where(i => i.Id == id).SingleOrDefault();
            return user;
        }
    }
}