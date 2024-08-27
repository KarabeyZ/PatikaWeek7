using PratikPatikaflixDizilerPlatformu;


//listeler olusturuldu
List<Dizi> diziler = new List<Dizi>();
List<KomediDizi> komediDizileri = new List<KomediDizi>();
//döngü olusturarak kullanıcıdan sınırsız sayida giris aliniyor
while (true)
{
    Console.WriteLine("'1' Dizi Ekle");
    Console.WriteLine("'2' Tüm Dizileri Göster");
    Console.WriteLine("'3' Çıkış Yap");
    int input = Convert.ToInt32(Console.ReadLine());
    //switch case yapisiyla kullanicidan girdi aliniyor ve ona göre islem yapiliyor
    switch (input)
    {
        case 1:
            Dizi dizi = new Dizi();
            Console.WriteLine("Dizi adı giriniz: ");
            dizi.Name = Console.ReadLine();
            Console.WriteLine("Dizi yapım yılı giriniz: ");
            dizi.Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dizi türü giriniz: ");
            dizi.Genre = Console.ReadLine();
            Console.WriteLine("Dizi yönetmeni giriniz: ");
            dizi.Director = Console.ReadLine();
            Console.WriteLine("Dizi platformu giriniz: ");
            dizi.Platform = Console.ReadLine();
            //listeye eleman ekleniyor
            diziler.Add(dizi);
            //komedi dizileri yeni bir listeye ekleniyor
            komediDizileri = diziler.Where(x => x.Genre == "Komedi").Select(x => new KomediDizi
            {
                Name = x.Name,
                Genre = x.Genre,
                Director = x.Director,
            }).ToList();
                                                   
            break;
            //yazdirma islemi
        case 2:
            foreach (var d in diziler)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("Komedi Dizileri:");
            var sortedKomediDizileri = komediDizileri
                            .OrderBy(k => k.Name)
                            .ThenBy(k => k.Director)
                            .ToList();

            foreach (var kdizi in sortedKomediDizileri)
            {
                Console.WriteLine(kdizi);
            }
            break;
        case 3:
            return;
        default:
            Console.WriteLine("Geçersiz işlem yapildi");
            break;
    }
}

