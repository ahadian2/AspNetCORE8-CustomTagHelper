using CustomTagHelper.Models;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text.Encodings.Web;

namespace CustomTagHelper.TagHelpers
{
    public class MyCarousel:TagHelper
    {
        public override int Order => 2;
        public List<carousel> Items { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
           output.TagName = "div";
           output.AddClass("owl-carousel", HtmlEncoder.Default);
           output.AddClass("owl-theme", HtmlEncoder.Default);
            var x = "";
            foreach (var item in Items) {

                x += $"<div class=\"item\"> <img src=\"{item.Url}\" /> <div> <h4>{item.Title}</h4> <p>ِ{item.Description}</p> </div> </div>";
            }
            output.Content.SetHtmlContent(x);
        }
    }
}
