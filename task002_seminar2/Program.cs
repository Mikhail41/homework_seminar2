//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Эта программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

string function()
{
    string stringNum = Convert.ToString(num);
    if (stringNum.Length > 2)
    {
        return "третья цифра числа -> " + stringNum[2];
    }
    else
    {
        return "третьей цифры нет";
    }
}
Console.WriteLine(function());
