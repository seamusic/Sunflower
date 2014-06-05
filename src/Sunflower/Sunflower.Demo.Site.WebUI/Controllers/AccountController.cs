using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sunflower.Core;
using Sunflower.Demo.Site;
using Sunflower.Demo.Site.Models;

namespace Sunflower.Demo.Site.WebUI.Controllers
{
    [Export]
    public class AccountController : Controller
    {
        #region 属性

        [Import]
        public IAccountSiteContract AccountContract { get; set; }

        #endregion

        #region 视图功能

        public ActionResult Login()
        {
            string returnUrl = Request.Params["returnUrl"];
            returnUrl = returnUrl ?? Url.Action("Index", "Home", new { area = "" });
            LoginModel model = new LoginModel
            {
                ReturnUrl = returnUrl
            };
            return View(model);
        }

        [HttpPost]

        public ActionResult Login(LoginModel model)
        {
            try
            {
                OperationResult result = AccountContract.Login(model);
                string msg = result.Message ?? result.ResultType.ToDescription();
                if (result.ResultType == OperationResultType.Success)
                {
                    return Redirect(model.ReturnUrl);
                }
                ModelState.AddModelError("", msg);
                return View(model);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View(model);
            }
        }

        public ActionResult Logout()
        {
            string returnUrl = Request.Params["returnUrl"];
            returnUrl = returnUrl ?? Url.Action("Index", "Home", new { area = "" });
            if (User.Identity.IsAuthenticated)
            {
                AccountContract.Logout();
            }
            return Redirect(returnUrl);
        }

        #endregion
    }
}
