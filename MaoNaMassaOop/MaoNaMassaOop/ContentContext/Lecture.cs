using MaoNaMassaOop.ContentContext.Enums;
using MaoNaMassaOop.SharedContext;

namespace MaoNaMassaOop.ContentContext
{
    public class Lecture : Base
    {
        public int Ordem { get; set; }
        public string Title { get; set; }     
        public int DurationInMinutes { get; set; }
        public int Name { get; set; }
        public ECOntentLevel Level { get; set; }

        
    
        
        
        
    }
}