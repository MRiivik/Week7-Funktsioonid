Console.WriteLine("Are you coming or leaving? (in/out):");
string userChoice = Console.ReadLine();

if(userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodbye(); // toob allolevad käsud välja
}
static void PrintHello() //function ehk 'meetod'
{
    Console.WriteLine("Hello, World!");
}

static void PrintGoodbye()
{
    Console.WriteLine("See you later, alligator!");
}