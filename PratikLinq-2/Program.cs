using PratikPatikafy;

List<Person> singers = new List<Person>();
singers.Add(new Person { Name = "Ajda Pekkan", Genre = "Pop", Year = 1968, Sale = 20 });
singers.Add(new Person { Name = "Sezen Aksu", Genre = "Türk Halk Müziği / Pop", Year = 1971, Sale = 10 });
singers.Add(new Person { Name = "Funda Arar", Genre = "Pop", Year = 1999, Sale = 3 });
singers.Add(new Person { Name = "Sertab Erener", Genre = "Pop", Year = 1994, Sale = 5 });
singers.Add(new Person { Name = "Sıla", Genre = "Pop", Year = 2009, Sale = 3 });
singers.Add(new Person { Name = "Serdar Ortaç", Genre = "Pop", Year = 1994, Sale = 10 });
singers.Add(new Person { Name = "Tarkan", Genre = "Pop", Year = 1992, Sale = 40 });
singers.Add(new Person { Name = "Hande Yener", Genre = "Pop", Year = 1999, Sale = 7 });
singers.Add(new Person { Name = "Hadise", Genre = "Pop", Year = 2005, Sale = 5 });
singers.Add(new Person { Name = "Gülben Ergen", Genre = "Pop / Türk Halk Müziği", Year = 1997, Sale = 10 });
singers.Add(new Person { Name = "Neşet Ertaş", Genre = "Türk Halk Müziği / Türk Sanat Müziği", Year = 1960, Sale = 2 });

foreach (Person singer in singers) { Console.WriteLine(singer); }

Console.WriteLine("-------------");

foreach (var item in singers.Where(x => x.Name.StartsWith("S")))
{
    Console.WriteLine(item);
}

Console.WriteLine("-----------------");


Console.WriteLine("Albüm Satislari 10 Milyonun üzerinde olanlar: ");
foreach (var singer in singers.Where(x => x.Sale > 10))
{
    Console.WriteLine(singer);
}

Console.WriteLine("-------------------");

var group = singers.Where(x => x.Sale < 2000 && x.Genre == "Pop")
                    .GroupBy(x => x.Year)
                    .OrderBy(x => x.Key)
                    .Select(x => new
                    {
                        Year = x.Key,
                        singers = x.OrderBy(x => x.Name)

                    })
;

foreach(var grouped in group)
{
    Console.WriteLine($"Year: {grouped.Year}");
    foreach(var singer in grouped.singers)
    {
        Console.WriteLine($" - {singer.Name}");
    }
}

Console.WriteLine("----------------");

var topSellingSinger = singers
                       .OrderByDescending(x => x.Sale)
                       .FirstOrDefault();
Console.WriteLine(topSellingSinger);

Console.WriteLine("-------------------");

var oldSinger = singers.OrderBy(x => x.Year)
                       .FirstOrDefault();
var newSinger = singers.OrderByDescending(x => x.Year)
                       .FirstOrDefault();

Console.WriteLine($"En yeni çıkış yapan şarkıcı: {newSinger}\nEn eski çıkış yapan şarkıcı: {oldSinger}");