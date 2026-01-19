using System;
using System.Text;

class Program
{
    static int CountThreeLetterWords(string s)
    {
        int count = 0;
        StringBuilder letters = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (!char.IsWhiteSpace(c))
            {
                if (char.IsLetter(c))
                    letters.Append(c);
            }
            else
            {
                if (letters.Length == 3) count++;
                letters.Clear();
            }
        }

        if (letters.Length == 3) count++; // последнее слово
        return count;
    }

    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string line = Console.ReadLine();
        int result = CountThreeLetterWords(line);
        Console.WriteLine("Трёхбуквенных слов: " + result);
    }
}