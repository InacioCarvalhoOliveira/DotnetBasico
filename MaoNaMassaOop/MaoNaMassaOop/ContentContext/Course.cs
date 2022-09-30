using System.Reflection;
using System.Collections.Generic;
using MaoNaMassaOop.ContentContext.Enums;

namespace MaoNaMassaOop.ContentContext
{
    public class Course : Content
    {
        public Course()
        {// iniciando  lista  nome = new Lista<prop>
            Modules = new List<Module>();
        }
        public string Tag { get; set; }   
        // declarando propiedade de Lista 
        public IList<Module> Modules { get; set; }   
        public int DurationInMinutes { get; set; }
        public ECOntentLevel Level { get; set; }
        
        
      
    }



    

}