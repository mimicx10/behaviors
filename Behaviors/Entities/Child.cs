using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Behaviors.Entities
{
    public class Child
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<BehaviorEntry> BehaviorEntries { get; set; }
    }
}