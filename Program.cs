﻿
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

            Console.WriteLine("4. Avsluta");



            string val = Console.ReadLine();

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

    }

    static void VisaInventarie()

    {

        // TODO: Implementera metod för att visa inventarie 

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