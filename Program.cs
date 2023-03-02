// Создать массив из строк который из имеюшегося массива возьмет все строки с размером менее или равное 3 символом и засунит их в новый массив.


string[] array = { "Sunn", "Monn", "Tu", "Wedd", "Thuu", "Frid", "Sat" };

string[] arraySorting (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) count ++;
        
    }
    string[] newArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) 
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

string[] finalArray = arraySorting(array);
Console.WriteLine($"[{string.Join(" ,", finalArray)}]");