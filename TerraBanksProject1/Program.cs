using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

class MyMain
{
    static void Main(string[] args)
    {
        // Game
        startGame();
    }

    static void startGame()
    {
        rules();

        int hiddenNumber = randomNumber();
        int usersNumber;
        int gameCounter = 0;
    //    string usersAnswer = "Y";

    //    while (playAgain2(usersAnswer))
    //    {

        
            while (gameCounter <= 2)
            {
                usersNumber = enterNumber();
                if (checkGame(hiddenNumber, usersNumber, gameCounter))
                {
    //                playAgain();
    //                hiddenNumber = randomNumber();
    //                gameCounter = 0;
                    return;
                }
                gameCounter++;
            }
            Console.WriteLine("You have lost! The hidden number was:" + hiddenNumber);
    //        playAgain();
    //        hiddenNumber = randomNumber();
    //        gameCounter = 0;
    //    }
    //        Console.WriteLine("Have a nice day");
    }

    static void rules()
    {
        Console.WriteLine("Let's play a game. I have a hidden number for you.");
        Console.WriteLine("This number is between 0 to 20. Please, guess it.");
        Console.WriteLine("You have three attempts.");
        Console.WriteLine();
    }

    static int randomNumber()
    {
        return new Random().Next(0, 5);
    }

    static int enterNumber()
    {
        Console.Write("Please, enter a number: ");
        return Int32.Parse(Console.ReadLine());
    }

    static bool checkGame(int hiddenNumber, int usersNumber, int gameCounter)
    {
        if (hiddenNumber == usersNumber)
        {
            Console.WriteLine("You have won!");
                return true;
        }
        else if (hiddenNumber > usersNumber && gameCounter <= 1)
        {
            Console.WriteLine("Hidden number is grater then your number");
        }
        else if (hiddenNumber < usersNumber && gameCounter <= 1)
        {
            Console.WriteLine("Hidden number is lower then your number");
        }
        return false;
    }

  //  static void playAgain()
  //  {
  //      Console.Write("Whould you like to play again? type Y for Yes: ");
  //      string usersAnswer = Console.ReadLine();
  //  }

  //  static bool playAgain2(string usersAnswer)
  //  {
  //      if (usersAnswer == "Y")
  //      {
   //         return true;
   //     }
   //     else
   //     {
   //         return false;
   //     }
   // }
}