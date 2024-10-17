
using System;

using System.Collections.Generic;

class Program

{

    static List<string> inventory = new List<string>();
    

    static void Main(string[] args)

    {

        Console.WriteLine("Välkommen till Fabrikshanteringssystemet!");

       

        while (true)

        {

            Console.WriteLine("\nVälj en åtgärd:");

            Console.WriteLine("1. Lägg till produkt");

            Console.WriteLine("2. Visa inventarie");

            Console.WriteLine("3. Ta bort produkt");

            Console.WriteLine("4. Söka");

            Console.WriteLine("5. Avsluta");



            string? val = Console.ReadLine();

            switch (val)

            {

                case "1":

                    LäggTillProdukt();

                    break;

                case "2":

                    VisaInventarie();

                    break;

                case "3":
                    TaBortProdukt();
                    break;
                
                case "4":
                    SearchProduct();
                    break;

                    case "5":


                    return;

                default:

                    Console.WriteLine("Ogiltigt val. Försök igen.");

                    break;

            }

        }

    }

    static void LäggTillProdukt()
    {
        // TODO: Implementera metod för att lägga till produkt 

        Console.Write("Ange product att lägga till: ");
        String productTillägg = Console.ReadLine();
        inventory.Add(productTillägg);  
    }

    static void VisaInventarie()

    {
        // TODO: Implementera metod för att visa inventarie 
        // kollar om det finns något i inventariet
        if (inventory.Count > 0)
        {
            // om det finns något kommer denna kod att köras och allt som finns i listan kommer skrivas ut
            Console.WriteLine("Detta finns i inventariet:");
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine(inventory[i]);
            }
        }
        // om det inte finns något i listan eller inventariet kommer texten skrivas ut
        else
        {
            Console.WriteLine("Det finns inget i inventariet!");
        }

    }

    static void SearchProduct()
    {
        Console.WriteLine("Vilken produkt vill du söka efter?");
        String? search = Console.ReadLine();

        bool found = false;
        for (int i = 0;i < inventory.Count; i++)
        {
            if (inventory[i] == search)
            {
                Console.WriteLine($"{search} hittades i inventariet");
                found = true;
                break;
            }

        }
        if (found == false)
        {
            Console.WriteLine("Produkten hittades inte");
        }

    }

    static void TaBortProdukt()
    {
        Console.WriteLine("Skriv den produkt du vill ta bort");
        string search = Console.ReadLine();

        bool found = false;
        for (int i = 0; i < inventory.Count; i++)
        {
            if (inventory[i].Contains(search))
            {
                inventory[i].Remove(i);
                found = true;
            }
        }
        if(found == false)
        {
            Console.WriteLine("Produkten du försöker ta bort existerar inte");
        }

    }

}