Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz:");

Console.Write("T.C Kimlik Numarası:");

string tcKimlikNo = Console.ReadLine();

Console.Write("Adı:");

string adi = Console.ReadLine();

Console.Write("Soyadı:");

string soyAdi = Console.ReadLine();

Console.Write("Telefon Numarası:");

string telefonNumarasi = Console.ReadLine(); // Telefon numarası değerini metinsel değer olarak string aldım.

Console.Write("Yaş:");

string yas = Console.ReadLine();

Console.Write("İlk Ürün Fiyatı:");

int ilkFiyat = Convert.ToInt32(Console.ReadLine()); // int veri tipini kullandım. Sebebi ise sayısal değer ile matematiksel hesaplama yapmam gerekiyor. Yazılan string ifadeyi burada convert ediyoruz.

Console.Write("İkinci Ürün Fiyatı:");

int ikinciFiyat = Convert.ToInt32(Console.ReadLine()); // int veri tipini kullandım. Sebebi ise sayısal değer ile matematiksel hesaplama yapmam gerekiyor. Yazılan string ifadeyi burada convert ediyoruz.

int urunFiyatToplam = ilkFiyat + ikinciFiyat;

int puanMiktari = urunFiyatToplam * 10 / 100;

Console.WriteLine("-----------------------------------------------");

Console.WriteLine($"{tcKimlikNo} T.C. Kimlik Numaralı {adi} {soyAdi} isimli kişi için kayıt oluşturulmuştur.");

Console.WriteLine($"{telefonNumarasi} telefon numarasına bildirim mesajı gönderilmiştir.");

Console.WriteLine($"{urunFiyatToplam} toplam harcama karşılığı kazanılan %10 patika puan miktarı {puanMiktari} TL'dir.");