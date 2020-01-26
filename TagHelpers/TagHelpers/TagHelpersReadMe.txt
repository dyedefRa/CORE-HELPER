**STATIK OLARAK ELEMENT ATTRIBUTELERINE VERILEN PARAMETREYI ALIP ISTEDIGIMIZ OZELLIGI INPUTA VEREBILIYORUZ

--Bunun için TagHelper sınıfından üretilen bir ButtonTagHelpers sınıfı oluşturduk

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

ve bunu _ViewImports'ta tanıtacağız;;
		@using TagHelpers.Models
		@addTagHelper TagHelpers.TagHelpers.*,TagHelpers
		@addTagHelper *,Microsoft.AspNetCore.Mvc.TagHelpers

TagHelpers.TagHelpers.* => Sınıfın bulunduğu dosya yolu
,TagHelpers            => Sınıfın bulunduğu dll ismi (Solution ismi)

------------------------------------------------------------------------------------------------------------------------------------
2 OLARAK OLMAYAN BIR INPUT ELEMENTI URETTIK **************VE BU ELEMENTIN SAHIP OLACAGI ATTRIBUTELERI AYARLADIK
VE BU AYARLARA GORE INPUTA OZELLIK VERDIK!!!!!!!!!!!!!!!!!
(customizeButton ile)


    [HtmlTargetElement("testButton")]//istersen bu sekilde de isim veririsin ınputa
    public class customizeButton:TagHelper
    {
        //Oluştucağın ımputun attrıbutelerına bu degerlerı verebılıyosun
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
	------------------------------------------------------------------------------------------------------------------------------------


