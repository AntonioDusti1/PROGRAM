// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int ukupnaVrijednost = 0;

        while (ukupnaVrijednost < 31)
        {
            Console.Write("Unesite vrijednost karte (1 - 13): ");
            if (int.TryParse(Console.ReadLine(), out int vrijednostKarte))
            {
                if (vrijednostKarte < 1 || vrijednostKarte > 13)
                {
                    Console.WriteLine("Neispravna vrijednost karte. Unesite ponovno.");
                    continue;
                }

                ukupnaVrijednost += vrijednostKarte;
                Console.WriteLine($"Trenutna ukupna vrijednost karata: {ukupnaVrijednost}");
            }
            else
            {
                Console.WriteLine("Neispravan unos. Molimo unesite broj.");
            }
        }

        if (ukupnaVrijednost == 31)
        {
            Console.WriteLine("Pobijedili ste!");
        }
        else
        {
            Console.WriteLine("Izgubili ste. Ukupna vrijednost karata je veća od 31.");
        }

        Console.ReadLine(); // Ova linija služi da zadrži konzolu otvorenom nakon izvršenja programa.
    }
}
