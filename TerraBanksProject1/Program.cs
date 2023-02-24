class MyMain
{
    static void Main(string[] args)
    {
        // Homework 3
        // 1. შევქმანთ სამი ცვლადი (x, z, y). მივანიჭოთ მნიშვნელობები. გამოვიყავნოთ კონსოლში: x + z * y = ჯამი; მაგ. 4, 5, 10-ის შედეგია 54.
        int x = 4;
        int y = 10;
        int z = 5;
        Console.WriteLine(x + y * z);

        // 2. პროგრამა სთავაზობს მომხმარებელს შეიყვანოს სახელი (Archil), გვარი (Sikharulidze), ასაკი (34), სიმართლე (171) და წონა (88.7).
        // შევინახოთ ეს მონაცემები შესაბამისი ტიპის ცვლადებში. გამოვიყვანოთ მთელი ინფორმაცია კონსოლში.
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
        Console.WriteLine("");
        Console.WriteLine("Your name is: " + name);
        Console.WriteLine("Your surname is: " + surname);
        Console.WriteLine("Your age is: " + age);
        Console.WriteLine("Your height is: " + height);
        Console.WriteLine("Your weight is: " + weight);

        // 3. დაწერეთ კოდი, რომელიც ითვლის ადამიანის BMI (Body Mass Index) მოიძიეთ ფორმულა ინტერნეტში. ლოგიკა და კოდი დამოუკიდებლად გაწერეთ.
        float heightForBmi = height / 100;
        Console.WriteLine("");
        Console.WriteLine("Your budy index is: " + weight / (heightForBmi * heightForBmi));

        // 4. დამიხატეთ კონსოლში შემდეგი ნახატი:
        int num1 = 1;
        Console.WriteLine("");
        Console.WriteLine("   |   |   ");
        Console.WriteLine(" " + num1 + " | " + ++num1 + " | " + ++num1 + " ");
        Console.WriteLine("___|___|___");
        Console.WriteLine("   |   |   ");
        Console.WriteLine(" " + ++num1 + " | " + ++num1 + " | " + ++num1 + " ");
        Console.WriteLine("___|___|___");
        Console.WriteLine("   |   |   ");
        Console.WriteLine(" " + ++num1 + " | " + ++num1 + " | " + ++num1 + " ");
        Console.WriteLine("   |   |   ");
    }
}   