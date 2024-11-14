# 8. Hafta Ödev

## 📌 Bu Haftaki Görevimiz: Kitap Projesine Üyelik ve Rol Yönetimi Sistemi Entegrasyonu

### 🗂 Mevcut kitap projemize üyelik sistemini entegre edeceğiz. Bu kapsamda:

1. ### **dbContext Güncellemesi**
   - Mevcut `AppDbContext` sınıfı, `IdentityDbContext` sınıfından miras alacak.
   - Böylece ASP.NET Identity sistemi ile uyumlu hale gelecek.

2. ### **Veritabanı Yapılandırması**
   - Üyelik sistemi entegrasyonuna bağlı olarak gerekli **üyelik tabloları** veritabanında otomatik olarak oluşturulacak.

---

## 👤 UserController Sınıfı

`UserController` sınıfı oluşturularak kullanıcı işlemleri için aşağıdaki metotlar yazılacaktır:

- **➕ Kullanıcı Ekleme (Create)**  
  Yeni bir kullanıcı oluşturma işlemini gerçekleştirir.

- **📄 Kullanıcı Bilgilerini Görüntüleme (Read)**  
  Belirli bir kullanıcının bilgilerini görüntülemek için bir endpoint sağlar.

- **✏ Kullanıcı Bilgilerini Güncelleme (Update)**  
  Mevcut kullanıcı bilgilerini güncelleme işlemi.

- **🗑 Kullanıcı Silme (Delete)**  
  Belirli bir kullanıcıyı veritabanından silme işlemini gerçekleştirir.

---

## 📌 RoleController Sınıfı

`RoleController` sınıfı oluşturularak rol işlemleri için aşağıdaki temel endpoint'ler eklenecektir:

- **➕ Rol Ekleme (Create Role)**  
  Yeni bir rol oluşturmak için bir endpoint sağlar.

- **📄 Rolleri Listeleme (List Roles)**  
  Mevcut rolleri listelemek için bir endpoint sağlar.

- **✏ Rol Güncelleme (Update Role)**  
  Var olan bir rolü güncelleme işlemini gerçekleştirir.

- **🗑 Rol Silme (Delete Role)**  
  Belirli bir rolü veritabanından silme işlemini gerçekleştirir.

- **🎭 Kullanıcıya Rol Atama ve Silme (Assign/Remove Role for User)**  
  Belirli bir kullanıcıya rol atama veya mevcut rolünü kaldırma işlemini gerçekleştirir.
