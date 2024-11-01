📝 6. Hafta Ödev :

Bu ödev kapsamında, ASP.NET Core ile modern bir API uygulaması geliştirilecektir. Uygulamanın temel yapı taşı olarak ProductController sınıfı oluşturulacak ve çeşitli özellikler içeren endpoint’ler tasarlanacaktır. Bu endpoint'ler, ASP.NET Core’un güçlü dependency injection ve binding öznitelikleri yardımıyla verilere farklı kaynaklardan nasıl erişilip işlenebileceğini gösteren örnekler sunacaktır.

🎯 ProductController Üzerinde Kullanılacak Attribute'lar
ProductController içerisinde ASP.NET Core'un aşağıdaki attribute'larının pratik kullanımına yönelik çeşitli senaryolar gerçekleştirilecektir. Her bir senaryo, gerçek dünyada karşılaşılabilecek ihtiyaçlara yönelik çözümler sunacak ve attribute’ların nasıl etkin kullanılabileceğini gösterecektir:

[FromServices]: Servis katmanından bağımlılıkları alma 📦
[FromKeyedServices]: Anahtar bazlı servisleri seçici olarak enjekte etme 🗝
[FromHeader]: HTTP başlıklarından veri okuma 📨
[FromBody]: İstek gövdesinden JSON/XML gibi verileri okuma 📄
[FromQuery]: Sorgu parametrelerinden veri alma 🔍
[FromRoute]: URL yol parametrelerinden veri alma 