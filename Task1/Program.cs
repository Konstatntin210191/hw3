// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int GetNumber(string msg)
{
    while(true)
    {
    Console.WriteLine(msg);
    string valueFromConsole = Console.ReadLine();
    
        if(int.TryParse(valueFromConsole, out int number))
        {
            if(number > 9999 & number < 100000)
            return number;
            else
            {
                Console.WriteLine("Вы ввели не пятизначное число. Введите, пожалуйста, пятизначное число");
            }
        }
        else
        {
            Console.WriteLine("Вы ввели не не число. Введите, пожалуйста, пятизначное число");
        }
    }
}

int GetRest(int n)
{
    int result = n % 10;
    return result;
}

string message = "Введите пятизначное число: ";
int fiveSign = GetNumber(message);

int n1 = fiveSign / 10000;
int result1 = GetRest(n1);
int n2 = fiveSign / 1000;
int result2 = GetRest(n2);
int n4 = fiveSign / 10;
int result4 = GetRest(n4);
int n5 = fiveSign / 1;
int result5 = GetRest(n5);

int sum1 = result1 + result2;
int sum2 = result4 + result5;

if (sum1 == sum2)
{
    Console.WriteLine("Заданное пятизначное число ЯВЛЯЕТСЯ палиндромом");
}
else
{
    Console.WriteLine("Заданное пятизначное число НЕ ЯВЛЯЕТСЯ палиндромом");
}
