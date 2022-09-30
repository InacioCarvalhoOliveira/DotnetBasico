using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Reflection.Emit;
using MaoNaMassaOop.NotificationContext;

namespace MaoNaMassaOop.ContentContext
{
    public class Article : Content
    {        
        public Article(string title,string url)
            :base(title,url)
        {

        }
    }
}