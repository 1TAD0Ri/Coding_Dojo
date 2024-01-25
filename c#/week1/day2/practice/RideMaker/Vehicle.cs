 public class Vehicle
{
    //field/properties
    public string Name { get; set; }
    public int NumberOfPassengers { get; set; }
    public string Color { get; set; }
    public bool HasEngine { get; set; }
    public int Miles { get; set; } = 0;


    //constructors
    public Vehicle (string name , int numofpassengers , string color , bool hasengine)
    {
        Name = name ;
        NumberOfPassengers = numofpassengers ; 
        Color = color;
        HasEngine = hasengine ; 
    }

    //Methods 
    public void ShowInfo()
    {
        System.Console.WriteLine($"The Vehicle name is {Name}\nand her number of passengers about {NumberOfPassengers}\nHer Color is {Color}\nHas Engine {HasEngine} ");
    }
}
