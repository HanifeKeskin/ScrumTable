using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimYapimi
{
    public class Task
    {
        public int ID { get; set; }
        public string TaskAdi { get; set; }
        public string TaskIcerik { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public virtual Sprint Sprint { get; set; }
        public virtual User User { get; set; }
    }
}
