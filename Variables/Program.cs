// See https://aka.ms/new-console-template for more information
string courseName = "TrueCoders";
int startDay = 5;
char at = '@';
bool inProgress = true;
double priceOfDesk = 225.99;
decimal priceOfChair = 115.99m;

Console.WriteLine($"My first day {at} {courseName} was on August {startDay}th.");
if (inProgress == true)
{
    Console.WriteLine($"Before staring the class I bought myself a desk for {priceOfDesk} and a chair for {priceOfChair}.");
}