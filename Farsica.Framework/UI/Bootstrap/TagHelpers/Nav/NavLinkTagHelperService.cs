﻿namespace Farsica.Framework.UI.Bootstrap.TagHelpers.Nav
{
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [DataAnnotation.Injectable]
    public class NavLinkTagHelperService : TagHelperService<NavLinkTagHelper>
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.TagMode = TagMode.StartTagAndEndTag;
            SetClasses(context, output);
        }

        protected virtual void SetClasses(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.AddClass("nav-link");

            SetDisabledClass(context, output);
            SetActiveClass(context, output);

            output.Attributes.RemoveAll("frb-nav-link");
        }

        protected virtual void SetDisabledClass(TagHelperContext context, TagHelperOutput output)
        {
            if (TagHelper.Disabled ?? false)
            {
                output.Attributes.AddClass("disabled");
            }
        }

        protected virtual void SetActiveClass(TagHelperContext context, TagHelperOutput output)
        {
            if (TagHelper.Active ?? false)
            {
                output.Attributes.AddClass("active");
            }
        }
    }
}