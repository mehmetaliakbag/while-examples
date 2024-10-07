#region Practices1

// Girilen girdiyi konsol ekranına 10 kere yazdıracak.

int counter = 1;

while(counter <= 10)
{
    Console.WriteLine($"{counter} - Kendime inanıyorum, ben bu yazılım işini hallederim!");
    counter++;
}


Console.WriteLine("\n----------\n");

#endregion

#region Practices2

// 1 ile 20 arasındaki sayıları konsol ekranına yazdırecak

int counter1 = 1;

while(counter1 <= 20)
{
    Console.WriteLine(counter1);
    counter1++;
}

Console.WriteLine("\n----------\n");

#endregion

#region Practices3

// 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

int counter2 = 1;

while(counter2 <= 20)
{
    if(counter2 % 2 == 0)
    {
        Console.WriteLine(counter2);
    }
    counter2++;
}

Console.WriteLine("\n----------\n");

#endregion

#region Practices4

// 50 ile 150 arasındaki sayıların toplamını ekrana yazdırıcak.

int counter3 = 50;

int total = 0;

while(counter3 <= 150)
{
    total += counter3;
    counter3++;
}

Console.WriteLine($"50 ile 150 arası sayıların toplamı: {total}");

Console.WriteLine("\n----------\n");

#endregion

#region Practices5

// 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırın

int counter4 = 1;

int doubleTotal = 0;

int singleTotal = 0;

while(counter4 <= 120)
{
    if(counter4 % 2 == 0)
    {
        doubleTotal += counter4;
    }
    else
    {
        singleTotal += counter4;
    }

    counter4++;
}

Console.WriteLine($"1 ile 120 arası çift sayıların toplamı: {doubleTotal}" +
                  $"\n1 ile 120 arası tek sayıların toplamı: {singleTotal}");

#endregion