using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HellpApi.Models;

namespace HellpApi.Data
{
    public class HellpApiContext : DbContext
    {
        public HellpApiContext (DbContextOptions<HellpApiContext> options)
            : base(options)
        {
        }

        public DbSet<HellpApi.Models.College>? College { get; set; }
    }
}
