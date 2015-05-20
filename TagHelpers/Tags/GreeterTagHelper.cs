using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using TagHelpers.Services;

namespace TagHelpers.Tags
{
    public class GreeterTagHelper : TagHelper
    {
        [Activate]
        public GreeterService GreeterService { get; set; }

        [HtmlAttributeName("name")]
        public string Name { get; set; }
               
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.Append("<div>");
            output.Content.Append(GreeterService.GreetName(Name));
            output.Content.Append("</div>");
        }
    }
}
