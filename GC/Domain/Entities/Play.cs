namespace GC.Domain.Entities
{
    public class Play:IDisposable // пьеса на английском 
    {
        public string Title { get; set; }

        public string NameOfAutor {  get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public Play(string title, string genre,string nameofautor, int year)
        {
            Title = title;
            Genre = genre;
            NameOfAutor = nameofautor;
            Year = year;
        }
        public override string ToString()
        {
            return $"Title: {Title}\nName of Autor: {NameOfAutor}\nGenre: {Genre}\nYear: {Year}";
        }
        public void Dispose()
        {
            Console.WriteLine("Play disposed manually!");
        }

        ~Play()
        {
            Console.WriteLine("By Destructor");
        }
    }
}
