# 🧠 InsuranceWebAIProject – Yapay Zekâ Destekli Sigorta Platformu

**InsuranceWebAIProject**, .NET MVC 4.7.2 ve Entity Framework (DB-First) mimarisiyle geliştirilen, modern bir sigorta firması web uygulamasıdır.  
Yapay zekâ entegrasyonları sayesinde içerik üretimini hızlandıran, sezgisel yönetici paneli ve kullanıcı dostu tasarımıyla öne çıkan bir dijital çözümdür.

---

## ⚙️ Yönetim Paneli Özellikleri

### 🗣️ AI Destekli Soru-Cevap Sistemi (FAQ)

- 🚫 Sistem **soru üretmez**  
- ✅ **Admin kendi sorusunu yazar**, sistem yalnızca **cevap üretir**
- Soru, **ChatGPT API (RapidAPI)** üzerinden işlenir ve AI tarafından **cevabı otomatik oluşturulur**
- Admin onayıyla soru ve cevap **veritabanına kaydedilir**
- Sıkça Sorulan Sorular bölümü böylece dinamik şekilde oluşturulur

### 🎨 Otomatik Hizmet Görselleri

- Admin, hizmete dair kısa bir açıklama girer (örnek: “Sağlık Sigortası”)
- Açıklama, **Hugging Face text-to-image API** aracılığıyla işlenir
- Resmin Url'si Yapay Zeka Tarafından Üretilir ve url kullanılması için admine sunulur.

### 🧾 İçerik Yönetimi (Tam Yetkili CRUD)

- Hizmetler  
- Slider İçerikleri  
- Referanslar  
- Çalışan Profilleri  
- Hakkımızda Sayfası  
- İletişim Bilgileri

---

## 🌐 Kullanıcı Arayüzü Özellikleri

- 📱 **Mobil Uyumlu ve Şık Arayüz**  
  - Bootstrap 5 ile geliştirilmiş modern UI
  - Tüm cihazlarda optimize edilmiş responsive yapı

- ❓ **Zeki SSS Alanı**  
  - AI ile oluşturulan cevaplar akordeon yapıda kullanıcıya sunulur

- 🖼️ **Zengin Görselli Hizmet Kartları**  
  - Her hizmet, AI görselleriyle desteklenerek sunulur

- 🧑‍💼 **Kurumsal İçerikler**  
  - Ekip, Referanslar, Hakkımızda ve İletişim sayfaları

- 📊 **Gerçek Zamanlı Sosyal Medya Takibi**  
  - **Instagram** ve **Twitter takipçi sayıları**, RapidAPI üzerinden alınır  
  - Admin paneline gerek kalmadan doğrudan arayüzde gösterilir

---

## 🌍 Çok Dilli Altyapı

- 🇹🇷 Türkçe ve 🇬🇧 İngilizce dil desteği
- Tüm içerikler `.resx` dosyalarıyla kontrol edilir
- Dil seçimi, kullanıcı tarafından arayüzden yapılabilir
- Controller ve View seviyesinde dinamik olarak yönetilir

---

## 🔗 Entegrasyonlar ve Kullanılan Teknolojiler

| Teknoloji | Açıklama |
|----------|----------|
| 🧱 .NET MVC 4.7.2 | Web uygulama çatısı |
| 🗃️ Entity Framework (DB-First) | Mevcut veritabanından model üretimi |
| 🛢️ SQL Server | Veritabanı sistemi |
| 🎨 Bootstrap 5 | Responsive arayüz |
| ✨ jQuery | UI animasyon ve etkileşimleri |
| 💬 ChatGPT API | AI ile cevap üretimi (RapidAPI) |
| 🖼️ Hugging Face API | Metne göre görsel üretimi |
| 📲 Instagram & Twitter API | Takipçi bilgisi çekme (RapidAPI) |
| 👨‍💻 C# | Backend geliştirme dili |

---

## 🖼️ Proje Resimleri

## UI
|-----------------------------|
<img width="1904" height="910" alt="UISlider" src="https://github.com/user-attachments/assets/d44e4da3-cf96-43db-9fa7-1613eef1e2ab" />
<img width="1902" height="905" alt="UIServices" src="https://github.com/user-attachments/assets/02a74c34-78b0-4bcb-b1d5-54d6870ed884" />
<img width="1894" height="907" alt="UIServices2" src="https://github.com/user-attachments/assets/6b2f8a20-6cd6-4a65-ac4d-f5c2a3a0606d" />
<img width="1900" height="902" alt="UIAbout" src="https://github.com/user-attachments/assets/e9219c21-5a6f-4acf-be7f-06f8292e6aef" />
<img width="1894" height="907" alt="UIBlog" src="https://github.com/user-attachments/assets/62b21199-bb20-4169-b888-5ab23d020064" />
<img width="1898" height="906" alt="UIFAQ" src="https://github.com/user-attachments/assets/e45f57c4-d31d-4ae8-b488-b0216f88f6d8" />
<img width="1901" height="906" alt="UITeams" src="https://github.com/user-attachments/assets/0e84046e-47d1-4e02-9827-d162e0452580" />
<img width="1898" height="906" alt="UITestimonials" src="https://github.com/user-attachments/assets/dca99b92-1f81-4429-adad-b7cc0e0ba953" />
<img width="1896" height="814" alt="UIContact" src="https://github.com/user-attachments/assets/a6110f18-c1ff-409b-afcf-81a5e1f8cdca" />

## ADMIN PAGE
|-----------------------------|
<img width="1898" height="904" alt="AdminAbout" src="https://github.com/user-attachments/assets/e5dde86e-cd5e-4925-95cd-8bf4e77b2b84" />
<img width="1895" height="899" alt="AIImageGenerator" src="https://github.com/user-attachments/assets/5da7cb7e-0e12-4f7f-95c4-2e402a878c33" />
<img width="1916" height="906" alt="AdminFaq" src="https://github.com/user-attachments/assets/4dcb414e-6ed7-48d4-8396-b7b1cd007424" />
<img width="1910" height="892" alt="AdminFaq (2)" src="https://github.com/user-attachments/assets/d35efc6e-0414-4f36-b507-7f995e35a545" />
