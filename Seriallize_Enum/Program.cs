using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

// Definisikan enum untuk status manusia
public enum HumanStatus
{
    P1,
    P2,
    P3
}

// Modifikasi kelas Human untuk menggunakan enum
public class Human
{
    public string Name { get; set; }
    public int Age { get; set; }
    public HumanStatus Status { get; set; } // Tambahkan properti Status dengan tipe enum

    public Human(string name, int age, HumanStatus status)
    {
        Name = name;
        Age = age;
        Status = status;
    }

    public Human() { }
}

class Program
{
    static void Main()
    {
        // Buat beberapa objek Human dengan status berbeda
        Human human = new Human("jan", 2, HumanStatus.P1);
        Human human2 = new Human("Gib4", 36, HumanStatus.P2);
        Human human3 = new Human("Kaseng", 29, HumanStatus.P3);

        // Buat list dan tambahkan objek-objek Human ke dalamnya
        List<Human> futurePresident = new List<Human>
        {
            human,
            human2,
            human3
        };

        // Serialisasi ke file XML
        XmlSerializer serializer = new XmlSerializer(typeof(List<Human>));
        using (FileStream fs = new FileStream("./human.xml", FileMode.Create))
        {
            serializer.Serialize(fs, futurePresident);
        }
    }
}
