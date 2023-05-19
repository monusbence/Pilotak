namespace pilotak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] szoveg = File.ReadAllLines("C:\\Users\\Mónus Bence\\source\\repos\\pilotak\\pilotak\\pilotak.csv");
            List<Versenyzők> lista = new List<Versenyzők>();

            foreach (var elem in szoveg.Skip(1))
            {
                string[] adatok = elem.Split(";");
                Versenyzők versenyzo = new Versenyzők(adatok[0], adatok[1], adatok[2], Convert.ToInt32(adatok[3]));
                lista.Add(versenyzo);
            }
            Console.WriteLine($"3. feladat: {lista.Count()}");
            Console.WriteLine($"4. feladat: {lista.Last().Nev}");
            Console.WriteLine("5. feladat: ");
            

            foreach (var adat in lista) {
                int szul_ev = Convert.ToInt32(adat.Születési_dátum.Split("."));
                if (szul_ev < 1901)
                {
                    Console.WriteLine($"{adat.Nev} ({adat.Születési_dátum})");
                }
            }
            var nemzetiseg = (from sor in lista
                             where sor.Rajtszám > 0
                             orderby sor.Rajtszám
                             select sor.Nemzetiség).First();
            Console.WriteLine($"6. feladat: {nemzetiseg}");

        }
    }
}