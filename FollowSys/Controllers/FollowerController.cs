using Microsoft.AspNetCore.Mvc;
using FollowSys.Models;
using FollowSys.Data;

namespace FollowSys.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FollowerController : ControllerBase
    {
        private readonly FollowSysContext _context;


        public FollowerController(FollowSysContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IEnumerable<Account> Get(int id)
        {
            string res = "";
            // select followerid from followers where accountid=1
            var followerIds = _context.Follower.Where(f => f.AccountId == id).Select(f => f.FollowerId).ToArray();
            // select * from followers where in ([followerIds])
            // redis
            Account[] accounts  = _context.Account.Where(f => followerIds.Contains(f.Id)).ToArray();
/*            foreach (Account account in accounts)
            {
                res = res + account.Id.ToString() + ":" + account.Name + ",";
            }*/
            return accounts;
        }
    }
}