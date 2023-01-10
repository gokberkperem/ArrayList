using System.Collections;

ArrayList liste = new ArrayList();
liste.Add("Ayşe");
liste.Add(2);
liste.Add(true);
liste.Add('A');

Console.WriteLine(liste[1]);

Console.WriteLine("=============");

foreach (var item in liste)
{
    Console.WriteLine(item);
}

Console.WriteLine("==================");

Console.Clear();

string[] renkler = { "Kırmızı", "Sarı", "Yeşil", "Mavi" };
List<int> sayilar = new List<int>() { 3, 24, 16, 48, 1, 5, 8, 12, 18, 20 };
liste.AddRange(renkler);
liste.AddRange(sayilar);

foreach (var item in liste)
{
    Console.WriteLine(item);
}

Console.WriteLine("==================");

liste.Sort();

foreach (var item in liste)
{
    Console.WriteLine(item);
}

