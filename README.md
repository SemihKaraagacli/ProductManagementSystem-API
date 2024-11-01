# 6. Hafta Ödevi: ASP.NET Core ile Modern API Uygulaması Geliştirme

Bu ödev kapsamında, **ASP.NET Core** ile modern bir API uygulaması geliştirilecektir. Uygulamanın temel yapı taşı olarak `ProductController` sınıfı oluşturulacak ve çeşitli özellikler içeren endpoint'ler tasarlanacaktır. Bu endpoint'ler, ASP.NET Core'un güçlü **dependency injection** ve **binding** öznitelikleri yardımıyla verilere farklı kaynaklardan nasıl erişilip işlenebileceğini gösteren örnekler sunacaktır.

---

## ProductController Üzerinde Kullanılacak Attribute'lar

`ProductController` içerisinde, ASP.NET Core'un aşağıdaki attribute'larının pratik kullanımına yönelik çeşitli senaryolar gerçekleştirilecektir. Bu senaryolar, gerçek dünyada karşılaşılabilecek ihtiyaçlara yönelik çözümler sunacak ve attribute'ların nasıl etkin kullanılabileceğini gösterecektir:

### 1. `[FromServices]`: Servis Katmanından Bağımlılıkları Alma
   - `FromServices` attribute'u, bir endpoint içinde, dependency injection kullanarak servis katmanındaki bağımlılıkları alır.
   - Bu attribute ile, servisleri manuel olarak enjekte edebilir ve kullanabilirsiniz.
   
### 2. `[FromKeyedServices]`: Anahtar Bazlı Servisleri Seçici Olarak Enjekte Etme
   - `FromKeyedServices` attribute'u, belirli bir anahtar kullanarak farklı türdeki servisleri enjekte etmeyi sağlar.
   - Bu yöntemle, aynı türde ancak farklı anahtarlarla tanımlanmış servisleri seçici olarak kullanabilirsiniz.

### 3. `[FromHeader]`: HTTP Başlıklarından Veri Okuma
   - `FromHeader` attribute'u, HTTP istek başlıklarından gelen verileri okuma imkanı sunar.
   - Örneğin, özel kimlik doğrulama veya oturum bilgilerini başlıklardan çekerek kullanabilirsiniz.

### 4. `[FromBody]`: İstek Gövdesinden JSON/XML Verilerini Okuma
   - `FromBody` attribute'u, HTTP isteğinin gövdesinden gelen JSON veya XML formatındaki verileri okur.
   - Bu yöntemle, istemci tarafından gönderilen detaylı veri paketlerini alıp işleyebilirsiniz.

### 5. `[FromQuery]`: Sorgu Parametrelerinden Veri Alma
   - `FromQuery` attribute'u, URL'de yer alan sorgu parametrelerinden veri çekmenize olanak tanır.
   - Bu sayede, URL'de verilen filtreleme, sıralama gibi bilgileri alıp kullanabilirsiniz.

### 6. `[FromRoute]`: URL Yol Parametrelerinden Veri Alma
   - `FromRoute` attribute'u, URL yolundaki parametreleri alır.
   - Özellikle kimlik numarası veya kategori gibi bilgileri yol parametreleri olarak alarak işlemler gerçekleştirebilirsiniz.

---

Bu ödev ile birlikte, ASP.NET Core'un farklı binding ve dependency injection özellikleri kullanılarak modern bir API geliştirme pratiği yapılacaktır. Her bir attribute, gerçek dünyada karşılaşılabilecek durumlara uygun çözümler sunacak şekilde kullanılacaktır.

---
