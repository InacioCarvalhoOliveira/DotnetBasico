using System.Collections.Generic;
using MaoNaMassaOop.SharedContext;

namespace MaoNaMassaOop.ContentContext
{
        public class Module : Base
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