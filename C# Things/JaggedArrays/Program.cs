// Jagged array practice 

Console.WriteLine("=== JAGGED ARRAYS ===");

// Declare jagged arrays

int[][] arraySet = new int[3][];

arraySet[0] = new int[]{1,2,3};
arraySet[1] = new int[]{22,72,53,48,98,67};
arraySet[2] = new int[]{8,56,21,1,0};

for (int row = 0; row < arraySet.GetLength(0); row++)
{
    Console.WriteLine($"Row number: {row + 1}");
    for (int column = 0; column < arraySet[row].Length; column++)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"{arraySet[row][column]}\t");
        Console.ForegroundColor = ConsoleColor.White;
    }
    Console.WriteLine("\n");
}

Console.WriteLine("=== BUBBLE SORTED JAGGED ARRAYS ===");

for (int i = 0; i < arraySet.GetLength(0); i++)
{
    for (int j = 0; j < arraySet[i].Length; j++)
    {
        for (int k = 0; k < arraySet[i].Length - 1; k++)
        {
            if (arraySet[i][k] > arraySet[i][k + 1])
            {
                int tempNum = arraySet[i][k];
                arraySet[i][k] = arraySet[i][k + 1];
                arraySet[i][k + 1] = tempNum;
            }
        }
        
    }
}

for (int row = 0; row < arraySet.GetLength(0); row++)
{
    Console.WriteLine($"Row number: {row + 1}");
    
    for (int column = 0; column < arraySet[row].Length; column++)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write($"{arraySet[row][column]}\t");
        Console.ForegroundColor = ConsoleColor.White;
    }
    Console.WriteLine("\n");
}
