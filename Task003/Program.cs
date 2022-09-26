//Задача 23
//Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int InputNumber()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}
void Cube(int number)
{
    for (int i = 1; i <= number; i++)
    {
        int cube = i * i * i;
        Console.Write(cube + " ");
    }
}
int number = InputNumber();
Cube(number);



