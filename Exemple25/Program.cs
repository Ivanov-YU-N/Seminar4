/*Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
нельзя использовать Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int GetNumber(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;
}

void Result(int number, int degree)
{   int result = number;
    for(int i = 1; i < degree ; i++)
    {
        result *= number;
        
    }
    Console.WriteLine(result);
}

int number = GetNumber("Введите число  ");
int degree = GetNumber("Введите степень числа  ");
Result(number, degree);