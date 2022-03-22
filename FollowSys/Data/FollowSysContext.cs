#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FollowSys.Data
{
    public class FollowSysContext : DbContext
    {
        public FollowSysContext (DbContextOptions<FollowSysContext> options)
            : base(options)
        {
        }

        public DbSet<FollowSys.Models.Account> Account { get; set; }

        public DbSet<FollowSys.Models.Follower> Follower { get; set; }


    }
}
