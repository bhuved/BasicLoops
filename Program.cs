// See https://aka.ms/new-console-template for more information
//BasicLoops Lab-Description 1
using System;
Console.WriteLine("***BasicLoops Lab-Description 1***");
bool optContinue = true;
do
{
    Console.WriteLine("Hello, World!");
//prompt the user want to continue and stop the loop for respond "n"
    Console.WriteLine("Would you like to continue y/n ?");
    string respond = Console.ReadLine();
    if (respond.ToLower() == "n")
    {
        optContinue = false;
        Console.WriteLine("GoodBye");
    }
} while (optContinue);

//BasicLoops Lab-Description 2. Print numbers from 0 to entered number and reverse it
Console.WriteLine("***BasicLoops Lab-Description 2***");
bool optContinueA = true;
do
{
    Console.WriteLine("Enter a number");
    int resNumber = Convert.ToInt32(Console.ReadLine());

    //Iterate using for loop and print the number
    for (int i = resNumber; i >= 0; i--)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine("");
    // print the number in reverse order
    for (int i = 0; i <= resNumber; i++)
    {
        Console.Write(i + " ");
    }

    //Prompt the user like to continue
    Console.WriteLine("\nWould you like to continue y/n ?");
    string respond = Console.ReadLine();
    if (respond.ToLower() == "n")
    {
        optContinueA = false;
        Console.WriteLine("GoodBye");
    }
} while (optContinueA);

//BasicLoops Lab-Description 3 door keypad entry
Console.WriteLine("***BasicLoops Lab-Description 3 door keypad***");
bool doorLocked = true;
int keyCode = 13579;
while (doorLocked)
{
    Console.WriteLine("Enter a Keycode");
    int enteredKeyCode = Convert.ToInt32(Console.ReadLine());
    if (enteredKeyCode == keyCode)
    {
        doorLocked = false;
        Console.WriteLine("Correct! Welcome");
    }
    else { Console.Write("Wrong One, try again! "); }
        
}

//BasicLoops Lab-Description 4 door keypad entry with attempts
Console.WriteLine("***BasicLoops Lab-Description 4 door keypad with attempts using while loop***");
//bool doorLockedA = true;
int keyCodeA = 13579;
int nofAttempts = 1;

while (nofAttempts <= 5) 
{
    Console.WriteLine("Enter a Keycode");
    int enteredKeyCodeA = Convert.ToInt32(Console.ReadLine());

    if (enteredKeyCodeA == keyCodeA)
    {
        //doorLockedA = false;
        Console.WriteLine("Correct! Welcome");
        break;
    }
  
    Console.Write("Wrong One! "); 
    nofAttempts++;

}
if (nofAttempts > 5)
{ Console.WriteLine("Too many incorrect Ateempts"); }



