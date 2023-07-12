// See https://aka.ms/new-console-template for more information

using System;
using System.Reflection.Metadata.Ecma335;

//use a method for cubing and for squaring
// Console.WriteLine(int.MaxValue);
//the cube root of the max value: 2147483647 is:1290
//prevent users from entering a number higher than 1290

Console.WriteLine("Welcome to the Powers Table!");

bool runProgram = true;
while (runProgram)
{
    //prompt the user to enter an integer
    Console.WriteLine("Enter an integer.");
    int answer = int.Parse(Console.ReadLine());
    //provide validation by rejecting 0 or negative numbers and limit the user to the max number whose cube will fit in an int
    if (answer > 0 && answer < 1290)
    {
        //right-align the numbers
        //display a table of squares and cubes from 1 to the "answer" (value entered)
        Console.WriteLine(string.Format("{0,10} | {1,10} | {2,10}", "Number", "Square", "Cube"));
        Console.WriteLine(string.Format("{0,10} | {1,10} | {2,10}", "------", "------", "------"));
        for (int counter = 1; counter <= answer; counter++)
        {
            Console.WriteLine(string.Format("{0,10} | {1,10} | {2,10}", counter, Squaring(counter), Cubing(counter)));
        }

        bool keepGoing = true;
        while (keepGoing)
        {
            //the application should prompt the user to continue and continue only if the user agrees to
            Console.Write("Do you want to continue? Y/N");
            string end = Console.ReadLine().ToLower().Trim();
            if (end == "n")
            {
                Console.WriteLine("Bye!");
                keepGoing = false;
                runProgram = false;
                break;
            }
            else if (end == "y")
            {
                break;
            }
            else
            {
                Console.WriteLine("That is not a valid response.");
            }
        }
    }
}
Console.WriteLine("Thank you for using the Exponents Powers Table!");



static int Cubing(int answer)
{
    return answer * answer * answer;
}
static int Squaring(int answer)
{
    return answer * answer;
}

    



