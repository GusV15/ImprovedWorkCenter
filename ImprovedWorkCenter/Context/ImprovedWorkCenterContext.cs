using ImprovedWorkCenter.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImprovedWorkCenter.Context
{
    public class ImprovedWorkCenterContext : DbContext
    {
        public ImprovedWorkCenterContext(DbContextOptions<ImprovedWorkCenterContext> options) : base(options)
        {
        }
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Socio> Socios { get; set; }

    }
}
