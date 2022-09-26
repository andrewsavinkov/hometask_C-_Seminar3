/* №23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
* Вывести таблицу с границами и значениями друг над другом
*/

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void PowerTable(int lastNumber, int power)  // выводит таблицу кубов от 1 до lastNumber. Если lastNumber больше 100, выводит первые 4 цифры числа, 
                                            //так как столбец вмещает только 7 символов 
{
    int tableWidth = 17;
    Console.WriteLine(new string('-', tableWidth));
    Console.WriteLine("|Число\t|Куб\t|");
    for (int i = 1; i <= lastNumber; i++)
    {
        Console.WriteLine(new string('-', tableWidth));
        if (Math.Pow(i, power) < 1000000)
        {
            Console.WriteLine("|{0}\t|{1}\t|", i, Math.Pow(i, power));
        }
        else
        {
            string shorten = Math.Pow(i, power).ToString();
            shorten = shorten.Substring(0, 4) + "...";
            Console.WriteLine("|{0}\t|{1}|", i, shorten);
        }
    }
    Console.WriteLine(new string('-', tableWidth));
}

int lastCube = ReadData("Введите число, куб которого хотите увидеть последним: ");
PowerTable(lastCube, 3);


