using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Interfaces;

namespace AssetManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        // Dependency Injection
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }



        [HttpPost("Register")]
        public IActionResult Register(User user)
        {
            try
            {
                var result = _userService.RegisterUser(user);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        [HttpGet("Login/{userName}/{password}")]
        public IActionResult Login(string userName, string password)
        {
            try
            {
                var user = _userService.ValidateUser(userName, password);

                if (user == null)
                {
                    return Unauthorized("Invalid Username or Password");
                }

                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        public IActionResult GetAllUsers()
        {
            try
            {
                return Ok(_userService.GetAllUsers());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            try
            {
                var user = _userService.GetUserById(id);

                if (user == null)
                {
                    return NotFound();
                }

                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut]
        public IActionResult UpdateUser(User user)
        {
            try
            {
                return Ok(_userService.UpdateUser(user));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                bool status = _userService.DeleteUser(id);

                if (!status)
                {
                    return NotFound();
                }

                return Ok("User Deleted Successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("Search/{keyword}")]
        public IActionResult SearchUser(string keyword)
        {
            try
            {
                return Ok(_userService.SearchUsers(keyword));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }







    }
}