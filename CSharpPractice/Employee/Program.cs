namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Emp> = DB , obj = tuple/ row
            List<Emp> elist = new List<Emp>();
            elist.Add(new Emp(101, "Nikita", "Alibag"));
            elist.Add(new Emp(102, "Shruti", "Pune"));
            elist.Add(new Emp(103, "Ankita", "Kopargaon"));
            elist.Add(new Emp(104, "Shreya", "Shrivadhan"));

            foreach (Emp e in elist)
            {
                e.Display();
                Console.WriteLine("-------");

            }

        }
    }
}
