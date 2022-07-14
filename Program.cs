//Console.WriteLine("Seminar 6 C#");

//задача 39 Программа переворачивающая одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.п.)

/*int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
// первый способ
void ReversArray1(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - i - 1] = k;
    }
}
//второй способ
int[] ReversArray2(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}

Console.Clear();

int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));

int[] reversArray=ReversArray2(array);
Console.WriteLine(String.Join(" ", reversArray));

ReversArray1(array);
Console.WriteLine(String.Join(" ", array));
*/

//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int b= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье  число: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if(a < (b+c) && b < (a + c) && c < (a + b)){
//     Console.WriteLine("да");
// }
// else{
//     Console.WriteLine("нет");
// }

//к дз -  //x = (b2 -b1)/(k1 - k2), y = k2 * x + b2


//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.


//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

//Практическое задание к семинару № 6 (11.07.2022)

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int[] CreateRandomArray(int N, int start, int end)
{
int[] RandomArray = new int[N];
for (int i = 0; i < N; i++)
{
RandomArray[i] = new Random().Next(start, end + 1);
}
return RandomArray;
}

int[] CreateArray()
{
Console.WriteLine("Введите количество элементов массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[size];
for (int i = 0; i < size; i++)
{
Console.WriteLine($"Введите {i+1} элемент массива");
Array[i] = Convert.ToInt32(Console.ReadLine());
}
return Array;
}

void ShowArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}

Console.Clear();
//Console.WriteLine("Введите количество элементов в массиве");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите первое число случайно генерируемого диапазона");
//int min = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
//int max = Convert.ToInt32(Console.ReadLine());

//int[] myRandomArray = CreateRandomArray(num, min, max);
//ShowArray(myRandomArray);
Console.WriteLine("-------");
int[] myArray = CreateArray();
ShowArray(myArray);

int positiv_nums = 0;
for (int i = 0; i<myArray.Length; i++)
{
if (myArray[i] > 0){
    positiv_nums += 1;
    }    
}

Console.WriteLine(positiv_nums);
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = 0;
double y = 0;

if (k1!=k2 || b1 != b2){
    x = (b2-b1)/(k1-k2);
    y = x*k1 + b1;
}

Console.WriteLine ("-> " + "x");
Console.WriteLine (y);
