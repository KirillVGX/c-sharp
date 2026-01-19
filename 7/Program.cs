using System;
using System.IO;

namespace Lab7 {
    class Program {
        static void Main() {
            while (true) {
                Console.WriteLine("\n===== МЕНЮ =====");
                Console.WriteLine("1 — Завдання 1");
                Console.WriteLine("2 — Завдання 2");
                Console.WriteLine("0 — Вихід");
                Console.Write("Ваш вибір: ");

                string choice = Console.ReadLine();

                switch (choice) {
                    case "1":
                        Task1();
                        break;

                    case "2":
                        Task2();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Невірний вибір");
                        break;
                }
            }
        }

        // 1
        static void Task1() {
            Console.WriteLine("\n--- Завдання 1 ---");
            string path = "text.txt";

            if (!File.Exists(path)) {
                Console.WriteLine($"Файл {path} не знайдено!");
                return;
            }

            string[] words = {
                "нуль", "один","два","три","чотири",
                "п’ять","шість","сім","вісім","дев’ять"
            };

            Console.WriteLine("\nРезультат:");

            using (StreamReader sr = new StreamReader(path)) {
                string line;
                while ((line = sr.ReadLine()) != null) {
                    for (int i = 0; i < 10; i++)
                        line = line.Replace(i.ToString(), words[i]);

                    string[] sentences = line.Split('.');
                    foreach (string sentence in sentences) {
                        string s = sentence.Trim();
                        if (s.Length > 0)
                            Console.WriteLine(s);
                    }
                }
            }
        }

        // 2 
        static void Task2() {
            Console.WriteLine("\n--- Завдання 2 ---");
            Console.Write("Скільки матеріалів додати? ");

            int n = int.Parse(Console.ReadLine());

            Material[] materials = new Material[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"\nМатеріал {i + 1}:");
                Material m = new Material();

                Console.Write("Назва: ");
                m.SetName(Console.ReadLine());

                Console.Write("Кг: ");
                m.SetKg(double.Parse(Console.ReadLine()));

                Console.Write("Ціна за кг: ");
                m.SetPrice(double.Parse(Console.ReadLine()));

                Console.Write("Код: ");
                m.SetCode(Console.ReadLine());

                materials[i] = m;
            }

            string path = "materials.txt";

            using (StreamWriter sw = new StreamWriter(path)) {
                for (int i = 0; i < n; i++) {
                    Material m = materials[i];
                    sw.WriteLine($"{m.GetName()};{m.GetKg()};{m.GetPrice()};{m.GetCode()}");
                }
            }

            Console.WriteLine($"\nФайл створено!");
            Console.WriteLine("\nЗчитування існуючого файла:");

            int linesCount = File.ReadAllLines(path).Length;  
            Material[] loaded = new Material[linesCount];    

            using (StreamReader sr = new StreamReader(path)) {
                string line;
                int index = 0;

                while ((line = sr.ReadLine()) != null) {
                    string[] p = line.Split(';');
                    Material m = new Material();
                    m.SetName(p[0]);
                    m.SetKg(double.Parse(p[1]));
                    m.SetPrice(double.Parse(p[2]));
                    m.SetCode(p[3]);
                    loaded[index++] = m;
                }
            }

            foreach (Material m in loaded) {
                Console.WriteLine($"{m.GetName()} | {m.GetKg()} кг | {m.GetPrice()} грн | код {m.GetCode()}");
            }

            double avg = Material.AveragePrice(loaded);
            Console.WriteLine($"\nСередня ціна за кг: {avg:F2} грн");
        }
    }
}