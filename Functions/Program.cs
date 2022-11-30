Console.WriteLine("Are you coming or leaving? (in/out):");
string userChoice = Console.ReadLine();

if(userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodbue();
}


static void PrintHello() //function / method
{
 Console.WriteLine("Hello, World!");
}


static void PrintGoodbue()
{
 Console.WriteLine("See you later, aligator.");
}