/* 
Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
> ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
> ["1234", "1567", "-2", "computer science"] -> ["-2"]
> ["Russia", "Denmark", "Kazan"] -> [ ]
*/
Console.Clear();
Console.WriteLine("------ Программа для формирования результирующего массива");
Console.WriteLine("------ со строчными элементами, длина которых меньше или равна 3.");
Console.WriteLine();
Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] inputArray = new string[size];
FillArrayHandler(inputArray);

void FillArrayHandler(string[] array) {
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine()!;
    }
}
