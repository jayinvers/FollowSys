using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FollowSys.Data;
using System;
using System.Linq;

namespace FollowSys.Models
{
    public static class SeedData
    {

       
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FollowSysContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FollowSysContext>>()))
            {
                if (!context.Account.Any())
                    context.Account.AddRange(
                        new Account[] {
                            new Account
                            {
                                Name = "Jay"
                            },
                            new Account
                            {
                                Name = "Tom"
                            },
                            new Account
                            {
                                Name = "Riley"
                            },
                            new Account
                            {
                                Name = "Theo"
                            },
                            new Account
                            {
                                Name = "May"
                            },
                        }
                        );

                if (!context.Follower.Any())
                    context.Follower.AddRange(
                        new Follower[] { 
                            new Follower
                            {
                                AccountId =1,
                                FollowerId = 2
                            },
                            new Follower
                            {
                                AccountId =1,
                                FollowerId = 3
                            },
                            new Follower
                            {
                                AccountId =1,
                                FollowerId = 4
                            },
                            new Follower
                            {
                                AccountId =2,
                                FollowerId = 4
                            },
                            new Follower
                            {
                                AccountId =2,
                                FollowerId = 5
                            },
                            new Follower
                            {
                                AccountId =5,
                                FollowerId = 1
                            },
                            new Follower
                            {
                                AccountId =4,
                                FollowerId = 1
                            },
                        }
                        );

                context.SaveChanges();

                
            }
        }
    }
}