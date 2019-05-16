using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimYapimi
{
    public class User
    {
        public int ID { get; set; }
        public string Kisi { get; set; }
        public string Gorev { get; set; }
        public ICollection<Task> Tasks { get; set; }

    }
}
