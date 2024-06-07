Console.Clear();
Console.WriteLine("Main Block Attestation");
Console.WriteLine("by Seredenko Iury Danilovich https://github.com/SeredenkoIury/GB_MainBlock_Attestation");
Console.WriteLine("");
//==========================================================================================================
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

//==========================================================================================================

// input the length of the 1st array (unchecked)
Console.WriteLine("Add the number of words in your Array and Press ENTER :");
int n = int.Parse(Console.ReadLine());


// Createing and filling the First Array
string[] FirstArray = new string[n];


for (int i = 0; i < n; i++)
{
    // Filling the Array from the console with checking if for empty
    Console.WriteLine($"Add the word number {i + 1} and Press ENTER");
    FirstArray[i] = Console.ReadLine();

    while (string.IsNullOrEmpty(FirstArray[i]))
    {
        Console.WriteLine("!WARNING!------You cannot leave an empty value in the array.------!WARNING!"); 
        Console.Write("Please type the word again and press Enter:  ");
        FirstArray[i] = Console.ReadLine();
    }
}

// Createing the Second Array for words with 3 or less symbols and the index for 2nd array
string[] SecondArray = new string[n];
int secondArrayIndex = 0;

// Sorting 3 and less, adding to the second array and writing it

for (int i = 0; i < n; i++)
{
    if (FirstArray[i].Length <= 3)
    {
        
        SecondArray[secondArrayIndex] = FirstArray[i];
        secondArrayIndex++;
    }
}

// Writing the Second Array
Console.WriteLine("");
Console.Write("Words with 3 or less symbols: ");

for (int i = 0; i < secondArrayIndex; i++)
{
    Console.Write($"|  {SecondArray[i]}  |");
}
