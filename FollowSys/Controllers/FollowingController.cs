using Microsoft.AspNetCore.Mvc;
using FollowSys.Models;
using FollowSys.Data;

namespace FollowSys.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FollowingController : ControllerBase
    {
        private readonly FollowSysContext _context;


        public FollowingController(FollowSysContext context)
        {
            _context = context;
    
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            string res = "";
            Follower[] followers = _context.Follower.Where(f => f.FollowerId==id).ToArray();
            foreach (Follower follower in followers)
            {
                res = res + follower.AccountId.ToString() + ",";
            }
            return res;
        }
    }
}