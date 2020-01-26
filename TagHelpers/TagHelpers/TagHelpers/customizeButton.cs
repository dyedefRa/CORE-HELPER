using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpers.TagHelpers
{
    [HtmlTargetElement("testButton")]//istersen bu sekilde isim veririsin ınputa
    public class customizeButton:TagHelper
    {
        //Oluştucağın ımputun attrıbutelerınden bu degerlerı verebılıyosun
        public string Type { get; set; } = "Submit";
        public string BgColor { get; set; } = "success";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.SetAttribute("class", $"btn btn-{BgColor}");
            output.Attributes.SetAttribute("type", Type);
            output.Content.SetContent(Type == "Submit" ? "Gönder":"Submit degil");//Burası text
            //base.Process(context, output);
        }

    }

    // =>  VIEWDE    <testButton bg-color="danger" type="Submit"></testButton>
}
