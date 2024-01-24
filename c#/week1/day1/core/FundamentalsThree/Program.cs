//1. Iterate and print values



// static void PrintList(List<string> MyList)
// {
//     // Your code here
//         foreach (string item in MyList)
//         {
//             System.Console.WriteLine(item);
//         }

// }
// List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
// PrintList(TestStringList);


// // ------------------------------------------------

// static void SumOfNumbers(List<int> IntList)
// {
//     // Your code here
//     int sum=0;
//     for (int i = 0; i < IntList.Count ; i++)
//     {
//      sum+=IntList[i];
//     }
//     System.Console.WriteLine(sum);
// }
// List<int> TestIntList = new List<int>() {2,7,12,9,3};
// // You should get back 33 in this example
// SumOfNumbers(TestIntList);

// --------------------------------------------------------


// static int FindMax(List<int> IntList)
// {
//     // Check if the list is empty
//     if (IntList.Count == 0)
//     {
//         throw new InvalidOperationException("Empty list");
//     }

//     int maxNum = int.MinValue;

//     // Iterate through the list to find the maximum value
//     foreach (int item in IntList)
//     {
//         if (item > maxNum)
//         {
//             maxNum = item;
//         }
//     }

//     return maxNum;
// }

// List<int> TestIntList2 = new List<int>() { -9, 12, 10, 3, 17, 5 };
// int result = FindMax(TestIntList2);
// Console.WriteLine("The maximum value is: " + result);


// ---------------------------------------------------------------------

// This is a method that takes a list of integers and returns a new list
// containing the squared values of each integer in the input list.
// static List<int> SquareValues(List<int> IntList)
// {
//     // Create a new list to store the squared values
//     List<int> squaredList = new List<int>();

//     // Iterate through each item in the input list
//     foreach (int item in IntList)
//     {
//         // Calculate the squared value of the current item
//         int squaredValue = item * item;

//         // Add the squared value to the new list
//         squaredList.Add(squaredValue);
//     }

//     // Return the new list containing squared values
//     return squaredList;
// }

// // Create a list of integers for testing
// List<int> TestIntList3 = new List<int>() { 1, 2, 3, 4, 5 };

// // Call the SquareValues method with the test list and store the result
// List<int> result = SquareValues(TestIntList3);

// // Display the squared values list
// Console.WriteLine("Squared Values: " + string.Join(", ", result));


// ---------------------------------------------------------------------------------------*
// static int[] NonNegatives(int[] IntArray)
// {
//     // Your code here
//     int[] newArray = new int[IntArray.Length]; 
//     for (int i = 0; i < IntArray.Length; i++)
//     {
//         // If the element is negative, set it to 0; otherwise, keep the original value
//         newArray[i] = IntArray[i] < 0 ? 0 : IntArray[i];
//     }

//     return newArray; // Move the return statement outside of the for loop
// }

// int[] TestIntArray = new int[] { -1, 2, 3, -4, 5 };
// // You should get back [0,2,3,0,5], think about how you will show that this worked

// // Capture the result of the function in a variable
// int[] modifiedArray = NonNegatives(TestIntArray);
// System.Console.WriteLine("Modified Array: " + string.Join(", ", modifiedArray));


// -------------------------------------------------------------------------------------------------

// static void PrintDictionary(Dictionary<string, string> MyDictionary)
// {
//     // Your code here
//     foreach (var kvp in MyDictionary)
//     {
//         Console.WriteLine($"{kvp.Key}: {kvp.Value}");
//     }

// }
// Dictionary<string, string> TestDict = new Dictionary<string, string>();
// TestDict.Add("HeroName", "Iron Man");
// TestDict.Add("RealName", "Tony Stark");
// TestDict.Add("Powers", "Money and intelligence");
// PrintDictionary(TestDict);


// // ------------------------------------------------------------------------------------------------------

// static bool FindKey(Dictionary<string, string> MyDictionary, string SearchTerm)
// {
//     // Your code here
//     return MyDictionary.ContainsKey(SearchTerm);


// }
// // Use the TestDict from the earlier example or make your own
// // This should print true
// Console.WriteLine(FindKey(TestDict, "RealName"));
// // This should print false
// Console.WriteLine(FindKey(TestDict, "Name"));
// ------------------------------------------------------------------------------------------------------





    static Dictionary<string, int> GenerateDictionary(List<string> Names, List<int> Numbers)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();

        for (int i = 0; i < Names.Count; i++)
        {
            result[Names[i]] = Numbers[i];
        }

        return result;
    }

    static void Main()
    {
        List<string> names = new List<string> { "zalzalz", "lakzlakzkaz", "akjlsklaks" };
        List<int> numbers = new List<int> { 23, 25, 22 };

        Dictionary<string, int> resultDictionary = GenerateDictionary(names, numbers);

        foreach (var kvp in resultDictionary)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }


































