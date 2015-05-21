using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using System.Threading.Tasks;
using TagHelpers.Services;

namespace TagHelpers.Tags
{
    public class GreeterTagHelper : TagHelper
    {
        [FromServices]
        public GreeterService GreeterService { get; set; }

        [HtmlAttributeName("name")]
        public string Name { get; set; }

        public GreeterTagHelper() : this(GreeterService)
        { }


        public GreeterTagHelper(GreeterService gs)
        {
            var x = gs;
        }

        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.Append(GreeterService.GreetName(Name));

            return base.ProcessAsync(context, output);
        }
    }
}
