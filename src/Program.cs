
string[] FilterByLength(string[] array, int len)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= len && array[i].Length > 0)
            count++;
    }
    string[] filteredArray = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= len && array[i].Length > 0){
            filteredArray[count] = array[i];
            count++;
        }
    }
    return filteredArray;    
}

void PrintArray(string[] array)
{
    Console.WriteLine($"[{String.Join(',', array)}]");
}



Console.WriteLine("Enter values separated by comma. " +
                    "When finished hit ENTER");
string input = Console.ReadLine();

string[] arr = input.Split(",");

string[] filteredArray = FilterByLength(arr, 3);

PrintArray(filteredArray);
