//Семинар 4.
//Домашнее задание.
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//Выполнил: Кельт Дмитрий Владимирович (kelt_1981@mail.ru)
//Решение:

int [] array = new int[8];

int[] FillArray()
{
    int Length = array.Length;
    int index = 0;
    while (index < Length)
    {
        array[index] = new Random().Next();
        index++;
    }
    return array;
}

System.Console.WriteLine(string.Join("  ", FillArray()));
