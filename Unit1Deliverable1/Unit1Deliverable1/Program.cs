// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int people = 0;

double loavesNeeded = 0;
double penutJarsNeeded = 0;
double jellyJarsNeeded = 0;

double slicesNeeded = 0;
double tbspPenutNeeded = 0;
double tspJellyNeeded = 0;

int slicesPerLoaf = 28;
int tbspPerJarPenut = 32;
int tspPerJarJelly = 48;

string continueYes = "yes";
string continueY = "y";
string restart = "";

Console.WriteLine("Welcome to the PB&J calculator!");
do
{
    Console.WriteLine("How many people are you trying to feed?");
    string input = Console.ReadLine();
    people = int.Parse(input);
    //Console.WriteLine($"you are trying to feed {people} people");
    slicesNeeded = people * 2;
    loavesNeeded = slicesNeeded / slicesPerLoaf;
    loavesNeeded = Math.Ceiling(loavesNeeded);
    //Console.WriteLine($"You are going to need {loavesNeeded} loaves of bread.");

    tbspPenutNeeded = people * 2;
    penutJarsNeeded = tbspPenutNeeded / tbspPerJarPenut;
    penutJarsNeeded = Math.Ceiling(penutJarsNeeded);
    //Console.WriteLine($"You are going to need {penutJarsNeeded} jar(s) of penut butter.");

    tspJellyNeeded = people * 4;
    jellyJarsNeeded = tspJellyNeeded / tspPerJarJelly;
    jellyJarsNeeded = Math.Ceiling(jellyJarsNeeded);
    //Console.WriteLine($"You are going to need {jellyJarsNeeded} jar(s) of jelly.");

    Console.WriteLine($"You are going to need {loavesNeeded} loaves of bread.");
    Console.WriteLine($"{penutJarsNeeded} jar(s) of penut butter");
    Console.WriteLine($"and {jellyJarsNeeded} jar(s) of jelly.");
    Console.WriteLine("");

    Console.WriteLine("Would you like to start again?");
    restart = Console.ReadLine();
    restart = restart.ToLower();

} while (restart == continueYes || restart == continueY);

Console.WriteLine("Goodbye");