# BlogProject-API-and-MVC

## Proje Açıklaması
**BlogProject-API-and-MVC**, **ASP.NET 6 MVC** mimarisiyle geliştirilmiş bir **blog platformudur**. Kullanıcılar blog yazıları paylaşabilir, yorum yapabilir ve yetkilendirme ile belirli işlemleri gerçekleştirebilir. **Web API** desteği sayesinde, veri alışverişi dinamik hale getirilmiştir.

## Kullanılan Teknolojiler
- **ASP.NET 6** – MVC mimarisi
- **Entity Framework Core** – Code First ile veritabanı yönetimi
- **JWT (JSON Web Token)** – Yetkilendirme sistemi
- **Fluent API** – Veritabanı yapılandırması
- **N Katmanlı Mimari** – Daha düzenli ve ölçeklenebilir yapı
- **RESTful Web API** – Dış sistemlerle entegrasyon için

## Özellikler
- **Üyelik Sistemi**: Kullanıcı kaydı, giriş ve yetkilendirme
- **Blog Yönetimi**: Blog oluşturma, düzenleme, silme
- **Yorum Sistemi**: Blog yazılarına yorum yapma ve yorumları yönetme
- **Kategori Yönetimi**: Blog yazıları için kategori belirleme
- **Admin Paneli**: Kullanıcı ve içerik yönetimi için yönetici paneli

## Kurulum
1. **Depoyu klonla:**
   ```sh
   git clone https://github.com/batuhangkdmr/BlogProject-API-and-MVC.git
   ```
2. **Proje dizinine gir:**
   ```sh
   cd BlogProject-API-and-MVC
   ```
3. **Bağımlılıkları yükle:**
   ```sh
   dotnet restore
   ```
4. **Veritabanını oluştur:**
   ```sh
   dotnet ef database update
   ```
5. **Projeyi çalıştır:**
   ```sh
   dotnet run
   ```

## API Kullanımı
Proje **RESTful API** yapısına sahiptir ve aşağıdaki gibi endpoint'ler içermektedir:

### Kullanıcı Kimlik Doğrulama
- **Giriş Yap** (POST) → `/api/auth/login`
- **Kayıt Ol** (POST) → `/api/auth/register`

### Blog İşlemleri
- **Tüm Blogları Getir** (GET) → `/api/blogs`
- **Yeni Blog Ekle** (POST) → `/api/blogs`
- **Blog Güncelle** (PUT) → `/api/blogs/{id}`
- **Blog Sil** (DELETE) → `/api/blogs/{id}`

### Yorum İşlemleri
- **Yorumu Listele** (GET) → `/api/comments/{blogId}`
- **Yeni Yorum Ekle** (POST) → `/api/comments`
- **Yorum Sil** (DELETE) → `/api/comments/{id}`

## Lisans
Bu proje **MIT Lisansı** ile lisanslanmıştır.



## Projeden Görseller
<img src="/BlogApp.WEB/wwwroot/img/projectImages/1.png" />
<img src="/BlogApp.WEB/wwwroot/img/projectImages/2.png" />
<img src="/BlogApp.WEB/wwwroot/img/projectImages/3.png" />
