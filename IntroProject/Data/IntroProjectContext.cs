using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IntroProject.Models;

namespace IntroProject.Data
{
    public class IntroProjectContext : DbContext
    {
        public IntroProjectContext (DbContextOptions<IntroProjectContext> options)
            : base(options)
        {
        }

        public DbSet<IntroProject.Models.Comment> Comment { get; set; } = default!;
        public DbSet<IntroProject.Models.Post> Post { get; set; } = default!;
        public DbSet<IntroProject.Models.User> User { get; set; } = default!;
    }
}
