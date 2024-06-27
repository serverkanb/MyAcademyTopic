using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topic.EntityLayer.Entities;

namespace Topic.DataAccessLayer.Context
{
    public class TopicContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-1IHFPICF;database=OneMusicDb;trusted_connection=true;multipleactiveresultsets=true;trustservercertificate=true");
        }

        DbSet<Blog> Blogs { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Manuel> Manuels { get; set; }

    }

  
}
