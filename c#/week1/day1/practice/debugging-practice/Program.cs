// Challenge 1
bool amProgrammer = true; // Fix: Use a boolean value directly, without quotes
int Age = 27; // Fix: Age should be an integer, not a decimal
List<string> Names = new List<string>(); 
Names.Add("Monica"); // Fix: Add the name to the list using Add method
Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
MyDictionary.Add("Hi there", "0"); // Fix: Both values should be strings
string MyName = "MyName"; // Fix: Use double quotes for string literals

// Challenge 2
List<int> Numbers = new List<int>() {2,3,6,7,1,5};
for(int i = Numbers.Count - 1; i >= 0; i--) // Fix: Adjust the loop condition
{
    Console.WriteLine(Numbers[i]);
}

// Challenge 3
List<int> MoreNumbers = new List<int>() {12,7,10,-3,9};
foreach(int num in MoreNumbers)
{
    Console.WriteLine(num); // Fix: Use 'num' directly, not MoreNumbers[num]
}

// Challenge 4
List<int> EvenMoreNumbers = new List<int> {3,6,9,12,14};
for (int i = 0; i < EvenMoreNumbers.Count; i++) // Fix: Use a for loop to access each element
{
    if(EvenMoreNumbers[i] % 3 == 0)
    {
        EvenMoreNumbers[i] = 0; // Fix: Assign 0 to the element, not the local variable 'num'
    }
}

// Challenge 5
string MyString = "superduberawesome";
// Fix: Strings in C# are immutable, so you can't change individual characters directly.
// You can create a new string with the desired modification.
MyString = MyString.Substring(0, 7) + "p" + MyString.Substring(8);
System.Console.WriteLine(MyString[7]);
//But if we console this qithout adding substring it will be 'b'
// Challenge 6
Random rand = new Random();
int randomNum = rand.Next(13); // Fix: Adjust the upper bound to include 12
if(randomNum == 12)
{
    Console.WriteLine("Hello");
}


