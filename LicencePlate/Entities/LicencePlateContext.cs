using LicencePlate.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LicencePlate.Entities
{
    public class LicencePlateContext : DbContext
    {
        public LicencePlateContext(DbContextOptions<LicencePlateContext> options) : base(options)
        {
        }

        DbSet<LicencePlateClass> licence_plates { get; set; }
    }
}
