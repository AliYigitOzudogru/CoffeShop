# ☕ Coffee Shop Simulation Game

<div align="center">

**[🇬🇧 English](#-english) | [🇹🇷 Türkçe](#-türkçe)**

</div>

---

## 🇬🇧 English

### 📖 Description

A console-based coffee shop management simulation game developed in C#. Manage your virtual coffee shop, handle inventory, serve customers, and grow your business day by day!

### ✨ Features

- 💰 **Budget Management** - Start with 100Z capital and grow your business
- ☕ **Coffee Operations**
  - Buy coffee packages (5Z per package, 3 shots each)
  - Brew fresh coffee (5 cups per shot)
  - Sell coffee cups (2Z per cup)
- 🥐 **Croissant Operations**
  - Buy croissant packages (10Z per package, 5 croissants each)
  - Open packages and display on tray
  - Sell croissants (3Z each)
- 📅 **Day Cycle System**
  - Minimum 3 orders before ending the day
  - Maximum 6 orders per day
  - Auto end-of-day after reaching max orders
  - Fresh coffee expires at end of day
  - Croissant tray clears every 2 days
- 🎮 **Game Mechanics**
  - Real-time inventory tracking
  - Order validation system
  - Budget constraint checks
  - Daily progress tracking

### 🎯 Game Rules

**Coffee System:**
- Each package contains 3 shots
- Each shot brews 5 fresh cups
- Fresh coffee becomes stale at end of day
- Coffee machine is cleaned daily

**Croissant System:**
- Each package contains 5 individual croissants
- Croissants must be displayed on tray before selling
- Tray is cleaned every 2 days

**Daily Operations:**
- Minimum 3 orders required to end the day
- Maximum 6 orders allowed per day
- Selling operations count as orders
- Day automatically ends after 6 orders

### 🚀 Installation

1. Clone the repository:
```bash
git clone https://github.com/AliYigitOzudogru/CoffeShop.git
```

2. Navigate to project folder:
```bash
cd CoffeShop
```

3. Open the project in your C# IDE (Visual Studio, Rider, etc.)

4. Build and run the application

### 🎮 How to Play

**Main Menu Options:**

1. **Buy coffee package** - Purchase coffee supplies
2. **Brew coffee** - Make fresh coffee from shots
3. **Sell cup(s) of coffee** - Serve customers coffee
4. **Buy packages of Croissant** - Purchase croissant supplies
5. **Open 1 package of Croissant** - Display croissants on tray
6. **Sell Croissant(s)** - Serve customers croissants
7. **End of the Day >** - Close shop and start new day
8. **Quit Game** - Exit and see final budget

**Tips:**
- Manage your budget carefully
- Keep track of inventory
- Balance between coffee and croissant sales
- Plan your purchases wisely
- Remember fresh coffee expires daily!

### 🛠️ Technical Details

- **Language:** C#
- **Type:** Console Application
- **Data Types:** Uses `long` for all numeric values (as per assignment requirements)
- **Architecture:** Procedural programming without arrays
- **Platform:** .NET Framework / .NET Core

### 🎓 Academic Note

This is an educational project created for academic purposes.

### 👤 Developer

**Ali Yigit Ozudogru**

- GitHub: [@AliYigitOzudogru](https://github.com/AliYigitOzudogru)

---

## 🇹🇷 Türkçe

### 📖 Açıklama

C# ile geliştirilmiş konsol tabanlı kahve dükkanı yönetim simülasyon oyunu. Sanal kahve dükkanınızı yönetin, envanter kontrolü yapın, müşterilere hizmet verin ve işinizi gün be gün büyütün!

### ✨ Özellikler

- 💰 **Bütçe Yönetimi** - 100Z sermaye ile başlayın ve işinizi büyütün
- ☕ **Kahve İşlemleri**
  - Kahve paketi satın alın (paket başı 5Z, her pakette 3 shot)
  - Taze kahve demleme (shot başı 5 fincan)
  - Kahve fincanı satışı (fincan başı 2Z)
- 🥐 **Kruvasan İşlemleri**
  - Kruvasan paketi satın alın (paket başı 10Z, her pakette 5 kruvasan)
  - Paketleri açın ve tepsiye yerleştirin
  - Kruvasan satışı (adet başı 3Z)
- 📅 **Günlük Döngü Sistemi**
  - Günü bitirmeden önce minimum 3 sipariş
  - Günde maksimum 6 sipariş
  - Maksimum sipariş sayısına ulaşınca otomatik gün sonu
  - Taze kahve gün sonunda bayatlar
  - Kruvasan tepsisi her 2 günde bir temizlenir
- 🎮 **Oyun Mekanikleri**
  - Gerçek zamanlı envanter takibi
  - Sipariş doğrulama sistemi
  - Bütçe kontrolü
  - Günlük ilerleme takibi

### 🎯 Oyun Kuralları

**Kahve Sistemi:**
- Her paket 3 shot içerir
- Her shot 5 taze fincan demler
- Taze kahve gün sonunda bayatlar
- Kahve makinesi her gün temizlenir

**Kruvasan Sistemi:**
- Her paket 5 adet kruvasan içerir
- Kruvasanlar satıştan önce tepsiye yerleştirilmelidir
- Tepsi her 2 günde bir temizlenir

**Günlük İşlemler:**
- Günü bitirmek için minimum 3 sipariş gereklidir
- Günde maksimum 6 sipariş verilebilir
- Satış işlemleri sipariş olarak sayılır
- 6 siparişten sonra gün otomatik kapanır

### 🚀 Kurulum

1. Depoyu klonlayın:
```bash
git clone https://github.com/AliYigitOzudogru/CoffeShop.git
```

2. Proje klasörüne gidin:
```bash
cd CoffeShop
```

3. Projeyi C# IDE'nizde açın (Visual Studio, Rider, vb.)

4. Uygulamayı derleyin ve çalıştırın

### 🎮 Nasıl Oynanır

**Ana Menü Seçenekleri:**

1. **Buy coffee package** - Kahve malzemesi satın al
2. **Brew coffee** - Shot'lardan taze kahve demle
3. **Sell cup(s) of coffee** - Müşterilere kahve sat
4. **Buy packages of Croissant** - Kruvasan malzemesi satın al
5. **Open 1 package of Croissant** - Kruvasanları tepsiye yerleştir
6. **Sell Croissant(s)** - Müşterilere kruvasan sat
7. **End of the Day >** - Dükkanı kapat ve yeni güne başla
8. **Quit Game** - Çık ve final bütçeyi gör

**İpuçları:**
- Bütçenizi dikkatli yönetin
- Envanteri takip edin
- Kahve ve kruvasan satışları arasında denge kurun
- Satın almalarınızı akıllıca planlayın
- Taze kahvenin her gün bayatladığını unutmayın!

### 🛠️ Teknik Detaylar

- **Dil:** C#
- **Tür:** Konsol Uygulaması
- **Veri Tipleri:** Tüm sayısal değerler için `long` kullanılmıştır (ödev gereksinimlerine göre)
- **Mimari:** Dizi kullanılmadan prosedürel programlama
- **Platform:** .NET Framework / .NET Core

### 🎓 Akademik Not

Bu, akademik amaçlarla oluşturulmuş eğitim projesidir.

### 👤 Geliştirici

**Ali Yigit Ozudogru**

- GitHub: [@AliYigitOzudogru](https://github.com/AliYigitOzudogru)

---

<div align="center">

⭐ If you liked this project, please give it a star! / Bu projeyi beğendiyseniz, lütfen yıldız verin!

**Academic Project - Educational Purpose Only**

</div>
