// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int GetNumber(string msg)
{
    while(true)
    {
    Console.WriteLine(msg);
    string valueFromConsole = Console.ReadLine();
    

        if(int.TryParse(valueFromConsole, out int number))
        {
            if(number != 0)
                return number;
                else
                {
                    Console.WriteLine("Число должно отличаться от 0. Введите другое число");
                }
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число, отличное от нуля");
        }
    }
}  

void GetCube(int n)
{
    for (int i = 1; i < n; i++)
    {
        int result = i*i*i;
        Console.WriteLine($"{result}");
    }
}

string message = "Введите число N: ";
int n = GetNumber(message);
GetCube(n);