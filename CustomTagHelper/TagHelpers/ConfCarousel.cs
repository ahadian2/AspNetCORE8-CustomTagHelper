using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelper.TagHelpers
{
    public class ConfCarousel:TagHelper
    {
        public override int Order => 2;
        public string CarouselName { get; set; } = "owl-carousel";
        public string Carouselmargin { get; set; } = "10";
        public string CarouselTimeout { get; set; } = "5000";
        public string CarouselItem { get; set; } = "3";
        public string CarouselLoop { get; set; } = "true";
        public string Carouselnav { get; set; } = "true";
        public string Carouselautoplay { get; set; } = "true";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "script";
            output.Content.SetHtmlContent($@"
        $('.{CarouselName}').owlCarousel({{
            loop: {CarouselLoop},
            margin: {Carouselmargin},
            nav: {Carouselnav},
            autoplay:{Carouselautoplay},
            autoplayTimeout:{CarouselTimeout},
            responsive: {{
                0: {{
                    items: 1
                }},
                600: {{
                    items: 3
                }},
                1000: {{
                    items: {CarouselItem}
                }}
            }}
        }})
       ");
        }
    }
}
