/*
 * Program Name: Create Your Own Creature
 * Programmer: Owen Perna
 * Date: 12/19/2022
 *
 * Description: Using this program, you can create
 * your own creature from a few options of mythological
 * creatures, set a password for that creature, and
 * log in as that creature.
 */

using System.Globalization;

bool isLooping = true;
bool isLooping2 = true;

List<Creature> creatureList = new List<Creature>();
List<Human> humanList = new List<Human>();
List<Elf> elfList = new List<Elf>();
List<Harpy> harpyList = new List<Harpy>();
List<Centaur> centaurList = new List<Centaur>();
List<Goblin> goblinList = new List<Goblin>();
List<Golem> golemList = new List<Golem>();

while (isLooping2)
{

    Console.WriteLine("Press 1 to login as an existing creature.");
    Console.WriteLine("Press 2 to create a new creature.");
    string userInput = Console.ReadLine();

    if (userInput == "1")
    {
        Login();
    }
    else if (userInput == "2")
    {
        CreateCreature();
    }
    else
    {
        Console.WriteLine("Invalid selection...");
    }
}


void CreateCreature()
{
    isLooping = true;
    string species;

    Console.Clear();
    Console.WriteLine("What is the name of your creature?");
    string n = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("What is the species of the creature?");
    Console.WriteLine("Type 1 for Human");
    Console.WriteLine("Type 2 for Elf");
    Console.WriteLine("Type 3 for Harpy");
    Console.WriteLine("Type 4 for Centaur");
    Console.WriteLine("Type 5 for Goblin");
    Console.WriteLine("Type 6 for Golem");
    species = Console.ReadLine();
    if (species == "1")
    {
        Console.Clear();
        isLooping = false;
            
        Console.WriteLine("What is the age of " + n + "?");
        string age = Console.ReadLine();
        Console.WriteLine("What is the sex of " + n + "?");
        string sex = Console.ReadLine();
        Console.WriteLine("What is the height of " + n + "? (In feet.inches)");
        string height = Console.ReadLine();
        Console.WriteLine("What is the weight of " + n + "? (In pounds)");
        string weight = Console.ReadLine();
        Console.WriteLine("Finally, what is the password for this human?");
        string pw = Console.ReadLine();
        humanList.Add(new Human(n, pw));
    }
    else if (species == "2")
    {
        Console.Clear();
        isLooping = false;

        Console.WriteLine("What is the age of " + n + "?");
        string age = Console.ReadLine();
        Console.WriteLine("What is the sex of " + n + "?");
        string sex = Console.ReadLine();
        Console.WriteLine("What is the height of " + n + "? (In feet.inches)");
        string height = Console.ReadLine();
        Console.WriteLine("What is the weight of " + n + "? (In pounds)");
        string weight = Console.ReadLine();
        Console.WriteLine("Finally, what is the password for this elf?");
        string pw = Console.ReadLine();
        elfList.Add(new Elf(n, pw));
    }
    else if (species == "3")
    {
        Console.Clear();
        isLooping = false;

        Console.WriteLine("What is the age of " + n + "?");
        string age = Console.ReadLine();
        Console.WriteLine("What is the sex of " + n + "?");
        string sex = Console.ReadLine();
        Console.WriteLine("What is the height of " + n + "? (In feet.inches)");
        string height = Console.ReadLine();
        Console.WriteLine("What is the weight of " + n + "? (In pounds)");
        string weight = Console.ReadLine();
        Console.WriteLine("Finally, what is the password for this harpy?");
        string pw = Console.ReadLine();
        harpyList.Add(new Harpy(n, pw));
    }
    else if (species == "4")
    {
        Console.Clear();
        isLooping = false;

        Console.WriteLine("What is the age of " + n + "?");
        string age = Console.ReadLine();
        Console.WriteLine("What is the sex of " + n + "?");
        string sex = Console.ReadLine();
        Console.WriteLine("What is the height of " + n + "? (In feet.inches)");
        string height = Console.ReadLine();
        Console.WriteLine("What is the weight of " + n + "? (In pounds)");
        string weight = Console.ReadLine();
        Console.WriteLine("Finally, what is the password for this centaur?");
        string pw = Console.ReadLine();
        centaurList.Add(new Centaur(n, pw));
    }
    else if (species == "5")
    {
        Console.Clear();
        isLooping = false;

        Console.WriteLine("What is the age of " + n + "?");
        string age = Console.ReadLine();
        Console.WriteLine("What is the sex of " + n + "?");
        string sex = Console.ReadLine();
        Console.WriteLine("What is the height of " + n + "? (In feet.inches)");
        string height = Console.ReadLine();
        Console.WriteLine("What is the weight of " + n + "? (In pounds)");
        string weight = Console.ReadLine();
        Console.WriteLine("Finally, what is the password for this goblin?");
        string pw = Console.ReadLine();
        goblinList.Add(new Goblin(n, pw));
    }
    else if (species == "6")
    {
        Console.Clear();
        isLooping = false;

        Console.WriteLine("What is the age of " + n + "?");
        string age = Console.ReadLine();
        Console.WriteLine("What is the sex of " + n + "?");
        string sex = Console.ReadLine();
        Console.WriteLine("What is the height of " + n + "? (In feet.inches)");
        string height = Console.ReadLine();
        Console.WriteLine("What is the weight of " + n + "? (In pounds)");
        string weight = Console.ReadLine();
        Console.WriteLine("Finally, what is the password for this golem?");
        string pw = Console.ReadLine();
        golemList.Add(new Golem(n, pw));
    }
    Console.Clear();
}
void Login()
{
    Console.WriteLine("Enter your creature's name: ");
    string n = Console.ReadLine();
    Console.WriteLine("Enter password for your creature: ");
    string pw = Console.ReadLine();

    foreach (Human human in humanList)
    {
        if (human.name == n)
        {
            if (human.password == pw)
            {
                LoadApp(n);
            }
            else
            {
                Console.WriteLine("Invalid Password.");
                Login();
            }
        }
        else
        {
            Console.WriteLine("Invalid Username.");
            Login();
        }
    }
    foreach (Elf elf in elfList)
    {
        if (elf.name == n)
        {
            if (elf.password == pw)
            {
                LoadApp(n);
            }
            else
            {
                Console.WriteLine("Invalid Password.");
                Login();
            }
        }
        else
        {
            Console.WriteLine("Invalid Username.");
            Login();
        }
    }
    foreach (Harpy harpy in harpyList)
    {
        if (harpy.name == n)
        {
            if (harpy.password == pw)
            {
                LoadApp(n);
            }
            else
            {
                Console.WriteLine("Invalid Password.");
                Login();
            }
        }
        else
        {
            Console.WriteLine("Invalid Username.");
            Login();
        }
    }
    foreach (Centaur centaur in centaurList)
    {
        if (centaur.name == n)
        {
            if (centaur.password == pw)
            {
                LoadApp(n);
            }
            else
            {
                Console.WriteLine("Invalid Password.");
                Login();
            }
        }
        else
        {
            Console.WriteLine("Invalid Username.");
            Login();
        }
    }
    foreach (Goblin goblin in goblinList)
    {
        if (goblin.name == n)
        {
            if (goblin.password == pw)
            {
                LoadApp(n);
            }
            else
            {
                Console.WriteLine("Invalid Password.");
                Login();
            }
        }
        else
        {
            Console.WriteLine("Invalid Username.");
            Login();
        }
    }
    foreach (Golem golem in golemList)
    {
        if (golem.name == n)
        {
            if (golem.password == pw)
            {
                LoadApp(n);
            }
            else
            {
                Console.WriteLine("Invalid Password.");
                Login();
            }
        }
        else
        {
            Console.WriteLine("Invalid Username.");
            Login();
        }
    }
}
void LoadApp(string n)
{
    Console.Clear();
    Console.WriteLine("Welcome " + n + "!");
}