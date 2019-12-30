1)Hem FakeProductRepository ile hemde ApplicationDbContext ile Injection yaptık
Bu ayarı > Startup.cs te;
=>             services.AddTransient<IProductRepository, FakeProductRepository>();
ile yaptık

2)Webconfig artık yok , onun yerine  json dosyasında tanıtıyoruz gerekli bilgileri
(Application settings File = appsettings.json )
Startupta dbyi tanıttık.s

3)MIGRATION ile olmayan db üretelim
Proje > Sağ tık > Edit csproj 'a 
    <DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="2.0.0"></DotNetCliToolReference>
yazdık ve bu paketi projeye yuklemıs olduk.
Aktif etmek için ;
CMD > Proje dizine git
--dotnet ef migrations add initial €
Migrations dosyası eklendi
SeedData sınıfını oluşturduk ve migration u tanıttık fake data oluşturduk.
Bunu startup a tanıttık*****
Programstada .UseDefaultServiceProvider ile Provider i tanıttık

4) Diyelimki Product sınıfına yeni bir field ekledik ve 
bu field i db ye yansıtacağız..
>proje dizini CMD>
--dotnet ef migrations add addStokColumn € 
ile migration eklliyorsun
--dotnet ef database update (son eklenilen migrationı aktif et)
ile db yi tetikliyorsun

5)Şu an için totalde iki migration var
initialize ve addStokColumn adında 
bir önceki migration'a yani initialize ye geçiş için ;
--dotnet ef database update  initial
bir sonrakine geçiş için mantık aynı
--dotnet ef database update addStokColumn