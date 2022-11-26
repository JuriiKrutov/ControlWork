/*написать программу, которая из иммеющегося массива строк формирует массив строк, длинна которых меньше или равна 3 символа. 
первоночальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
коллекциями, лучше обойтись исключительно массивами*/


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

string[] array = {"hello", "2", "world", ":-)" };
string[] massiv = new string [array.Length];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        massiv[count] = array[i];
        count++;
    }
}

PrintArray(array);
System.Console.WriteLine();
PrintArray(massiv);