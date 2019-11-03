using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ControleDeGastos.Web.Helper
{
    public class LayoutInjecterAttribute : ActionFilterAttribute
    {
        private readonly string _masterName;
        public LayoutInjecterAttribute(string masterName)
        {
            _masterName = masterName;
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            var result = filterContext.Result as ViewResult;
            if (result != null)
            {
                result.ContentType = _masterName;
            }
        }
    }
}
