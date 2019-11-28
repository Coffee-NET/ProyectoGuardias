using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuardiasAPI_Jobs.Models
{
    public class GuardiasAPIDbContext: DbContext
    {
        public GuardiasAPIDbContext(DbContextOptions<GuardiasAPIDbContext> options)
            : base(options)
        {
        }

        public DbSet<Job> Jobs { get; set; }
    }
}
