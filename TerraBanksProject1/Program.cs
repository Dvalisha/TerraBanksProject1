﻿using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

class MyMain
{
    static void Main(string[] args)
    {
        //1. დაწერეთ პროგრამა, რომელიც გამოთვლის კონსოლიდან შეყვანილი ორი რიცხვის ნამრავლს.

        Console.Write("Please, enter first number: ");
        int x1 = Int32.Parse(Console.ReadLine());

        Console.Write("Please, enter second number: ");
        int x2 = Int32.Parse(Console.ReadLine());

        int product = x1 * x2;

        Console.Write(x1 + x2);
        Console.WriteLine();

        //2. დაწერეთ პროგრამა, რომელიც კონსოლზე გამოიტანს თქვენ სახელს, გვარს და ასაკს.

        Console.WriteLine();
        Console.Write("Please, enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Please, enter your surname: ");
        string surname = Console.ReadLine();

        Console.Write("Please, enter your age: ");
        int age = Int32.Parse(Console.ReadLine());

        Console.Write("Your name is " + name + ".Your surname is " + surname + ".Your age is " + age + ".");
        Console.WriteLine();

        //3. დაწერეთ პროგრამა, რომელიც გამოიტანს ნაშთს კონსოლიდან გადაცემული ორი რიცხვის გაყოფის შედეგად.

        Console.WriteLine();
        Console.Write("Please, enter dividen: ");
        int dividend = Int32.Parse(Console.ReadLine());

        Console.Write("Please, enter divisor: ");
        int divisor = Int32.Parse(Console.ReadLine());

        int remainder = dividend % divisor;

        Console.Write("The remainder is: " + remainder);
        Console.WriteLine();

        //4. შედარების ლოგიკური ოპერატორების საშუალებით შეადარეთ რიცხვები და დაწერეთ პროგრამა, რომელიც გამოიტანს true ან false.

        Console.WriteLine();
        Console.Write("Please, enter first number: ");
        int y1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please, enter second number: ");
        int y2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        if (y1 >= y2)
        {
            Console.WriteLine("True");
        } 
        else
        {
            Console.WriteLine("False");
        }
        Console.WriteLine();

        //5. ჩაწერეთ შემდეგი პირობა Boolean ლოგიკური ოპერატორის გამოყენებით: A>B და A>C, A>B ან A>C. როცა A=5 B=4 C=7

        int a = 5;
        int b = 4;
        int c = 7;

        bool logic1 = a > b && a > c;
        Console.WriteLine(logic1);

        bool logic2 = a > b || a > c;
        Console.WriteLine(logic2);
        Console.WriteLine();

        //6. შექმენით რიცხვითი ტიპის, 10 ელემენტისაგან შემდგარი მასივი. კონსოლზე გამოიტანეთ პირველი და მეშვიდე ელემენტი.
        
        int[] numbers = new int[10] { 20, -5, 39, 47, -99, 165, 300, 0, 68, -5 };

        Console.WriteLine("First element is: " + numbers[0]);
        Console.WriteLine("Seventh element is: " + numbers[6]);
        Console.WriteLine();

        //7. შექმენით მასივები შემდეგი განზომილებებით და შეავსე რიცხვებით: ორგანზომილებიანი [3,2], [4,2]. სამგზანზომილებიანი [2,2,2], [1,2,3]

        int[,] array2A = new int[3, 2]
        {
            {13, 25 },
            {-5, -13 },
            {47, -12 }
        };

        Console.Write(array2A[0, 1]);
        Console.WriteLine();

        int[,] array2B = new int[4, 2]
        {
            {3, 2 },
            {12, 885 },
            {27, -1 },
            {313, 0 }
        };

        Console.Write(array2B[2, 0]);
        Console.WriteLine();

        int[,,] array3A = new int[2, 2, 2]
        {
            { {77, 87 }, {2, 18 } },
            { {0, 475 }, {36, -15 } }
        };

        Console.Write(array3A[1, 1, 0]);
        Console.WriteLine();

        int[,,] array3B = new int[1, 2, 3]
        {
            { {17, -61, -11 }, {256, 11, 51 } },
        };

        Console.Write(array3B[0, 0, 2]);
        Console.WriteLine();

    }
}