

//Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.

int VowelsLetters(string[] words)
{
    int count = 0;
    for(int i = 0; i < words.Length; i++)
    {
        if (words[i].ToLower()[0] == 'a'
            || words[i].ToLower()[0] == 'e'
            || words[i].ToLower()[0] == 'i'
            || words[i].ToLower()[0] ==  'y'
            || words[i].ToLower()[0] ==  'o'
            || words[i].ToLower()[0] ==  'u' ) count++;
    }
    return count;
}


Console.WriteLine("Задан массив: ltlsjdf, sdlkjo, ajs, ojshdf");
string[] names = {"ltlsjdf", "sdlkjo", "ajs", "ojshdf"};
Console.WriteLine();

Console.Write("В указанном массиве слов начинающихся с гласной буквы = ");
Console.WriteLine(VowelsLetters(names));



//Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

// string[] plus (string[] words)
// {
//     string[] WordsPlus = new string[words.Length/2];

//         for(int i = 0; i < (WordsPlus.Length); i++)
//     {
//         WordsPlus[i] = words[i+i] + " " + words[i+i+1];
        
//     }
//     return WordsPlus;
// }

// void ShowPlus (string[] a)
// {
//     for(int i = 0; i < a.Length; i++)
//     {
//         Console.WriteLine(a[i]);
//     }
// }

// string[] numbers = {"111", "222", "333", "444", "555", "666", "777", "888"};

// Console.WriteLine("Задан массив: 111, 222, 333, 444, 555, 666, 777, 888");
// Console.WriteLine();

// Console.WriteLine("Элементы массива сгруппированы попарно:");

// ShowPlus(plus(numbers));


