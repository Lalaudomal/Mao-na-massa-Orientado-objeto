namespace Balta.ContentContext
{
    public class Career : Content
    {
        public Career(string Title, string Url)
        : base(Title, Url)
        {
            Items = new List<careerItem>();
        }
        public IList<careerItem> Items { get; set; }
    }
    public int TotalCourses => Items.count;

}
