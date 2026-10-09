// Machine problem: Daily Temperature and Trend Tracker
// Store temperature for '7 days' in a 1D Array
// Find the Highest and Lowest Temperature
// Find the weekly average temperature
// Find the total number of days above a certain temperature (e.g.: 31 degrees C)

// Declare variables

double highest, lowest, weeklyAve;
double sum = 0;
int daysAboveTemp = 0;
int lowIndex, highIndex;

Console.WriteLine("=== Daily Temperature and Trend Tracker ===\n");

// Initialize array for storage

double[] weatherTemp = [33.6,29.8,35.0,31.9,34.1,32.7,30.4];

// Initialize array for printing days of the week (absolutely not necessary)

string[] days = ["MON","TUE","WED","THU","FRI","SAT","SUN"];

foreach (var item in days)
{
    Console.Write(item + "\t");
}

Console.WriteLine();

highest = weatherTemp[0];
lowest = weatherTemp[0];
highIndex = 0;
lowIndex = 0;

for (int i = 1; i < weatherTemp.Length - 1; i++)
{
    if (weatherTemp[i] > highest)
    {
        highest = weatherTemp[i];
        highIndex = i;
    }
    else if (weatherTemp[i] < lowest)
    {
        lowest = weatherTemp[i];
        lowIndex = i;
    }
}
for (int i = 0; i < weatherTemp.Length; i++)
{
    sum += weatherTemp[i];

    Console.Write($"{weatherTemp[i]:F1}\t");

    if (weatherTemp[i] > 31.0)
    {
        daysAboveTemp++;
    }
}

Console.WriteLine("\n");

Console.WriteLine($"Highest temperature: {days[highIndex]} at {highest:F1}");
Console.WriteLine($"Lowest temperature: {days[lowIndex]} at {lowest:F1}\n");

weeklyAve = sum / weatherTemp.Length;

Console.WriteLine($"Average temperature for the week: {weeklyAve:F1}");

Console.WriteLine($"\nDays above temp: {daysAboveTemp}");

Console.ReadLine();