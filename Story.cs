using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimYapimi
{
   public  class Story
    {
        public string StoryAd { get; set; }
        public string StoryIcerik { get; set; }
        public DateTime Sure { get; set; }
        public virtual Sprint Sprint { get; set; }
    }
}
