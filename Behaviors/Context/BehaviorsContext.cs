using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Behaviors.Entities;

namespace Behaviors.Context
{
    public class BehaviorsContext : DbContext
    {
        public DbSet<Behavior> Behaviors { get; set; }
        public DbSet<BehaviorEntry> BehaviorEntries { get; set; }
        public DbSet<Child> Children { get; set; }

        public BehaviorsContext()
            : base("name=behaviors")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Child>()
                .HasMany(e => e.BehaviorEntries)
                .WithRequired(e => e.Child)
                .HasForeignKey(e => e.ChildId);
            base.OnModelCreating(modelBuilder);
        }
    }
}