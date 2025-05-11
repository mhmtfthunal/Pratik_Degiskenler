Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz...");
Console.Write("T.C Kimlik Numarası:");
string tcKimlikNo = Console.ReadLine();

Console.Write("Adı:");
string adi = Console.ReadLine();

Console.Write("Soyadı:");
string soyAdi = Console.ReadLine();

Console.Write("Telefon Numarası:");
string telefonNumarasi = Console.ReadLine(); // Matematiksel bir işlem olmayacağından string veri tipi kullandım.

Console.Write("Yaş:");
byte yas = Convert.ToByte(Console.ReadLine());

Console.Write("İlk Ürün Fiyatı:");

double ilkFiyat = Convert.ToDouble(Console.ReadLine()); // double veri tipini kullandım. Sebebi ise sayısal değer ile matematiksel hesaplama yapmam gerekiyor. Yazılan string ifadeyi burada convert ediyoruz.

Console.Write("İkinci Ürün Fiyatı:");

double ikinciFiyat = Convert.ToDouble(Console.ReadLine()); // double veri tipini kullandım. Sebebi ise sayısal değer ile matematiksel hesaplama yapmam gerekiyor. Yazılan string ifadeyi burada convert ediyoruz.
double urunFiyatToplam = ilkFiyat + ikinciFiyat;
double puanMiktari = urunFiyatToplam * 10 / 100;

Console.WriteLine("-----------------------------------------------");

Console.WriteLine($"{tcKimlikNo} T.C. Kimlik Numaralı {adi} {soyAdi} isimli kişi için kayıt oluşturulmuştur.");
Console.WriteLine($"{telefonNumarasi} telefon numarasına bildirim mesajı gönderilmiştir.");
Console.WriteLine($"{urunFiyatToplam} toplam harcama karşılığı kazanılan %10 patika puan miktarı {puanMiktari} TL'dir.");