Önemli yerler:
1)Register.cshtml de ki form inputlarında,
asp-for TagHelper'i Tipe bagımsız olarak herhangi bir inputa verebilirsin ve o inputun tipine göre otomaik olarak typeni belırlıyor.
		  string deger için  =>       <input class="form-control" asp-for="UserName">
		  boold deger icin =>         <input asp-for="TermsAccepted">
yani tipe bakmadan asp-for dedigin an , arka taraftaki tipi algılayıp ona göre bir input text yada input chech vs gibi degerlere burunuyor.

--------------------------------------VALIDATION 1--------------------------------------
Validation Model Binding yardımıyla "ModelStateDictionary" ile kontrol ediliyor
Bu özelliğin 3 önemli aksiyonu var
1- AddModelError(property,message)
2- GetValidationState(proporty) 
3- IsValid

Home>Register metedonda bunları kullandık.
Eğer bir input validasyonu sorunluya   input-validation-error sınıfı o inputa eklenıyor..
Bu durumu bootstrap ile kullabiliriz.   (Register.cshtmlde var)
	$('input.input-validation-error')
				  .closest('form-group')
				  .addClass('has-danger');

ModelState.AddModelError ile belirlediğimiz hata mesajları ve propertileri yansıtmak için
bir TagHelper kullanacağız;
 @@@@@@@@@@@@@@@@@@@@@@@@@@@@   <div class="text-danger" asp-validation-summary="All"></div>  ile toplu olarak tum hataları cıkarabılırız.
	
EK OLARAK ;
Register.cs sınıfındaki nullable olmayan değerler için yani BirthDate ve Terms...(string olmayan değerler) , değerler boş gönderildiğinde  
@@@@@@@@@@@@@@@@@@@@@@@@@@@@ data-val-required="The BirthDate field is required."  sınıfı atanıyor default olarak.
Bunu değiştirebiliriz.Startup>Configuration =>
@@@@@@@@@@@@@@@@@@@@@@@@@@@@
	  services.AddMvc().AddMvcOptions(opt =>
                opt.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(msg => "Lütfen bir değer giriniz"));

Property level işlemi yani , hata hangi inputtaysa onun yanında hata belirsin.Üstte toplu olarak çıkmasın (asp-validation-summary="All" yaptığımızda çıkan hataları propery seviyesin getirelim)
Bunun için  her inputun altında ;
@@@@@@@@@@@@@@@@@@@@@@@@@@@@      <span class="text-danger" asp-validation-for="Email"></span>
eklemek yeterli :)
--------------------------------------VALIDATION 2--------------------------------------

META DATA ILE VALIATION YANI DATAANNOTIANS ILE BU ISLEMLERI YAPALIM BUNUN ICIN REGISTER2.cs ve REgister2.cshtml  oluşturduk.
Aynı olayı buradan daha basit bir şekilde yapabiliyioruz.
cshtml yani view tafında ypılanlar aynı .
İlk olayda Controller tarafında ModelState.AddModelError ile hataları ekleyip view tarafına yansıtıyorduk
2 olayda Register2.cs sınıfında DataAnnotite ile  daha basit bir şekilde yapıyoruz.
ONEMLI OLAN asp-validation-for u ikisi için de view tarafında kullanıyor olmamız

--------------------------------------ÖZEL VALIDATION KURALI OLUSTURMA-------------------------------------
KesinlikleTrueOlmaliAttribute sınıfını ekledik ve
KesinlikleTrueOlmali : Attribute, IModelValidator miras verdik.
Register2 > Terms te kullandık.

---------------------------------CLIENT SIDE TAFAINDA VALITAION ISLEMLERI :!:!:!
bower ile bir kaç kütüphane ekleyelim
  "jquery-validation": "1.19.1",
  "jquery-validation-unobtrusive": "3.2.11",

Bunun için Register3.cshtml ini oluşturuyorum Register2.cs i kullanabılırız

Register3.cshtml e 
    <script src="~/lib/jquery-validation/dist/jquery.validate.js"></script>
    <script src="~/lib/jquery-validation-unobtrusive/src/jquery.validate.unobtrusive.js"></script>
ekledik başka hiç bişey yapmadık ve otomatik olarak input change de validate olayı tetıklenıyor ve controlleri gitmeden kontrol ediliyor.



