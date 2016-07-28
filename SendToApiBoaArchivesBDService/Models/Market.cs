using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SendToApiBoaArchivesBDService.Models
{
    public class Market
    {
        public string Title { get; set; }
        public List<ConfigDate> ConfigDate { get; set; } 
    }
}
