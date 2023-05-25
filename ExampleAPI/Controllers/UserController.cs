using ExampleAPI.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ExampleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet("GetAllUsers")]
        public UserList GetAllUsers()
        {
            using (StreamReader reader = new StreamReader("Data/userData.json"))
            {
                string jsonData = reader.ReadToEnd();
                UserList users = JsonConvert.DeserializeObject<UserList>(jsonData);
                return users;
            }
        }
    }
    public class AppController : ControllerBase
    {
        [HttpGet("GetAppData")]
        public App GetAppData()
        {
            using (StreamReader reader = new StreamReader("Data/appData.json"))
            {
                string jsonData = reader.ReadToEnd();
                App appData = JsonConvert.DeserializeObject<App>(jsonData);
                return appData;
            }
        }
    }
    public class UserAppXref : ControllerBase
    {
        [HttpGet("GetUserAppXref")]
        public UserAppXref GetUserAppXref()
        {
            using (StreamReader reader = new StreamReader("Data/userAppXref.json"))
            {
                string jsonData = reader.ReadToEnd();
                UserAppXref xrefData = JsonConvert.DeserializeObject<UserAppXref>(jsonData);
                return xrefData;
            }
        }
    }
}