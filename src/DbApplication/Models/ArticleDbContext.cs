using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DbApplication.Models
{
    public class ArticleDbContext: DbContext
    {
        private IConfiguration _config;

        public DbSet<Article> Articles { get; set; }

        public ArticleDbContext(IConfiguration config)
        {
            _config = config;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_config["Database:Connection"]);
        }
    }
}
