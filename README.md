#Projeden görseller
-
![Index](https://user-images.githubusercontent.com/47740036/137976398-57cd268d-3651-4e54-a8d6-fc58f9e61718.png) 
-
![Month](https://user-images.githubusercontent.com/47740036/137976401-3b201f2e-179e-41d4-9f4b-6df31331f078.png)
-
![week](https://user-images.githubusercontent.com/47740036/137976405-b471fd05-59d5-475d-8322-dd9103cd9576.png)
-
![AddTask](https://user-images.githubusercontent.com/47740036/137976392-4793ce27-ac9e-4a4a-8b0a-e8589a7266e4.png)
-
![Update](https://user-images.githubusercontent.com/47740036/137976404-a66d5c67-7740-4f4f-8ad9-af3169f7c401.png)



__Katmanlar__

-*Bussiness* : Bu sınıfta daha önce DataAccess'te oluşturulmuş Crud işlemleri gerekli fonksiyonlarda çağırılır ve gerekli iş kurullları eklenir.
<br><br>
-*Core* : Core katmanı temel yapıları içeren bir katmandır. Bu katmanında bulunan yapılar kodun diğer her katmanında kullanabilecek kod parçalarıdır.
<br>
Core katmanında bulunan DataAccess klasörü Veritabanı işlemleri için oluşturulmuş bir klasördür. Bu klasör içerisinde bulunan IEntityRepository sınıfı 
Yazılacak temel Crud işlemlerini bulunduran bir interface'dir.EfEntityRepositoryBase ise IEntityRepository'den implament edilmiş bir sınıftır. Bu sınıf generic bir sınıftır. 
DbContext ve Entity attribute classını parametre olarak alır ve MSSQl için Crud işlemlerini yapar. Bu class kod tekrarını en aza indirger.
<br>
Core katmanında bulunan diğer bir klasörde Result'dır. Result sınıfı fonksiyon geri dönüşlerini özelleştiren bir sınıftır. Data döndürmeyen fonksiyonlar için Result Data döndürenler içinse Data result yapısı kullanılır.
Bu Sınıflar temelde fonksiyonun başarı durumunu fonksiyon sonucunda kullanıcıya döndürülecek mesajı ve var ise datayı döndürür.
<br><br>
-*DataAccess* : Veritabanına kayıt işlemleri ile ilgili sınıflar bulunur.
<br><br>
-*Entities* : Entities katmanı dataların özelliklerini(attribute) tutan sınıflardan oluşan katmandır.
<br><br>
-*MVC* : ASP .Net Core MVC projesidir gereki view, models ve controller'ları içerir.
<br><br>
