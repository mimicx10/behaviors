using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Behaviors.Entities
{
    public class BehaviorEntry
    {
        public virtual int Id { get; set; }
        public virtual int ChildId { get; set; }
        public virtual int BehaviorId { get; set; }
        public virtual DateTime DateAndTime { get; set; }
        public virtual int DurationMinutes { get; set; }
        public virtual int DurationSeconds { get; set; }

        public virtual Child Child { get; set; }
        public virtual Behavior Behavior { get; set; }
    }
}