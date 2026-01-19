using System;

class Program
{
    // Функція перевертання слова
    static string ReverseWord(string word)
    {
        char[] chars = word.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    // Функція для перевертання кожного слова в рядку
    static string ReverseWordsInLine(string line)
    {
        string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
            words[i] = ReverseWord(words[i]);
        return string.Join(" ", words);
    }

    static void Main()
    {
        Console.WriteLine("Введіть рядок:");
        string input = Console.ReadLine();

        string result = ReverseWordsInLine(input);

        Console.WriteLine("Результат:");
        Console.WriteLine(result);
    }
}