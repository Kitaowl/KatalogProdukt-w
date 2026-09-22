using KatalogProduktów;
using Microsoft.Win32.SafeHandles;

Console.OutputEncoding = System.Text.Encoding.UTF8;

string[] nazwy = { "Procesor", "Pamięć RAM", "Dysk SSD", "Zasilacz", "Karta graficzna" };
double[] ceny = { 899.00, 249.50, 379.00, 189.99, 1599.99 };

//stwórz nowy obiekt procesor według definicji klasy Produkt
Produkt procesor = new Produkt();

procesor.Nazwa = "AMD Ryzen";
procesor.Cena = 899.00;
procesor.Kategoria = "Podzespoły";
procesor.Ilosc = 10;

Produkt ram = new Produkt
{
    Nazwa = "Pamięć RAM",
    Cena = 249.50,
    Kategoria = "Podzespoły",
    Ilosc = 20
};
Produkt ssd = new Produkt
{
    Nazwa = "Dysk SSD",
    Cena = 379.00,
    Kategoria = "Podzespoły",
    Ilosc = 15
};
Produkt zasilacz = new Produkt
{
    Nazwa = "Zasilacz",
    Cena = 189.99,
    Kategoria = "Podzespoły",
    Ilosc = 5
};

Produkt[] produkty = { procesor, ram, ssd, zasilacz };

//double minimalnaCena = 0;
//double sredniaCena = 0;
//double maksymalnaCena = 0;

//Polecenie: Sugerując się petlą foreach wypisaującą na ekranie produktu z katalogu zaimplementuj obliczanie najniższej,
//średniej i najwyższej cerny w katalogu - wypisz je na ekranie.

double sumOfPrices = 0;
double minimumPrice = double.MaxValue;
double maximumPrice = 0;

foreach (Produkt produkt in produkty)
{
    sumOfPrices += produkt.Cena;

    if (produkt.Cena < minimumPrice)
    {
        minimumPrice = produkt.Cena;
    }
    if (produkt.Cena > maximumPrice)
    {
        maximumPrice = produkt.Cena;
    }
    Console.WriteLine($"Nazwa: {produkt.Nazwa,-25}| Cena: {produkt.Cena,10:f2} zł | " + $"Kategoria: {produkt.Kategoria} | Ilość: {produkt.Ilosc,5}");
}

double averagePrice = sumOfPrices / produkty.Length;

Console.WriteLine($"Najniższa cena: {minimumPrice:f2} zł");
Console.WriteLine($"Średnia cena: {averagePrice:f2} zł");
Console.WriteLine($"Najwyższa cena: {maximumPrice:f2} zł");

//if(minimalnaCena < procesor.Cena)
//{
//    minimalnaCena = procesor.Cena;
//    Console.WriteLine(procesor.Cena);
//} else if(sredniaCena == procesor.Cena)
//{
//    sredniaCena = procesor.Cena;
//    Console.WriteLine(procesor.Cena);
//} else if (maksymalnaCena > procesor.Cena)
//{
//    maksymalnaCena = procesor.Cena;
//    Console.WriteLine(procesor.Cena);
//}
//double suma = 0;
//int licznik = 0;


//for (int i = 0; i < nazwy.Length; i++)
//{
//    // Do sumy trafiają tylko produkty droższe niż 200 zł
//    if (ceny[i] > 200)
//    {
//        suma = suma + ceny[i];
//        licznik++;
//    }
//}

//// Uwaga: przy pustym liczniku byłoby dzielenie przez zero
//double srednia = suma / licznik;
//Console.WriteLine($"Ilość produktów w bazie: {nazwy.Length}");
//Console.WriteLine($"Średnia cena: {srednia:F2} zł z {licznik} produktów");
//// "suma" po drugim obiegu wyniosła:
