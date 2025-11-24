namespace GC.Domain.Entities
{
    public class Shop
    {
        public string NameOfShop { get; set; }
        public string Adress { get; set; }
        public string TypeOfShop { get; set; }

        public Shop(string name, string adress, string type)
        {
            NameOfShop = name;
            Adress = adress;
            TypeOfShop = type;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Shop: {NameOfShop}");
            Console.WriteLine($"Adress: {Adress}");
            Console.WriteLine($"Type: {TypeOfShop}");
        }
        public void Dispose()
        {
            Console.WriteLine("Shop disposed manually!");
        }

        ~Shop()
        {
            Console.WriteLine("Shop was removed by GC!");
        }
    }
}
