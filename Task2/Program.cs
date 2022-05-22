// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int GetNumber(string msg)
{
    while(true)
    {
    Console.WriteLine(msg);
    string valueFromConsole = Console.ReadLine();
    
        if(int.TryParse(valueFromConsole, out int number))
            return number;
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число, отличное от нуля");
        }
    }
}  

double GetLength(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double difX = Math.Pow((x1 - x2) , 2);
    double difY = Math.Pow((y1 - y2) , 2);
    double difZ = Math.Pow((z1 - z2) , 2);
    double length = Math.Sqrt(difX+difY+difZ);
    return length;
}

string messageX1 = "Введите координату первой точки по оси X: ";
int x1 = GetNumber(messageX1);
string messageY1 = "Введите координату первой точки по оси Y: ";
int y1 = GetNumber(messageY1);
string messageZ1 = "Введите координату первой точки по оси Z: ";
int z1 = GetNumber(messageZ1);
string messageX2 = "Введите координату второй точки по оси X: ";
int x2 = GetNumber(messageX2);
string messageY2 = "Введите координату второй точки по оси Y: ";
int y2 = GetNumber(messageY2);
string messageZ2 = "Введите координату первой точки по оси Z: ";
int z2 = GetNumber(messageZ2);

double result = GetLength(x1, x2, y1, y2, z1, z2);
Console.WriteLine($"Расстояние между двумя точками {result}");
