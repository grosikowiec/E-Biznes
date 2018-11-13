using Reservations.App_Data;
using Reservations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Reservations.Controllers
{
    public class UserController : ApiController
    {
        public UserController()
        {
        }

        [HttpGet]
        [Route("api/login/{email}/{password}")]
        public async Task<IHttpActionResult> TryLogin([FromUri] string email, [FromUri] string password)
        {
            string sid;
            bool isExist = false;
            LuxStayReservationEntities db = new LuxStayReservationEntities();

            isExist = db.Users.FirstOrDefault(p => p.email == email) != null;
            if (isExist)
            {
                sid = await GenerateSidAsync();
                db.Users.FirstOrDefault(p => p.email == email).session_id = sid;
                db.SaveChanges();
                return Ok(sid);
            }
            else
            {
                return NotFound();
            }
        }
        // GET: User
       
    }
}