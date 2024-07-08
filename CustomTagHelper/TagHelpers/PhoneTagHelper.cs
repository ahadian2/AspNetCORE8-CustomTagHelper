using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelper.TagHelpers
{
    public class PhoneTagHelper:TagHelper
    {
        public string PhoneNumber { get; set; } = "0912";
        public string PhoneColer { get; set; } = "red";
        public string PhoneText { get; set; } = "Call";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", $"tel:{PhoneNumber}");
            output.Attributes.SetAttribute("style",$"color:{PhoneColer}");
            output.Content.SetContent(PhoneText);
        }

    }
}
