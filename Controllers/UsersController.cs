using Dating_App.Data;
using Dating_App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dating_App.Controllers
{
   
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext dataContext;

        public UsersController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
           var users = await dataContext.Users.ToListAsync();
           return users;
        }

        [HttpGet("{id:int}")]
        public async  Task<ActionResult<AppUser>> GetUsers(int id)
        {
            var user = await dataContext.Users.FindAsync(id);

            if(user == null) return NotFound();

            return user;
        }
    }
}
