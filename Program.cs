System.Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
 if (number > 0 && number < 8)
{
if (number == 7 || number == 6)
{
    Console.Write("Под цифрой " + number + " - Выходной");
}
else
{
     Console.Write("Под цифрой " + number + " - Рабочий");
}
}
else
{
    Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
}
