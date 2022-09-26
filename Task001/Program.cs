//Задача 19
// Напишите метод, который принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
int InputNumber()
{
    Console.Write("Введите пятизначное число: ");
    return Convert.ToInt32(Console.ReadLine());
}
void Logic(int number, int fifthCategory, int fourthCategory, int thirdCategory, int secondCategory, int firstCategory)
{
    if (fifthCategory == firstCategory && fourthCategory == secondCategory)
    {
        Console.WriteLine("Число " + number + " является палиндромом");
    }
    else
    {
        Console.WriteLine("Число " + number + " НЕ является палиндромом!");
    }
}
int number = InputNumber();
//12345
int fifthCategory = number / 10000;//1
int fourthCategory = (number % 10000) / 1000;//2
int thirdCategory = (number % 1000) / 100;//3
int secondCategory = (number % 100) / 10;//4
int firstCategory = number % 10;//5
Logic(number, fifthCategory, fourthCategory, thirdCategory, secondCategory, firstCategory);

