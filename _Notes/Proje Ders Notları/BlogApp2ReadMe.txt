1)Başlangıç ayarları yapıldı (Startup.cs)
2)_ViewImports & _ViewStart eklendi, _Layout eklendi
***
3)Bootstrap kütüphanesi için bower ekleyeyelim;
.bowerrc ekle ve klasor belirt.
ardından bower.json ekle (bunları manuel olarak Json dosyasından üretiyorsun)
***
4)BlogApp.Data da Abstract/Concrete file oluşturduk ve buraya SQLSERVER kutuphanesi ekleyelim çünkü EF Core işlemleri yapacağız
Data>Nuget > SqlServer  yada
edit.csproj >     <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="3.1.0" />
Ardından Data>EFCore>BlogContext sınıfını doldurduk ve buraya conStr vermemiz gerek ;
WebUI new Item > appsettings.json (eski web.config)
ve bunu Startup.cs e tanıtalım ;