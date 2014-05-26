using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Lennon.Sunflower.Core;
using Lennon.Sunflower.Core.Infrastructure;

namespace Lennon.Sunflower.WebUI.Framework
{
    public class StoreLastVisitedPageAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //if (!DataSettingsHelper.DatabaseIsInstalled())
            //    return;

            if (filterContext == null || filterContext.HttpContext == null || filterContext.HttpContext.Request == null)
                return;

            //don't apply filter to child methods
            if (filterContext.IsChildAction)
                return;

            //only GET requests
            if (!String.Equals(filterContext.HttpContext.Request.HttpMethod, "GET", StringComparison.OrdinalIgnoreCase))
                return;

            //var customerSettings = EngineContext.Current.Resolve<CustomerSettings>();
            //if (!customerSettings.StoreLastVisitedPage)
            //    return;

            var webHelper = EngineContext.Current.Resolve<IWebHelper>();
            var pageUrl = webHelper.GetThisPageUrl(true);
            if (!String.IsNullOrEmpty(pageUrl))
            {
                //var workContext = EngineContext.Current.Resolve<IWorkContext>();
                //var genericAttributeService = EngineContext.Current.Resolve<IGenericAttributeService>();

                //var previousPageUrl = workContext.CurrentCustomer.GetAttribute<string>(SystemCustomerAttributeNames.LastVisitedPage);
                //if (!pageUrl.Equals(previousPageUrl))
                //{
                //    genericAttributeService.SaveAttribute(workContext.CurrentCustomer, SystemCustomerAttributeNames.LastVisitedPage, pageUrl);
                //}
            }
        }
    }
}
