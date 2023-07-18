// Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int j = i;
while(j > 0)
{
    int num = j % 10;
    j = j / 10;
    sum = sum + num;
}
Console.WriteLine($"Сумма числа {i} равна: "+ sum);
