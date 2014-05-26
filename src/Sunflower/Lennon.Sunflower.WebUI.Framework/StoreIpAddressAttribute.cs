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
    public class StoreIpAddressAttribute : ActionFilterAttribute
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

            var webHelper = EngineContext.Current.Resolve<IWebHelper>();

            //update IP address
            string currentIpAddress = webHelper.GetCurrentIpAddress();
            if (!String.IsNullOrEmpty(currentIpAddress))
            {
                //todo:update ipaddress
                //var workContext = EngineContext.Current.Resolve<IWorkContext>();
                //var customer = workContext.CurrentCustomer;
                //if (!currentIpAddress.Equals(customer.LastIpAddress, StringComparison.InvariantCultureIgnoreCase))
                //{
                //    var customerService = EngineContext.Current.Resolve<ICustomerService>();
                //    customer.LastIpAddress = currentIpAddress;
                //    customerService.UpdateCustomer(customer);
                //}
            }
        }
    }
}
