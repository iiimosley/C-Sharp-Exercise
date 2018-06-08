using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnatomyAPI.Models
{
    public class Member
    {
            public string Name { get; set; }
            public string Description { get; set; }
            public string[] Sections { get; set; }
    }
}
