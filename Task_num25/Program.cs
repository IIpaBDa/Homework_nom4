//Семинар 4.
//Домашнее задание.
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Выполнил: Кельт Дмитрий Владимирович (kelt_1981@mail.ru)
//Решение:

int number = ReadInt("Введите число: ");
int degree = ReadInt("Введите степень: ");

if (Degree(number, degree) != -1)
{
    System.Console.WriteLine($"{number} в степени {degree} = {Degree(number, degree)}");
}
else
{
    System.Console.WriteLine("Ошибка! В процессе вычисления присутствует 0.");
}

int ReadInt(string argument)
{
	Console.Write(argument);
	int i;
	while (!int.TryParse(Console.ReadLine(), out i))
	{
        Console.WriteLine("Вы ввели не число!");
        Console.Write(argument);
	}
	return i;
}
double Degree(int a, int b)
{
    double multiplication = 1;
    if (b > 0)
    {
        for (int i = 1; i <= b; i++)
        {
            multiplication = multiplication * a;
        }
        return multiplication;
    }
    else if (b < 0 && a!=0)
    {
        b = Math.Abs(b);
        for (int i = 1; i <= b; i++)
        {
            multiplication = multiplication * a;
        }
        multiplication = 1 / multiplication;
        return multiplication;
    }
    else
    {
        multiplication = -1;
        return multiplication;
    }
}
