// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int imputed(string massege)
{
    Console.WriteLine(massege);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] Result(int lengt)
{
    int[] array = new int[lengt];
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = imputed($"Введите {i+1}");
        
    }
    return array;
        
}

void PrintArrey(int[] arrey)
{
    for (int i = 0; i < arrey.Length; i++)
    {
        Console.WriteLine($"a[{i}]={arrey[i]}");
    }
    
}

int resultpositive (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
        
    }
    return count;
}

int lengt = imputed ("Введите значения > ");
int[] array;
array = Result(lengt);
PrintArrey(array);
Console.WriteLine($"количество значений больше 0 > {resultpositive(array)}");







