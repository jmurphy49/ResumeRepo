using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ResumePage.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumePage.Models
{
    public class EducationSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var context =
                new ApplicationDbContext(
                    serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                //Look for any records, if there are records do nothing
                if (context.Education.Any())
                {
                    return;
                }
                context.Education.AddRange(
                   new Education
                   {
                      Establishment="V. Sue Cleveland",
                      Level="Highschool",
                      Graduated=DateTime.Parse("2014-05-15")
                   }
                   );
                context.SaveChanges();
            }
        }
    }
}
