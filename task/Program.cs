/* Решение задачи*/

string[] arrayOne = new string[] {"Kazan", "BMW", "Hello", "-2", "one", ":(", "{}", "1234", "kat"};
string[] arrayTwo = new string[arrayOne.Length];

void Array(string[] arrayOne, string[] arrayTwo)
{
    int count = 0;
    for (int i = 0; i < arrayOne.Length; i++)
    {
        if (arrayOne[i].Length <= 3)
        {
            arrayTwo[count] = arrayOne[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}

Array(arrayOne, arrayTwo);
PrintArray(arrayOne);
PrintArray(arrayTwo);