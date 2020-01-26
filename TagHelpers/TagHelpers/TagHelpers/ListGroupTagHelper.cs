using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpers.TagHelpers
{
    //ul elemetleri için geçerli bir TagHelper olsun
    //elemanın items attributesi olsun bu attr den dinamik değeri verelim
    [HtmlTargetElement("ul",Attributes ="items",ParentTag ="form")]
    public class ListGroupTagHelper:TagHelper
    {
        //bu Items direk dışardan gelecek (Model den alcaz)
        public List<string> Items { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //ul elemana class verdik
            output.Attributes.SetAttribute("class", "list-group");

            foreach (var item in Items)
            {
                TagBuilder li = new TagBuilder("li");
                li.Attributes["class"] = "list-group-item";
                li.InnerHtml.AppendHtml(item);
                output.PreContent.AppendHtml(li);
            }
        }
    }
}
