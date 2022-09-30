using System.Reflection;
using System.Collections.Generic;
namespace MaoNaMassaOop.ContentContext
{
    public class Course : Content
    {
        public Course()
        {
            // instancia de lista  nome = new Lista<prop>
            Modules = new List<Module>();
        }
        public string Tag { get; set; }   
        // criando propiedade de Lista 
        public IList<Module> Modules { get; set; }         
    }

    public class Module
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }

        public int Order { get; set; }
        public string Title { get; set; } 
        public IList<Lecture> Lectures { get; set; }
        
          

  
    }

    public class Lecture
    {
        public int Ordem { get; set; }
        public string Title { get; set; }
        
        
        
        
    }

}