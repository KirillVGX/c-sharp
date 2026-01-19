using System;
using System.Collections.Generic;

class Program {
    static BuyerRepository repo = new BuyerRepository();

    static void Main() {
        while (true) {
            Console.WriteLine("\n=== Лабораторна 8 ===");
            Console.WriteLine("1 — Додати покупця");
            Console.WriteLine("2 — Вивести всіх");
            Console.WriteLine("3 — Вивести по діапазону номера карти");
            Console.WriteLine("0 — Вихід");
            Console.Write("Ваш вибір: ");

            string choice = Console.ReadLine();

            switch (choice) {
                case "1":
                    CreateBuyer();
                    break;

                case "2":
                    ShowAll();
                    break;

                case "3":
                    ShowRange();
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Невірний вибір");
                    break;
            }
        }
    }

    static void CreateBuyer() {
        User b = new User();

        Console.Write("Ім'я: ");
        b.SetName(Console.ReadLine());

        Console.Write("Прізвище: ");
        b.SetSurname(Console.ReadLine());

        Console.Write("Телефон: ");
        b.SetPhone(Console.ReadLine());

        Console.Write("Номер кредитної картки: ");
        b.SetCreditCard(long.Parse(Console.ReadLine()));

        repo.AddBuyer(b);

        Console.WriteLine("Покупця додано!");
    }

    static void ShowAll() {
        var list = repo.GetAll();

        Console.WriteLine("{0,-10} {1,-12} {2,-12} {3,-16}",
                    "Ім'я", "Прізвище", "Телефон", "Карта");

        foreach (var b in list) {
            Console.WriteLine("{0,-10} {1,-12} {2,-12} {3,-16}",
                b.GetName(),
                b.GetSurname(),
                b.GetPhone(),
                b.GetCreditCard());
        }
    }

    static void ShowRange() {
        Console.Write("Мінімум: ");
        long min = long.Parse(Console.ReadLine());

        Console.Write("Максимум: ");
        long max = long.Parse(Console.ReadLine());

        var list = repo.GetByCardRange(min, max);

        Console.WriteLine("\nПокупці в діапазоні:");

        foreach (var b in list) {
            Console.WriteLine($"{b.GetName()} {b.GetSurname()} — {b.GetCreditCard()}");
        }
    }
}