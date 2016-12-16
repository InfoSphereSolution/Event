using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Event.Model
{
    public class offeredServicesModel
    {
        public Int32 ID { get; set; }
        public String Name { get; set; }
        public String ImageURL { get; set; }
        public String Description { get; set; }
        public String Category { get; set; }
        public String HashTag { get; set; }
    }
}