using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text.Encodings.Web;

namespace CustomTagHelper.TagHelpers
{
    public class Authentication:TagHelper
    {
        public bool Authenticated { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AddClass("AuthenticatedUser", HtmlEncoder.Default);
            output.Content.SetContent("کاربر گرامی خوش آمدین");
            if (!Authenticated) {
                output.SuppressOutput();
            }
        }

    }
}
