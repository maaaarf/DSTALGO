Console.WriteLine("=== SELECTION SORTING ===");

int[] arraySet = new int[]{53,16,31,1,73,9,6,2,3631,254};

int minPos;
int tempNum;



for (int i = 0; i < arraySet.Length - 1; i++)
{
    minPos = i;
    for (int j = i + 1; j < arraySet.Length; j++)
    {
        if (arraySet[j] < arraySet [minPos])
        {
            minPos = j;
        }
    }
    tempNum = arraySet[minPos];
    arraySet[minPos] = arraySet[i];
    arraySet[i] = tempNum;
}

foreach (int p in arraySet)
    Console.Write(p + "\t");
Console.Read();