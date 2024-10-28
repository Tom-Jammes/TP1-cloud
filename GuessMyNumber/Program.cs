Random random = new Random();

int userNumber = 0;
int computerNumber = random.Next(1, 11);
string? userInput;
bool userHasWon = false;

Console.WriteLine("Entrez un nombre entre 1 et 10");

while (!userHasWon)
{
    userInput = Console.ReadLine();
    if (userInput == null) Console.WriteLine("Il faut entrer quelque chose");
    else if (!int.TryParse(userInput, out userNumber)) Console.WriteLine("Il faut rentrer un nombre");
    else
    {
        userHasWon = int.Parse(userInput) == computerNumber;
        if (!userHasWon) Console.WriteLine("Perdu");
    }
}

Console.WriteLine("Gagné");