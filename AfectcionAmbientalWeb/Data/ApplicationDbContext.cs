using System;
using System.Collections.Generic;
using System.Text;
using AfectcionAmbientalWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AfectcionAmbientalWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Celular> Celulars { get; set; } 
        public DbSet<Persona> Personas { get; set; }
       
    }
}
