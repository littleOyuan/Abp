using Abp.AspNetCore.Mvc.ViewComponents;

namespace Abby.Web.Views
{
    public abstract class AbbyViewComponent : AbpViewComponent
    {
        protected AbbyViewComponent()
        {
            LocalizationSourceName = AbbyConsts.LocalizationSourceName;
        }
    }
}
