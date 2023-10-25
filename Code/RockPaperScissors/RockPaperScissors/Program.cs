// See https://aka.ms/new-console-template for more information
const string Paper = "Paper";
const string Rock = "Rock";
const string Scissors = "Scissors";

string playerChoice=String.Empty;
string computerChoice=String.Empty;

Console.WriteLine("Enter your choice!");
Console.WriteLine("For rock - rock/r");
Console.WriteLine("For paper - paper/p");
Console.WriteLine("For scissors - scissors/s");

var choice=Console.ReadLine();
if (choice.ToLower() == "rock" || choice.ToLower() == "r")
{
    playerChoice = Rock;
}
else if (choice.ToLower() == "paper" || choice.ToLower() == "p")
{
    playerChoice = Paper;
}
else if (choice.ToLower() == "scissors" || choice.ToLower() == "s")
{
    playerChoice = Scissors;
}
else
{
    while (playerChoice == String.Empty)
    {
        Console.WriteLine("Wrong input!");
        Console.WriteLine("Enter your choice again!");
        choice=Console.ReadLine();
        if (choice.ToLower() == "rock" || choice.ToLower() == "r")
        {
            playerChoice = Rock;
        }
        else if (choice.ToLower() == "paper" || choice.ToLower() == "p")
        {
            playerChoice = Paper;
        }
        else if (choice.ToLower() == "scissors" || choice.ToLower() == "s")
        {
            playerChoice = Scissors;
        }
    }
}