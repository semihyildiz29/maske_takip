# Workaround Projesi

Bu proje, C# dilinde yazılmış basit bir uygulama örneğidir. Projede temel sınıf kullanımı, arayüzler, koleksiyonlar ve method kullanımı gibi C# programlama dilinin temel özellikleri gösterilmektedir.

## Projenin İçeriği

Bu uygulama aşağıdaki özellikleri içerir:

- **SelamVer Metodu:** Kullanıcılara isimleriyle selam verir. İsim girilmezse varsayılan olarak "isimsiz" ile selam verir.
- **Topla Metodu:** İki sayıyı toplar ve sonucu döndürür. Varsayılan değerler atanabilir.
- **Koleksiyonlar:** Öğrenciler ve şehirler gibi verilerin diziler ve `List` koleksiyonları ile yönetilmesi.
- **OOP Kullanımı:** `Person` ve `Vatandas` sınıflarıyla nesne yönelimli programlamanın (OOP) temel özellikleri gösterilir.
- **Arayüzler (Interfaces):** `IApplicantService` arayüzü ve bu arayüzü uygulayan `ForeignerManager` sınıfı ile basit bir arayüz kullanımı örneği.
- **Dependency Injection:** `PttManager` sınıfı, bir bağımlılık olarak `IApplicantService` arayüzünü kullanır ve dependency injection örneği sunar.

## Nasıl Çalıştırılır

1. Projeyi klonlayın veya indirin.
2. Visual Studio gibi bir C# geliştirme ortamında projeyi açın.
3. `Program.cs` dosyasını çalıştırarak uygulamayı başlatın.

## Uygulama İşleyişi

Uygulama başlatıldığında, çeşitli selamlaşma mesajları konsola yazdırılır, öğrenciler listelenir, şehirler ve şehirlerin değiştirilmesiyle ilgili örnekler gösterilir. Ayrıca, bir vatandaşın maske alabilmesi için uygunluk kontrolü yapılır ve sonucuna göre çıktı üretilir.

## Katkıda Bulunma

Bu proje üzerinde geliştirme yapmak istiyorsanız, lütfen projeyi fork'layın ve pull request gönderin. Her türlü katkı kabul edilir.

## Lisans

Bu proje MIT Lisansı altında lisanslanmıştır.
