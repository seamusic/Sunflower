using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sunflower.Core;
using Sunflower.Demo.Core.Models.Account;
using Sunflower.Demo.Site.Models;

namespace Sunflower.Demo.Site.WebUI.Controllers
{
    [Export]
    public class HomeController : Controller
    {
        [Import]
        public IAccountSiteContract AccountContract { get; set; }
        //
        // GET: /Home/

        public ActionResult Index(int? id = 1)
        {
            int pageIndex = id ?? 1;
            const int pageSize = 20;
            PropertySortCondition[] sortConditions = new[] { new PropertySortCondition("Id") };
            int total;
            var memberViews = AccountContract.Members.Where<Member, int>(m => true, pageIndex, pageSize, out total, sortConditions).Select(m => new MemberView
            {
                UserName = m.UserName,
                NickName = m.NickName,
                Email = m.Email,
                IsDeleted = m.IsDeleted,
                AddDate = m.AddDate,
                LoginLogCount = m.LoginLogs.Count,
                RoleNames = m.Roles.Select(n => n.Name)
            });
            PagedList<MemberView> model = new PagedList<MemberView>(memberViews, pageIndex, pageSize, total);
            return View(model);
        }

    }
}
