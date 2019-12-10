using System;
using System.Collections.Generic;

namespace ScaffoldFromDatabase
{
    public partial class Battle
    {
        public Battle()
        {
            Samurais = new HashSet<Samurai>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<Samurai> Samurais { get; set; }
    }
}
