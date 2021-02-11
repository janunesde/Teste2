using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnCore_Licao.Models
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<Contato> Contatos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
    }
}
