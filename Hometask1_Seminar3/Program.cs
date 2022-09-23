/* №19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
* Сделать вариант через СЛОВАРЬ четырехзначных палиндромов */


// стандартное решение
int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

bool IsPalindrome(int value)
{
    if (value / 10000 == value % 10 && (value / 1000) % 10 == (value / 10) % 10)
    {
        return true;
    }
    else
        return false;
}

int number = ReadData("Введите 5-значное число: ");
if (number < 10000 || number > 99999)
{
    PrintData("Введите число в заданном диапазоне", "");
}
else
{
    bool check = IsPalindrome(number);
    PrintData("Палиндром?", check.ToString());
}

// решение через словарь 4-х-значных палиндромов:

Dictionary<int, string> CreatePalindromesList() // создаём словарь 4-значных палиндромов (функция)
{
    var list = new Dictionary<int, string>();
    for (int i = 1000; i < 10000; i++)
    {
        if (i / 1000 == i % 10 && (i / 100) % 10 == (i / 10) % 10)
        {
            list.Add(i, "is Palindrome number");
        }
    }
    return list;
}
bool SearchTheDictionary(int keyword, Dictionary<int, string> dict) // функция поиска введенного значения в словаре палиндромов
{
    string mediatorValue = keyword.ToString();
    mediatorValue = mediatorValue.Substring(0, mediatorValue.Length - 3) + mediatorValue.Substring(3);
    keyword = int.Parse(mediatorValue);
    bool result = dict.ContainsKey(keyword);
    return result;
}
int searchValue = ReadData("Введите 5-значное число: ");
var listing = CreatePalindromesList();
if (searchValue < 10000 || searchValue > 99999)
{
    PrintData("Введите число из заданного диапазона", "");
}
else
{
    bool check = SearchTheDictionary(searchValue, listing);
    PrintData("Введенное число палиндром?", check.ToString());
}