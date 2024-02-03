
List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    // new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
IEnumerable<Eruption> FirstChilie = eruptions.Where(c => c.Location == "Chile").Take(1).ToList();
IEnumerable<Eruption> FirstHawaiin = eruptions.Where(e => e.Location == "Hawaiian Is").Take(1).ToList();
IEnumerable<Eruption> FirstGreenlad = eruptions.Where(e => e.Location == "Greenland").Take(1).ToList();
IEnumerable<Eruption> FirstAfter1900AndNewZ = eruptions.Where(e => e.Year > 1900 && e.Location == "New Zealand").Take(1).ToList();
IEnumerable<Eruption> FirstEruptionWhereVolcanoOver2000 = eruptions.Where(e => e.ElevationInMeters < 2000).ToList();
IEnumerable<Eruption> StartsWithL = eruptions.Where(e => e.Volcano.StartsWith("L")).ToList();
// Console.WriteLine("\nVolcanoes whose names start with 'L':");
int highestElevation = eruptions.Max(e => e.ElevationInMeters);
// Console.WriteLine($"\nHighest Elevation: {highestElevation}");
IEnumerable<string> alphabeticallyOrderedNames = eruptions.OrderBy(e => e.Volcano).Select(e => e.Volcano).ToList();
// Console.WriteLine("\nVolcano Names Alphabetically:");
Eruption volcanoWithHighestElevation = eruptions.First(e => e.ElevationInMeters == highestElevation);
// Console.WriteLine($"\nVolcano with Highest Elevation: {volcanoWithHighestElevation.Volcano}");
int sumOfElevations = eruptions.Sum(e => e.ElevationInMeters);
// Console.WriteLine($"\nSum of Elevations: {sumOfElevations}");
bool eruptedInYear2000 = eruptions.Any(e => e.Year == 2000);
// Console.WriteLine($"\nDid any volcanoes erupt in the year 2000? {eruptedInYear2000}");
IEnumerable<Eruption> Stratovolcanoes = eruptions.Where(e => e.Type == "Stratovolcano").Take(3).ToList();
// Console.WriteLine("\nFirst Three Stratovolcanoes:");
IEnumerable<Eruption> BeforeYear1000 = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano).ToList();
// Console.WriteLine("\nEruptions Before the Year 1000 Alphabetically:");
IEnumerable<string> VolcanoNamesBeforeYear1000 = eruptions
    .Where(e => e.Year < 1000)
    .OrderBy(e => e.Volcano)
    .Select(e => e.Volcano)
    .ToList();
// Console.WriteLine("\nVolcano Names Before the Year 1000:");





PrintEach(FirstHawaiin, "First one with Hawaiian Is location.");
PrintEach(FirstGreenlad, "First one with Greenland Is location.");
PrintEach(FirstAfter1900AndNewZ, "First eruption After 1900 and New Zealand.");
PrintEach(StartsWithL, "Volcanoes whose names start with 'L':");






    static void PrintEach(IEnumerable<Eruption> items, string msg = "")
    {
        Console.WriteLine("\n" + msg);

        if (items.Any())
        {
            foreach (Eruption item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }
        else
        {
            Console.WriteLine("No matching eruptions found.");
        }
    }










// class Program
// {
//     static void Main()
//     {
//         List<Eruption> eruptions = new List<Eruption>
//         {
//             new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
//             new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
//             new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
//             // new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
//             new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
//             new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
//             new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
//             new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
//             new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
//             new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
//             new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
//             new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
//             new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
//         };

//         IEnumerable<Eruption> FirstChile = eruptions.Where(c => c.Location == "Chile").Take(1).ToList();
//         IEnumerable<Eruption> FirstHawaiian = eruptions.Where(e => e.Location == "Hawaiian Is").Take(1).ToList();
//         IEnumerable<Eruption> FirstGreenland = eruptions.Where(e => e.Location == "Greenland").Take(1).ToList();
//         IEnumerable<Eruption> FirstAfter1900 = eruptions.Where(e => e.Year > 1900).Take(1).ToList();
//         IEnumerable<Eruption> FirstAfter1900AndNewZ = eruptions.Where(e => e.Year > 1900 && e.Location == "New Zealand").Take(1).ToList();
//         IEnumerable<Eruption> FirstEruptionWhereVolcanoOver2000 = eruptions.Where(e => e.ElevationInMeters > 2000).ToList();

//         PrintEach(FirstHawaiian, "First one with Hawaiian Is location.");
//         PrintEach(FirstGreenland, "First one with Greenland Is location.");
//         PrintEach(FirstAfter1900, "First eruption After 1900.");
//         PrintEach(FirstAfter1900AndNewZ, "First eruption After 1900 and New Zealand.");
//         PrintEach(FirstEruptionWhereVolcanoOver2000, "All eruptions with elevation over 2000 meters.");

//         // Find all eruptions where the volcano's name starts with "L" and print them. Also print the number of eruptions found.
//         IEnumerable<Eruption> startsWithLEruptions = eruptions.Where(e => e.Volcano.StartsWith("L"));
//         Console.WriteLine($"\nEruptions with names starting with 'L' (Count: {startsWithLEruptions.Count()}):");
//         PrintEach(startsWithLEruptions);

//         // Find the highest elevation and print only that integer.
//         int highestElevation = eruptions.Max(e => e.ElevationInMeters);
//         Console.WriteLine($"\nHighest Elevation: {highestElevation}");

//         // Use the highest elevation variable to find and print the name of the Volcano with that elevation.
//         Eruption volcanoWithHighestElevation = eruptions.First(e => e.ElevationInMeters == highestElevation);
//         Console.WriteLine($"\nVolcano with Highest Elevation: {volcanoWithHighestElevation.Volcano}");

//         // Print all Volcano names alphabetically.
//         IEnumerable<string> alphabeticallyOrderedNames = eruptions.OrderBy(e => e.Volcano).Select(e => e.Volcano);
//         Console.WriteLine("\nVolcano Names Alphabetically:");
//         PrintEach(alphabeticallyOrderedNames);

//         // Print the sum of all the elevations of the volcanoes combined.
//         int sumOfElevations = eruptions.Sum(e => e.ElevationInMeters);
//         Console.WriteLine($"\nSum of Elevations: {sumOfElevations}");

//         // Print whether any volcanoes erupted in the year 2000.
//         bool eruptedInYear2000 = eruptions.Any(e => e.Year == 2000);
//         Console.WriteLine($"\nDid any volcanoes erupt in the year 2000? {eruptedInYear2000}");

//         // Find all stratovolcanoes and print just the first three.
//         IEnumerable<Eruption> stratovolcanoes = eruptions.Where(e => e.Type == "Stratovolcano").Take(3);
//         Console.WriteLine("\nFirst Three Stratovolcanoes:");
//         PrintEach(stratovolcanoes);

//         // Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.
//         IEnumerable<Eruption> beforeYear1000Eruptions = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano);
//         Console.WriteLine("\nEruptions Before the Year 1000 Alphabetically:");
//         PrintEach(beforeYear1000Eruptions);

//         // Redo the last query, but this time use LINQ to only select the volcano's name so that only the names are printed.
//         IEnumerable<string> namesBeforeYear1000 = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano).Select(e => e.Volcano);
//         Console.WriteLine("\nVolcano Names Before the Year 1000:");
//         PrintEach(namesBeforeYear1000);

//         Console.ReadLine();
//     }

//     // Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!







