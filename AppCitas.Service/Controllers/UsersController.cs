using AppCitas.Service.Data;
using AppCitas.Service.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppCitas.Service.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly DataContext _context;

    public UsersController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    //Get api/Users
    public ActionResult<IEnumerable<AppUser>> GetUsers()
    {
        return _context.Users.ToList();
    }
    //GET api/users/id
    [HttpGet("{id}")]
    public  ActionResult<AppUser> GetUserById(int id)
    {
        return _context.Users.Find(id);
    }
}
