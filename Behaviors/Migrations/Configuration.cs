namespace Behaviors.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<Behaviors.Context.BehaviorContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Behaviors.Context.BehaviorContext context)
        {
            var behaviors = new HashSet<Entities.Behavior>();
            var behavior = context.Behaviors.Create();

            behavior.Description = "Self-induced frustration";
            behaviors.Add(behavior);

            behavior = context.Behaviors.Create();
            behavior.Description = "Sibling-induced frustration";
            behaviors.Add(behavior);

            behavior = context.Behaviors.Create();
            behavior.Description = "Parental-induced frustration";
            behaviors.Add(behavior);

            context.Behaviors.AddOrUpdate(behaviors.ToArray());

            context.SaveChanges();
        }
    }
}
