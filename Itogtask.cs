// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] Array()
{
    string[] array = new string[new Random().Next(3, 4)]; //Массив размеров от 3 до 4 строк
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Задайте массив: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
string[] arrayNew = Array();

void PrintArray()
{
    for (int i = 0; i < arrayNew.Length; i++)
    {
        if (arrayNew[i].Length <= 3)
            Console.Write($"\"{arrayNew[i]}\" ");
    }
}

PrintArray();
