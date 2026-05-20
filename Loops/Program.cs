int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

Console.WriteLine("Enter an integer value between 5 and 10");
string? input = null;
bool validIntInput = false;
do
{
    input = Console.ReadLine();
    if (int.TryParse(input, out int value))
    {
        if(value >= 5 && value <= 10)
        {
            validIntInput = true;
            Console.WriteLine($"Your input value ({value}) has been accepted.");
        }
        else
            Console.WriteLine($"You entered {value}. Please enter a number between 5 and 10.");
    }
    else
    {
        Console.WriteLine("Sorry you entered an invalid number, please try again.");
    }
}
while (!validIntInput);


bool validRoleInput = false;
do
{
    Console.WriteLine("Enter your role name (Administrator, Manager or User)");
    input = Console.ReadLine();
    if (input?.Trim().ToLower() == "administrator" || input?.Trim().ToLower() == "manager" || input?.Trim().ToLower() == "user")
    {
        validRoleInput = true;
        Console.WriteLine($"Your input value ({input.Trim()}) has been accepted.");
    }
    else
    {
        Console.WriteLine($"The role name that you entered, \"{input}\" is not valid.");
    }
}
while (!validRoleInput);

string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];

int periodLocation = 0;

for(int i = 0; i < myStrings.Length; i++)
{
    string myString = myStrings[i];
    periodLocation = myString.IndexOf(".");
    string mySentence = string.Empty;
    while (periodLocation != -1)
    {
        mySentence = myString.Remove(periodLocation);
        myString = myString.Substring(periodLocation + 1).TrimStart();
        periodLocation = myString.IndexOf(".");
        Console.WriteLine(mySentence);
    }
    Console.WriteLine($"{myString.Trim()}");
}