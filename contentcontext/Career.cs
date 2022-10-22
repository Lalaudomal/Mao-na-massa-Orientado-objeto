namespace Balta.ContentContext
{
    public class Career : Content
    {
        public Career()
        {
            Items = new List<careerItem>();
        }
        public IList<careerItem> Items { get; set; }
    }
    public int TotalCourses => Items.count;

}
