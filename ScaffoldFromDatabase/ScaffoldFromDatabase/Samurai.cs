using System;
using System.Collections.Generic;

namespace ScaffoldFromDatabase
{
    public partial class Samurai
    {
        public Samurai()
        {
            Quotes = new HashSet<Quote>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int BattleId { get; set; }

        public virtual Battle Battle { get; set; }
        public virtual ICollection<Quote> Quotes { get; set; }
    }
}
