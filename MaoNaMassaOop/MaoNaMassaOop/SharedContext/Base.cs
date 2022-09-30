using System;
using MaoNaMassaOop.NotificationContext;

namespace MaoNaMassaOop.SharedContext
{
    public class Base : Notifiable
    {
      public Base()
      {
          Id = Guid.NewGuid();
      } 

      public Guid Id  { get; set; }
      
      

    }
}