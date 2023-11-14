namespace ZooAnimalFeeding;

class Program
{
    static void Main(string[] args)
    {
        var lion = new Lion(100);
        Console.WriteLine(lion.FeedInstructions());

        var elephant = new Elephant(200);
        Console.WriteLine(elephant.FeedInstructions());

        var snake = new Snake(3);
        Console.WriteLine(snake.FeedInstructions());
        Console.WriteLine($"Days until next feeding: {snake.DaysUntilNextFeeding()}");

        var penguin = new Penguin(6);
        Console.WriteLine(penguin.FeedInstructions());
        Console.ReadLine();
    }
}
public abstract class Animal
{ 
    //Property
    public int Weight { get; set; }
    //Constructor
    public Animal(int weight)
    {
        Weight = weight;
    }
    //Abstract method for feeding instructions
    public abstract string FeedInstructions();
}

//Derived class Lion
public class Lion : Animal
{
    //Constructor
    public Lion(int weight): base(weight) 
    {
    }
    // Implementing of abstract method
    public override string FeedInstructions()
    {
        if (Weight < 150)
            return "Feed 5kg meat twice a day.";
        else
            return "Feed 10kg meat twice a day.";
    }
}
public class Elephant : Animal
{
    //Constructor
    public Elephant(int weight) : base(weight) { }
    // Implementing of abstract method
    public override string FeedInstructions()
    {
            return $"Feed {Weight * 0.03}kg hay daily.";
    }
}
public class Snake : Animal
{
    //Constructor
    public Snake(int weight) : base(weight) { }
    // Implementing of abstract method
    public override string FeedInstructions()
    {
        if (Weight < 2)
            return "Feed one mouse weekly.";
        else
            return "Feed one rabbit bi-weekly.";
    }
    public int DaysUntilNextFeeding()
        {
            return Weight < 2 ? 7 : 14;//ternary condition
        }
}

public class Penguin : Animal
{
    //Constructor
    public Penguin(int weight) : base(weight) { }
    // Implementing of abstract method

    public override string FeedInstructions()
    {
        return Weight < 5 ? "Feed 1kg fish daily." : "Feed 2kg fish daily.";
    }
}