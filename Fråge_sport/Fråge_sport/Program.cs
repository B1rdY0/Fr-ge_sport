using System;

string cont = "yes";

while (cont == "yes")
{
    //P (point)
    int P = 0;

    Console.WriteLine($"Aaryan: How many diffrent sports did i go?");
    Console.WriteLine($"a = 2   b = 7   c = 5");

    string answer;
    answer = Console.ReadLine();
    answer = answer.ToLower();


    if (answer == "a")
    {
    }
    else if (answer == "b")
    {

    }
    else if (answer == "c")
    {
        P += 1;
    }
    else
    {
        P = 0;
    }

    Console.WriteLine($"The score is --> {P}");

    Console.WriteLine($"What type of game do i like");

    System.Console.WriteLine($" a = FPS    b = Strategy  c = Open world");
    answer = Console.ReadLine();
    answer = answer.ToLower();

    if (answer == "a")
    {

    }

    else if (answer == "b")
    {
        P += 1;
    }

    else if (answer == "c")
    {

    }

    else
    {
        P -= 1;
    }

    Console.WriteLine($"Your score is {P}");




    System.Console.WriteLine($"was this easy?");
    System.Console.WriteLine($" a = yes    b = no");

    string answer_3;
    answer_3 = Console.ReadLine();
    answer_3 = answer.ToLower();

    if (answer_3 == "a")
    {

    }

    else if (answer_3 == "b")
    {
        P += 1;
    }

    else
    {
        P -= 1;
    }


    Console.WriteLine($"Your score is {P}");



    string answer_4;
    answer_4 = Console.ReadLine();

    Console.WriteLine("Do you want to play again??????");
    System.Console.WriteLine("yes or no");

    cont = Console.ReadLine();

    System.Console.WriteLine(@"  ,-.
          .:\ '`-.
          |:|  __ b
           `;-(
          ,'  |
         ( \|||_
  ,-----(.-''--``-------.
 /_______`'______________\
/                      SSt\");
}
Console.ReadLine();