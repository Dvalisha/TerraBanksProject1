class MyMain
{
    static void Main(string[] args)
    {
        // Homework 3
        // Part 1
        int x = 4;
        int y = 10;
        int z = 5;
        Console.WriteLine(x + y * z);

        // Part 2
        Console.WriteLine("");
        Console.Write("Please, enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Please, enter your surname: ");
        string surname = Console.ReadLine();
        Console.Write("Please, enter your age: ");
        int age = Int32.Parse(Console.ReadLine());
        Console.Write("Please, enter your height in cm: ");
        float height = float.Parse(Console.ReadLine());
        Console.Write("Please, enter your weight in kg: ");
        float weight = float.Parse(Console.ReadLine());

        //Part 3
        float heightForBmi = height / 100;
        Console.WriteLine(heightForBmi);
        Console.WriteLine("");
        Console.WriteLine(weight / (heightForBmi * heightForBmi));   
    }
}   