using System.Runtime.InteropServices;
using DatabaseAccessController;
using Microsoft.AspNetCore.Mvc;
using SDP_EntityModels;

// In SDK-style projects such as this one, several assembly attributes that were historically
// defined in this file are now automatically added during build and populated with
// values defined in project properties. For details of which attributes are included
// and how to customise this process see: https://aka.ms/assembly-info-properties


// Setting ComVisible to false makes the types in this assembly not visible to COM
// components.  If you need to access a type in this assembly from COM, set the ComVisible
// attribute to true on that type.



// The following GUID is for the ID of the typelib if this project is exposed to COM.


namespace SDP_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public UserLoginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("RegisterUser")]
        public int RegisterUser([FromBody] LoginRequest loginRequest)
        {
            try
            {
                String username = loginRequest.username;
                String password = loginRequest.password;

                dboUserLogin dboUserLogin = new dboUserLogin(_configuration["ConnectionStrings"]);
                int rowsUpdated = dboUserLogin.RegisterUser(username, password);
                return rowsUpdated;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("Login")]
        public bool Login([FromBody] LoginRequest loginRequest)
        {
            try
            {
                String username = loginRequest.username;
                String password = loginRequest.password;

                dboUserLogin dboUserLogin = new dboUserLogin(_configuration["ConnectionStrings"]);
                bool login = dboUserLogin.User(username, password);
                return login;
                }
            catch (Exception ex)
            {
                    throw ex;
            }
        }
    }
}
