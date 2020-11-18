using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ej9.Data;
namespace ej9.Data{

public class IglesiaDbContext : DbContext{

public DbSet<Iglesia> Iglesias {get; set;}
 protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=Iglesia.db");


}

}

