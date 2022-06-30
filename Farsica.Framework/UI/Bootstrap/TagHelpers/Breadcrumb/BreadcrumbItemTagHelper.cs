﻿namespace Farsica.Framework.UI.Bootstrap.TagHelpers.Breadcrumb
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using Microsoft.Extensions.Options;

    [DataAnnotation.Injectable]
    [HtmlTargetElement("frb-bread-crumb-item")]
    public class BreadcrumbItemTagHelper : TagHelper<BreadcrumbItemTagHelper, BreadcrumbItemTagHelperService>
    {
        public BreadcrumbItemTagHelper(BreadcrumbItemTagHelperService tagHelperService, IOptions<MvcViewOptions> optionsAccessor)
            : base(tagHelperService, optionsAccessor)
        {
        }

        [HtmlAttributeName("frb-href")]
        public string Href { get; set; }

        [HtmlAttributeName("frb-title")]
        public string Title { get; set; }

        [HtmlAttributeName("frb-active")]
        public bool Active { get; set; }
    }
}
