using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{

public class Credenciais{
  public string Username { get; set; }
  public string Password { get; set; }
}

    [ApiController]
    [Route("api/login")]
    public class LoginController : Controller
    {
        [HttpGet]
        [Route("teste")]
        public string DoLogin()
        {
            string login = "Retornou!!";
            return login;
        }

        [HttpPost]
        [Route("SignIn")]
        public string SignIn(Credenciais cred)
        {
            if(cred.Username == "Thales"){
              return "Logou";
            } else {
            return "Não logou";
            }
        }
    }
}
