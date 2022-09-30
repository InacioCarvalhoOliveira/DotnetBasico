using System;
using MaoNaMassaOop.SharedContext;

namespace MaoNaMassaOop.ContentContext
{
    public abstract class Content : Base
    {
        //guid - global unique identifier 
        // gera um id automaticamente
        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }

        public string Title { get; set; }
        public string Url { get; set; }    
      
    }
}