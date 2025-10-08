# 🌸 MultiShop Microservice Project 



> 📌 Modern teknolojiler ve mikro hizmetler mimarisi kullanılarak geliştirilmiş bir e-ticaret projesi.  
> 📌 **Docker entegrasyonu** ile taşınabilir, güvenli ve ölçeklenebilir bir altyapı sunar.  
> 📌 **MSSQL, MongoDB, Redis ve PostgreSQL** gibi SQL ve NoSQL veritabanlarıyla sorunsuz çalışacak şekilde yapılandırılmıştır.

---

## ✨ Proje Özellikleri
- 🏗️ **Mikro Hizmetler Mimarisi**  
  Katmanlı ve Soğan mimarileri kullanılarak inşa edilmiştir.  
  **SOLID** ilkelerine uygun, esnek ve genişletilebilir bir yapı sunar.

- 🧩 **Tasarım Desenleri**  
  Repository, **CQRS** ve Mediator desenleri ile ölçeklenebilirlik ve modülerlik artırılmıştır.

- 🔒 **Güvenlik**  
  Kimlik doğrulama ve yetkilendirme için **Identity Server** ve **JWT** kullanılır.

- 💾 **Veritabanı Yönetimi**  
  MSSQL, MongoDB, Redis ve PostgreSQL ile optimize edilmiş veri yönetimi sağlar.

- 🧹 **Temiz Kod ve Katmanlı Yapı**  
  Catalog mikroservisinde veri yapısı ve Folder Structure korunarak temiz kod prensipleri uygulanmıştır.

- ⚡ **Gerçek Zamanlı Bildirim**  
  SignalR kullanılarak anlık mesajlaşma ve bildirimler sağlanır.

- 🌐 **Dış API Entegrasyonu**  
  RapidAPI üzerinden döviz kuru, hava durumu gibi dış bilgiler consume edilmiştir.

- 🛼 Çoklu dil desteği için Globalization, kuyruk için RabbitMQ kullanıldı

---

## 🛠️ Kullanılan Teknolojiler

### Backend

- Docker  
- RapidAPI  
- RabbitMQ  
- Postman, Swagger  


### Veritabanları
- MSSQL
- Redis
- PostgreSQL
- MongoDB

### Mimariler & Desenler
- Onion Architecture  
- CQRS  
- Mediator  
- Repository Design Pattern  
- Ocelot Gateway  
- SignalR  


## 📦 MikroServisler ve Detayları
| Servis | Veri Tabanı / Depolama | Açıklama |
|--------|-----------------------|----------|
| 🛒 Basket | Redis (Docker) | Kullanıcı sepet işlemleri; Token üzerinden Redis ile bağlantı |
| 📦 Cargo | MSSQL | Kargo ve lojistik işlemleri |
| 📚 Catalog | MongoDB | Ürünler, kategoriler ve vitrin verileri; tek katmanda temiz kod prensibi |
| 💬 Comment | MSSQL (Docker) | Kullanıcı yorumları yönetimi |
| 💰 Discount | MSSQL (Docker) | İndirimler; Docker SQL kullanımı ile izolasyon |
| 🖼️ Images | Google Cloud Storage | Ürün ve diğer görsellerin depolanması |
| ✉️ Message | PostgreSQL | Mesajlaşma servisi |
| 📝 Order | PostgreSQL | Sipariş yönetimi; Onion Architecture, CQRS ve Mediator kullanımı |
| 🔑 IdentityServer4 | MSSQL (Docker) | Kimlik doğrulama; farklı DB ile izolasyon sağlandı |
| 💳 Payment | - | Ödeme işlemleri |
| ⚡ SignalR | - | Anlık bildirim ve mesajlaşma |

---

## 💡  Notlar
- Docker kullanılarak tüm mikroservisler izole ve taşınabilir şekilde kolayca ayağa kaldırılabilir.

- SignalR entegrasyonu sayesinde gerçek zamanlı bildirim, anlık mesajlaşma ve iletişim desteği sağlanmıştır.

- Catalog, Discount, Identity, Order gibi servisler birbirinden bağımsız çalışacak şekilde yapılandırılmış; böylece olası servis kesintilerinde sistemin geneli etkilenmeden akış devam eder.

- RapidAPI üzerinden döviz kuru, hava durumu gibi dış kaynaklı veriler dinamik olarak tüketilmiştir.

- Globalization ile çoklu dil desteği ve RabbitMQ ile mesaj kuyruk yönetimi entegre edilmiştir.

---

# 📸 Proje Görselleri


![Ana Sayfa](https://github.com/Sevcanarig/MultiShop/raw/main/Frontends/MultiShop.WebUI/wwwroot/Img/1.png)
![Ürün Listesi](https://github.com/Sevcanarig/MultiShop/raw/main/Frontends/MultiShop.WebUI/wwwroot/Img/2.png)
![Ürün Detayı](https://github.com/Sevcanarig/MultiShop/raw/main/Frontends/MultiShop.WebUI/wwwroot/Img/3.png)
![Sepet Sayfası](https://github.com/Sevcanarig/MultiShop/raw/main/Frontends/MultiShop.WebUI/wwwroot/Img/4.png)
![Kargo Bilgileri](https://github.com/Sevcanarig/MultiShop/raw/main/Frontends/MultiShop.WebUI/wwwroot/Img/5.png)
![Sipariş Özeti](https://github.com/Sevcanarig/MultiShop/raw/main/Frontends/MultiShop.WebUI/wwwroot/Img/6.png)
![Kullanıcı Girişi](https://github.com/Sevcanarig/MultiShop/raw/main/Frontends/MultiShop.WebUI/wwwroot/Img/7.png)
![Kayıt Ol Sayfası](https://github.com/Sevcanarig/MultiShop/raw/main/Frontends/MultiShop.WebUI/wwwroot/Img/8.png)
![Yorum Ekranı](https://github.com/Sevcanarig/MultiShop/raw/main/Frontends/MultiShop.WebUI/wwwroot/Img/9.png)
![İndirimler Sayfası](https://github.com/Sevcanarig/MultiShop/raw/main/Frontends/MultiShop.WebUI/wwwroot/Img/10.png)
![Ödeme Sayfası](https://github.com/Sevcanarig/MultiShop/raw/main/Frontends/MultiShop.WebUI/wwwroot/Img/11.png)
![Mesajlaşma Ekranı](https://github.com/Sevcanarig/MultiShop/raw/main/Frontends/MultiShop.WebUI/wwwroot/Img/12.png)
![Bildirim Ekranı](https://github.com/Sevcanarig/MultiShop/raw/main/Frontends/MultiShop.WebUI/wwwroot/Img/13.png)
![Rapid API Verileri](https://github.com/Sevcanarig/MultiShop/raw/main/Frontends/MultiShop.WebUI/wwwroot/Img/14.png)
![Admin Paneli](https://github.com/Sevcanarig/MultiShop/raw/main/Frontends/MultiShop.WebUI/wwwroot/Img/15.png)
![Genel Görünüm](https://github.com/Sevcanarig/MultiShop/raw/main/Frontends/MultiShop.WebUI/wwwroot/Img/16.png)



