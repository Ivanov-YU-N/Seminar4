/*Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int GetNumber(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;
}

void Result(int number)
{   
    int result = 0;
    for(;number > 0; number /= 10)
    {
        result = result + number % 10;
    }
    Console.WriteLine(result);
}
int number = GetNumber("Введите число  ");
Result(number);