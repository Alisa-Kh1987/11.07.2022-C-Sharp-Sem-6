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
    for (int i = 0; i < array.Length; i++){
        Console.Write(array[i]);
        if (i<array.Length-1) {
        Console.Write(", ");
        }
    }
Console.WriteLine();
}

Console.Clear();

Console.WriteLine("-------");
int[] myArray = CreateArray();
ShowArray(myArray);

int positiv_count = 0;
for (int i = 0; i<myArray.Length; i++)
{
if (myArray[i] > 0){
    positiv_count += 1;
    }    
}

Console.WriteLine($"Количество положительных элементов: -> {positiv_count}");

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
Console.WriteLine("Введите k1 для прямой, заданной уравнением y = k1*x + b1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1 для прямой, заданной уравнением y = k1*x + b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2 для прямой, заданной уравнением y = k2*x + b2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2 ля прямой, заданной уравнением y = k2*x + b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if  (k1==k2 && b1 == b2) {
    Console.WriteLine("Прямые совпадают");
    }
    else if (k1==k2 && b1 != b2){
    Console.WriteLine("Прямые параллельны, точек пересечения нет");
    }
else{
    double x = (b2-b1)/(k1-k2);
    double y = x*k1 + b1;
Console.WriteLine ($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} -> ({x}; {y})");
}
*/