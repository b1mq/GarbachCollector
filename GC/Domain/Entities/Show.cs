namespace GC.Domain.Entities
{
    public  class Show:IDisposable
    {
        public string Title {  get; set; }

        public string Genre { get; set; }

        public double Duration { get; set; }

        public int CountOfActors {  get; set; }

        public Show(string title,string genre,double duration,int countofacters)
        {
            Title = title;
            Genre = genre;
            Duration = duration;
            CountOfActors = countofacters;

        }
        public void InfoAboutShow()
        {
            Console.WriteLine($"Name {Title}\nGenre {Genre}\nDuration {Duration}\nCount of Actors {CountOfActors}");
        }
        ~Show()
        {
            Console.WriteLine("By GC");
        }
       public void Dispose()
        {
            Console.WriteLine("Disposed");
        }
    }
}
