// Model a theatre with R rows and C seats per row
// Initialize as 0 for empty and 1 for occupied
// Build a menu system allowing the user to do the following
// Display the current seating map in the terminal  
// Reserve a specific seat by R row and C column
// Find the first row that has N adjacent empty seats available.

// Initialize theatre array set

using System.Dynamic;

bool isNotOccupied = false;
bool isOccupied = true;
bool loopCheck = true;

bool[,] seatPlan = new bool[5,6]; 

void displaySeatPlan()
{   
    Console.WriteLine("Seating Chart".PadLeft(23));
    for (int i = 0; i < seatPlan.GetLength(0); i++)
    {
        Console.Write("\t");
        for (int j = 0; j < seatPlan.GetLength(1); j++)
        {
            if (seatPlan[i,j] == isNotOccupied)
            {
                Console.Write("[ ]");
            }
            else if (seatPlan[i,j] == isOccupied)
            {
                Console.Write("[x]");
            }
        }
        Console.WriteLine();
    }
}

string row = "";
string column = "";

void reserveSeat(string n)
{
    string num = "";
    string letter = "";

    foreach (char x in n)
    {
        if (x >= '0' && x <= '9')
        {
            num += x;
            column = num;
        }
        else if (x >= 'A' && x <= 'Z' || x >= 'a' && x <= 'z' )
        {
            letter += x;
            row = letter;
        }
    }
}

Console.WriteLine("=== SEATING CHART MANAGEMENT SYSTEM ===");
Console.WriteLine("Press any key to continue...");
Console.ReadLine();
Console.WriteLine();

// Menu system

while (loopCheck)
{
    Console.Write("What would you like to do?\n1. Display seating map\n2. Reserve a seat\n3. Find available seats in batches\n4. Exit\n>>> ");
    int menuDecision = Convert.ToInt32(Console.ReadLine());

    switch (menuDecision)
    {
        case 1:
        displaySeatPlan();
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadLine();
        break;

        case 2:
        // Reserve seat
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        reserveSeat(input);
        Console.WriteLine($"Your seat is reserved at row {row} column {column}");
        break;

        case 3:
        //Find adjacent N seats
        break;

        case 4:
        //Exit the program
        loopCheck = false;
        break;
    }
}

// string input = "he5llo wo2rl3d";

// string numbers = "";
// string letters;

// foreach (char c in input)
// {
//     if (c >= '0' && c <= '9')
//     {
//         numbers += c;
//     }
// }

// Console.WriteLine(numbers);
// int numbersVal = int.Parse(numbers);

// Console.WriteLine(numbersVal + 1);

