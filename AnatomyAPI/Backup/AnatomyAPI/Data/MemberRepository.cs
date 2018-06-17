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
                    "Left Ventricle",
                    "Right Ventricle",
                    "Left Atrium",
                    "Right Atrium"
                }
            },
            new Member()
            {
                Id = 2,
                Name = "Brain",
                Description = "<p>Engine for the body</p>",
                Sections = new string[]
                {
                    "Frontal Lobe",
                    "Temporal Lobe",
                    "Occipital Lobe",
                    "Porietal Lobe",
                    "Frontal Cortex",
                    "Cerebullum",
                    "Medulla Oblongata",
                    "Thalamus",
                    "Brain Stem",
                    "Pons"
                }
            },
            new Member()
            {
                Id = 3,
                Name = "Spinal Cord",
                Description = "<p>Foundation of the skeleton</p>",
                Sections = new string[]
                {
                    "Cervical",
                    "Thoracic",
                    "Lumbar",
                    "Atlas",
                    "Axis"
                }
            }
        };

        public Member[] GetMembers()
        {
            return _members;
        }

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
