using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

class MyMain
{
    static void Main(string[] args)
    {
        //1. if/else ბლოკების გამოყენებით დაწერეთ ფუნქცია, რომელიც გამოიტანს გადაცემული რიცხვი კენტია თუ ლუწი.
        Console.Write("Please enter a number: ");
        int a = Int32.Parse(Console.ReadLine());

        if (a % 2 == 0) 
        {
            Console.WriteLine("Your number is even");
        }
        else
        {
            Console.WriteLine("Your number is odd");
        }

        Console.WriteLine();

        //2. Switch/Case ბლოკის გამოყენებით დაწერეთ ფუნქცია, რომელიც გადაცემული რიცხვის მიხედვით გამოითვლის რომელი დღეა დღეს. მაგ. 1 ნიშნავს ორშაბათს, 2 სამშაბათს და ა.შ.

        Console.Write("Please enter a number for day (1-7): ");
        int b = Int32.Parse(Console.ReadLine());

        switch (b)
        {
            case 1: Console.WriteLine("Today is Monday");
                break;
            case 2: Console.WriteLine("Today is Tuesday");
                break;
            case 3: Console.WriteLine("Today is Wednesday");
                break;
            case 4: Console.WriteLine("Today is Thursday");
                break;
            case 5: Console.WriteLine("Today is Friday");
                break;
            case 6: Console.WriteLine("Today is Saturday");
                break;
            case 7: Console.WriteLine("Today is Sunday");
                break;
        }

        //2.1 ნებისმიერი რიცხვზე რომ თქვას დღე:

        switch (b % 7)
        {
            case 1:
                Console.WriteLine("Today is Monday");
                break;
            case 2:
                Console.WriteLine("Today is Tuesday");
                break;
            case 3:
                Console.WriteLine("Today is Wednesday");
                break;
            case 4:
                Console.WriteLine("Today is Thursday");
                break;
            case 5:
                Console.WriteLine("Today is Friday");
                break;
            case 6:
                Console.WriteLine("Today is Saturday");
                break;
            case 0:
                Console.WriteLine("Today is Sunday");
                break;
        }

        Console.WriteLine();

        //3. შექმენით რიცხვიდი ცვლადი. While ციკლის საშუალებით გამოიტანეთ კონსოლზე რიცხვი იქამდე სანამ ის არ მიიღებს უარყოფით მნიშვნელობას.

        int c = 10;

        while (c >= 0)
        {
            Console.WriteLine("Number = {0}", c);
            c--;
        }

        Console.WriteLine();

        //4. Do/While ციკლის საშუალებით გამოიტანეთ კონსოლიდან შეყვანილი და შესაბამისი რიცხვები, სანამ ჩვენ მიერ შეტანილი რიცხვი არ მიიღებს უარყოფით მნიშვნელობას.

        Console.Write("Please enter a number: ");
        int d = Int32.Parse(Console.ReadLine());

        do
        {
            Console.WriteLine("Number = {0}", d);
            d--;
        } while(d >= 0);

        Console.WriteLine();

        //5. Do/While ციკლის საშუალებით გამოიტანეთ თქვენი დაბადების წელი და გაზარდეთ 2015 წლამდე. 2015 წლის შემდეგ მონაცემები აღარ უნდა დაიბეჭდოს.

        int e = 1990;

        do
        {
            Console.WriteLine("Year = {0}", e);
            e++;
        } while(e < 2016);

        Console.WriteLine();

        //6. გამოიტანეთ 1-დან 10-მდე ნატურალური რიცხვები while ციკლის საშუალებით.

        int f = 1;

        while (f <10)
        {
            Console.WriteLine("Number = {0}", f);
            f++;
        }

        Console.WriteLine();

        //7. For ციკლის საშუალებით გამოთვალეთ და კონსოლზე გამოიტანეთ ყველა ლუწი რიცხვი, იმ ორი რიცხვის დიაპაზონში რომელსაც გადავცემთ კონსოლიდან.

        Console.Write("Please enter first number: ");
        int g = Int32.Parse(Console.ReadLine());

        Console.Write("Please enter second number: ");
        int h = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < (h - g) / 2 ; i++)
        {
            if(g % 2 == 0)
            {
                Console.WriteLine("Number = {0}", g + (i * 2));
            } 
            else
            {
                Console.WriteLine("Number = {0}", g + 1 + (i * 2));
            }
        }
    }
}