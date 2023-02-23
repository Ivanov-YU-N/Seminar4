/*Задача 29: Напишите метод, который задаёт массив из N элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int GetNumber(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return  number;
}

void Result(int[] array, int number)
{
    for(int i = 0; i < number; i++)
    array[i] = new Random().Next(2, 36);
}

void PrintArray(int[] array, int number)
{
    for(int i = 0; i < number; i++)
    Console.Write(array[i] + " ");
}


int index = GetNumber("Введите размер массива  ");
int[] array = new int[index];
Result(array, index);
PrintArray(array, index);
Console.WriteLine();