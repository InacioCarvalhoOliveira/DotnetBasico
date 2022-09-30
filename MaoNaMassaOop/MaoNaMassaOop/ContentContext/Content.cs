using System;
namespace MaoNaMassaOop.ContentContext
{
    public abstract class Content
    {
        //guid - global unique identifier 
        // gera um id automaticamente
        public Content()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }    
      
    }
}