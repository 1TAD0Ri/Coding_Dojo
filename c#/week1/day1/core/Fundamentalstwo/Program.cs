// Dictionary<int,string> Ninjas= new Dictionary<int, string>();

// Ninjas.Add(01,"Naruto");
// Ninjas.Add(02,"Sasuke");
// Ninjas.Add(03,"Boruto");
// Ninjas.Add(04,"Sadara");

// System.Console.WriteLine("The ninja with id 1his name is " + Ninjas[01]);


// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         // Creating a dictionary with string keys and integer values
//         Dictionary<string, int> myDict = new Dictionary<string, int>
//         {
//             {"apple", 3},
//             {"banana", 8},
//             {"cherry", 2},
//             {"date", 10},
//             {"elderberry", 4}
//         };

//         // Looping through the dictionary to print values greater than 5
//         Console.WriteLine("Values greater than 5:");
//         foreach (var kvp in myDict)
//         {
//             if (kvp.Value > 5)
//             {
//                 Console.WriteLine(kvp.Value);
//             }
//         }

//         // Trying to add a new entry with an existing key
//         try
//         {
//             myDict.Add("banana", 12);
//         }
//         catch (ArgumentException ex)
//         {
//             Console.WriteLine($"Error: {ex.Message}. Key already exists!");
//         }

//         // Creating a dictionary with values as lists of integers
//         Dictionary<string, List<int>> myDictWithLists = new Dictionary<string, List<int>>
//         {
//             {"list1", new List<int> {1, 2, 3}},
//             {"list2", new List<int> {4, 5, 6}},
//             {"list3", new List<int> {7, 8, 9}}
//         };

//         // Removing an entry from the dictionary
//         string keyToRemove = "list2";
//         if (myDictWithLists.ContainsKey(keyToRemove))
//         {
//             myDictWithLists.Remove(keyToRemove);
//             Console.WriteLine($"Entry with key '{keyToRemove}' removed.");
//         }
//         else
//         {
//             Console.WriteLine($"Key '{keyToRemove}' not found.");
//         }

//         // Removing all entries from the dictionary
//         myDictWithLists.Clear();
//         Console.WriteLine("All entries removed from the dictionary.");
//     }
// }



// -------------------------------------------------------------------------------------------------3Basic Arrays-----------------------------------------------------

// Creating an array of integers named 'namesArray' with a length of 10
// int[] namesArray = new int[10];

// // Populating 'namesArray' with values from 1 to 9
// for (int i = 1; i < namesArray.Length; i++)
// {
//     namesArray[i] = i;
// }

// // Printing the value at index 2 of 'namesArray'
// System.Console.WriteLine(namesArray[2]);


// // Creating an array of strings named 'stringArray' with initial values
// string[] stringArray = { "Tim", "Martin", "Nikki", "Sara" };


// // Creating an array of booleans named 'boolArray' with a length of 10
// bool[] boolArray = new bool[10];

// // Populating 'boolArray' with alternating true/false values starting with true
// for (int i = 0; i < boolArray.Length; i++)
// {
//     boolArray[i] = (i % 2 == 0);
// }

// // -------------------------------------------------------------------------------------------------3 list of  flavors-----------------------------------------------------

// // Creating a list of strings named 'iceCreamFlavors'
// List<string> iceCreamFlavors = new List<string>();

// // Adding various ice cream flavors to the list
// iceCreamFlavors.Add("chocolat");
// iceCreamFlavors.Add("Vanilla");
// iceCreamFlavors.Add("Lemon");
// iceCreamFlavors.Add("Rocky Road");
// iceCreamFlavors.Add("White Chocolate");
// iceCreamFlavors.Add("Strawberry");

// // Removing the first element from 'iceCreamFlavors' and printing the new first element and the count of elements
// iceCreamFlavors.Remove(iceCreamFlavors[0]);
// System.Console.WriteLine(iceCreamFlavors[0]);
// System.Console.WriteLine(iceCreamFlavors.Count());


// // -------------------------------------------------------------------------------------------------3 user dictionnary-----------------------------------------------------

// // Creating a dictionary named 'AnimeC' to store user names and associated ice cream flavors
// Dictionary<string, string> AnimeC = new Dictionary<string, string>();
// Random random = new Random();

// // Associating each name from 'namesArray' with a random ice cream flavor
// foreach (var name in namesArray)
// {
//     int randomIndex = random.Next(iceCreamFlavors.Count);
//     string randomFlavor = iceCreamFlavors[randomIndex];
//     AnimeC.Add(name.ToString(), randomFlavor);
// }

// // Looping through the dictionary and printing out each user's name and their associated ice cream flavor
// Console.WriteLine("User Names and Associated Ice Cream Flavors:");
// foreach (var kvp in AnimeC)
// {
//     Console.WriteLine($"{kvp.Key}: {kvp.Value}");
// }




























        // Create an integer array with the values 0 through 9
        int[] integerArray = new int[10];
        for (int i = 0; i < 10; i++)
        {
            integerArray[i] = i;
        }

        // Create a string array with the names "Tim", "Martin", "Nikki", and "Sara"
        string[] stringArray = { "Tim", "Martin", "Nikki", "Sara" };

        // Create a boolean array of length 10 with alternating true/false values, starting with true
        bool[] booleanArray = new bool[10];
        for (int i = 0; i < 10; i++)
        {
            booleanArray[i] = i % 2 == 0;
        }

        // Output the three arrays
        Console.WriteLine("Integer Array: " + string.Join(", ", integerArray));
        Console.WriteLine("String Array: " + string.Join(", ", stringArray));
        Console.WriteLine("Boolean Array: " + string.Join(", ", booleanArray));

        // List of Flavors
        // Create a string List of ice cream flavors
        List<string> flavorsList = new List<string> { "Chocolate", "WhiteChocolat", "Strawberry", "Lemon", "Cookies" };

        // Output the length of the List after adding flavors
        Console.WriteLine("Length of Flavors List: " + flavorsList.Count);

        // Output the third flavor in the List
        Console.WriteLine("Third Flvoar in the List: " + flavorsList[2]);

        // Remove the third flavor using its index location
        flavorsList.RemoveAt(2);

        // Output the length of the List again
        Console.WriteLine("Length of Flavors List after removing one flavor: " + flavorsList.Count);

        // User Dictionary
        // Create a dictionary that will store string keys and string values
        Dictionary<string, string> userDictionary = new Dictionary<string, string>();

        // Add key/value pairs to the dictionary
        for (int i = 0; i < stringArray.Length; i++)
        {
            string randomFlavor = flavorsList[new Random().Next(flavorsList.Count)];
            userDictionary.Add(stringArray[i], randomFlavor);
        }

        // Loop through the dictionary and print out each user's name and their associated ice cream flavor
        foreach (var pair in userDictionary)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    






