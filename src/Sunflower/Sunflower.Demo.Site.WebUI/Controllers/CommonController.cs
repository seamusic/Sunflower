using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Sunflower.Core;
using Sunflower.Core.Caching;

namespace Sunflower.Demo.Site.WebUI.Controllers
{
    public partial class CommonController : BasePublicController
    {
        #region Fields
        private readonly IWebHelper _webHelper;
        private readonly ICacheManager _cacheManager;
        #endregion

        #region Constructors

        public CommonController(
            IWebHelper webHelper,
            ICacheManager cacheManager)
        {
            this._webHelper = webHelper;
            this._cacheManager = cacheManager;
        }

        #endregion


        #region Methods

        //page not found
        public ActionResult PageNotFound()
        {
            this.Response.StatusCode = 404;
            this.Response.TrySkipIisCustomErrors = true;

            return View();
        }

        public ActionResult GenericUrl()
        {
            //seems that no entity was found
            return InvokeHttp404();
        }

        //store is closed
        public ActionResult StoreClosed()
        {
            return View();
        }

        #endregion
    }
}