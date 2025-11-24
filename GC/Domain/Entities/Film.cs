namespace GC.Domain.Entities
{
    public class Movie
    {

        public double Duration {  get; set; }
        public int Year { get; set; }
        public string Title {  get; set; }
        public string Genre { get; set; }
        public Movie(string title, string genre, int year,double duration) 
        {
            Title = title;
            Genre = genre;
            Year = year;
            Duration = duration;

        }
        public void Play()
        {
            Console.WriteLine($"You are watching Movie {Title}");
            Console.WriteLine($"Duration: {Duration}");
        }
        ~Movie()
        {
            Console.WriteLine("Movie was removed!");
        }


    }
}
