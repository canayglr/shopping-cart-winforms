# 🛒 Shopping Cart & Admin Panel (C# WinForms)

**🇬🇧 English** · [🇹🇷 Türkçe](#alışveriş-sistemi-ve-admin-paneli-uygulaması)

A Windows Forms desktop app with a **shopping cart** for customers and an **admin panel** for managing products. It is built around OOP principles: `Urun` (product), `Sepet` (cart) and `Siparis` (order) classes, plus an `ISiparisVerilebilir` interface that handles **stock checks** before an order is placed.

- Add/remove items, live cart total, clear cart
- Order flow with per-item stock validation
- Admin panel: add & edit products; changes are reflected instantly in the shop UI
- Open `Proje.sln` in Visual Studio 2022 (.NET 9) and run

---

# Alışveriş Sistemi ve Admin Paneli Uygulaması
## Proje Genel Bakış
Bu Windows Forms uygulaması, temel bir e-ticaret sistemi ve yönetim panelinden oluşmaktadır. Uygulama üç ana arayüz (AdminPanel, Form1 ve UrunDuzenle) ve dört temel sınıf (Sepet, Siparis, Urun ve ISiparisVerilebilir arayüzü) üzerine inşa edilmiştir. Kullanıcılar ürünleri görüntüleyebilir, sepete ekleyebilir ve sipariş oluşturabilirken, yöneticiler ürün yönetimi yapabilmektedir.
## Ana Özellikler ve İş Akışı
### Kullanıcı Deneyimi (Form1)
Uygulama başlangıcında kullanıcıları ana alışveriş ekranı karşılamaktadır. Bu arayüzde:
* Ürün listesi ListBox içinde sunulur
* "Sepete Ekle" butonu seçili ürünü sepete ekler
* "Sepeti Temizle" tüm sepet içeriğini siler
* "Sepetten Çıkar" seçili ürünü sepetten kaldırır
* Sepete her ürün eklendiğinde/çıkarıldığında toplam tutar otomatik güncellenir
* "Sipariş Ver" butonu tıklandığında sistem ISiparisVerilebilir arayüzü üzerinden stok kontrolü yapar:
* StokVarMi() metodu stok durumunu kontrol eder
  * Yeterli stok varsa SiparisVer() metodu siparişi onaylar
  * Stok yetersizse ilgili ürün için hata mesajı gösterir

### Yönetim Paneli (AdminPanel)
Ürün yönetimi için tasarlanan bu arayüzde:
* Yöneticiler "Ürün Adı", "Ürün Fiyatı" ve "Ürün Stoğu" alanlarıyla yeni ürün ekleyebilir
* Eklenen her ürün Urun[] dizisinde depolanır
* Yapılan değişiklikler hem admin panelinde hem de ana arayüzdeki ListBox'larda anında güncellenir
* Ürün güncellemeleri sepetteki mevcut ürünleri de etkiler

### Sistem Mimarisi ve Arayüz Tasarımı
```
public interface ISiparisVerilebilir
{
    void SiparisVer();
    bool StokVarMi();
}

public class Siparis : ISiparisVerilebilir
{
    public void SiparisVer()
    {
        // Sipariş onaylama ve stok güncelleme işlemleri
    }

    public bool StokVarMi()
    {
        // Sepetteki ürünlerin stok kontrolünü yapar
        return true; // veya false
    }
}
```
* Ürün Sınıfı (Urun): Tüm ürün bilgilerini (ID, Ad, Fiyat, Stok) depolar
* Sepet Sınıfı: Ürün ekleme/çıkarma, temizleme ve toplam tutar hesaplama işlevlerini yönetir
* Sipariş Sınıfı: ISiparisVerilebilir arayüzünü uygulayarak stok kontrolü ve sipariş onaylama süreçlerini işler
* Tüm arayüzler gerçek zamanlı senkronizasyonla çalışır; birinde yapılan değişiklik diğerlerine anında yansır
### Nesne Yönelimli Tasarım Prensipleri
Proje, temel OOP prensiplerini şu şekilde uygular:
* Soyutlama (Abstraction):
  * ISiparisVerilebilir arayüzü sipariş işlemlerinin karmaşıklığını gizler
  *Kullanıcı sadece "Sipariş Ver" butonuyla etkileşime girer
* Kapsülleme (Encapsulation):
  * Urun sınıfı tüm ürün özelliklerini tek bir yapıda kapsüller
  * Sepet sınıfı sepete özel işlemleri dış dünyadan korur
* Kompozisyon (Composition):
  * Siparis sınıfı bir Sepet örneği oluşturur (sahip olma ilişkisi)
  * Sepet sınıfı Urun koleksiyonunu yönetir
* Arayüz Kullanımı (Interface Segregation):
  * ISiparisVerilebilir arayüzü sadece gerekli metodları tanımlar
  * Siparis sınıfı bu arayüzü eksiksiz uygular
