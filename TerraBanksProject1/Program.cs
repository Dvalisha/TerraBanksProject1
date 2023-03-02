using System.Runtime.CompilerServices;

class MyMain
{
    static void Main(string[] args)
    {
        // Homework 3
        // 1. პირველი მეთოდის გამოძახება
        getSum(5, 4);
        Console.WriteLine();

        //   2. მომხმარებელს შეყავს მონაცემები
        Console.Write("Please enter Number 1: ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("Please enter Number 2: ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Please enter Number 3: ");
        double x3 = double.Parse(Console.ReadLine());

        Console.Write("Please enter Number 4: ");
        double x4 = double.Parse(Console.ReadLine());

        // 2. მეორე მეთოდის გამოძახება
        Console.WriteLine();
        minMax(x1, x2, x3, x4);
        Console.WriteLine();

        //   3. მესამე მეთოდის გამოძახება
        fruits();


        // 1. შევქმნათ მეთოდი, რომელსაც გადავცემთ ორ სრულ რიცხვს. მეთოდმა უნდა დააბრუნოს ორი რიცხვის ჯამი. გამოვიყვანოთ ეს ჯამი შესვლის წერტილის მეთოდის მეშვეობით კონსოლში
        static void getSum(int x, int y)
        {
        Console.WriteLine(x + y);
        }

        //   2. შევქმნათ მეთოდი. ვთხოვოთ მომხმარებელს შეიყვანოს ოთხი ნებისმიეირ ტიპის რიცხვი (ანუ არა მხოლოდ ინტეჯერი).
        //   მეთოდის ფარგლებში უნდა მოიძებნოს ამ ოთხი რიცხვიდან ყველაზე დიდი და ყველაზე პატარა. მეთოდმა უნდა გამოიყვანოს კონსოლში ეს ორი რიცხვი.
        static void minMax(double x1,double x2, double x3, double x4)
        {
            if (x1 >= x2 && x1 >= x3 && x1 >= x4) 
            {
                Console.WriteLine("The highest number is: " + x1);
            }
            else if (x2 >= x1 && x2 >= x3 && x2 >= x4) 
            {
                Console.WriteLine("The highest number is: " + x2);
            }
            else if (x3 >= x1 && x3 >= x2 && x3 >= x4)
            {
                Console.WriteLine("The highest number is: " + x3);
            }
            else 
            {
                Console.WriteLine("The highest number is: " + x4);
            }

            if (x1 <= x2 && x1 <= x3 && x1 <= x4)
            {
                Console.WriteLine("The lowest number is: " + x1);
            }
            else if (x2 <= x1 && x2 <= x3 && x2 <= x4)
            {
                Console.WriteLine("The lowest number is: " + x2);
            }
            else if (x3 <= x1 && x3 <= x2 && x3 <= x4)
            {
                Console.WriteLine("The lowest number is: " + x3);
            }
            else 
            {
                Console.WriteLine("The lowest number is: " + x4);
            }
        }

        //   3. შევქმნათ მეთოდი, რომელმაც უნდა მიიღოს მეორე მეთოდის მეშვეობით მომხმარებლისგან ხილის დასახელება.
        //   ამ ხილის დასახელების მიღების შემდეგ switch ოპერატორის მეშვეობით ნახოს თუ რომელი ხილია და გამოიყვანოს შესაბამისი შეტყობინება.
        //   თუ ასეთი ხილი არ მოიძებნა, ამის შესახებაც მომხმარებელმა უნდა მიიღოს შეტყობინება. ხილი: apple, watermelon, melon, cherry, strawberry.
        static void fruits()
        {
            Console.Write("Please enter a fruit: ");
            string fruitName = Console.ReadLine();
            switch (fruitName) 
            {
                case "apple":
                    Console.WriteLine("Fruit: apple");
                    break;
                case "watermelon":
                    Console.WriteLine("Fruit: watermelon");
                    break;
                case "melon":
                    Console.WriteLine("Fruit: melon");
                    break;
                case "cherry":
                    Console.WriteLine("Fruit: cherry");
                    break;
                case "strawberry":
                    Console.WriteLine("Fruit: strawberry");
                    break;
                default:
                    Console.WriteLine("There is no such fruit");
                    break;
            }
        }
    }
}   