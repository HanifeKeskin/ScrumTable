using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimYapimi
{
    public class Sprint
    {
        public DateTime Deadline { get; set; }
        public virtual Category Category { get; set; }

        public ICollection<Task> Tasks { get; set; }
        public ICollection<Story> Stories { get; set; }
    }
}
