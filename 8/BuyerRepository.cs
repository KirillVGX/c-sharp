using System;
using System.Collections.Generic;
using System.IO;

class BuyerRepository {
    private const string FileName = "buyers.dat";

    public void AddBuyer(User b) {
        try {
            using (FileStream fs = new FileStream(FileName, FileMode.Append))
            using (BinaryWriter bw = new BinaryWriter(fs)) {
                bw.Write(b.GetName());
                bw.Write(b.GetSurname());
                bw.Write(b.GetPhone());
                bw.Write(b.GetCreditCard());
            }
        }
        catch (Exception e) {
            Console.WriteLine("Помилка запису: " + e.Message);
        }
    }

    public List<User> GetAll() {
        List<User> list = new List<User>();

        if (!File.Exists(FileName) || new FileInfo(FileName).Length == 0) {
            Console.WriteLine("Файл порожній.");
            return list;
        }

        try {
            using (FileStream fs = new FileStream(FileName, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs)) {
                while (br.BaseStream.Position < br.BaseStream.Length) {
                    User b = new User();
                    b.SetName(br.ReadString());
                    b.SetSurname(br.ReadString());
                    b.SetPhone(br.ReadString());
                    b.SetCreditCard(br.ReadInt64());

                    list.Add(b);
                }
            }
        }
        catch (Exception e) {
            Console.WriteLine("Помилка зчитування: " + e.Message);
        }

        return list;
    }

    public List<User> GetByCardRange(long min, long max) {
        List<User> res = new List<User>();

        foreach (var b in GetAll()) {
            if (b.IsCreditCardInRange(min, max))
                res.Add(b);
        }

        return res;
    }
}