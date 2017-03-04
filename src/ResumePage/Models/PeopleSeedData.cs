using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ResumePage.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumePage.Models
{
    public class PeopleSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var context =
                new ApplicationDbContext(
                    serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                //Look for any records, if there are records do nothing
                if (context.People.Any())
                {
                    return;
                }
                context.People.AddRange(
                   new People
                   {
                       FName = "Jacob",
                       LName = "Murphy",
                       Phone = "505-485-9551",
                       Email = "email@email.com",
                       Adress = "Adress",
                       City = "Rio Rancho",
                       State = "New Mexico"
                   }
                   );
                context.SaveChanges();
            }
        }
    }
}