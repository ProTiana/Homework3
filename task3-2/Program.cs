// ввести координаты 2х точек в трехмерном пространстве и найти расстояние между ними

Console.WriteLine("Введите координаты точки А");
double x1 = Convert.ToInt32(Console.ReadLine());
double y1 = Convert.ToInt32(Console.ReadLine());
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки В");
double x2 = Convert.ToInt32(Console.ReadLine());
double y2 = Convert.ToInt32(Console.ReadLine());
double z2 = Convert.ToInt32(Console.ReadLine());

double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double sum = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2);
    double result = Math.Pow(sum, 0.5);
    return result;
}
double Distance = FindDistance(x1, y1, z1, x2, y2, z2);

Console.Write("Длина отрезка = ");
Console.WriteLine(Distance);


