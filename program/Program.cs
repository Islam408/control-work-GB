// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void Array(string[] massif)
{
    for (int countElement = 0; countElement < massif.Length; countElement++)
    {
        Console.WriteLine("Введите элеммент массива:");
        massif[countElement] = Console.ReadLine();
    }
}
void CreatingNewArray(string[] massif)
{
    try
    {
        Console.WriteLine("Введите количество элемментов в строке для формирования нового массива:");
        int lengthString = Convert.ToInt32(Console.ReadLine());
        string[] newMassif = new string[massif.Length];
        int countNewMassif = 0;
        for (int countMassif = 0; countMassif < massif.Length; countMassif++)
        {
            if (massif[countMassif].Length <= lengthString)
            {
                newMassif[countNewMassif] = massif[countMassif];
                countNewMassif++;
            }
        }
        Console.WriteLine("\nНовый массив");
        Console.Write("[");
        Console.Write(string.Join(" ", newMassif));
        Console.Write("]");
    }
    catch (System.Exception)
    {
        Console.WriteLine("Не корректный ввод");
        CreatingNewArray(massif);
    }
}
int lengthMassif;
try
{
    Console.WriteLine("Введите количество элемментов в массиве:");
    lengthMassif = Convert.ToInt32(Console.ReadLine());
}
catch (System.Exception)
{
    Console.WriteLine("Не корректный ввод");
    Console.WriteLine("\nВведите количество элемментов в массиве:");
    lengthMassif = Convert.ToInt32(Console.ReadLine());
}
string[] arr = new string[lengthMassif];

Array(arr);
CreatingNewArray(arr);