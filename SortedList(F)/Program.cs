using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        SortedList<string, string> playerList = new SortedList<string, string>
        {
            {"P1", "Chris"},
            {"P2", "James"},
            {"P3", "Mark"},
            {"P4", "Ethan"},
            {"P5", "Brad"}
        };

   
        Console.WriteLine("Player List:");
        foreach (KeyValuePair<string, string> player in playerList)
        {
            Console.WriteLine($"{player.Key}: {player.Value}");
        }


        string addKey;
        string addValue;
        while (true)
        {
            Console.Write("\nEnter a player key (e.g., 'P6'): ");
            addKey = Console.ReadLine();
            Console.Write("Enter a player name to add: ");
            addValue = Console.ReadLine();

            if (!playerList.ContainsKey(addKey) && !playerList.ContainsValue(addValue))
            {
                playerList.Add(addKey, addValue);
                Console.WriteLine($"Player {addValue} added with key {addKey}.");
                break;
            }
            else
            {
                if (playerList.ContainsKey(addKey))
                {
                    Console.WriteLine($"Key {addKey} already exists.");
                }
                if (playerList.ContainsValue(addValue))
                {
                    Console.WriteLine($"Player name {addValue} is already in use.");
                }
                Console.WriteLine("Please enter a unique key and player name.");
            }
        }

        
        string removeKey;
        while (true)
        {
            Console.Write("\nEnter a player key to remove (e.g., 'P3'): ");
            removeKey = Console.ReadLine();

            if (playerList.ContainsKey(removeKey))
            {
                playerList.Remove(removeKey);
                Console.WriteLine($"Player with key {removeKey} removed.");
                break;
            }
            else
            {
                Console.WriteLine($"Key {removeKey} does not exist. Please enter a valid key.");
            }
        }

        
        Console.WriteLine("\nUpdated Player List:");
        foreach (KeyValuePair<string, string> player in playerList)
        {
            Console.WriteLine($"{player.Key}: {player.Value}");
        }
    }
}
