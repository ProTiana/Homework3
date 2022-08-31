// Напишите программу, которая принимает число N и возвращает таблицукубов чисел от 1 до N


Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

string FindCube(int n)
{
    string result = "";
    for (int i = 1; i <= n; i++)
    {
        result += $"{Math.Pow(i, 3)} ";
    }
    return result;
}

//string Cubs = FindCube(N);
Console.WriteLine(FindCube(N));

