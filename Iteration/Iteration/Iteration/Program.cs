using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // -------------------------------- Ask user to answer questions, store the answer in an array and display each answer --------------------------------

        string[] favs = { "My favorite beer is: ", "My favorite cocktail is: ", "My favorite soda is: ", "My favorite snack is: " };

        Console.WriteLine("\nPlease answer the following questions- ");

        for (int i = 0; i <= favs.Length - 1; i++)
        {
            Console.WriteLine(favs[i]);
            string answer = Console.ReadLine();
            favs[i] = favs[i] + answer;
        }

        for (int i = 0; i < favs.Length; i++)
        {
            Console.WriteLine(favs[i]);
        }
        // -------------------------------- Create an array of sodas and let user search for one and retrieve the index number if it exists --------------------------------

        var sodas = new List<string>()
        {
            "pepsi",
            "dr. pepper",
            "mt. dew",
            "root beer"
        };

        Console.WriteLine("\nPlease enter a soda to search for:");
        string soda_search = Console.ReadLine();

        string soda_check = soda_search.ToLower();

        for (int i = 0; i < sodas.Count; i++)
        {
            if (String.Equals(sodas[i], soda_check))
            {
                Console.WriteLine("The index number of your soda is " + i + ".");
                break;
            }
            else
            {
                Console.WriteLine("Sorry, that soda is unavailable.");
                break;
            }
        }
        // -------------------------------- Create a list of snacks and let user search for one and retrieve the index number if it exists --------------------------------

        var snacks = new List<string>()
        {
            "doritos",
            "doritos",
            "fritos",
            "doritos",
            "popcorn",
            "popcorn"
        };

        var snack_matches = new List<int>();

        Console.WriteLine("\nPlease enter a snack to search for:");
        string snack_search = Console.ReadLine();

        string snack_check = snack_search.ToLower();

        for (int i = 0; i < snacks.Count; i++)
        {
            if (String.Equals(snacks[i], snack_check))
            {
                snack_matches.Add(i);
            }
        }

        if (snack_matches.Count == 0)
        {
            Console.WriteLine("\nSorry, that snack is not available.");
        }

        else if (snack_matches.Count == 1)
        {
            Console.WriteLine("\nThe index number of your snack is " + snack_matches[0] + ".\n");
        }

        else if (snack_matches.Count == 2)
        {
            Console.WriteLine("\nThere are two indexes that match that snack: " + snack_matches[0] + " and " + snack_matches[1] + ".");
        }

        else
        {
            Console.Write("\nThere are multiple indexes that match that snack: ");

            for (int i = 0; i < snack_matches.Count - 1; i++)
            {
                Console.Write(snack_matches[i] + ", ");
            }

            int last = snack_matches.Count;

            Console.Write("and " + snack_matches[Convert.ToInt32(last) - 1] + ".");
        }

        Console.WriteLine("\nPlease press enter to see how many times each snack appears on the list.");
        Console.ReadLine();

        // -------------------------------- Foreach loop to count how often an item is on the list --------------------------------
        foreach (string item in snacks)
        {
            int item_count = 0;
            for (int i = snacks.Count; i > 0; i--)
            {
                if (String.Equals(snacks[i-1], item))
                {
                    item_count++;
                }
            }
            Console.WriteLine(item + " appears " + item_count + " times in this list.");
        }

        Console.WriteLine("\nPlease press enter to exit.");
        Console.ReadLine();
    }
}