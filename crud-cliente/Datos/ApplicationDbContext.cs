using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud_cliente.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_cliente.Datos
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Cliente> Cliente { get; set; }
    }
}
