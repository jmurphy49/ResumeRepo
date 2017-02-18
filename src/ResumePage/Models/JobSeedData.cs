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
                        Title = "Crew Member",
                        JobDescription = "Make sandwhiches and coordinate orders, while holding interactions with customers.",
                        DateJoined = DateTime.Parse("2016 - 10 - 20"),
                        DateLeft = DateTime.Parse("2016 - 10 - 20"),
                        StartingPay = 7.55M,
                        EndingPay = 7.55M
                    }
                   );
                context.SaveChanges();
            }
        }
    }
}

