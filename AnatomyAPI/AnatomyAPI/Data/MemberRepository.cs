using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnatomyAPI.Models;

namespace AnatomyAPI.Data
{
    public class MemberRepository
    {
        private static Member[] _members = new Member[]
        {
            new Member()
            {
                Id = 1,
                Name = "Heart",
                Description = "<p>Keeps the blood flowing and the body moving</p>",
                Sections = new string[]
                {
                    "left ventricle",
                    "right ventricle",
                    "left atrium",
                    "right atrium"
                }
            }
        };

        public Member GetMember(int id)
        {
            Member memberReturn = null;

            foreach (var member in _members)
            {
                if (member.Id == id)
                    memberReturn = member;
            }

            return memberReturn;
        }
    }
} 
