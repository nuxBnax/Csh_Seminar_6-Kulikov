// Задача 41:

// Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void Main()
{
    int result = NumPositiveCounter(ReadArray());
    System.Console.Write("Number of positive elements in YOUR array: " + result);
}

int[] ReadArray()
{
    System.Console.Write("Enter numbers of YOUR array using a spacebar: ");
    int[] inputArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    return inputArray;
}

int NumPositiveCounter(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) counter++; 
    }
    return counter;
}

Main();

