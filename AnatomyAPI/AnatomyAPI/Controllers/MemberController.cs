using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using AnatomyAPI.Data;
using AnatomyAPI.Models;

namespace AnatomyAPI.Controllers
{
    public class MemberController : Controller
    {

        private MemberRepository _memberRepository = null;

        public MemberController()
        {
            _memberRepository = new MemberRepository();
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
                return HttpNotFound();
            
            var member = _memberRepository.GetMember((int)id);

            return View(member);
        }
    }
} 
