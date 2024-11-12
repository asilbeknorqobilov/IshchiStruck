using System;

struct ISHCHI
{
    public string Familiya;
    public string Lavozimi;
    public int IshgaKirganYili;

    public override string ToString()
    {
        return $"Familiya: {Familiya}, Lavozim: {Lavozimi}, Ishga kirgan yili: {IshgaKirganYili}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ishchilar sonini kiriting: ");
        int n = int.Parse(Console.ReadLine());

        ISHCHI[] ishchilar = new ISHCHI[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Ishchi {i + 1} ma'lumotlarini kiriting:");
            Console.Write("Familiya: ");
            string familiya = Console.ReadLine();
            Console.Write("Lavozimi: ");
            string lavozimi = Console.ReadLine();
            Console.Write("Ishga kirgan yili: ");
            int ishgaKirganYili = int.Parse(Console.ReadLine());

            ishchilar[i] = new ISHCHI
            {
                Familiya = familiya,
                Lavozimi = lavozimi,
                IshgaKirganYili = ishgaKirganYili
            };
        }

        // Birinchi task
        Array.Sort(ishchilar, (x, y) => string.Compare(x.Lavozimi, y.Lavozimi));

        Console.WriteLine("\nLavozim bo'yicha tartiblangan ishchilar:");
        foreach (var ishchi in ishchilar)
        {
            Console.WriteLine(ishchi);
        }

        // Ikkinchi task
        Console.Write("\nIshga kirgan yildan keyin ishga kirgan ishchilar familiyasi chop etilsin. Yilni kiriting: ");
        int kiritilganYil = int.Parse(Console.ReadLine());

        Console.WriteLine($"\n{ kiritilganYil } yilidan keyin ishga kirgan ishchilar familiyasi:");

        foreach (var ishchi in ishchilar)
        {
            if (ishchi.IshgaKirganYili > kiritilganYil)
            {
                Console.WriteLine(ishchi.Familiya);
            }
        }

        // Uchinchi task
        Console.Write("\nLavozimdagi ishchilar familiyasi va ishga kirgan yili chop etilsin. Lavozimni kiriting: ");
        string kiritilganLavozim = Console.ReadLine();

        Console.WriteLine($"\n{ kiritilganLavozim } lavozimdagi ishchilar familiyasi va ishga kirgan yili:");

        foreach (var ishchi in ishchilar)
        {
            if (ishchi.Lavozimi.ToLower() == kiritilganLavozim.ToLower())
            {
                Console.WriteLine($"Familiya: {ishchi.Familiya}, Ishga kirgan yili: {ishchi.IshgaKirganYili}");
            }
        }
    }
}
