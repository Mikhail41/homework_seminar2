// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int shownumber()
{

    Console.WriteLine("введите трехзачное число :");
    int num = Convert.ToInt32(Console.ReadLine());
    int second_num = num / 10 % 10;
    Console.WriteLine($"второй цифрой числа {num} являеться {second_num}");
    return (second_num);
}
Console.WriteLine(shownumber());