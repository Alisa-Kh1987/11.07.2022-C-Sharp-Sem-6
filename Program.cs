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