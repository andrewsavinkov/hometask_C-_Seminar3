/* №21 Напишите программу, которая принимает на вход координаты двух точек и находит
расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
* Сделать метод загрузки точек
*/
double[] ReadData(string line)
{
    Console.WriteLine(line);
    string coordinates = Console.ReadLine() ?? "";
    string[] coordXYZ = coordinates.Split(new char[] { ',' });
    double[] result = new double[3];
    for (int i = 0; i < 3; i++)
    {
        result[i] = Convert.ToDouble(coordXYZ[i]);
    }
    return result;
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

double ThreeDimLength(double[] coordInputOne, double[] coordInputTwo)
{
    double xComponent = Math.Pow(coordInputTwo[0] - coordInputOne[0], 2);
    double yComponent = Math.Pow(coordInputTwo[1] - coordInputOne[1], 2);
    double zComponent = Math.Pow(coordInputTwo[2] - coordInputOne[2], 2);
    double result = Math.Sqrt(xComponent + yComponent + zComponent);
    return Math.Round(result, 2);
}

double[] coordOne = ReadData("Введите координаты в формате: (x,y,z)");
double[] coordTwo = ReadData("Введите координаты в формате: (x,y,z)");
double length = ThreeDimLength(coordOne, coordTwo);
PrintData("Расстояние между точками равно: ", length.ToString());
