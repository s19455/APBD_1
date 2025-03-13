// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello Jurassic World 3");

public static double ObliczSrednia(int[] liczby)
{
    double sum = 0;
    foreach (var liczba in liczby)
    {
        sum += liczba;
    }
    return sum / liczby.Length;
}


public static int ZnajdzMaksymalnaWartosc(int[] liczby)
{
    return liczby.Max();
}

