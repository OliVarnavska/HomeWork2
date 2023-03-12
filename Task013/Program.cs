//Задача 13: Напишите программу, которая выводит третью цифру
//заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

Console.WriteLine("Введите число:");
int x = Convert.ToInt32(Console.ReadLine());
int y = x % 10; 

while ((Math.Abs(x) > 99) && (Math.Abs(x) < 1000))
{
        break;
}
int z = x;
while (Math.Abs(z) > 1000)
{
    z /= 10;

}
int k = z % 10;

if (Math.Abs(z) < 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
Console.WriteLine(k);
}