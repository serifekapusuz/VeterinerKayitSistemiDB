# VeterinerKayitSistemiDB

# 🐾 Veteriner Kliniği Kayıt Sistemi
Bu proje, küçük ve orta ölçekli veteriner kliniklerinin hasta kayıtlarını, randevularını, tedavi ve aşı süreçlerini dijital olarak yönetebilmesi amacıyla geliştirilmiştir. Windows Forms ve SQL Server kullanılarak yapılmıştır.

## 📌 Proje Özeti

**Amaç:** Hayvan sahiplerinin, hayvanların, randevuların, tedavi ve aşı kayıtlarının dijital ortamda yönetimini sağlamak.

**Teknolojiler:**
- 👨‍💻 C# (Windows Forms - .NET Framework)
- 🗄️ Microsoft SQL Server
- 💻 SQL Server Management Studio
- 🧰 Visual Studio 2022

---

## 🧩 Veritabanı Tasarımı

Aşağıdaki tablolar kullanılmıştır:

| Tablo        | Açıklama                         |
|--------------|----------------------------------|
| `Musteri`    | Hayvan sahibi bilgileri          |
| `Hayvan`     | Hayvan bilgileri                 |
| `Veteriner`  | Klinik çalışan bilgileri         |
| `Randevu`    | Randevu tarihi, açıklama vb.     |
| `Tedavi`     | Uygulanan tedavi ve ücret        |
| `Asi`        | Aşı adı, tarihi ve sonrası       |

### 🔗 İlişkiler
- Her `Hayvan`, bir `Musteri`'ye bağlıdır.
- Her `Randevu`, bir `Hayvan` ve bir `Veteriner` ile ilişkilidir.
- Her `Tedavi`, bir `Randevu`ya bağlıdır.
- Her `Asi`, bir `Hayvan`a aittir.

---

## 💻 Özellikler

- ✅ Müşteri kayıt ekleme / listeleme / silme
- ✅ Hayvan kayıtlarını müşteriyle ilişkilendirme
- ✅ Veteriner bilgilerini kaydetme
- ✅ Hayvan ve veteriner seçerek randevu oluşturma
- ✅ Randevuya bağlı tedavi ekleme
- ✅ Aşı kaydı oluşturma ve sonraki tarih planlama
- ✅ Tek bir Windows Form üzerinde sekmeli (TabControl) yapı


## Notlar
Projede TabControl ile tüm işlemler tek form üzerinden yapılmaktadır.

Her sekmede ilgili tabloya ait: ekle, sil, listele işlemleri yapılabilmektedir.

Aşı ve tedavi için ComboBox'lar ile hayvan seçimleri yapılır.

Tüm işlemler SqlParameter ile güvenli biçimde yapılmıştır.


