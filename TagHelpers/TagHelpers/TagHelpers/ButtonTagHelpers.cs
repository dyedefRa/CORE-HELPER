using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpers.TagHelpers
{
    [HtmlTargetElement("button",Attributes="bs-button-color",ParentTag ="form")] //form tagleri arasındaki buttonlar için
    [HtmlTargetElement("a", Attributes = "bs-button-color", ParentTag = "form")]
    //bs-button-color attributesi ile verdigin degeri alttaki ayarlara ata
    public class ButtonTagHelpers:TagHelper
    {
        public string BsButtonColor { get; set; }
        //Process özelliğini eziyoruz...
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //üzerinde çalıştığımız input,html itemi => context ile yakalacağız
            //Değişiklikleri output ile göndereceğiz.
            output.Attributes.SetAttribute("class", $"btn btn-{BsButtonColor}");
        }
        //Bu ayarları uyulamaya tanıtacağız.
        //Bunu _ViewImports.cshtml de yapacağız

        //@addTagHelper TagHelpers.TagHelpers.*,TagHelpers    ilk parametre dosya yolu
        //2. parametre ait olduğu dll ismi..yani solution ismi
    }
}
