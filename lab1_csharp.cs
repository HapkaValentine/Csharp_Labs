using System;

internal class Programm
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Лабораторная работа №1. Нечётный вариант.");
            Console.WriteLine("1  - fraction");
            Console.WriteLine("2  - charToNum");
            Console.WriteLine("3  - is2Digits");
            Console.WriteLine("4  - isInRange");
            Console.WriteLine("5  - isEqual");
            Console.WriteLine("6  - abs");
            Console.WriteLine("7  - is35");
            Console.WriteLine("8  - max3");
            Console.WriteLine("9  - sum2");
            Console.WriteLine("10 - day");
            Console.WriteLine("11 - listNums");
            Console.WriteLine("12 - chet");
            Console.WriteLine("13 - numLen");
            Console.WriteLine("14 - square");
            Console.WriteLine("15 - rightTriangle");
            Console.WriteLine("16 - findFirst");
            Console.WriteLine("17 - maxAbs");
            Console.WriteLine("18 - add (массив в массив)");
            Console.WriteLine("19 - reverseBack");
            Console.WriteLine("20 - findAll");
            Console.WriteLine("0  - Выход");
            Console.Write("Выберите пункт: ");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 20)
            {
                Console.Write("Ошибка! Введите число от 0 до 20: ");
            }

            if (choice == 0) break;

            switch (choice)
            {
                case 1:
                    Console.Write("Введите число x: ");
                    double x1 = ReadDouble();
                    Console.WriteLine("Результат: " + fraction(x1));
                    break;

                case 2:
                    Console.Write("Введите цифру от 0 до 9: ");
                    char c2 = ReadDigit();
                    Console.WriteLine("Результат: " + charToNum(c2));
                    break;

                case 3:
                    Console.Write("Введите число x: ");
                    int x3 = ReadInt();
                    Console.WriteLine("Результат: " + is2Digits(x3));
                    break;

                case 4:
                    Console.Write("Введите a: ");
                    int a4 = ReadInt();
                    Console.Write("Введите b: ");
                    int b4 = ReadInt();
                    Console.Write("Введите num: ");
                    int num4 = ReadInt();
                    Console.WriteLine("Результат: " + isInRange(a4, b4, num4));
                    break;

                case 5:
                    Console.Write("Введите a: ");
                    int a5 = ReadInt();
                    Console.Write("Введите b: ");
                    int b5 = ReadInt();
                    Console.Write("Введите c: ");
                    int c5 = ReadInt();
                    Console.WriteLine("Результат: " + isEqual(a5, b5, c5));
                    break;

                case 6:
                    Console.Write("Введите x: ");
                    int x6 = ReadInt();
                    Console.WriteLine("Результат: " + abs(x6));
                    break;

                case 7:
                    Console.Write("Введите x: ");
                    int x7 = ReadInt();
                    Console.WriteLine("Результат: " + is35(x7));
                    break;

                case 8:
                    Console.Write("Введите x: ");
                    int x8 = ReadInt();
                    Console.Write("Введите y: ");
                    int y8 = ReadInt();
                    Console.Write("Введите z: ");
                    int z8 = ReadInt();
                    Console.WriteLine("Результат: " + max3(x8, y8, z8));
                    break;

                case 9:
                    Console.Write("Введите x: ");
                    int x9 = ReadInt();
                    Console.Write("Введите y: ");
                    int y9 = ReadInt();
                    Console.WriteLine("Результат: " + sum2(x9, y9));
                    break;

                case 10:
                    Console.Write("Введите номер дня недели (1-7): ");
                    int x10 = ReadIntInRange(1, 7);
                    Console.WriteLine("Результат: " + day(x10));
                    break;

                case 11:
                    Console.Write("Введите x (x >= 0): ");
                    int x11 = ReadIntInRange(0, int.MaxValue);
                    Console.WriteLine("Результат: " + listNums(x11));
                    break;

                case 12:
                    Console.Write("Введите x (x >= 0): ");
                    int x12 = ReadIntInRange(0, int.MaxValue);
                    Console.WriteLine("Результат: " + chet(x12));
                    break;

                case 13:
                    Console.Write("Введите x (x >= 0): ");
                    long x13 = ReadLongInRange(0, long.MaxValue);
                    Console.WriteLine("Результат: " + numLen(x13));
                    break;

                case 14:
                    Console.Write("Введите размер квадрата x (x >= 1): ");
                    int x14 = ReadIntInRange(1, int.MaxValue);
                    square(x14);
                    break;

                case 15:
                    Console.Write("Введите высоту треугольника x (x >= 1): ");
                    int x15 = ReadIntInRange(1, int.MaxValue);
                    rightTriangle(x15);
                    break;

                case 16:
                    int[] arr16 = ReadArray();
                    Console.Write("Введите искомое число x: ");
                    int x16 = ReadInt();
                    Console.WriteLine("Результат: " + findFirst(arr16, x16));
                    break;

                case 17:
                    int[] arr17 = ReadArray();
                    Console.WriteLine("Результат: " + maxAbs(arr17));
                    break;

                case 18:
                    int[] arr18 = ReadArray();
                    int[] ins18 = ReadArray();
                    Console.Write("Введите позицию вставки: ");
                    int pos18 = ReadIntInRange(0, arr18.Length);
                    int[] result18 = add(arr18, ins18, pos18);
                    PrintArray(result18);
                    break;

                case 19:
                    int[] arr19 = ReadArray();
                    int[] result19 = reverseBack(arr19);
                    PrintArray(result19);
                    break;

                case 20:
                    int[] arr20 = ReadArray();
                    Console.Write("Введите искомое число x: ");
                    int x20 = ReadInt();
                    int[] result20 = findAll(arr20, x20);
                    PrintArray(result20);
                    break;
            }
        }
    }

    private static int ReadInt()
    {
        while (true)
        {
            string s = Console.ReadLine();
            if (int.TryParse(s, out int result))
                return result;
            Console.Write("Ошибка! Введите целое число: ");
        }
    }

    private static int ReadIntInRange(int min, int max)
    {
        while (true)
        {
            string s = Console.ReadLine();
            if (int.TryParse(s, out int result) && result >= min && result <= max)
                return result;
            Console.Write("Ошибка! Введите число от " + min + " до " + max + ": ");
        }
    }

    private static long ReadLongInRange(long min, long max)
    {
        while (true)
        {
            string s = Console.ReadLine();
            if (long.TryParse(s, out long result) && result >= min && result <= max)
                return result;
            Console.Write("Ошибка! Введите число от " + min + " до " + max + ": ");
        }
    }

    private static double ReadDouble()
    {
        while (true)
        {
            string s = Console.ReadLine();
            if (double.TryParse(s, out double result))
                return result;
            Console.Write("Ошибка! Введите вещественное число: ");
        }
    }

    private static char ReadDigit()
    {
        while (true)
        {
            string s = Console.ReadLine();
            if (s.Length == 1 && s[0] >= '0' && s[0] <= '9')
                return s[0];
            Console.Write("Ошибка! Введите одну цифру от 0 до 9: ");
        }
    }

    private static int[] ReadArray()
    {
        while (true)
        {
            Console.Write("Введите элементы массива через пробел: ");
            string s = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Ошибка! Массив не должен быть пустым.");
                continue;
            }
            string[] parts = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[parts.Length];
            bool ok = true;
            for (int i = 0; i < parts.Length; i++)
            {
                if (!int.TryParse(parts[i], out arr[i]))
                {
                    ok = false;
                    break;
                }
            }
            if (ok && arr.Length > 0)
                return arr;
            Console.WriteLine("Ошибка! Введите целые числа через пробел.");
        }
    }

    private static void PrintArray(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            if (i > 0) Console.Write(", ");
            Console.Write(arr[i]);
        }
        Console.WriteLine("]");
    }

    public static double fraction(double x)
    {
        int cel = (int)x;
        return x - cel;
    }

    public static int charToNum(char x)
    {
        return x - '0';
    }

    public static bool is2Digits(int x)
    {
        if (x < 0) x = -x;
        return x >= 10 && x <= 99;
    }

    public static bool isInRange(int a, int b, int num)
    {
        int min, max;
        if (a < b)
        {
            min = a;
            max = b;
        }
        else
        {
            min = b;
            max = a;
        }
        return num >= min && num <= max;
    }

    public static bool isEqual(int a, int b, int c)
    {
        return a == b && b == c;
    }

    public static int abs(int x)
    {
        if (x < 0) return -x;
        return x;
    }

    public static bool is35(int x)
    {
        bool del3 = x % 3 == 0;
        bool del5 = x % 5 == 0;
        if (del3 && del5) return false;
        return del3 || del5;
    }

    public static int max3(int x, int y, int z)
    {
        int max = x;
        if (y > max) max = y;
        if (z > max) max = z;
        return max;
    }

    public static int sum2(int x, int y)
    {
        int sum = x + y;
        if (sum >= 10 && sum <= 19) return 20;
        return sum;
    }

    public static string day(int x)
    {
        switch (x)
        {
            case 1: return "понедельник";
            case 2: return "вторник";
            case 3: return "среда";
            case 4: return "четверг";
            case 5: return "пятница";
            case 6: return "суббота";
            case 7: return "воскресенье";
            default: return "это не день недели";
        }
    }

    public static string listNums(int x)
    {
        string result = "";
        for (int i = 0; i <= x; i++)
        {
            if (i > 0) result += " ";
            result += i;
        }
        return result;
    }

    public static string chet(int x)
    {
        string result = "";
        for (int i = 0; i <= x; i += 2)
        {
            if (i > 0) result += " ";
            result += i;
        }
        return result;
    }

    public static int numLen(long x)
    {
        if (x == 0) return 1;
        int count = 0;
        while (x > 0)
        {
            count++;
            x = x / 10;
        }
        return count;
    }

    public static void square(int x)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public static void rightTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            for (int j = 0; j < x - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public static int findFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x) return i;
        }
        return -1;
    }

    public static int maxAbs(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            int absMax = max < 0 ? -max : max;
            int absCur = arr[i] < 0 ? -arr[i] : arr[i];
            if (absCur > absMax)
            {
                max = arr[i];
            }
        }
        return max;
    }

    public static int[] add(int[] arr, int[] ins, int pos)
    {
        int[] result = new int[arr.Length + ins.Length];
        for (int i = 0; i < pos; i++)
        {
            result[i] = arr[i];
        }
        for (int i = 0; i < ins.Length; i++)
        {
            result[pos + i] = ins[i];
        }
        for (int i = pos; i < arr.Length; i++)
        {
            result[ins.Length + i] = arr[i];
        }
        return result;
    }

    public static int[] reverseBack(int[] arr)
    {
        int[] result = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = arr[arr.Length - 1 - i];
        }
        return result;
    }

    public static int[] findAll(int[] arr, int x)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x) count++;
        }
        int[] result = new int[count];
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                result[index] = i;
                index++;
            }
        }
        return result;
    }
}