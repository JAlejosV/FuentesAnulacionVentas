using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AnulacionVentas
{
    public class InterfacesDBContext : DbContext
    {
        public InterfacesDBContext()
        {
        }

        public InterfacesDBContext(DbContextOptions<InterfacesDBContext> options)
           : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var Conn = ConfigurationManager.ConnectionStrings["InterfacesDB"].ConnectionString;
            optionsBuilder.UseSqlServer(Conn);
        }

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
