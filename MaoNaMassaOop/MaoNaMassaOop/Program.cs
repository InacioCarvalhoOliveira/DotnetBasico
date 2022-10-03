using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;
using System;
using MaoNaMassaOop.ContentContext;
using MaoNaMassaOop.SubscriptionContext;

namespace MaoNaMassaOop 
{
    class Program
    {
        static void Main(string[] args)
        {
           var articles = new List<Article>();
           articles.Add(new Article("Aritgo sobre OOP","orientacao_objetos"));
           articles.Add(new Article("Aritgo sobre API","primeira-API"));
           articles.Add(new Article("Aritgo sobre MVC","WebSite_mvc"));

           foreach (var article in articles)
           {
            // Console.WriteLine(article.Id);
            // Console.WriteLine(article.Title);
            // Console.WriteLine(article.Url);            
           }

           var course = new List<Course>();
           var CourseOop = new Course("funamentos oop","fund-oop");
           var CourseCsharp = new Course("funamentos c#","fund-c#");
           var CourseAspnet = new Course("funamentos aspnet","fund-aspnet");
           course.Add(CourseOop);
           course.Add(CourseCsharp);
           course.Add(CourseAspnet);
        
           var carrers = new List<Career>();

           var carrerDotnet = new Career("especialista dotnet","esp-dotnet");
           var careerItem = new CareerItem(1,"comece por aqui","aboa","",null);
           carrerDotnet.Items.Add(careerItem);
           carrers.Add(carrerDotnet);

           var carrerJira = new Career("especialista jira","esp-jira");
           var careerItem2 = new CareerItem(2,"comece por aqui","aboaJira","",null);
           carrerJira.Items.Add(careerItem2);
           carrers.Add(carrerJira);

           foreach (var career in carrers)
           {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x=>x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine($"{item.Course?.Title}");
                    Console.WriteLine($"{item.Course?.Level}");
                    
                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                        
                    }         
                    
                }

                var payPalSubscriptions = new PayPalSubscription(); 
                var student = new Student();
           }
        }
    }
}
