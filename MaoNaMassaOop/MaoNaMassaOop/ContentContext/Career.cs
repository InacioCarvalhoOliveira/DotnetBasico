using System.Collections.Generic;

namespace MaoNaMassaOop.ContentContext
{
    public class Careers : Content
    {
        public Careers()
        {
            Items = new List<CareerItem>(); 
        }
        public IList<CareerItem> Items { get; set; }
        public int TotalCourses => Items.Count;

        
        
    }
    
}