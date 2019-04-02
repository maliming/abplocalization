﻿using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace QA.Web.Views
{
    public abstract class QARazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected QARazorPage()
        {
            LocalizationSourceName = QAConsts.LocalizationSourceName;
        }
    }
}
