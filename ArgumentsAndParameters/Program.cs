Console.WriteLine("Enter a word");
string userInput = Console.ReadLine(); // kasutaja annab argumendi väärtusele 'userInput'

PrintAnyWord(userInput);

static void PrintAnyWord(string anyString) // anyString = parameeter
{
	anyString= anyString.ToUpper();
	for (int i = 0; i < 5; i++)
	{
		Console.WriteLine(anyString);
	}
}
