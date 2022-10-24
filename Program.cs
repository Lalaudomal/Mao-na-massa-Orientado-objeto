using System;

namespace Balta.ContentContext
{

    class Program
    {
        private static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("artigo sobre C#", "csharp"));
            articles.Add(new Article("artigo sobre .NET", ".net"));
            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }
            var couses = new List<Course>();
            var CourseOOP = new Course("fundamentos OOP", "fundamentos-OOP");
            var CourseCsharp = new Course("fundamentos C#", "fundamentos-csharp");
            var CourseAspNet = new Course("fundamentos ASP.NET", "fundamentos-aspnet");
            Course.Add(CourseOOP);
            Course.Add(CourseCsharp);
            Course.Add(CourseAspNet);

            var carrers = new List<Career>();
            var careerDOTNET = new Career("espreccialista .NET", "especialista-dotnet");
            var careerItem = new CareerItem(1, "Começe por aqui", "", null);
            careerDOTNET.Items.Add(careerItem);
            careers.Add(careerDOTNET);

            foreach (var career in carrers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items)
                {
                    Console.WriteLine($"{item.Ordem}");
                }
            }

        }
    }
}