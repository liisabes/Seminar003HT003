//Задача 21
//Напишите метод, который принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


void DistanceBetweenPoints(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double x = x2 - x1;
    double y = y2 - y1;
    double z = z2 - z1;
    double distanceBetweenPoints = Math.Sqrt(x*x + y*y + z*z);
    Console.WriteLine("Расстояние между точками в 3D пространстве: " + distanceBetweenPoints);
}

Console.Write("Введите x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z1: ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z2: ");
double z2 = Convert.ToInt32(Console.ReadLine());

DistanceBetweenPoints(x1, x2, y1, y2, z1, z2);