using System;

class Program
{


    static double AddNumbers(double x, int y)
    {
        return x+y;
    }

    static string MyName()
    {
        return "Jerry";
    }

    static void DisplayGreeting(string name)
    {
        Console.WriteLine($"Welcome {name}");
    }

    static void Main(string[] args)
    {
        Circle myCircle = new Circle();
        myCircle._radius = 10;
        double area = myCircle.GetArea();
        Console.WriteLine(area);

        string name = MyName();
        DisplayGreeting(name);
        double total = AddNumbers(3.14,96);
        Console.WriteLine(total);
        // Console.WriteLine("Bom dia gente!");
        // Console.WriteLine("I have never dealt drugs.\n\n");

        // int x = 11;
        // int y = 20;
        // int z = 40;

        // if (x==10 && y == 20 || z == 40) //&& has higher precedence
        // {
        //     Console.WriteLine("X is 10");
        //     Console.WriteLine("dont' do drugs");
        // }

        // else if (x==20)
        // {
        //     Console.WriteLine("X is 10");
        // }
        // else
        // {
        //     Console.WriteLine("I'm tired");
        // }


        //Loops and whatnot

        //bool done = false;

        // while (! done)
        // {
        //     Console.Write("Are we done yet? (y/n) ");
        //     done = Console.ReadLine() == "y";
        // }


        // do while loop. Notice you don't have to declare the bool statement
        // bool done;
        // do
        // {
        //     Console.Write("Are we done yet? (y/n) ");
        //     done = Console.ReadLine() == "y";
        // } while (! done);

        //for loops
        // declare variable, condition that must be true to keep going, step increment
        // for(int i =10000; i > 100; i-=120)
        // {
        //     Console.WriteLine(i);
        // }

        //foreach loop iteration over list/string
        // List<string> myFriends = new List<string> {"Bob","Betty","Bubba"};
        // myFriends.Add("Doug");

        // foreach(string friend in myFriends)
        // {
        //     Console.WriteLine(friend);
        // }



    }
}


// Indentation and white space makes no difference