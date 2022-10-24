using Balta.ContentContext.Enums;
using System.Collections.Generic;
using System.Reflection;

namespace Balta.ContentContext
{
    public class Course : Content
    {
        public Course(string Title, string Url)
        : base(Title, Url)
        {
            Modules = new List<Module>();
        }
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public double DurationInMinutes { get; set; }

        public EContentLevel Level { get; set; }

    }

}