using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RobotArena.Models;

using RobotArena.Models.Items;
using RobotArena.Models.NPC;
using RobotArena.Models.Robots;
using System;

namespace RobotArena.Data
{
    public class RobotContext : IdentityDbContext<User>
    {
        public RobotContext(DbContextOptions<RobotContext> options)
            : base(options)
        {
        }

        public DbSet<Armor> Armors { get; set; }
    
       public DbSet<Weapon> Weapons { get; set; }
       public DbSet<Creep> Creeps { get; set; }
        public DbSet<Robot> Robots { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                   .Entity<User>()
                   .HasMany(u=>u.Robots)
                   .WithOne(r=>r.Owner)
                   .HasForeignKey(r=>r.OwnerId);
            builder
                   .Entity<Robot>()
                   .HasOne(u => u.Owner)
                   .WithMany(r => r.Robots)
                   .HasForeignKey(r => r.OwnerId);

            builder
                     .Entity<User>()
                     .HasMany(u => u.Weapons)
                     .WithOne(w=>w.User)
                     .HasForeignKey(w => w.UserId);
            builder
                    .Entity<User>()
                    .HasMany(u => u.Armors)
                    .WithOne(a => a.User)
                    .HasForeignKey(a => a.UserId);
                                       



            base.OnModelCreating(builder);
        }
        
    }
}
