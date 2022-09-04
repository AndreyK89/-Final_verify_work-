/* Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789 |
Задача:
Написать программу, которая из имеющегося массива строк, формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма.

Пример:

[ hello, 2, world, :-)] -> [ 2, :-) ]
[ 1234, 1567, -2, computer science ] -> [ -2 ]
[ Rassia, Denmark, Kazan ] -> []
*/



string[] array = AskArray();
string[] result = FindLessThan(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] FindLessThan(string[] input, int n)
{
    string[] output = new string[CountLessThan(input, n)];

    for (int i = 0, j = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int CountLessThan(string[] input, int n)
{
    int count = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            count++;
        }
    }

    return count;
}

string[] AskArray()
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}