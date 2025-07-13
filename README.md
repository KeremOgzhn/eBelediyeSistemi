# e-Belediye Yönetim Sistemi (Masaüstü Uygulaması)

![C#](https://img.shields.io/badge/dil-C%23-blueviolet.svg)
![Database](https://img.shields.io/badge/veritabanı-MS%20SQL-red.svg)
![Platform](https://img.shields.io/badge/platform-Windows-blue.svg)

Bu proje, staj dönemi içerisinde **C# Windows Forms** ve **MS SQL Server** kullanılarak geliştirilmiş bir e-Belediye yönetim sistemi masaüstü uygulamasıdır. Proje, belediyecilik hizmetlerinin dijital ortamda yönetilmesini ve takip edilmesini amaçlamaktadır.

---

## 📖 İçindekiler

- [Proje Hakkında](#-proje-hakkında)
- [✨ Temel Özellikler](#-temel-özellikler)
- [🛠️ Teknoloji ve Mimarisi](#-teknoloji-ve-mimarisi)
- [🚀 Başlarken](#-başlarken)
  - [Gereksinimler](#gereksinimler)
  - [Kurulum Adımları](#kurulum-adımları)
- [👤 İletişim](#-iletişim)

---

## 📝 Proje Hakkında

**e-Belediye Yönetim Sistemi**, vatandaş bilgilerini kaydetme, borç sorgulama, ödeme işlemleri ve talep/şikayet yönetimi gibi temel belediyecilik fonksiyonlarını dijitalleştiren bir masaüstü uygulamasıdır. Bu proje, veri yönetimi, veritabanı işlemleri ve masaüstü uygulama geliştirme yetkinliklerini sergilemek amacıyla staj kapsamında geliştirilmiştir.

---

## ✨ Temel Özellikler

- **Vatandaş Yönetimi:** Vatandaş bilgilerini ekleme, silme, güncelleme ve arama (CRUD) işlemleri.
- **Borç Sorgulama:** Vatandaşların TC kimlik numarası ile vergi, su vb. borçlarını sorgulama.
- **Tahsilat ve Ödeme:** Borç ödeme işlemlerini kaydetme ve makbuz oluşturma.
- **Talep/Şikayet Yönetimi:** Vatandaşlardan gelen talep ve şikayetleri kaydetme ve durumlarını takip etme.
- **Kullanıcı Girişi:** Yetkilendirilmiş personel için güvenli giriş sistemi.

---

## 🛠️ Teknoloji ve Mimarisi

- **Programlama Dili:** **C#**
- **Platform:** **.NET Framework (Windows Forms)**
- **Veritabanı:** **Microsoft SQL Server (MS SQL)**
- **Veri Erişimi:** **ADO.NET** kullanılarak veritabanı bağlantısı ve işlemleri.
- **Mimari Yaklaşım:** 3 Katmanlı Mimari (Veri Erişim Katmanı, İş Mantığı Katmanı, Sunum Katmanı) prensiplerine uygun bir yapı hedeflenmiştir.

---

## 🚀 Başlarken

Projeyi yerel makinenizde kurup çalıştırmak için aşağıdaki adımları izleyebilirsiniz.

### Gereksinimler

- **Visual Studio** 2019 veya üzeri
- **.NET Framework** 4.7.2 veya üzeri
- **Microsoft SQL Server** ve **SQL Server Management Studio (SSMS)**

### Kurulum Adımları

1.  **Depoyu Klonlayın:**
    ```bash
    git clone https://github.com/KeremOgzhn/eBelediyeSistemi.git
    ```
2.  **Veritabanını Kurun:**
    - Proje içerisindeki `.sql` uzantılı veritabanı script'ini veya `.bak` dosyasını SSMS kullanarak kendi SQL Server'ınıza yükleyin.
3.  **Projeyi Visual Studio'da Açın:**
    - `eBelediyeSistemi.sln` dosyasını Visual Studio ile açın.
4.  **Veritabanı Bağlantısını Yapılandırın:**
    - Proje içerisindeki `App.config` veya veritabanı bağlantısının yapıldığı sınıftaki **Connection String**'i kendi SQL Server bilgilerinize göre güncelleyin.
5.  **Uygulamayı Derleyin ve Çalıştırın:**
    - Visual Studio'da **Start (F5)** butonuna basarak projeyi başlatın.

---

## 👤 İletişim

Kerem Oğuzhan - [@KeremOgzhn](https://github.com/KeremOgzhn)

Proje Linki: [https://github.com/KeremOgzhn/eBelediyeSistemi](https://github.com/KeremOgzhn/eBelediyeSistemi)
