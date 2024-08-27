//random sayi ürettirip list tanimladik
Random random = new Random();
List<int> numbers = new List<int>();
//10 adet random sayi üretildi listeye eklendi
for (int i = 0; i < 10; i++)
{
    int rndNumber = random.Next(-101, 101);
    numbers.Add(rndNumber);
}

//cift sayilar 
var evenNumbers = numbers.Where(x => x % 2 == 0);

foreach (int i in evenNumbers)
{
    Console.WriteLine(i);
}

Console.WriteLine("------------------");

//tek sayilar
var oddNumbers = numbers.Where(x => x % 2 != 0);

foreach (int odd in oddNumbers) {  Console.WriteLine(odd); }


//negativ sayilar
var negativeNumbers = numbers.Where(x => x < 0);

Console.WriteLine("--------------------");

foreach (int negative in negativeNumbers) {  Console.WriteLine(negative); }

Console.WriteLine("--------------------");


//positive sayilar
var positiveNumbers = numbers.Where(x => x >= 0);

foreach (int positive in positiveNumbers) { Console.WriteLine(positive); }

Console.WriteLine("------------------");

//15-22 arasi asayilar
var selectedNumbers = numbers.Where(x => (x > 15) && (x < 22));

foreach(int selected in selectedNumbers) { Console.WriteLine(selected); }

Console.WriteLine("----------------------------");

//sayilarin kareleri
List<int> squared = numbers.Select(x => x*x).ToList();
Console.WriteLine("Sayilarin kareleri: ");
foreach(int square in squared) {  Console.WriteLine(square); }
