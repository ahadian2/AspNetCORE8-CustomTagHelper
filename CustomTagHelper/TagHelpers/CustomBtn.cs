using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text.Encodings.Web;

namespace CustomTagHelper.TagHelpers
{
    public class CustomBtn : TagHelper
    {
        public string Text { get; set; }
        public string Type { get; set; }
        public string Icon { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.Content.SetContent(Text);
            output.AddClass("btn", HtmlEncoder.Default);
            
            output.PreContent.SetHtmlContent($"<i class=\"{Icon}\"></i><span>");
            output.PostContent.SetHtmlContent("</span>");

            output.PreElement.SetHtmlContent("<div>");
            output.PostElement.SetHtmlContent("</div>");


            if (Type == "submit")
            {
                output.AddClass("submit", HtmlEncoder.Default);
            }
            else if (Type == "update")
            {
                output.AddClass("update", HtmlEncoder.Default);
            }
            else
            {
                output.AddClass("delete", HtmlEncoder.Default);
            }
        }
    }
}
