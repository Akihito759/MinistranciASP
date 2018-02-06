using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ministranci.Models
{
    public class Day
    {
        public DateTime Date { get;  set; }
        public List<HolyMass> HolyMassList { get;  set; }

    }
}