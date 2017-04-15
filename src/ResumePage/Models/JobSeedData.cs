using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ResumePage.Data;

namespace ResumePage.Models
{
    public class JobSeedData
    {
            
        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var context =
                new ApplicationDbContext(
                    serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                //Look for any records, if there are records do nothing
                if (context.Job.Any())
                {
                    return;
                }

                context.Job.AddRange(
                    new Job
                    {
                        Title = "JAEB Wendy's Resteraunts",
                        JobDescription = "Crew Member",
                        DateJoined = DateTime.Parse("2014 - 05 - 20"),
                        DateLeft = DateTime.Parse("2016 - 12 - 20"),
                        StartingPay = 7.55M,
                        EndingPay = 7.55M,
                        PeopleId = 1,
                    },
                    new Job
                    {
                        Title = "Little Caesers",
                        JobDescription = "Crew Member",
                        DateJoined = DateTime.Parse("2013 - 10 - 20"),
                        DateLeft = DateTime.Parse("2014 - 05 - 01"),
                        StartingPay = 7.55M,
                        EndingPay = 7.55M,
                        PeopleId = 1,
                    }
                   );
                context.SaveChanges();
            }
        }
    }
}

