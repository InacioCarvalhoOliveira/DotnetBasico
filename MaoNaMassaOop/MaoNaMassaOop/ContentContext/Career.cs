using System.Collections.Generic;

namespace MaoNaMassaOop.ContentContext
{
    public class Career : Content
    {
        public Career(string title,string url)
        :base(title,url)
        {
            Items = new List<CareerItem>(); 
        }
        public IList<CareerItem> Items { get; set; }
        public int TotalCourses => Items.Count;

      //  var articles = new List<Article>(); 
        
        
    }
    
}