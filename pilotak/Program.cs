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
        }
    }
}