using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace Abby.Web.Views
{
    public abstract class AbbyRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected AbbyRazorPage()
        {
            LocalizationSourceName = AbbyConsts.LocalizationSourceName;
        }
    }
}
