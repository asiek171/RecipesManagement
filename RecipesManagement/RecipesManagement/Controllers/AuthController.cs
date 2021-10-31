using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public async Task<ActionResult> AuthenticateUser() {
            return NotFound();
        }

        public async Task<ActionResult> IsAuthenticated()
        {
            return NotFound();
        }


    }
}
