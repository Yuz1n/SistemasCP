using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemasCP.Models;

namespace SistemasCP.Data
{
    public class SistemasCPContext : DbContext
    {
        public SistemasCPContext (DbContextOptions<SistemasCPContext> options)
            : base(options)
        {
        }

        public DbSet<CriminalCodes>? CriminalCode { get; set; }
        public DbSet<status>? status { get; set; }
        public DbSet<User>? User { get; set; }
    }
}

