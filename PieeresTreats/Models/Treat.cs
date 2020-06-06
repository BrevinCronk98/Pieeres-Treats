using System.Collections.Generic;

namespace PieeresTreats.Models
{
    public class Treat
    {
        public Treat()
        {
            this.Flavors = new HashSet<TreatFlavor>();
        }

        public int TreatId { get; set; }
        public string Name { get; set; }

        public virtual ApplicationUser User { get; set; }
        public  ICollection<TreatFlavor> Flavors { get; set; }
    }
}