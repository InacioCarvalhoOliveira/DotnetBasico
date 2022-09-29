using System.Collections.Generic;
namespace MaoNaMassaOop.ContentContext
{
        public class Module
    {
        public Module()
        {// iniciando lista
            Lectures = new List<Lecture>();
        }

        public int Order { get; set; }
        public string Title { get; set; } 
        //declarando lista
        public IList<Lecture> Lectures { get; set; }
        
          

  
    }
}