﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnatomyAPI.Models;

namespace AnatomyAPI.Data
{
    public class AnatomyRepository
    {
        public Member GetMember()
        {
            var member = new Member()
            {
                Name = "Heart",
                Description = "<p>Keeps the blood flowing and the body moving</p>",
                Sections = new string[]
                {
                    "left ventricle",
                    "right ventricle",
                    "left atrium",
                    "right atrium"
                }
            };

            return member;
        }
    }
} 
