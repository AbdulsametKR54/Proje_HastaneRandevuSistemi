# 🏥 Proje_HastaneRandevuSistemi

**Proje_HastaneRandevuSistemi**, hastaların doktorlara randevu alabildiği, doktorların kendi randevularını yönetebildiği ve sekreterlerin sistem genelinde randevu organizasyonunu sağladığı **C# Windows Forms (WinForms)** tabanlı bir **masaüstü hastane randevu sistemidir**.

Proje, **rol bazlı yetkilendirme**, **veritabanı işlemleri** ve **katmanlı yapı mantığını** masaüstü uygulamalar üzerinde uygulamak amacıyla geliştirilmiştir.

---

## 🚀 Kullanılan Teknolojiler

- **Platform:** Windows Desktop  
- **Uygulama Türü:** Windows Forms (WinForms)  
- **Programlama Dili:** C#  
- **Veritabanı:** MS SQL Server  
- **Veri Erişimi:** ADO.NET / Entity Framework *(projeye göre)*  
- **Mimari Yaklaşım:** Katmanlı yapı (Form / Business / Data)  
- **Versiyon Kontrol:** Git & GitHub  

---

## 👥 Kullanıcı Rolleri ve Yetkiler

### 👤 Hasta
- Sisteme kayıt olma ve giriş yapma
- Doktor ve branş listeleme
- Uygun tarih ve saate göre randevu alma
- Mevcut randevularını görüntüleme ve iptal etme

### 🩺 Doktor
- Kendisine ait randevuları listeleme
- Randevu detaylarını görüntüleme
- Randevu durumlarını güncelleme (Onaylandı / Tamamlandı)

### 🧾 Sekreter
- Doktor ve hasta adına randevu oluşturma
- Günlük / haftalık randevu takibi
- Randevu düzenleme ve iptal işlemleri
- Sistem akışının düzenli ilerlemesini sağlama
